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

namespace GreenLife_Organic_Store.Forms.Modals
{
    public partial class frmViewOrderDetails : Form
    {
        private int _customerId;
        private int _orderId;
        public frmViewOrderDetails(int customerId, int orderId)
        {
            InitializeComponent();
             _customerId = customerId;
            _orderId = orderId;
        }

        private void frmViewOrderDetails_Load(object sender, EventArgs e)
        {

            showOrderMainData();
            loadOrderDetails();

        }

        public void loadOrderDetails()
        {
         

            flowLayoutOrderDetails.Controls.Clear();

            IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
            List<OrderDetail> items = orderDetailRepository.getOrderDetailsByOrderId(_orderId);

            Label lblHeader = new Label
            {
                Text = "Items",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Margin = new Padding(3, 0, 3, 10)
            };

            flowLayoutOrderDetails.Controls.Add(lblHeader);

            decimal total = 0m;

            foreach (var item in items)
            {
                total += item.subTotal;
                flowLayoutOrderDetails.Controls.Add(createOrderItemCard(item));
            }

            flowLayoutOrderDetails.Controls.Add(createTotalRow(total));
        }

        private Panel createOrderItemCard(OrderDetail item)
        {
            Panel card = new Panel
            {
                Width = flowLayoutOrderDetails.ClientSize.Width - 30,
                Height = 65,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 8)
            };

            Label lblName = new Label
            {
                Text = item.productName,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, 8)
            };

            Label lblQty = new Label
            {
                Text = $"Quantity: {item.quantity}",
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(10, 30)
            };

            Label lblPrice = new Label
            {
                Text = $"LKR { item.subTotal.ToString()}",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true
            };

            lblPrice.Location = new Point(card.Width - lblPrice.PreferredWidth - 15, 22);

            card.Controls.Add(lblName);
            card.Controls.Add(lblQty);
            card.Controls.Add(lblPrice);

            return card;
        }

        private Panel createTotalRow(decimal total)
        {
            Panel totalPanel = new Panel
            {
                Width = flowLayoutOrderDetails.ClientSize.Width - 30,
                Height = 45,
                BackColor = Color.White,
                Margin = new Padding(0, 10, 0, 0)
            };

            Label lblTotalText = new Label
            {
                Text = "Total",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, 12)
            };

            Label lblTotalValue = new Label
            {
                Text = $"LKR {total.ToString()}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Green,
                AutoSize = true
            };

            lblTotalValue.Location = new Point(
                totalPanel.Width - lblTotalValue.PreferredWidth - 10,
                12
            );

            totalPanel.Controls.Add(lblTotalText);
            totalPanel.Controls.Add(lblTotalValue);

            return totalPanel;
        }


        private void showOrderMainData()
        {
            IOrderRepository orderRepository = new OrderRepository();
            Order? order = orderRepository.getOrderById(_orderId);
            if (order != null)
            {
                lblOrderCode.Text = $"{order.orderCode}";
                lblOrderDate.Text = $"Order Date: {order.orderDate.ToString("yyyy-MM-dd HH:mm:ss")}"; ;
                lblOrderStatus.Text = order.orderStatus;

                lblOrderStatus.BackColor = getStatusBackColor(order.orderStatus);
                lblOrderStatus.ForeColor = Color.White;
                lblOrderStatus.AutoSize = true;
                lblOrderStatus.TextAlign = ContentAlignment.MiddleCenter;
                lblOrderStatus.Padding = new Padding(8, 4, 8, 4);
            }
            else
            {
                MessageBox.Show("Error loading order data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private Color getStatusBackColor(string orderStatus)
        {
            switch (orderStatus)
            {
                case "Pending":
                    return Color.Orange;

                case "Shipped":
                    return Color.DodgerBlue;

                case "Delivered":
                    return Color.SeaGreen;

                case "Cancelled":
                    return Color.IndianRed;

                default:
                    return Color.Gray;
            }
        }


    }
}
