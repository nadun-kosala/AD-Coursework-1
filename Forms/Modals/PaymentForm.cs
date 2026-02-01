using GreenLife_Organic_Store.Controllers;
using GreenLife_Organic_Store.Forms.Customer;
using GreenLife_Organic_Store.Helpers;
using GreenLife_Organic_Store.RepoistoryInterfaces;
using GreenLife_Organic_Store.Repositories;
using GreenLife_Organic_Store.Models;
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
    public partial class frmPaymentForm : Form
    {
        private int _loggedUserId;
        private int _customerId;
        private string? _customerAddress;
        private decimal _finalAmount;
        private Discount? _appliedDiscount;

        public frmPaymentForm(int userId, decimal finalAmount)
        {
            InitializeComponent();
            _loggedUserId = userId;
            _finalAmount = finalAmount;
        }

        public frmPaymentForm(int userId, decimal finalAmount, Discount? appliedDiscount) : this(userId, finalAmount)
        {
            _appliedDiscount = appliedDiscount;
        }

        private void frmPaymentForm_Load(object sender, EventArgs e)
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            var cus = customerRepository.getCustomerByUserId(_loggedUserId);
            if (cus != null)
            {
                _customerId = cus.customerId;
                _customerAddress = cus.address;

                lblTotalAmountShow.Text = $"LKR {_finalAmount:F2}";
            }
            else
            {
                MessageBox.Show("Unable to retrieve customer details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void btnCancelPayNow_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            string cardNumber = txtCardNumber.Text.Trim();
            DateTime expiryDate = dateTimeExpire.Value;
            string cvv = txtCVV.Text.Trim();
            string address = txtShippingAddress.Text.Trim();
            bool useProdileAddress = checkProfileAddress.Checked;
            if (!validateCardDetails(cardNumber, expiryDate, cvv))
            {
                return; 
            }
            string? shippingAddress = validateAndGetShippingAddress(address, useProdileAddress);
            if (shippingAddress == null)
                return;

            try
            {
                var payment = new ProcessPaymentController(_customerId, shippingAddress);
                payment.process();

                if (_appliedDiscount != null)
                {
                    try
                    {
                        IDiscountRepository discountRepo = new DiscountRepository();
                        discountRepo.incrementUsage(_appliedDiscount.discountId);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to update discount usage: " + ex.ToString());
                    }
                }

                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Payment Failed");
            }

        }

        private string? validateAndGetShippingAddress(string address, bool useProfileAddress)
        {
            if (string.IsNullOrWhiteSpace(address) && !useProfileAddress)
            {
                MessageBox.Show(
                    "Please enter a shipping address or select profile address.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return null;
            }

            if (!string.IsNullOrWhiteSpace(address) && useProfileAddress)
            {
                MessageBox.Show(
                    "Please select only one shipping address option.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return null;
            }

            if (useProfileAddress)
            {
                return _customerAddress;
            }

            return address;
        }

        private bool validateCardDetails(string cardNumber, DateTime expireDate, string cvv)
        {

            if(string.IsNullOrWhiteSpace(cardNumber))
            {
                MessageBox.Show(
                    "Card number is required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (string.IsNullOrWhiteSpace(cvv))
            {
                MessageBox.Show(
                    "CVV number is required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(cardNumber, @"^[0-9 ]+$"))
            {
                MessageBox.Show(
                    "Card number must contain only numbers.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (cardNumber != "4444444444444444")
            {
                MessageBox.Show(
                    "Invalid card number.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (expireDate.Date <= DateTime.Now.Date)
            {
                MessageBox.Show(
                    "Card expiry date must be a future date.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(cvv, @"^\d{3}$"))
            {
                MessageBox.Show(
                    "CVV must be exactly 3 digits.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            return true;
        }

    }
}
