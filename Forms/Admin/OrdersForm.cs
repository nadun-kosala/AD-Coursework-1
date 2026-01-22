using GreenLife_Organic_Store.Forms.Modals;
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

    public partial class frmAdminOrdersForm : Form
    {
        private int _loggedUserId;
        public frmAdminOrdersForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
            readOrders();
        }

        private void readOrders()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Order Code");
            dataTable.Columns.Add("Customer");
            dataTable.Columns.Add("Order Date");
            dataTable.Columns.Add("Total Amount");
            dataTable.Columns.Add("Discount Amount");
            dataTable.Columns.Add("Final Amount");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Shipping Address");


            var orderRepository = new OrderRepository();
            var orders = orderRepository.getAllOrders();

            foreach (var order in orders)
            {
                var row = dataTable.NewRow();
                row["ID"] = order.orderId;
                row["Order Code"] = order.orderCode;
                row["Customer"] = order.customerName;
                row["Order Date"] = order.orderDate;
                row["Total Amount"] = order.totalAmount;
                row["Discount Amount"] = order.discountAmount;
                row["Final Amount"] = order.finalAmount;
                row["Status"] = order.orderStatus;
                row["Shipping Address"] = order.shippingAddress;

                dataTable.Rows.Add(row);
            }

            this.tblOrders.DataSource = dataTable;
        }

        private void searchOrders()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Order Code");
            dataTable.Columns.Add("Customer");
            dataTable.Columns.Add("Order Date");
            dataTable.Columns.Add("Total Amount");
            dataTable.Columns.Add("Discount Amount");
            dataTable.Columns.Add("Final Amount");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Shipping Address");

            var searchTerm = txtOrderSearch.Text.Trim();
            var orderRepository = new OrderRepository();
            var orders = orderRepository.getAllOrderByOrderCode(searchTerm);

            foreach (var order in orders)
            {
                var row = dataTable.NewRow();
                row["ID"] = order.orderId;
                row["Order Code"] = order.orderCode;
                row["Customer"] = order.customerName;
                row["Order Date"] = order.orderDate;
                row["Total Amount"] = order.totalAmount;
                row["Discount Amount"] = order.discountAmount;
                row["Final Amount"] = order.finalAmount;
                row["Status"] = order.orderStatus;
                row["Shipping Address"] = order.shippingAddress;

                dataTable.Rows.Add(row);
            }

            this.tblOrders.DataSource = dataTable;
        }


        private void frmAdminOrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNavigateCustomers_Click(object sender, EventArgs e)
        {
            frmAdminCustomerForm frm = new frmAdminCustomerForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateProducts_Click(object sender, EventArgs e)
        {
            frmAdminProductFrom frm = new frmAdminProductFrom(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboardForm frm = new frmAdminDashboardForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateOrders_Click(object sender, EventArgs e)
        {
            frmAdminOrdersForm frm = new frmAdminOrdersForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateReports_Click(object sender, EventArgs e)
        {
            frmAdminReportsForm frm = new frmAdminReportsForm(_loggedUserId);
            frm.Show();
            this.Hide();

        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            searchOrders();
        }

        private void btnUpdateOrderStatus_Click(object sender, EventArgs e)
        {
            var val = this.tblOrders.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int orderId = int.Parse(val);

            var repository = new OrderRepository();
            var order = repository.getOrderById(orderId);

            if (order == null) return;

            frmOrderStatusUpdate frm = new frmOrderStatusUpdate();
            frm.updateStatus(order);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                readOrders();
            }
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
