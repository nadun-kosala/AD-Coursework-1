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

namespace GreenLife_Organic_Store.Forms.Modals
{
    public partial class frmOrderStatusUpdate : Form
    {
        private int id = 0;
        public frmOrderStatusUpdate()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public void updateStatus(Order order)
        {

            this.lblOrderCodeValue.Text = order.orderCode;
            this.lblOrderDateValue.Text = Convert.ToString(order.orderDate);
            this.lblFinalAmountValue.Text = "LKR " + Convert.ToString(order.finalAmount);
            this.cmbOrderStatus.Text = order.orderStatus;

            this.id = order.orderId;
        }

        private void frmOrderStatusUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnProductCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (cmbOrderStatus.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a valid order status.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            Order order = new Order();
            order.orderId = this.id;
            order.orderStatus = cmbOrderStatus.SelectedItem.ToString();

            try
            {
                var repository = new OrderRepository();
                repository.updateOrderStatus(order);

                MessageBox.Show(
                    "Order status updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while updating order status: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
