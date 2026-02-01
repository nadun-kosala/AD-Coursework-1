using GreenLife_Organic_Store.Forms.Modals;
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

namespace GreenLife_Organic_Store.Forms.Admin
{
    public partial class frmSettingsForm : Form
    {
        private int _loggedUserId;
        public frmSettingsForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
        }

        private void frmSettingsForm_Load(object sender, EventArgs e)
        {

        }



        private void btnNavigateSettings_Click(object sender, EventArgs e)
        {
            frmSettingsForm frm = new frmSettingsForm(_loggedUserId);
            frm.Show();
            this.Hide();

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

        private void frmSettingsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategoryDetails frmCategoryDetails = new frmCategoryDetails();
            frmCategoryDetails.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplierDetails frmSupplierDetails = new frmSupplierDetails();
            frmSupplierDetails.Show();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmDiscountDetails frmDiscountDetails = new frmDiscountDetails();
            frmDiscountDetails.Show();
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
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
