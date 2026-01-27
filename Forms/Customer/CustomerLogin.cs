using GreenLife_Organic_Store.Forms.Admin;
using GreenLife_Organic_Store.RepoistoryInterfaces;
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

namespace GreenLife_Organic_Store.Forms.Customer
{
    public partial class frmCustomerLogin : Form
    {
        public frmCustomerLogin()
        {
            InitializeComponent();
        }

        private void frmCustomerLogin_Load(object sender, EventArgs e)
        {

        }
        private bool validatePassword(string inputPassword, string storedHash)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(storedHash))
                    return false;

                return BCrypt.Net.BCrypt.Verify(inputPassword, storedHash);
            }
            catch
            {
                return false;
            }
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {

            string inputUsername = txtCustomerUsername.Text.Trim();
            string inputPassword = txtCustomerPassword.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IUserRepository userRepository = new UserRepository();
                var user = userRepository.getUser(inputUsername);

                if (user != null && user.userType == "customer" && user.isActive && validatePassword(inputPassword, user.password))
                {
                    frmCustomerDashboardForm frm = new frmCustomerDashboardForm(user.userId);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                                "Incorrect Username or Password",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSwitchCustomer_Click(object sender, EventArgs e)
        {

            frmCustomerLogin frm = new frmCustomerLogin();
            frm.Show();
            this.Hide();
        }

        private void btnSwitchAdmin_Click(object sender, EventArgs e)
        {

            frmAdminLogin frm = new frmAdminLogin();
            frm.Show();
            this.Hide();
        }

        private void btnCustomerRegister_Click(object sender, EventArgs e)
        {

            frmCustomerRegister frm = new frmCustomerRegister();
            frm.Show();
            this.Hide();
        }

    }
}
