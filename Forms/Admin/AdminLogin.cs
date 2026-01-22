using GreenLife_Organic_Store.Forms.Customer;
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

namespace GreenLife_Organic_Store.Forms.Admin
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtAdminUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtAdminUsername.Text.Trim();
            string inputPassword = txtAdminPassword.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UserRepository userRepository = new UserRepository();
                var user = userRepository.getUser(inputUsername);

                if (user != null && user.userType == "admin" && user.isActive && validatePassword(inputPassword, user.password))
                {
                    frmAdminDashboardForm frm = new frmAdminDashboardForm(user.userId);
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
    }
}
