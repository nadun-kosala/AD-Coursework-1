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

namespace GreenLife_Organic_Store.Forms.Customer
{
    public partial class frmCustomerProfileForm : Form
    {
        private int _loggedUserId;
        public frmCustomerProfileForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
        }

        private void CustomerProfileForm_Load(object sender, EventArgs e)
        {

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

        private void btnCustomerLogout_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
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
