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
    public partial class frmGiveReview : Form
    {
        private int _customerId;
        private List<OrderDetail>? _orderDetails;
        private readonly IProductReviewRepository _reviewRepository = new ProductReviewRepository();

        public frmGiveReview(int customerId, List<OrderDetail> orderDetails)
        {
            InitializeComponent();
            _customerId = customerId;
            _orderDetails = orderDetails;
        }

        private void frmGiveReview_Load(object sender, EventArgs e)
        {
            cmbProductName.Items.Clear();
            if (_orderDetails != null)
            {
                var products = _orderDetails.Select(od => new { Id = od.productId, Name = od.productName }).ToList();
                cmbProductName.DataSource = products;
                cmbProductName.DisplayMember = "Name";
                cmbProductName.ValueMember = "Id";
                cmbProductName.SelectedIndex = -1;
            }

            cmbRating.Items.Clear();
            for (int i = 1; i <= 5; i++) cmbRating.Items.Add(i);
            cmbRating.SelectedIndex = -1;
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (cmbProductName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRating.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(cmbProductName.SelectedValue);
            int rating = Convert.ToInt32(cmbRating.SelectedItem);
            string reviewText = txtReview.Text?.Trim() ?? string.Empty;

            bool exists = _reviewRepository.checkExistingReview(productId, _customerId);
            if (exists)
            {
                MessageBox.Show("You have already reviewed this product", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _reviewRepository.addReview(productId, _customerId, rating, reviewText);
                MessageBox.Show("Review submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while submitting the review." + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnReviewCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
