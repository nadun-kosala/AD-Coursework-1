namespace GreenLife_Organic_Store.Forms.Modals
{
    partial class frmSupplierDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierDetails));
            lblSubHeading = new Label();
            lblHeading = new Label();
            btnCreate = new Button();
            txtContactPerson = new TextBox();
            lblContactPerson = new Label();
            txtSupplierName = new TextBox();
            lblSupplierName = new Label();
            txtPhoneNumber = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtAddress = new TextBox();
            lblAdress = new Label();
            dataGridSupplier = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridSupplier).BeginInit();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(12, 42);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(155, 20);
            lblSubHeading.TabIndex = 11;
            lblSubHeading.Text = "Create supplier here";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(12, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.RightToLeft = RightToLeft.No;
            lblHeading.Size = new Size(223, 33);
            lblHeading.TabIndex = 10;
            lblHeading.Text = "Supplier Details";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LimeGreen;
            btnCreate.FlatAppearance.BorderColor = Color.LimeGreen;
            btnCreate.FlatAppearance.MouseDownBackColor = Color.Green;
            btnCreate.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(622, 373);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(180, 43);
            btnCreate.TabIndex = 37;
            btnCreate.Text = "Add Supplier";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtContactPerson
            // 
            txtContactPerson.BackColor = SystemColors.InactiveBorder;
            txtContactPerson.BorderStyle = BorderStyle.FixedSingle;
            txtContactPerson.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactPerson.Location = new Point(389, 112);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(413, 31);
            txtContactPerson.TabIndex = 36;
            // 
            // lblContactPerson
            // 
            lblContactPerson.AutoSize = true;
            lblContactPerson.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactPerson.ForeColor = SystemColors.ControlText;
            lblContactPerson.Location = new Point(389, 76);
            lblContactPerson.Name = "lblContactPerson";
            lblContactPerson.Size = new Size(146, 23);
            lblContactPerson.TabIndex = 35;
            lblContactPerson.Text = "Contact Person";
            // 
            // txtSupplierName
            // 
            txtSupplierName.BackColor = SystemColors.InactiveBorder;
            txtSupplierName.BorderStyle = BorderStyle.FixedSingle;
            txtSupplierName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierName.Location = new Point(18, 112);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(320, 31);
            txtSupplierName.TabIndex = 34;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplierName.ForeColor = SystemColors.ControlText;
            lblSupplierName.Location = new Point(18, 76);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(159, 23);
            lblSupplierName.TabIndex = 33;
            lblSupplierName.Text = "Supplier Name *";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.InactiveBorder;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(389, 204);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(413, 31);
            txtPhoneNumber.TabIndex = 41;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = SystemColors.ControlText;
            lblPhone.Location = new Point(389, 168);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(68, 23);
            lblPhone.TabIndex = 40;
            lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveBorder;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(18, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 31);
            txtEmail.TabIndex = 39;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlText;
            lblEmail.Location = new Point(18, 168);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 23);
            lblEmail.TabIndex = 38;
            lblEmail.Text = "Email";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.InactiveBorder;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(18, 304);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(784, 31);
            txtAddress.TabIndex = 43;
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdress.ForeColor = SystemColors.ControlText;
            lblAdress.Location = new Point(12, 265);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(85, 23);
            lblAdress.TabIndex = 42;
            lblAdress.Text = "Address";
            // 
            // dataGridSupplier
            // 
            dataGridSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridSupplier.BackgroundColor = Color.Honeydew;
            dataGridSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSupplier.GridColor = Color.Green;
            dataGridSupplier.Location = new Point(18, 479);
            dataGridSupplier.MultiSelect = false;
            dataGridSupplier.Name = "dataGridSupplier";
            dataGridSupplier.ReadOnly = true;
            dataGridSupplier.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSupplier.Size = new Size(784, 251);
            dataGridSupplier.TabIndex = 44;
            // 
            // frmSupplierDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(842, 742);
            Controls.Add(dataGridSupplier);
            Controls.Add(txtAddress);
            Controls.Add(lblAdress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnCreate);
            Controls.Add(txtContactPerson);
            Controls.Add(lblContactPerson);
            Controls.Add(txtSupplierName);
            Controls.Add(lblSupplierName);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "frmSupplierDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier Details";
            Load += frmSupplierDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private Button btnCreate;
        private TextBox txtContactPerson;
        private Label lblContactPerson;
        private TextBox txtSupplierName;
        private Label lblSupplierName;
        private TextBox txtPhoneNumber;
        private Label lblPhone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtAddress;
        private Label lblAdress;
        private DataGridView dataGridSupplier;
    }
}