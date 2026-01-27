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

namespace GreenLife_Organic_Store
{
    public partial class frmUpdateCustomerProfile : Form
    {
        private int id = 0;
        public frmUpdateCustomerProfile()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public void editCustomer(Customer customer)
        {
            this.Text = "Edit Customer";
            this.lblHeading.Text = "Update Customer Information";
            this.lblSubHeading.Text = "Enter customer details to update to inventory";
            this.btnUpdateProfileConfirm.Text = "Update Customer";


            this.txtProfileFullName.Text = customer.fullName;
            this.txtProfileEmail.Text = customer.email;
            this.txtProfilePhone.Text = customer.phoneNumber;
            this.txtProfileAddress.Text = customer.address;
            this.id = customer.customerId;
        }

        private void frmUpdateCustomerProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelUpdateProfile_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnUpdateProfileConfirm_Click(object sender, EventArgs e)
        {
            if (txtProfileFullName.Text == "" || txtProfileEmail.Text == "" || txtProfileAddress.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Customer customer = new Customer();
            customer.customerId = this.id;
            customer.fullName = txtProfileFullName.Text;
            customer.email = txtProfileEmail.Text;
            customer.phoneNumber = txtProfilePhone.Text;
            customer.address = txtProfileAddress.Text;


            ICustomerRepository repository = new CustomerRepository();

            if (customer.customerId == 0)
            {
                MessageBox.Show("Something went wrong", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                repository.updateCustomer(customer);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
