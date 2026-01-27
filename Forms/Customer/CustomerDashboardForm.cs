using GreenLife_Organic_Store.Models;
using GreenLife_Organic_Store.RepoistoryInterfaces;
using GreenLife_Organic_Store.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLife_Organic_Store.Forms.Customer
{
    public partial class frmCustomerDashboardForm : Form
    {

        private int _loggedUserId;
        public frmCustomerDashboardForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void lblSubHeading_Click(object sender, EventArgs e)
        {

        }

        private GreenLife_Organic_Store.Models.Customer? getLoggedInCustomer()
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            return customerRepository.getCustomerByUserId(_loggedUserId);
        }
        private void updateCartItemCount(int customerId)
        {
            ICartRepository cartRepository = new CartRepository();
            int cartItemsCount = cartRepository.getCartItemCountByCustomer(customerId);

            lblDashboardCartItem.Text = $"{cartItemsCount} item{(cartItemsCount == 1 ? "" : "s")} in cart";
        }

        private void updateWelcomeHeading(string customerName)
        {
            lblWelcomeHeadingName.Text = $"{customerName}!";
        }

        private void updateActiveOrderCount(int customerId)
        {
            IOrderRepository orderRepository = new OrderRepository();
            int activeOrderCount = orderRepository.getActiveOrderCountByCustomerId(customerId);
            lblDashboardActiveOrders.Text = $"{activeOrderCount} active order{(activeOrderCount == 1 ? "" : "s")}";
        }

        private void showTopRatedProductList()
        {
            flowLayoutPanalTopRateProducts.Controls.Clear();
            flowLayoutPanalTopRateProducts.AutoScroll = true;

            IProductRepository repo = new ProductRepository();
            var products = repo.getTopRatingProducts();

            if (products == null || products.Count == 0)
            {
                Label lblNoProducts = new Label();
                lblNoProducts.Text = "Products not found";
                lblNoProducts.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblNoProducts.ForeColor = Color.Gray;
                lblNoProducts.AutoSize = true;
                lblNoProducts.Margin = new Padding(20);

                flowLayoutPanalTopRateProducts.Controls.Add(lblNoProducts);
                return;
            }

            foreach (var product in products)
            {

                flowLayoutPanalTopRateProducts.Controls.Add(createProductCard(product));
            }
        }

        private Panel createProductCard(Product product)
        {
            Panel card = new Panel();
            card.Width = 230;
            card.Height = 300;
            card.BackColor = Color.White;
            card.Margin = new Padding(12);
            card.BorderStyle = BorderStyle.FixedSingle;

            int y = 10;

            PictureBox pic = new PictureBox();
            pic.Image = Properties.Resources._9309051;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Width = 200;
            pic.Height = 120;
            pic.Left = 15;
            pic.Top = y;
            card.Controls.Add(pic);

            y += 150;

            Label lblName = new Label();
            lblName.Text = product.productName;
            lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblName.ForeColor = Color.Green;
            lblName.AutoSize = false;
            lblName.Width = 200;
            lblName.Left = 15;
            lblName.Top = y;
            card.Controls.Add(lblName);

            y += 26;

            Label lblCategory = new Label();
            lblCategory.Text = product.category;
            lblCategory.Font = new Font("Segoe UI", 8);
            lblCategory.ForeColor = Color.DarkGreen;
            lblCategory.Left = 15;
            lblCategory.Top = y;
            lblCategory.AutoSize = true;
            card.Controls.Add(lblCategory);

            y += 22;


            Label lblDesc = new Label();
            lblDesc.Text = product.description;
            lblDesc.Font = new Font("Segoe UI", 8);
            lblDesc.ForeColor = Color.Black;
            lblDesc.Width = 200;
            lblDesc.Height = 45;
            lblDesc.Left = 15;
            lblDesc.Top = y;
            card.Controls.Add(lblDesc);

            y += 40;

            Label lblPrice = new Label();
            lblPrice.Text = $"LKR {product.price:N2}";
            lblPrice.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblPrice.ForeColor = Color.Green;
            lblPrice.Left = 15;
            lblPrice.Top = y;
            lblPrice.AutoSize = true;
            card.Controls.Add(lblPrice);


            return card;
        }


        private void frmCustomerDashboardForm_Load(object sender, EventArgs e)
        {

            var customer = getLoggedInCustomer();

            if (customer == null)
            {
                lblDashboardCartItem.Text = "0 items in cart";
                lblWelcomeHeadingName.Text = "Welcome!";
                return;
            }

            updateCartItemCount(customer.customerId);
            updateActiveOrderCount(customer.customerId);
            updateWelcomeHeading(customer.fullName);
            showTopRatedProductList();

        }

        private void btnNavigateDashboard_Click(object sender, EventArgs e)
        {
            frmCustomerDashboardForm frm = new frmCustomerDashboardForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateSearch_Click(object sender, EventArgs e)
        {
            frmSearchForm frm = new frmSearchForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateCart_Click(object sender, EventArgs e)
        {
            frmCartForm frm = new frmCartForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateOrders_Click(object sender, EventArgs e)
        {
            frmCustomerOrderForm frm = new frmCustomerOrderForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateProfile_Click(object sender, EventArgs e)
        {
            frmCustomerProfileForm frm = new frmCustomerProfileForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnBrowseProducts_Click(object sender, EventArgs e)
        {
            frmSearchForm frm = new frmSearchForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnDashboardViewCartNav_Click(object sender, EventArgs e)
        {
            frmCartForm frm = new frmCartForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnDashboardTrackOrdersNav_Click(object sender, EventArgs e)
        {
            frmCustomerOrderForm frm = new frmCustomerOrderForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnDashboardEditProfileNav_Click(object sender, EventArgs e)
        {
            frmCustomerProfileForm frm = new frmCustomerProfileForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnCustomerLogout_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
            User? user = userRepository.getUserById(_loggedUserId);
            if (user != null && user.userType == "customer")
            {
                frmCustomerLogin frm = new frmCustomerLogin();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error logging out. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void flowLayoutPanalTopRateProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}