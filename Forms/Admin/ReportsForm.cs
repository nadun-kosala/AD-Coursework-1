using GreenLife_Organic_Store.Controllers;
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

namespace GreenLife_Organic_Store.Forms.Admin
{
    public partial class frmAdminReportsForm : Form
    {
        private int _loggedUserId;
        public frmAdminReportsForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdminReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNavigateCustomers_Click_1(object sender, EventArgs e)
        {
            frmAdminCustomerForm frm = new frmAdminCustomerForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateProducts_Click_1(object sender, EventArgs e)
        {
            frmAdminProductFrom frm = new frmAdminProductFrom(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateDashboard_Click_1(object sender, EventArgs e)
        {
            frmAdminDashboardForm frm = new frmAdminDashboardForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateOrders_Click_1(object sender, EventArgs e)
        {
            frmAdminOrdersForm frm = new frmAdminOrdersForm(_loggedUserId);
            frm.Show();
            this.Hide();
        }

        private void btnNavigateReports_Click_1(object sender, EventArgs e)
        {
            frmAdminReportsForm frm = new frmAdminReportsForm(_loggedUserId);
            frm.Show();
            this.Hide();

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

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string reportType = cmbReportType.Text;
            DateTime startDate = dtStartDate.Value;
            DateTime endDate = dtEndDate.Value;


            ReportController reportController = new ReportController();
            reportController.generateSalesReport(reportType, startDate, endDate);
        }
    }
}
