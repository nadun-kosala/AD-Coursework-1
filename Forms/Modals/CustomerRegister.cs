using GreenLife_Organic_Store.Forms.Customer;
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
    public partial class frmCustomerRegister : Form
    {
        public frmCustomerRegister()
        {
            InitializeComponent();
        }

        private void lblSubHeading_Click(object sender, EventArgs e)
        {

        }

        private void btnCusRegBackToLogin_Click(object sender, EventArgs e)
        {
            frmCustomerLogin frm = new frmCustomerLogin();
            frm.Show();
            this.Hide();
        }

        private void btnCusRegRegister_Click(object sender, EventArgs e)
        {
            if (txtCusRegFullName.Text == "" || txtCusRegEmail.Text == "" || txtCusRegUsername.Text == "" || txtCusRegPhone.Text == "" || txtCusRegAddress.Text == "" || txtCusRegPassword.Text == "" || txtCusRegConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCusRegPassword.Text.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters long.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (txtCusRegPassword.Text != txtCusRegConfirmPassword.Text)
            {
                MessageBox.Show(
                    "Password do not match",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            var plainPassword = txtCusRegPassword.Text;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainPassword);

            IUserRepository userRepository = new UserRepository();

            var isUsernameTaken = userRepository.getUser(txtCusRegUsername.Text);
            if (isUsernameTaken != null)
            {
                MessageBox.Show(
                       "Username already taken. Try with another",
                       "Validation Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            User user = new User();
            user.username = txtCusRegFullName.Text;
            user.password = hashedPassword;
            user.userType = "customer";
            user.isActive = true;


            int userId = userRepository.createUser(user);


            Customer customer = new Customer();
            customer.fullName = txtCusRegFullName.Text;
            customer.email = txtCusRegEmail.Text;
            customer.phoneNumber = txtCusRegPhone.Text;
            customer.address = txtCusRegAddress.Text;
            customer.userId = userId;

            ICustomerRepository repository = new CustomerRepository();
            repository.createCustomer(customer);

            MessageBox.Show("Registration Successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            frmCustomerLogin frm = new frmCustomerLogin();
            frm.Show();
            this.Hide();

        }

        private void frmCustomerRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
