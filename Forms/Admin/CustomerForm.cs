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
    public partial class frmAdminCustomerForm : Form
    {
        private int _loggedUserId;
        public frmAdminCustomerForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
            readCustomers();
        }

        private void frmAdminCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void readCustomers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Full Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Phone Number");
            dataTable.Columns.Add("Address");

            var customerRepository = new CustomerRepository();
            var customers = customerRepository.getAllCustomers();

            foreach (var customer in customers)
            {
                var row = dataTable.NewRow();
                row["ID"] = customer.customerId;
                row["Full Name"] = customer.fullName;
                row["Email"] = customer.email;
                row["Phone Number"] = customer.phoneNumber;
                row["Address"] = customer.address;
                dataTable.Rows.Add(row);
            }

            this.tblCustomers.DataSource = dataTable;

        }

        private void searchCustomers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Full Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Phone Number");
            dataTable.Columns.Add("Address");

            var searchTerm = txtCustomerSearch.Text.Trim();

            var customerRepository = new CustomerRepository();
            var customers = customerRepository.getAllCustomersByNameOrEmail(searchTerm);

            foreach (var customer in customers)
            {
                var row = dataTable.NewRow();
                row["ID"] = customer.customerId;
                row["Full Name"] = customer.fullName;
                row["Email"] = customer.email;
                row["Phone Number"] = customer.phoneNumber;
                row["Address"] = customer.address;
                dataTable.Rows.Add(row);
            }

            this.tblCustomers.DataSource = dataTable;

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

        private void btnNavigateCustomers_Click(object sender, EventArgs e)
        {
            frmAdminCustomerForm frm = new frmAdminCustomerForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            searchCustomers();
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            var val = this.tblCustomers.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int customerId = int.Parse(val);

            var repository = new CustomerRepository();
            var customer = repository.getCustomerById(customerId);

            if (customer == null) return;

            frmUpdateCustomerProfile frm = new frmUpdateCustomerProfile();
            frm.editCustomer(customer);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                readCustomers();
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            var val = this.tblCustomers.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int customerId = int.Parse(val);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repository = new CustomerRepository();
            repository.deleteCustomer(customerId);
           
            readCustomers();
            
        }
    }
}
