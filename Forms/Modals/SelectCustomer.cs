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
    public partial class frmSelectCustomer : Form
    {
        public int selectedCustomerId { get; private set; } = 0;
        public string selectedCustomerName { get; private set; } = string.Empty;

        public frmSelectCustomer()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmSelectCustomer_Load(object sender, EventArgs e)
        {
            loadCustomers();
        }

        private void loadCustomers()
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            List<GreenLife_Organic_Store.Models.Customer> customers = customerRepository.getAllCustomers();


            cmbCustomersList.DataSource = customers;
            cmbCustomersList.DisplayMember = "fullName";
            cmbCustomersList.ValueMember = "customerId";
            cmbCustomersList.SelectedIndex = -1;

        }

        private void btnGenerateCustomerReport_Click(object sender, EventArgs e)
        {
            if (cmbCustomersList.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = (int)cmbCustomersList.SelectedValue;
            string customerName = cmbCustomersList.Text;

            this.selectedCustomerId = customerId;
            this.selectedCustomerName = customerName;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
