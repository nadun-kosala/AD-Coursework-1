using GreenLife_Organic_Store.Models;
using GreenLife_Organic_Store.RepoistoryInterfaces;
using GreenLife_Organic_Store.Repositories;
using System;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;

namespace GreenLife_Organic_Store.Forms.Modals
{
    public partial class frmSupplierDetails : Form
    {
        private readonly ISupplierRepository _supplierRepository = new SupplierRepository();

        public frmSupplierDetails()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text?.Trim() ?? string.Empty;
            string contact = txtContactPerson.Text?.Trim() ?? string.Empty;
            string email = txtEmail.Text?.Trim() ?? string.Empty;
            string phone = txtPhoneNumber.Text?.Trim() ?? string.Empty;
            string address = txtAddress.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Supplier name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email.Trim()))
            {
                return;
            }

            try
            {
                Supplier supplier = new Supplier
                {
                    supplierName = name,
                    contactPerson = contact,
                    email = email,
                    phoneNumber = phone,
                    address = address
                };

                _supplierRepository.createSupplier(supplier);

                MessageBox.Show("Supplier created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSupplierName.Text = string.Empty;
                txtContactPerson.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty;
                txtAddress.Text = string.Empty;

                loadSuppliersToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
        }

        private void frmSupplierDetails_Load(object sender, EventArgs e)
        {
            loadSuppliersToGrid();
        }

        private void loadSuppliersToGrid()
        {
            try
            {
                var suppliers = _supplierRepository.getAllSuppliers();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Supplier Name");
                dt.Columns.Add("Contact Person");
                dt.Columns.Add("Email");
                dt.Columns.Add("Phone");

                foreach (var s in suppliers)
                {
                    var row = dt.NewRow();
                    row["ID"] = s.supplierId;
                    row["Supplier Name"] = s.supplierName;
                    row["Contact Person"] = s.contactPerson;
                    row["Email"] = s.email;
                    row["Phone"] = s.phoneNumber;
                    dt.Rows.Add(row);
                }

                dataGridSupplier.DataSource = dt;
                dataGridSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                if (addr.Address != email)
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
