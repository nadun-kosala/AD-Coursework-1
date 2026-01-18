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
    public partial class frmAdminDashboardForm : Form
    {
        private int _loggedUserId;
        public frmAdminDashboardForm(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
        }

        private void frmAdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNavigateProducts_Click(object sender, EventArgs e)
        {
            frmAdminProductFrom frm = new frmAdminProductFrom(_loggedUserId);
            frm.Show();
            this.Hide();
        }
    }
}
