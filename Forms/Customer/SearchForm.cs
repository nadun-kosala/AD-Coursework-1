using GreenLife_Organic_Store.Models;
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
    public partial class frmSearchForm : Form
    {
        private int _loggedUserId;
        public frmSearchForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
        }

        private void frmSearchForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanalForProducts.Controls.Clear();
            flowLayoutPanalForProducts.AutoScroll = true;

            ProductRepository repo = new ProductRepository();
            var products = repo.getAllProducts();

            if (products == null || products.Count == 0)
            {
                Label lblNoProducts = new Label();
                lblNoProducts.Text = "Products not found";
                lblNoProducts.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblNoProducts.ForeColor = Color.Gray;
                lblNoProducts.AutoSize = true;
                lblNoProducts.Margin = new Padding(20);

                flowLayoutPanalForProducts.Controls.Add(lblNoProducts);
                return;
            }

            foreach (var product in products)
            {
                flowLayoutPanalForProducts.Controls.Add(createProductCard(product));
            }
            var productCount = products.Count;
            lblProductCount.Text = $"{productCount.ToString()} product{(productCount == 1 ? "" : "s")} found";

        }

        private Panel createProductCard(Product product)
        {
            Panel card = new Panel();
            card.Width = 230;
            card.Height = 360;
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

            y += 130;

            Label lblName = new Label();
            lblName.Text = product.productName;
            lblName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblName.ForeColor = Color.Green;
            lblName.AutoSize = false;
            lblName.Width = 200;
            lblName.Left = 15;
            lblName.Top = y;
            card.Controls.Add(lblName);

            y += 25;

            Label lblCategory = new Label();
            lblCategory.Text = product.category;
            lblCategory.Font = new Font("Segoe UI", 8);
            lblCategory.ForeColor = Color.DarkGreen;
            lblCategory.Left = 15;
            lblCategory.Top = y;
            lblCategory.AutoSize = true;
            card.Controls.Add(lblCategory);

            y += 22;

            Label lblRating = new Label();
            lblRating.Text = getStarText(product.avarageRating) + $" ({product.totalReviews})";
            lblRating.Font = new Font("Segoe UI", 9);
            lblRating.ForeColor = Color.Goldenrod;
            lblRating.Left = 15;
            lblRating.Top = y;
            lblRating.AutoSize = true;
            card.Controls.Add(lblRating);

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

            y += 50;

            Label lblPrice = new Label();
            lblPrice.Text = $"LKR {product.price:N2}";
            lblPrice.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblPrice.ForeColor = Color.Green;
            lblPrice.Left = 15;
            lblPrice.Top = y;
            lblPrice.AutoSize = true;
            card.Controls.Add(lblPrice);


            y += 30;

            Label lblStock = new Label();
            lblStock.Text = $"Stock: {product.stockQuantity}";
            lblStock.Font = new Font("Segoe UI", 8);
            lblStock.ForeColor = product.stockQuantity >= 10 ? Color.Black : Color.Red;
            lblStock.Left = 15;
            lblStock.Top = y;
            lblStock.AutoSize = true;
            card.Controls.Add(lblStock);

            y += 25;

            Button btnAddToCart = new Button();
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.BackColor = Color.Green;
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            btnAddToCart.Width = 110;
            btnAddToCart.Height = 30;
            btnAddToCart.Left = 100;
            btnAddToCart.Top = y;

            btnAddToCart.Click += (s, e) =>
            {
                MessageBox.Show($"{product.productName} added to cart");
            };

            card.Controls.Add(btnAddToCart);

            return card;
        }

        private string getStarText(decimal rating)
        {
            int fullStars = (int)Math.Round(rating);
            return new string('★', fullStars) + new string('☆', 5 - fullStars);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnCustomerLogout_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
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

        private void flowLayoutPanalForProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
