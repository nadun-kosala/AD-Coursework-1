namespace GreenLife_Organic_Store
{
    partial class frmAddNewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewProduct));
            lblSubHeading = new Label();
            lblHeading = new Label();
            lblCusRegEmail = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            cmbCategory = new ComboBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblStockQuantity = new Label();
            lblSupplier = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btnProductCancel = new Button();
            btnAddProduct = new Button();
            numericStockQuantity = new NumericUpDown();
            cmbSupplier = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericStockQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(12, 56);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(305, 20);
            lblSubHeading.TabIndex = 7;
            lblSubHeading.Text = "Enter product details to add to inventory";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(12, 23);
            lblHeading.Name = "lblHeading";
            lblHeading.RightToLeft = RightToLeft.No;
            lblHeading.Size = new Size(238, 33);
            lblHeading.TabIndex = 6;
            lblHeading.Text = "Add New Product";
            // 
            // lblCusRegEmail
            // 
            lblCusRegEmail.AutoSize = true;
            lblCusRegEmail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegEmail.ForeColor = SystemColors.ControlText;
            lblCusRegEmail.Location = new Point(387, 112);
            lblCusRegEmail.Name = "lblCusRegEmail";
            lblCusRegEmail.Size = new Size(104, 23);
            lblCusRegEmail.TabIndex = 16;
            lblCusRegEmail.Text = "Category *";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.InactiveBorder;
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(12, 148);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(320, 31);
            txtProductName.TabIndex = 15;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = SystemColors.ControlText;
            lblProductName.Location = new Point(12, 112);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(153, 23);
            lblProductName.TabIndex = 14;
            lblProductName.Text = "Product Name *";
            lblProductName.Click += lblProductName_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.InactiveBorder;
            cmbCategory.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Fruits", "Vegitable", "Grains", "Dairy", "Dairy Alternatives", "Sweeteners" });
            cmbCategory.Location = new Point(387, 148);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(320, 31);
            cmbCategory.TabIndex = 22;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.InactiveBorder;
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(12, 245);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(320, 31);
            txtPrice.TabIndex = 24;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ControlText;
            lblPrice.Location = new Point(12, 209);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(128, 23);
            lblPrice.TabIndex = 23;
            lblPrice.Text = "Price (LKR) *";
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockQuantity.ForeColor = SystemColors.ControlText;
            lblStockQuantity.Location = new Point(387, 209);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(156, 23);
            lblStockQuantity.TabIndex = 25;
            lblStockQuantity.Text = "Stock Quantity *";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplier.ForeColor = SystemColors.ControlText;
            lblSupplier.Location = new Point(12, 302);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(101, 23);
            lblSupplier.TabIndex = 27;
            lblSupplier.Text = "Supplier *";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.InactiveBorder;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(12, 430);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(695, 31);
            txtDescription.TabIndex = 30;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.ControlText;
            lblDescription.Location = new Point(12, 394);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(116, 23);
            lblDescription.TabIndex = 29;
            lblDescription.Text = "Description";
            // 
            // btnProductCancel
            // 
            btnProductCancel.BackColor = SystemColors.ControlLightLight;
            btnProductCancel.FlatAppearance.BorderColor = Color.Lime;
            btnProductCancel.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnProductCancel.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnProductCancel.FlatStyle = FlatStyle.Popup;
            btnProductCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductCancel.ForeColor = SystemColors.ControlText;
            btnProductCancel.Location = new Point(344, 496);
            btnProductCancel.Name = "btnProductCancel";
            btnProductCancel.Size = new Size(166, 43);
            btnProductCancel.TabIndex = 32;
            btnProductCancel.Text = "Cancel";
            btnProductCancel.UseVisualStyleBackColor = false;
            btnProductCancel.Click += btnCustomerRegister_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.LimeGreen;
            btnAddProduct.FlatAppearance.BorderColor = Color.LimeGreen;
            btnAddProduct.FlatAppearance.MouseDownBackColor = Color.Green;
            btnAddProduct.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(527, 496);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(180, 43);
            btnAddProduct.TabIndex = 31;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // numericStockQuantity
            // 
            numericStockQuantity.BackColor = SystemColors.InactiveBorder;
            numericStockQuantity.BorderStyle = BorderStyle.FixedSingle;
            numericStockQuantity.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericStockQuantity.Location = new Point(387, 245);
            numericStockQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericStockQuantity.Name = "numericStockQuantity";
            numericStockQuantity.Size = new Size(320, 31);
            numericStockQuantity.TabIndex = 33;
            numericStockQuantity.ValueChanged += numericStockQuantity_ValueChanged;
            // 
            // cmbSupplier
            // 
            cmbSupplier.BackColor = SystemColors.InactiveBorder;
            cmbSupplier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(14, 343);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(693, 31);
            cmbSupplier.TabIndex = 34;
            // 
            // frmAddNewProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(735, 562);
            Controls.Add(cmbSupplier);
            Controls.Add(numericStockQuantity);
            Controls.Add(btnProductCancel);
            Controls.Add(btnAddProduct);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblSupplier);
            Controls.Add(lblStockQuantity);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(cmbCategory);
            Controls.Add(lblCusRegEmail);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddNewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Product";
            Load += frmAddNewProduct_Load;
            ((System.ComponentModel.ISupportInitialize)numericStockQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private Label lblCusRegEmail;
        private TextBox txtProductName;
        private Label lblProductName;
        private ComboBox cmbCategory;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtStockQuantity;
        private Label lblStockQuantity;
        private Label lblSupplier;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnProductCancel;
        private Button btnAddProduct;
        private NumericUpDown numericStockQuantity;
        private ComboBox cmbSupplier;
    }
}