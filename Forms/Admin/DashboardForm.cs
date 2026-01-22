using GreenLife_Organic_Store.Forms.Customer;
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
        public frmAdminDashboardForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
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
            var customerRepo = new CustomerRepository();
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

        private void fillAttributesOfActiveOrdersCard()
        {
            var orderRepo = new OrderRepository();
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

        }

        private void fillAttributesOfProductInStockCard()
        {
            var productRepo = new ProductRepository();
            int productsInStock = productRepo.getAllProductCount();
            int activeProductsInStock = productRepo.getUniqueProductsInStockCount();

            lblProductInStock.Text = productsInStock.ToString();
            lblProductInStockSub.Text = $"{activeProductsInStock} active products";
        }

        private void showLowStockProducts()
        {
            flowLayoutPanelLowStock.Controls.Clear();
            flowLayoutPanelLowStock.AutoScroll = true;
            flowLayoutPanelLowStock.WrapContents = true;
            flowLayoutPanelLowStock.FlowDirection = FlowDirection.LeftToRight;

            var productRepo = new ProductRepository();
            var lowStockProducts = productRepo.getLowStockProducts();

            foreach (var product in lowStockProducts)
            {
                // Create a panel for card
                Panel card = new Panel();
                card.Width = 200;
                card.Height = 120;
                card.BackColor = Color.FromArgb(255, 245, 245, 245); // light gray
                card.Margin = new Padding(10);
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Padding = new Padding(10);

                // Product Name label
                Label lblName = new Label();
                lblName.Text = product.productName;
                lblName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblName.ForeColor = Color.Black;
                lblName.AutoSize = false;
                lblName.Height = 25;
                lblName.Dock = DockStyle.Top;

                // Category label
                Label lblCategory = new Label();
                lblCategory.Text = "Category: " + product.category;
                lblCategory.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                lblCategory.ForeColor = Color.DimGray;
                lblCategory.AutoSize = false;
                lblCategory.Height = 20;
                lblCategory.Dock = DockStyle.Top;

                // Stock count label
                Label lblStock = new Label();
                lblStock.Text = "Stock: " + product.stockQuantity;
                lblStock.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                lblStock.ForeColor = product.stockQuantity <= 5 ? Color.Red : Color.OrangeRed;
                lblStock.AutoSize = false;
                lblStock.Height = 20;
                lblStock.Dock = DockStyle.Top;

                // Add labels to card (top-down)
                card.Controls.Add(lblStock);
                card.Controls.Add(lblCategory);
                card.Controls.Add(lblName);

                // Add card to flow panel
                flowLayoutPanelLowStock.Controls.Add(card);
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
            UserRepository userRepository = new UserRepository();
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
