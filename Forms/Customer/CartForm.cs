using GreenLife_Organic_Store.Forms.Modals;
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
    public partial class frmCartForm : Form
    {

        private int _loggedUserId;
        private readonly ICartRepository _cartRepository;
        private decimal _subTotal = 0m;
        public frmCartForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
            _cartRepository = new CartRepository();

        }

        private void frmCartForm_Load(object sender, EventArgs e)
        {
            var customer = getLoggedInCustomer();
            if (customer != null)
            {
                loadCartItems(customer.customerId);
            }

        }

        private void showTotalCountOfCartItem(int itemCount)
        {
            if (itemCount == 0)
            {
                lblShoppingCartSub.Text = "0 item in your cart";
            }
            else
            {
                lblShoppingCartSub.Text = $"{itemCount.ToString()} item{(itemCount == 1 ? "" : "s")} in your cart";
            }

        }
        private GreenLife_Organic_Store.Models.Customer? getLoggedInCustomer()
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            return customerRepository.getCustomerByUserId(_loggedUserId);
        }

        private void loadCartItems(int customerId)
        {
            flowLayoutPanalForCartItem.Controls.Clear();
            List<Cart> cartItems = _cartRepository.getCartProductsByCustomer(customerId);
            showTotalCountOfCartItem(cartItems.Count());

            if (cartItems.Count == 0)
            {
                showEmptyCartUI();
                _subTotal = 0m;
                updateTotals();
                return;
            }

            _subTotal = 0m;

            foreach (var item in cartItems)
            {
                var card = createCartItemCard(item);
                flowLayoutPanalForCartItem.Controls.Add(card);
                _subTotal += item.price * item.cartQuantity;
            }

            updateTotals();
        }

        private Panel createCartItemCard(Cart item)
        {
            Panel card = new Panel
            {
                Width = flowLayoutPanalForCartItem.Width - 25,
                Height = 90,
                BackColor = Color.White,
                Margin = new Padding(10),
                Padding = new Padding(10)
            };


            PictureBox pic = new PictureBox
            {
                Image = Properties.Resources._9309051,
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 60,
                Height = 60,

                Location = new Point(15, 10),
                BackColor = Color.Transparent
            };

            card.Controls.Add(pic);
            pic.BringToFront();

            Label lblName = new Label
            {
                Text = item.productName,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(90, 15)
            };

            Label lblPrice = new Label
            {
                Text = $"LKR {item.price:0.00} each",
                ForeColor = Color.Green,
                Location = new Point(90, 45),
                AutoSize = true
            };

            Label lblQty = new Label
            {
                Text = item.cartQuantity.ToString(),
                ForeColor = Color.Black,
                Width = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button btnMinus = new Button
            {
                Text = "−",
                Width = 30,
                Height = 30
            };

            Button btnPlus = new Button
            {
                Text = "+",
                Width = 30,
                Height = 30
            };

            Button btnDelete = new Button
            {
                Width = 30,
                Height = 30,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.images__9_,
                BackgroundImageLayout = ImageLayout.Zoom,
                Cursor = Cursors.Hand
            };

            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);

            Label lblTotal = new Label
            {
                Text = $"LKR {item.price * item.cartQuantity:0.00}",
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true
            };

            int rightX = card.Width - 190;

            btnMinus.Location = new Point(rightX, 5);
            lblQty.Location = new Point(rightX + 35, 5);
            btnPlus.Location = new Point(rightX + 70, 5);
            lblTotal.Location = new Point(card.Width - 200, 50);
            btnDelete.Location = new Point(card.Width - 40, 5);


            btnPlus.Click += (s, e) =>
            {
                if (item.cartQuantity >= item.stockQuantity)
                {
                    MessageBox.Show("Stock limit reached", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                item.cartQuantity++;
                lblQty.Text = item.cartQuantity.ToString();
                lblTotal.Text = $"LKR {item.price * item.cartQuantity:0.00}";

                _cartRepository.updateCartQuantity(item.cartId, item.cartQuantity);

                _subTotal += item.price;
                updateTotals();

            };

            btnMinus.Click += (s, e) =>
            {
                if (item.cartQuantity <= 1) return;

                item.cartQuantity--;
                lblQty.Text = item.cartQuantity.ToString();
                lblTotal.Text = $"LKR {item.price * item.cartQuantity:0.00}";

                _cartRepository.updateCartQuantity(item.cartId, item.cartQuantity);

                _subTotal -= item.price;
                updateTotals();
            };

            btnDelete.Click += (s, e) =>
            {
                var result = MessageBox.Show(
                    "Remove item from cart?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _subTotal -= item.price * item.cartQuantity;

                    _cartRepository.deleteCartItem(item.cartId);

                    flowLayoutPanalForCartItem.Controls.Remove(card);

                    if (flowLayoutPanalForCartItem.Controls.Count == 0)
                        showEmptyCartUI();

                    updateTotals();
                }
            };

            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);
            card.Controls.Add(btnMinus);
            card.Controls.Add(lblQty);
            card.Controls.Add(btnPlus);
            card.Controls.Add(lblTotal);
            card.Controls.Add(btnDelete);

            return card;
        }

        private void updateTotals()
        {
            if (_subTotal < 0) _subTotal = 0m;
            lblSubTotal.Text = $"{_subTotal:0.00} LKR";

            // This should be update with discount price later-----------------------------------------------------------
            lblFinalAmmount.Text = $"{_subTotal:0.00} LKR";
        }

        private void showEmptyCartUI()
        {
            flowLayoutPanalForCartItem.Controls.Clear();

            Panel emptyPanel = new Panel
            {
                Width = flowLayoutPanalForCartItem.Width,
                Height = 250,
                BackColor = Color.FromArgb(20, 140, 80)
            };

            Label lblTitle = new Label
            {
                Text = "Your cart is empty",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(100, 60)
            };

            Label lblSub = new Label
            {
                Text = "Add some organic products to get started!",
                ForeColor = Color.WhiteSmoke,
                AutoSize = true,
                Location = new Point(100, 100)
            };

            Button btnBrowse = new Button
            {
                Text = "Browse Products",
                BackColor = Color.White,
                ForeColor = Color.Green,
                Width = 160,
                Height = 40,
                Location = new Point(120, 140)
            };

            btnBrowse.Click += (s, e) =>
            {
                frmSearchForm frm = new frmSearchForm(_loggedUserId);
                frm.Show();
                this.Hide();
            };

            emptyPanel.Controls.Add(lblTitle);
            emptyPanel.Controls.Add(lblSub);
            emptyPanel.Controls.Add(btnBrowse);

            flowLayoutPanalForCartItem.Controls.Add(emptyPanel);
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

        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            frmSearchForm frm = new frmSearchForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            btnPlaceOrder.Enabled = false;

            using (frmPaymentForm frm = new frmPaymentForm(_loggedUserId, _subTotal))
            {
                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    frmCustomerOrderForm frmCustomerOrder = new frmCustomerOrderForm(_loggedUserId);
                    frmCustomerOrder.Show();
                    this.Hide();
                }
                else
                {
                    btnPlaceOrder.Enabled = true;
                }
            }

        }
    }
}
