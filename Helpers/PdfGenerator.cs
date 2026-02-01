using GreenLife_Organic_Store.Models;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

public class PdfGenerator
{

    public void generateSalesReportPdf(List<Order> items, SalesReportSummary summary, DateTime startDate, DateTime endDate, string filePath)
    {

        try
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                document.Add(new Paragraph("Sales Report")
                    .SetFontSize(18)
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph(
                    $"Period: {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}")
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph("\n"));

                Table table = new Table(6).UseAllAvailableWidth();

                table.AddHeaderCell("Order Code");
                table.AddHeaderCell("Date");
                table.AddHeaderCell("Customer");
                table.AddHeaderCell("Total");
                table.AddHeaderCell("Discount");
                table.AddHeaderCell("Final");

                foreach (var item in items)
                {
                    table.AddCell(item.orderCode);
                    table.AddCell(item.orderDate.ToString("yyyy-MM-dd"));
                    table.AddCell(item.customerName);
                    table.AddCell(item.totalAmount.ToString("F2"));
                    table.AddCell(item.discountAmount.ToString("F2"));
                    table.AddCell(item.finalAmount.ToString("F2"));
                }

                document.Add(table);

                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph($"Total Orders: {summary.totalOrders}"));
                document.Add(new Paragraph($"Gross Sales: LKR {summary.grossSales:F2}"));
                document.Add(new Paragraph($"Total Discounts: LKR {summary.totalDiscounts:F2}"));
                document.Add(new Paragraph($"Net Sales: LKR {summary.netSales:F2}")
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD)));
            }

        } 
        catch (Exception ex)
        {
            throw new Exception("Error generating PDF: " + ex.Message);
        }
        
    }

    public void generateStockReportPdf(List<Product> items, StockReportSummary summary, string filePath)
    {

        try
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                var titleFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                var regularFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                document.Add(new Paragraph("Stock Report")
                    .SetFont(titleFont)
                    .SetFontSize(18)
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph($"Generated On: {DateTime.Now:yyyy-MM-dd}")
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph("\n"));

                Table table = new Table(new float[] { 80, 150, 120, 80, 80, 100 })
                    .UseAllAvailableWidth();

                string[] headers =
                {
            "ID", "Product Name", "Category",
            "Quantity", "Unit Price", "Stock Value"
        };

                foreach (var h in headers)
                {
                    table.AddHeaderCell(new Cell()
                        .Add(new Paragraph(h).SetFont(titleFont))
                        .SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                }

                foreach (var item in items)
                {
                    table.AddCell(item.id.ToString());
                    table.AddCell(item.productName);
                    table.AddCell(item.category);
                    table.AddCell(item.stockQuantity.ToString());
                    table.AddCell(item.price.ToString("F2"));
                    table.AddCell(item.stockValue.ToString("F2"));
                }

                document.Add(table);

                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph($"Total Products: {summary.TotalProducts}"));
                document.Add(new Paragraph($"Total Units: {summary.TotalUnits}"));
                document.Add(new Paragraph($"Low Stock Items: {summary.LowStockCount}"));
                document.Add(new Paragraph($"Total Stock Value: LKR {summary.TotalStockValue:F2}")
                    .SetFont(titleFont)
                    .SetFontSize(14));
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error generating PDF: " + ex.Message);
        }
     
    }

    public void generateCustomerHistoryReportPdf(List<Order> orders, CustomerHistoryReportSummary summary, string customerName, DateTime startDate, DateTime endDate, string filePath)
    {
        try
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                document.Add(new Paragraph("Customer Order History")
                    .SetFontSize(18)
                    .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(new Paragraph($"Customer: {customerName}"));
                document.Add(new Paragraph($"Period: {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}"));
                document.Add(new Paragraph("\n"));

                Table table = new Table(6).UseAllAvailableWidth();
                table.AddHeaderCell("Order Code");
                table.AddHeaderCell("Date");
                table.AddHeaderCell("Status");
                table.AddHeaderCell("Total");
                table.AddHeaderCell("Discount");
                table.AddHeaderCell("Final");

                foreach (var o in orders)
                {
                    table.AddCell(o.orderCode);
                    table.AddCell(o.orderDate.ToString("yyyy-MM-dd"));
                    table.AddCell(o.orderStatus);
                    table.AddCell(o.totalAmount.ToString("F2"));
                    table.AddCell(o.discountAmount.ToString("F2"));
                    table.AddCell(o.finalAmount.ToString("F2"));
                }

                document.Add(table);
                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph($"Total Orders: {summary.totalOrders}"));
                document.Add(new Paragraph($"Total Spent: LKR {summary.totalSpent:F2}"));
                document.Add(new Paragraph($"Total Discounts: LKR {summary.totalDiscounts:F2}"));
                document.Add(new Paragraph($"Net Spent: LKR {summary.netSpent:F2}")
                          .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD)));
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error generating PDF: " + ex.Message);
        }
    }


}