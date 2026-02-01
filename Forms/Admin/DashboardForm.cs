using GreenLife_Organic_Store.Forms.Customer;
using GreenLife_Organic_Store.Models;
using GreenLife_Organic_Store.RepoistoryInterfaces;
using GreenLife_Organic_Store.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLife_Organic_Store.Forms.Admin
{
    public partial class frmAdminDashboardForm : Form
    {
        private int _loggedUserId;
        private readonly IProductRepository _productRepository;
        public frmAdminDashboardForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
            _productRepository = new ProductRepository();
        }

        private void frmAdminDashboardForm_Load(object sender, EventArgs e)
        {
            fillAttributesOfTotalCustomersCard();
            fillAttributesOfActiveOrdersCard();
            fillAttributesOfProductInStockCard();
            showLowStockProducts();
        }

        private void fillAttributesOfTotalCustomersCard()
        {
            try
            {
                ICustomerRepository customerRepo = new CustomerRepository();
                int thisMonthCustomers = customerRepo.getCurrentMonthCustomerCount();
                int lastMonthCustomers = customerRepo.getLastMonthCustomerCount();

                var customerDifference = thisMonthCustomers - lastMonthCustomers;
                if (customerDifference > 0)
                {
                    lblTotalCustomersSub.Text = $"+{customerDifference} this month";
                    lblTotalCustomersSub.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lblTotalCustomersSub.Text = $"{customerDifference} this month";
                    lblTotalCustomersSub.ForeColor = Color.Red;
                }

                lblTotalCustomers.Text = thisMonthCustomers.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching customer data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
        }

        private void fillAttributesOfActiveOrdersCard()
        {
            try
            {
                IOrderRepository orderRepo = new OrderRepository();
                int thisMonthActiveOrders = orderRepo.getActiveOrdersCountThisMonth();
                int thisMonthTotalOrders = orderRepo.getTotalOrdersCountThisMonth();
                decimal thisMonthSale = orderRepo.getThisMonthSalesAmount();
                decimal lastMonthSale = orderRepo.getLastMonthSalesAmount();
                decimal growthPercentage = 0;

                if (lastMonthSale > 0)
                {
                    growthPercentage = ((thisMonthSale - lastMonthSale) / lastMonthSale) * 100;
                }

                if (growthPercentage < 0)
                {
                    lblTotalSalesSub.ForeColor = Color.Red;
                }
                else if (growthPercentage > 0)
                {
                    lblTotalSalesSub.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lblTotalSalesSub.ForeColor = Color.Gray;
                }


                lblActiveOrders.Text = thisMonthActiveOrders.ToString();
                lblTotalOrdersSub.Text = $"{thisMonthTotalOrders} total orders";
                lblTotalSale.Text = $"LKR {thisMonthSale:F2}";
                lblTotalSalesSub.Text = $"{growthPercentage:+0.##;-0.##;0}% from last month";
            } catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching order data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

        }

        private void fillAttributesOfProductInStockCard()
        {
            try
            {
                int productsInStock = _productRepository.getAllProductCount();
                int activeProductsInStock = _productRepository.getUniqueProductsInStockCount();

                lblProductInStock.Text = productsInStock.ToString();
                lblProductInStockSub.Text = $"{activeProductsInStock} active products";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching product data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
        }

        private void showLowStockProducts()
        {
            try
            {
                flowLayoutPanelLowStock.Controls.Clear();
                flowLayoutPanelLowStock.AutoScroll = true;
                flowLayoutPanelLowStock.WrapContents = false;
                flowLayoutPanelLowStock.FlowDirection = FlowDirection.TopDown;

                var lowStockProducts = _productRepository.getLowStockProducts();

                if (!lowStockProducts.Any())
                {
                    flowLayoutPanelLowStock.Controls.Clear();
                    flowLayoutPanelLowStock.AutoScroll = false;
                    flowLayoutPanelLowStock.WrapContents = false;
                    flowLayoutPanelLowStock.FlowDirection = FlowDirection.TopDown;

                    Panel card = new Panel();
                    card.Width = flowLayoutPanelLowStock.ClientSize.Width - 25;
                    card.Height = 60;
                    card.Margin = new Padding(5);
                    card.Padding = new Padding(10);
                    card.BackColor = Color.FromArgb(40, Color.Green);
                    card.BorderStyle = BorderStyle.FixedSingle;

                    Label lblMessage = new Label();
                    lblMessage.Text = "All products are sufficiently stocked ✅";
                    lblMessage.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lblMessage.ForeColor = Color.DarkGreen;
                    lblMessage.Dock = DockStyle.Fill;
                    lblMessage.TextAlign = ContentAlignment.MiddleCenter;

                    card.Controls.Add(lblMessage);
                    flowLayoutPanelLowStock.Controls.Add(card);

                    return;
                }


                Label lblHeading = new Label();
                lblHeading.Text = "Low Stock Alert";
                lblHeading.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblHeading.ForeColor = Color.Green;
                lblHeading.AutoSize = true;
                lblHeading.Margin = new Padding(5, 5, 5, 0);


                Label lblSubHeading = new Label();
                lblSubHeading.Text = "Products running low";
                lblSubHeading.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                lblSubHeading.ForeColor = Color.FromArgb(0, 120, 0);
                lblSubHeading.AutoSize = true;
                lblSubHeading.Margin = new Padding(5, 0, 5, 10);

                flowLayoutPanelLowStock.Controls.Add(lblHeading);
                flowLayoutPanelLowStock.Controls.Add(lblSubHeading);


                foreach (var product in lowStockProducts)
                {
                    Panel card = new Panel();
                    card.Width = flowLayoutPanelLowStock.ClientSize.Width - 25;
                    card.Height = 90;
                    card.Margin = new Padding(5);
                    card.Padding = new Padding(10);
                    card.BackColor = Color.FromArgb(30, Color.Red);
                    card.BorderStyle = BorderStyle.FixedSingle;

                    Label lblName = new Label();
                    lblName.Text = product.productName;
                    lblName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lblName.ForeColor = Color.Black;
                    lblName.AutoSize = true;
                    lblName.Location = new Point(10, 8);

                    Label lblCategory = new Label();
                    lblCategory.Text = product.category;
                    lblCategory.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    lblCategory.ForeColor = Color.Black;
                    lblCategory.AutoSize = true;
                    lblCategory.Location = new Point(10, 30);

                    Label lblStock = new Label();
                    lblStock.Text = $"{product.stockQuantity} units";
                    lblStock.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    lblStock.ForeColor = Color.Red;
                    lblStock.AutoSize = true;
                    lblStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                    lblStock.Location = new Point(card.Width - 90, 10);

                    Label lblWarning = new Label();
                    lblWarning.Text = "Low stock!";
                    lblWarning.Font = new Font("Segoe UI", 8, FontStyle.Regular);
                    lblWarning.ForeColor = Color.Red;
                    lblWarning.AutoSize = true;
                    lblWarning.Location = new Point(10, 55);

                    card.Controls.Add(lblName);
                    card.Controls.Add(lblCategory);
                    card.Controls.Add(lblStock);
                    card.Controls.Add(lblWarning);

                    flowLayoutPanelLowStock.Controls.Add(card);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching low stock products.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNavigateProducts_Click(object sender, EventArgs e)
        {
            frmAdminProductFrom frm = new frmAdminProductFrom(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateDashboard_Click_1(object sender, EventArgs e)
        {
            frmAdminDashboardForm frm = new frmAdminDashboardForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateCustomers_Click_1(object sender, EventArgs e)
        {
            frmAdminCustomerForm frm = new frmAdminCustomerForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateOrders_Click_1(object sender, EventArgs e)
        {
            frmAdminOrdersForm frm = new frmAdminOrdersForm(_loggedUserId);
            frm.Show();
            this.Hide();

        }

        private void btnNavigateReports_Click_1(object sender, EventArgs e)
        {
            frmAdminReportsForm frm = new frmAdminReportsForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateSettings_Click(object sender, EventArgs e)
        {
            frmSettingsForm frm = new frmSettingsForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelLowStock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
            var user = userRepository.getUserById(_loggedUserId);
            if (user != null && user.userType == "admin")
            {
                frmAdminLogin frm = new frmAdminLogin();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error logging out. Admin not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
