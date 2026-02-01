using GreenLife_Organic_Store.Models;
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
    public partial class frmCustomerProfileForm : Form
    {
        private int _loggedUserId;
        private GreenLife_Organic_Store.Models.Customer? _customer;
        private GreenLife_Organic_Store.Models.User? _user;
        ICustomerRepository _customerRepository = new CustomerRepository();
        IUserRepository userRepository = new UserRepository();
        public frmCustomerProfileForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
            _user = userRepository.getUserById(_loggedUserId);

        }

        private void CustomerProfileForm_Load(object sender, EventArgs e)
        {
            fillCustomerProfileForm();
        }

        private void fillCustomerProfileForm()
        {
            _customer = _customerRepository.getCustomerByUserId(_loggedUserId);
            if (_customer != null)
            {
                lblProfileName.Text = _customer.fullName;
                lblProfileEmailHead.Text = _customer.email;
                lblProfileEmail.Text = _customer.email;
                lblProfilePhoneNumber.Text = _customer.phoneNumber;
                lblProfileAddress.Text = _customer.address;

                txtProfileFullName.Text = _customer.fullName;
                txtProfileEmail.Text = _customer.email;
                txtProfilePhone.Text = _customer.phoneNumber;
                txtProfileAddress.Text = _customer.address;

            }
            else
            {
                MessageBox.Show("Error loading profile. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMyProfilesSub_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProfilEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            _user = userRepository.getUserById(_loggedUserId);
            if (txtCurrentPassword.Text == "" || txtNewPassword.Text == "" || txtConfirmNewPassword.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters long.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show(
                    "Password do not match",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            var currentPassword = txtCurrentPassword.Text;
            var newPassword = txtNewPassword.Text;

            if (_user == null || string.IsNullOrWhiteSpace(_user.password) || !validatePassword(currentPassword, _user.password))
            {
                MessageBox.Show("Current password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
            _user.password = hashedPassword;
            bool isUpdated = userRepository.updateUserPassword(_loggedUserId, hashedPassword);
            if (isUpdated) {
                MessageBox.Show(
                            "Password updated. You will logout now",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                logout();
            }
            else 
            {                
                MessageBox.Show(
                            "Error updating password",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                return;
            }
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

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtProfileEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMyProfileHeadings_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCusRegUsername_Click(object sender, EventArgs e)
        {

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

        private void logout()
        {
            if (_user != null && _user.userType == "customer")
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

        private void btnCustomerLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            frmUpdateCustomerProfile frmUpdateCustomerProfile = new frmUpdateCustomerProfile();
            frmUpdateCustomerProfile.editCustomer(_customer);
            var result = frmUpdateCustomerProfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                frmUpdateCustomerProfile.Close();
                fillCustomerProfileForm();

            }
        }
    }
}
