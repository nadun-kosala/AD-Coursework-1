using GreenLife_Organic_Store.Models;
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

namespace GreenLife_Organic_Store.Forms.Modals
{
    public partial class frmCategoryDetails : Form
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();

        public frmCategoryDetails()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text?.Trim() ?? string.Empty;
            string desc = txtDiscription.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(desc))
            {
                MessageBox.Show("Please enter category description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Category category = new Category
                {
                    categoryName = name,
                    description = desc
                };

                _categoryRepository.createCategory(category);

                MessageBox.Show("Category created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCategoriesToGrid();

                txtCategoryName.Text = string.Empty;
                txtDiscription.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

        private void frmCategoryDetails_Load(object sender, EventArgs e)
        {
            loadCategoriesToGrid();
        }

        private void loadCategoriesToGrid()
        {
            try
            {
                var categories = _categoryRepository.getAllCategories();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Category Name");

                foreach (var c in categories)
                {
                    var row = dt.NewRow();
                    row["ID"] = c.categoryId;
                    row["Category Name"] = c.categoryName;
                    dt.Rows.Add(row);
                }

                dataGridCategory.DataSource = dt;
                dataGridCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
