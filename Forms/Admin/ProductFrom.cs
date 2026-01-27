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

namespace GreenLife_Organic_Store
{
    public partial class frmAdminProductFrom : Form
    {
        private int _loggedUserId;
        private readonly IProductRepository _productRepository = new ProductRepository();
        public frmAdminProductFrom(int userId)
        {
            InitializeComponent();
            _loggedUserId = userId;
            readProducts();
        }

        private void frmProductFrom_Load(object sender, EventArgs e)
        {

        }

        private void readProducts()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Stock");
            dataTable.Columns.Add("Description");

            var products = _productRepository.getAllProducts();

            foreach (var product in products)
            {
                var row = dataTable.NewRow();
                row["ID"] = product.id;
                row["Product Name"] = product.productName;
                row["Category"] = product.category;
                row["Price"] = product.price;
                row["Stock"] = product.stockQuantity;
                row["Description"] = product.description;
                dataTable.Rows.Add(row);
            }

            this.tblProducts.DataSource = dataTable;

        }

        private void searchProducts()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Stock");
            dataTable.Columns.Add("Description");

            var searchTerm = txtProductSearch.Text.Trim();

            var products = _productRepository.getAllProductsByName(searchTerm);

            foreach (var product in products)
            {
                var row = dataTable.NewRow();
                row["ID"] = product.id;
                row["Product Name"] = product.productName;
                row["Category"] = product.category;
                row["Price"] = product.price;
                row["Stock"] = product.stockQuantity;
                row["Description"] = product.description;
                dataTable.Rows.Add(row);
            }

            this.tblProducts.DataSource = dataTable;

        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            frmAddNewProduct frm = new frmAddNewProduct();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                readProducts();
            }
        }

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            var val = this.tblProducts.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int productId = int.Parse(val);

            var product = _productRepository.getProductById(productId);

            if (product == null) return;

            frmAddNewProduct frm = new frmAddNewProduct();
            frm.editProduct(product);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                readProducts();
            }
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            var val = this.tblProducts.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int productId = int.Parse(val);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            _productRepository.deleteProduct(productId);

            readProducts();

        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            searchProducts();
        }

        private void tblProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNavigateCustomers_Click(object sender, EventArgs e)
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

        private void btnNavigateDashboard_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
