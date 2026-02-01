namespace GreenLife_Organic_Store.Forms.Modals
{
    partial class frmDiscountDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscountDetails));
            lblSubHeading = new Label();
            lblHeading = new Label();
            lblEmail = new Label();
            lblContactPerson = new Label();
            txtDiscountCode = new TextBox();
            lblSupplierName = new Label();
            numericDiscountPercentage = new NumericUpDown();
            numericMaxUsage = new NumericUpDown();
            checkBoxIsActive = new CheckBox();
            btnCreate = new Button();
            dataGridDiscount = new DataGridView();
            btnActiveDiscount = new Button();
            btnDeleteDiscount = new Button();
            ((System.ComponentModel.ISupportInitialize)numericDiscountPercentage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMaxUsage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDiscount).BeginInit();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(12, 42);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(158, 20);
            lblSubHeading.TabIndex = 13;
            lblSubHeading.Text = "Create discount here";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(12, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.RightToLeft = RightToLeft.No;
            lblHeading.Size = new Size(227, 33);
            lblHeading.TabIndex = 12;
            lblHeading.Text = "Discount Details";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ControlText;
            lblEmail.Location = new Point(12, 173);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(165, 23);
            lblEmail.TabIndex = 46;
            lblEmail.Text = "Max Usage Count";
            // 
            // lblContactPerson
            // 
            lblContactPerson.AutoSize = true;
            lblContactPerson.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactPerson.ForeColor = SystemColors.ControlText;
            lblContactPerson.Location = new Point(383, 81);
            lblContactPerson.Name = "lblContactPerson";
            lblContactPerson.Size = new Size(237, 23);
            lblContactPerson.TabIndex = 44;
            lblContactPerson.Text = "Discount Percentage (%)";
            // 
            // txtDiscountCode
            // 
            txtDiscountCode.BackColor = SystemColors.InactiveBorder;
            txtDiscountCode.BorderStyle = BorderStyle.FixedSingle;
            txtDiscountCode.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscountCode.Location = new Point(12, 117);
            txtDiscountCode.Name = "txtDiscountCode";
            txtDiscountCode.Size = new Size(320, 31);
            txtDiscountCode.TabIndex = 43;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplierName.ForeColor = SystemColors.ControlText;
            lblSupplierName.Location = new Point(12, 81);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(139, 23);
            lblSupplierName.TabIndex = 42;
            lblSupplierName.Text = "Discount Code";
            // 
            // numericDiscountPercentage
            // 
            numericDiscountPercentage.BackColor = SystemColors.InactiveBorder;
            numericDiscountPercentage.BorderStyle = BorderStyle.FixedSingle;
            numericDiscountPercentage.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericDiscountPercentage.Location = new Point(383, 117);
            numericDiscountPercentage.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericDiscountPercentage.Name = "numericDiscountPercentage";
            numericDiscountPercentage.Size = new Size(413, 31);
            numericDiscountPercentage.TabIndex = 50;
            // 
            // numericMaxUsage
            // 
            numericMaxUsage.BackColor = SystemColors.InactiveBorder;
            numericMaxUsage.BorderStyle = BorderStyle.FixedSingle;
            numericMaxUsage.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericMaxUsage.Location = new Point(12, 221);
            numericMaxUsage.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericMaxUsage.Name = "numericMaxUsage";
            numericMaxUsage.Size = new Size(784, 31);
            numericMaxUsage.TabIndex = 51;
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxIsActive.Location = new Point(12, 276);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(132, 27);
            checkBoxIsActive.TabIndex = 52;
            checkBoxIsActive.Text = "Active Now";
            checkBoxIsActive.UseVisualStyleBackColor = true;
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
            btnCreate.Location = new Point(213, 325);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(180, 43);
            btnCreate.TabIndex = 53;
            btnCreate.Text = "Add Discount";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dataGridDiscount
            // 
            dataGridDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDiscount.BackgroundColor = Color.Honeydew;
            dataGridDiscount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDiscount.GridColor = Color.Green;
            dataGridDiscount.Location = new Point(12, 399);
            dataGridDiscount.MultiSelect = false;
            dataGridDiscount.Name = "dataGridDiscount";
            dataGridDiscount.ReadOnly = true;
            dataGridDiscount.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridDiscount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDiscount.Size = new Size(784, 281);
            dataGridDiscount.TabIndex = 54;
            // 
            // btnActiveDiscount
            // 
            btnActiveDiscount.BackColor = Color.LimeGreen;
            btnActiveDiscount.FlatAppearance.BorderColor = Color.LimeGreen;
            btnActiveDiscount.FlatAppearance.MouseDownBackColor = Color.Green;
            btnActiveDiscount.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnActiveDiscount.FlatStyle = FlatStyle.Flat;
            btnActiveDiscount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActiveDiscount.ForeColor = Color.White;
            btnActiveDiscount.Location = new Point(415, 325);
            btnActiveDiscount.Name = "btnActiveDiscount";
            btnActiveDiscount.Size = new Size(180, 43);
            btnActiveDiscount.TabIndex = 55;
            btnActiveDiscount.Text = "Active Discount";
            btnActiveDiscount.UseVisualStyleBackColor = false;
            btnActiveDiscount.Click += btnActiveDiscount_Click;
            // 
            // btnDeleteDiscount
            // 
            btnDeleteDiscount.BackColor = Color.Salmon;
            btnDeleteDiscount.FlatAppearance.BorderColor = Color.Salmon;
            btnDeleteDiscount.FlatAppearance.MouseDownBackColor = Color.OrangeRed;
            btnDeleteDiscount.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDeleteDiscount.FlatStyle = FlatStyle.Flat;
            btnDeleteDiscount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteDiscount.ForeColor = Color.White;
            btnDeleteDiscount.Location = new Point(616, 325);
            btnDeleteDiscount.Name = "btnDeleteDiscount";
            btnDeleteDiscount.Size = new Size(180, 43);
            btnDeleteDiscount.TabIndex = 56;
            btnDeleteDiscount.Text = "Remove Discount";
            btnDeleteDiscount.UseVisualStyleBackColor = false;
            btnDeleteDiscount.Click += btnDeleteDiscount_Click;
            // 
            // frmDiscountDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(840, 692);
            Controls.Add(btnDeleteDiscount);
            Controls.Add(btnActiveDiscount);
            Controls.Add(dataGridDiscount);
            Controls.Add(btnCreate);
            Controls.Add(checkBoxIsActive);
            Controls.Add(numericMaxUsage);
            Controls.Add(numericDiscountPercentage);
            Controls.Add(lblEmail);
            Controls.Add(lblContactPerson);
            Controls.Add(txtDiscountCode);
            Controls.Add(lblSupplierName);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmDiscountDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Discount Details";
            Load += frmDiscountDetails_Load;
            ((System.ComponentModel.ISupportInitialize)numericDiscountPercentage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMaxUsage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private Label lblEmail;
        private Label lblContactPerson;
        private TextBox txtDiscountCode;
        private Label lblSupplierName;
        private NumericUpDown numericDiscountPercentage;
        private NumericUpDown numericMaxUsage;
        private CheckBox checkBoxIsActive;
        private Button btnCreate;
        private DataGridView dataGridDiscount;
        private Button btnActiveDiscount;
        private Button btnDeleteDiscount;
    }
}