using GreenLife_Organic_Store.Forms.Admin;
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

namespace GreenLife_Organic_Store
{
    public partial class frmAdminProductFrom : Form
    {
        private int _loggedUserId;
        public frmAdminProductFrom(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
            readProducts();
        }

        private void frmProductFrom_Load(object sender, EventArgs e)
        {

        }

        private void btnNavigateDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboardForm frm = new frmAdminDashboardForm(_loggedUserId);
            frm.Show();
            this.Hide();

        }

        private void readProducts()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Stock");
            dataTable.Columns.Add("Description");

            var productRepository = new ProductRepository();
            var products = productRepository.GetAllProducts();

            foreach (var product in products)
            {
                var row = dataTable.NewRow();
                row["ID"] = product.id;
                row["Product Name"] = product.productName;
                row["Price"] = product.price;
                row["Stock"] = product.stockQuantity;
                row["Description"] = product.description;
                dataTable.Rows.Add(row);
            }

            this.tblProducts.DataSource = dataTable;

        }

    }
}
