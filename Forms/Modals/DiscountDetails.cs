using GreenLife_Organic_Store.Models;
using GreenLife_Organic_Store.Repositories;
using GreenLife_Organic_Store.RepoistoryInterfaces;
using System;
using System.Data;
using System.Windows.Forms;

namespace GreenLife_Organic_Store.Forms.Modals
{
    public partial class frmDiscountDetails : Form
    {
        private readonly IDiscountRepository _discountRepository = new DiscountRepository();

        public frmDiscountDetails()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string code = txtDiscountCode.Text?.Trim() ?? string.Empty;
            decimal percentage = numericDiscountPercentage.Value;
            int maxUsage = (int)numericMaxUsage.Value;
            bool isActive = checkBoxIsActive.Checked;

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Discount code is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (percentage <= 0)
            {
                MessageBox.Show("Discount percentage must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var discount = new Discount
                {
                    discountCode = code,
                    percentage = percentage,
                    maxUsageCount = maxUsage,
                    currentUsageCount = 0,
                    isActive = isActive
                };

                _discountRepository.createDiscount(discount);

                MessageBox.Show("Discount created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDiscountCode.Text = string.Empty;
                numericDiscountPercentage.Value = 0;
                numericMaxUsage.Value = 0;
                checkBoxIsActive.Checked = false;

                loadDiscountsToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating discount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

        private void frmDiscountDetails_Load(object sender, EventArgs e)
        {
            loadDiscountsToGrid();
        }

        private void loadDiscountsToGrid()
        {
            try
            {
                var discounts = _discountRepository.getAllDiscounts();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Code");
                dt.Columns.Add("Percentage");
                dt.Columns.Add("Max Usage");
                dt.Columns.Add("Current Usage");
                dt.Columns.Add("Status");

                foreach (var d in discounts)
                {
                    var row = dt.NewRow();
                    row["ID"] = d.discountId;
                    row["Code"] = d.discountCode;
                    row["Percentage"] = d.percentage;
                    row["Max Usage"] = d.maxUsageCount;
                    row["Current Usage"] = d.currentUsageCount;
                    row["Status"] = d.isActive ? "Active" : "Deactive";
                    dt.Rows.Add(row);
                }

                dataGridDiscount.DataSource = dt;
                dataGridDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnActiveDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridDiscount.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a discount to activate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var selectedRow = dataGridDiscount.SelectedRows[0];
                int discountId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string status = Convert.ToString(selectedRow.Cells["Status"].Value) ?? string.Empty;

                if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Selected discount is already active.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _discountRepository.activateDiscount(discountId);

                MessageBox.Show("Discount activated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDiscountsToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error activating discount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridDiscount.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a discount to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var selectedRow = dataGridDiscount.SelectedRows[0];
                int discountId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete the selected discount?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                _discountRepository.deleteDiscount(discountId);
                MessageBox.Show("Discount deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDiscountsToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting discount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
