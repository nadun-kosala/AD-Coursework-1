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
    public partial class frmCustomerOrderForm : Form
    {
        private int _loggedUserId;
        private int _customerId;
        public frmCustomerOrderForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
        }

        private void frmCustomerOrderForm_Load(object sender, EventArgs e)
        {
            flowLayoutShowOrders.Controls.Clear();

            var customer = getLoggedInCustomer();
            if (customer == null)
            {
                MessageBox.Show("Error loading customer data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _customerId = customer.customerId;
     
            IOrderRepository orderRepository = new OrderRepository();
            List<Order> orders = orderRepository.getAllOrderByCustomerId(_customerId);
          

            foreach (var order in orders)
            {
                var card = createOrderCard(order);
                flowLayoutShowOrders.Controls.Add(card);
            }
        }

        private Panel createOrderCard(Order order)
        {
            Panel card = new Panel
            {
                Width = flowLayoutShowOrders.ClientSize.Width - 25,
                Height = 170,
                BackColor = Color.White,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblOrderCode = new Label
            {
                Text = $"Order Code: {order.orderCode}",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.Green,
                Location = new Point(15, 15),
                AutoSize = true
            };

            Label lblOrderDate = new Label
            {
                Text = $"Placed on {order.orderDate:yyyy-MM-dd}",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Gray,
                Location = new Point(15, 45),
                AutoSize = true
            };

            Label lblStatus = new Label
            {
                Text = order.orderStatus,
                AutoSize = false,
                Width = 90,
                Height = 25,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(card.Width - 120, 15),
                BackColor = getStatusColor(order.orderStatus)
            };

            Label lblAmounts = new Label
            {
                Text = $"Total: LKR {order.finalAmount:F2}",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                Location = new Point(15, 80),
                AutoSize = true
            };

            Button btnView = new Button
            {
                Text = "View Details",
                Width = 110,
                Height = 32,
                Location = new Point(card.Width - 140, 65),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnView.FlatAppearance.BorderColor = Color.Green;
            btnView.Click += (s, e) =>
            {

                frmViewOrderDetails frm = new frmViewOrderDetails(_customerId, order.orderId);
                frm.ShowDialog();
            };

            Panel progressPanel = createProgressBar(order.orderStatus);
            progressPanel.Location = new Point(30, 120);

            card.Controls.Add(lblOrderCode);
            card.Controls.Add(lblOrderDate);
            card.Controls.Add(lblStatus);
            card.Controls.Add(lblAmounts);
            card.Controls.Add(btnView);
            card.Controls.Add(progressPanel);

            return card;
        }

        private Color getStatusColor(string status)
        {
            return status switch
            {
                "Pending" => Color.Orange,
                "Shipped" => Color.DodgerBlue,
                "Delivered" => Color.Green,
                "Cancelled" => Color.IndianRed,
                _ => Color.Gray
            };
        }

        private Panel createProgressBar(string status)
        {
            Panel container = new Panel
            {
                Width = 800,
                Height = 50
            };

            string[] steps = { "Pending", "Shipped", "Delivered" };
            int activeIndex = Array.IndexOf(steps, status);

            int x = 0;
            for (int i = 0; i < steps.Length; i++)
            {
                Panel dot = new Panel
                {
                    Width = 14,
                    Height = 14,
                    Left = x,
                    Top = 8,
                    BackColor = i <= activeIndex ? Color.Green : Color.LightGray
                };

                Label lbl = new Label
                {
                    Text = steps[i],
                    Left = x - 5,
                    Top = 20,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };

                container.Controls.Add(lbl);
                container.Controls.Add(dot);

                if (i < steps.Length - 1)
                {
                    Panel line = new Panel
                    {
                        Width = 180,
                        Height = 4,
                        Left = x + 14,
                        Top = 13,
                        BackColor = i < activeIndex ? Color.Green : Color.LightGray
                    };
                    container.Controls.Add(line);
                    x += 200;
                }
            }

            return container;
        }

        private GreenLife_Organic_Store.Models.Customer? getLoggedInCustomer()
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            return customerRepository.getCustomerByUserId(_loggedUserId);
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
    }
}
