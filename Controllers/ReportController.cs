using GreenLife_Organic_Store.Helpers;
using GreenLife_Organic_Store.Models;
using GreenLife_Organic_Store.RepoistoryInterfaces;
using GreenLife_Organic_Store.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GreenLife_Organic_Store.Forms.Modals;
using System.Windows.Forms;

namespace GreenLife_Organic_Store.Controllers
{
    public class ReportController
    {
        private readonly PdfGenerator _pdfGenerator = new PdfGenerator();
        public ReportController() {
        }

        public void generateSalesReport(string reportType, DateTime startDate, DateTime endDate)
        {

            try
            {
                validateReportParameters(reportType, startDate, endDate);

                switch (reportType)
                {
                    case "Sales Report":
                        createSalesReport("Sales Report", startDate, endDate);
                        break;
                    case "Stock Report":
                        createStockReport("Stock Report", null, null);
                        break;
                    case "Customer Order History":
                        createCustomerHistoryReport("Customer Order Histor", startDate, endDate);
                        break;
                    default:
                        throw new Exception("Unsupported report type.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

        }

        private void validateReportParameters(string reportType, DateTime? startDate, DateTime? endDate)
        {
            try
            {
                DateTime? fromDate = startDate?.Date;
                DateTime? toDate = endDate?.Date;
                DateTime? today = DateTime.Today;

                var allowedReportTypes = new List<string>
                        {
                            "Sales Report",
                            "Stock Report",
                            "Customer Order History"
                        };

                if (!allowedReportTypes.Contains(reportType))
                {
                    throw new Exception("Invalid report type selected.");
                }
                if (reportType != "Stock Report")
                {
                    if (fromDate > today || toDate > today)
                    {
                        throw new Exception("Future dates are not allowed.");
                    }

                    if (toDate < fromDate)
                    {
                        throw new Exception("End date cannot be earlier than start date.");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Validation process error");
            }
         
        }

        private void createSalesReport(string reportType, DateTime startDate, DateTime endDate)
        {
            try
            {
                IOrderRepository orderRepository = new OrderRepository();
                List<Order> items = orderRepository.getSalesReport(startDate, endDate);
                var summary = calculateSummary(items);

                string fullPath = createFilePathAndFileName(reportType, startDate, endDate);

                _pdfGenerator.generateSalesReportPdf(
                    items,
                    summary,
                    startDate,
                    endDate,
                    fullPath
                );

                MessageBox.Show($"Report saved to: {fullPath}", "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating sales report.");
            }
        
        }

        private void createStockReport(string reportType, DateTime? startDate, DateTime? endDate)
        {
            try
            {
                IProductRepository _productRepository = new ProductRepository();
                List<Product> items = _productRepository.getAllProducts();

                if (items.Count == 0)
                    throw new Exception("No stock data available.");

                var summary = buildStockSummary(items);
                string fullPath = createFilePathAndFileName(reportType, null, null);

                _pdfGenerator.generateStockReportPdf(items, summary, fullPath);

                MessageBox.Show($"Report saved to: {fullPath}", "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating stock report.");
            }
            
        }

        private void createCustomerHistoryReport(string reportType, DateTime startDate, DateTime endDate)
        {
            try
            {
                Customer customer = showGetCustomerUI();

                if (customer.customerId <= 0)
                {
                    return;
                }

                IOrderRepository orderRepo = new OrderRepository();

                List<Order> orders = orderRepo.getOrdersByCustomerIdAndDateRange(customer.customerId, startDate, endDate);

                var summary = buildCustomerHistorySummary(orders);
                string fullPath = createFilePathAndFileName(reportType, startDate, endDate);
                _pdfGenerator.generateCustomerHistoryReportPdf(orders, summary, customer.fullName, startDate, endDate, fullPath);


                MessageBox.Show($"Report saved to: {fullPath}", "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating stock report.");
            }
        }

        private Customer showGetCustomerUI()
        {
            using (var frm = new frmSelectCustomer())
            {
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Customer customer = new Customer();
                    customer.customerId = frm.selectedCustomerId;
                    customer.fullName = frm.selectedCustomerName;
                    return customer;
                }
                else
                {
                    throw new Exception("Error getting customer's name");
                }
            }
        }

        private string createFilePathAndFileName(string reportType, DateTime? startDate, DateTime? endDate)
        {
            try
            {
                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string downloads = Path.Combine(userProfile, "Downloads");
                Directory.CreateDirectory(downloads);

                var invalidChars = Path.GetInvalidFileNameChars();
                string safeReportType = new string(reportType.Select(c => invalidChars.Contains(c) ? '_' : c).ToArray());
                safeReportType = safeReportType.Replace(' ', '_');
                string? fileName = null;
                if (startDate != null && endDate != null)
                {
                    fileName = $"{safeReportType}_{startDate:yyyyMMdd}_{endDate:yyyyMMdd}_{Guid.NewGuid().ToString("N").Substring(0, 8)}.pdf";
                }
                else
                {
                    fileName = $"{safeReportType}_{Guid.NewGuid().ToString("N").Substring(0, 8)}.pdf";
                }

                string fullPath = Path.Combine(downloads, fileName);

                return fullPath;
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating file path and name.");
            }
           
        }

        public SalesReportSummary calculateSummary(List<Order> items)
        {
            return new SalesReportSummary
            {
                totalOrders = items.Count,
                grossSales = items.Sum(x => x.totalAmount),
                totalDiscounts = items.Sum(x => x.discountAmount),
                netSales = items.Sum(x => x.finalAmount)
            };
        }

        private StockReportSummary buildStockSummary(List<Product> items)
        {
            return new StockReportSummary
            {
                TotalProducts = items.Count,
                TotalUnits = items.Sum(x => x.stockQuantity),
                TotalStockValue = items.Sum(x => x.stockValue),
                LowStockCount = items.Count(x => x.stockQuantity <= x.lowStockThreshold)
            };
        }

        private CustomerHistoryReportSummary buildCustomerHistorySummary(List<Order> items)
        {
            return new CustomerHistoryReportSummary
            {
                totalOrders = items.Count,
                totalSpent = items.Sum(o => o.totalAmount),
                totalDiscounts = items.Sum(o => o.discountAmount),
                netSpent = items.Sum(o => o.finalAmount)
            };
        }
    }
}
