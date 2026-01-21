using GreenLife_Organic_Store.Models;
using GreenLife_Organic_Store.Repositories;
using MySql.Data.MySqlClient;
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
    public partial class frmAddNewProduct : Form
    {
        private int id = 0;
        public frmAddNewProduct()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            LoadCategories();
            LoadSuppliers();
        }

        private void btnCustomerRegister_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void frmAddNewProduct_Load(object sender, EventArgs e)
        {

        }

        public void editProduct(Product product)
        {
            this.Text = "Edit Product";
            this.lblHeading.Text = "Update Product Information";
            this.lblSubHeading.Text = "Enter product details to update to inventory";
            this.btnAddProduct.Text = "Update Product";


            this.txtProductName.Text = product.productName;
            this.cmbCategory.Text = product.category;
            this.txtPrice.Text = product.price.ToString();
            this.numericStockQuantity.Value = product.stockQuantity;
            this.cmbSupplier.Text = product.supplierName;
            this.txtDescription.Text = product.description;

            this.id = product.id;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtPrice.Text == "" || cmbCategory.SelectedIndex == -1 || cmbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show(
                    "Please enter a valid price (numbers only).",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (decimal.Parse(txtPrice.Text) < 0)
            {
                MessageBox.Show(
                   "Price cannot be negative",
                   "Validation Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return;
            }

            Product product = new Product();
            product.id = this.id;
            product.productName = txtProductName.Text;
            product.categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            product.price = decimal.Parse(txtPrice.Text);
            product.stockQuantity = (int)numericStockQuantity.Value;
            product.supplierId = Convert.ToInt32(cmbSupplier.SelectedValue);
            product.description = txtDescription.Text;

            var repository = new ProductRepository();

            if (product.id == 0)
            {
                repository.createProduct(product);
            }
            else
            {
                repository.updateProduct(product);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void LoadCategories()
        {
            var categoryRepo = new CategoryRepository();
            var categories = categoryRepo.getAllCategories();

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryId";
            cmbCategory.SelectedIndex = -1;
        }

        private void LoadSuppliers()
        {
            var supplierRepo = new SupplierRepository();
            var suppliers = supplierRepo.getAllSuppliers();

            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "supplierName";
            cmbSupplier.ValueMember = "supplierId";
            cmbSupplier.SelectedIndex = -1;
        }
        private void numericStockQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }
    }
}
