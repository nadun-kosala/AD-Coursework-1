namespace GreenLife_Organic_Store.Forms.Customer
{
    partial class frmSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchForm));
            panel1 = new Panel();
            btnCustomerLogout = new Button();
            lblHeading = new Label();
            lblSubHeading = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnNavigateProfile = new Button();
            btnNavigateOrders = new Button();
            btnNavigateCart = new Button();
            btnNavigateSearch = new Button();
            btnNavigateDashboard = new Button();
            lblCustomerSearchProductSubHading = new Label();
            lblCustomerSearchProducts = new Label();
            panel3 = new Panel();
            numericProductMaxPrice = new NumericUpDown();
            numericProductMinPrice = new NumericUpDown();
            btnFilterProducts = new Button();
            btnSearchProducts = new Button();
            label1 = new Label();
            label3 = new Label();
            label8 = new Label();
            cmbProductCategory = new ComboBox();
            txtSearchProducts = new TextBox();
            label9 = new Label();
            flowLayoutPanalForProducts = new FlowLayoutPanel();
            lblProductCount = new Label();
            btnRefreshProducts = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericProductMaxPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericProductMinPrice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnCustomerLogout);
            panel1.Controls.Add(lblHeading);
            panel1.Controls.Add(lblSubHeading);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1622, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnCustomerLogout
            // 
            btnCustomerLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCustomerLogout.AutoSize = true;
            btnCustomerLogout.BackColor = SystemColors.ControlLightLight;
            btnCustomerLogout.FlatAppearance.BorderColor = Color.LimeGreen;
            btnCustomerLogout.FlatAppearance.MouseDownBackColor = Color.Ivory;
            btnCustomerLogout.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnCustomerLogout.FlatStyle = FlatStyle.Flat;
            btnCustomerLogout.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerLogout.ForeColor = Color.LimeGreen;
            btnCustomerLogout.Location = new Point(1450, 42);
            btnCustomerLogout.Name = "btnCustomerLogout";
            btnCustomerLogout.Size = new Size(141, 44);
            btnCustomerLogout.TabIndex = 16;
            btnCustomerLogout.Text = "Logout";
            btnCustomerLogout.UseVisualStyleBackColor = false;
            btnCustomerLogout.Click += btnCustomerLogout_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(86, 26);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(456, 47);
            lblHeading.TabIndex = 14;
            lblHeading.Text = "GreenLife Organic Store";
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(95, 73);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(226, 27);
            lblSubHeading.TabIndex = 15;
            lblSubHeading.Text = "Welcome to GreenLife";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(2, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnNavigateProfile);
            panel2.Controls.Add(btnNavigateOrders);
            panel2.Controls.Add(btnNavigateCart);
            panel2.Controls.Add(btnNavigateSearch);
            panel2.Controls.Add(btnNavigateDashboard);
            panel2.Location = new Point(1, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 612);
            panel2.TabIndex = 1;
            // 
            // btnNavigateProfile
            // 
            btnNavigateProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateProfile.AutoSize = true;
            btnNavigateProfile.BackColor = Color.DarkGreen;
            btnNavigateProfile.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateProfile.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateProfile.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateProfile.FlatStyle = FlatStyle.Flat;
            btnNavigateProfile.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateProfile.ForeColor = Color.White;
            btnNavigateProfile.Location = new Point(11, 318);
            btnNavigateProfile.Name = "btnNavigateProfile";
            btnNavigateProfile.Size = new Size(227, 44);
            btnNavigateProfile.TabIndex = 29;
            btnNavigateProfile.Text = "Profile";
            btnNavigateProfile.UseVisualStyleBackColor = false;
            btnNavigateProfile.Click += btnNavigateProfile_Click;
            // 
            // btnNavigateOrders
            // 
            btnNavigateOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateOrders.AutoSize = true;
            btnNavigateOrders.BackColor = Color.DarkGreen;
            btnNavigateOrders.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateOrders.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateOrders.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateOrders.FlatStyle = FlatStyle.Flat;
            btnNavigateOrders.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateOrders.ForeColor = Color.White;
            btnNavigateOrders.Location = new Point(11, 240);
            btnNavigateOrders.Name = "btnNavigateOrders";
            btnNavigateOrders.Size = new Size(227, 44);
            btnNavigateOrders.TabIndex = 28;
            btnNavigateOrders.Text = "Orders";
            btnNavigateOrders.UseVisualStyleBackColor = false;
            btnNavigateOrders.Click += btnNavigateOrders_Click;
            // 
            // btnNavigateCart
            // 
            btnNavigateCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateCart.AutoSize = true;
            btnNavigateCart.BackColor = Color.DarkGreen;
            btnNavigateCart.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateCart.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateCart.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateCart.FlatStyle = FlatStyle.Flat;
            btnNavigateCart.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateCart.ForeColor = Color.White;
            btnNavigateCart.Location = new Point(11, 167);
            btnNavigateCart.Name = "btnNavigateCart";
            btnNavigateCart.Size = new Size(227, 44);
            btnNavigateCart.TabIndex = 27;
            btnNavigateCart.Text = "Cart";
            btnNavigateCart.UseVisualStyleBackColor = false;
            btnNavigateCart.Click += btnNavigateCart_Click;
            // 
            // btnNavigateSearch
            // 
            btnNavigateSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateSearch.AutoSize = true;
            btnNavigateSearch.BackColor = Color.DarkGreen;
            btnNavigateSearch.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateSearch.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateSearch.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateSearch.FlatStyle = FlatStyle.Flat;
            btnNavigateSearch.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateSearch.ForeColor = Color.White;
            btnNavigateSearch.Location = new Point(11, 94);
            btnNavigateSearch.Name = "btnNavigateSearch";
            btnNavigateSearch.Size = new Size(227, 44);
            btnNavigateSearch.TabIndex = 26;
            btnNavigateSearch.Text = "Search";
            btnNavigateSearch.UseVisualStyleBackColor = false;
            btnNavigateSearch.Click += btnNavigateSearch_Click;
            // 
            // btnNavigateDashboard
            // 
            btnNavigateDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateDashboard.AutoSize = true;
            btnNavigateDashboard.BackColor = Color.DarkGreen;
            btnNavigateDashboard.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateDashboard.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateDashboard.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateDashboard.FlatStyle = FlatStyle.Flat;
            btnNavigateDashboard.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateDashboard.ForeColor = Color.White;
            btnNavigateDashboard.Location = new Point(11, 23);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 25;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += btnNavigateDashboard_Click;
            // 
            // lblCustomerSearchProductSubHading
            // 
            lblCustomerSearchProductSubHading.AutoSize = true;
            lblCustomerSearchProductSubHading.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerSearchProductSubHading.ForeColor = Color.LimeGreen;
            lblCustomerSearchProductSubHading.Location = new Point(276, 177);
            lblCustomerSearchProductSubHading.Name = "lblCustomerSearchProductSubHading";
            lblCustomerSearchProductSubHading.Size = new Size(361, 23);
            lblCustomerSearchProductSubHading.TabIndex = 15;
            lblCustomerSearchProductSubHading.Text = "Find the perfect organic products for you";
            // 
            // lblCustomerSearchProducts
            // 
            lblCustomerSearchProducts.AutoSize = true;
            lblCustomerSearchProducts.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerSearchProducts.ForeColor = Color.ForestGreen;
            lblCustomerSearchProducts.Location = new Point(272, 134);
            lblCustomerSearchProducts.Name = "lblCustomerSearchProducts";
            lblCustomerSearchProducts.Size = new Size(293, 43);
            lblCustomerSearchProducts.TabIndex = 16;
            lblCustomerSearchProducts.Text = "Search Products";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(numericProductMaxPrice);
            panel3.Controls.Add(numericProductMinPrice);
            panel3.Controls.Add(btnFilterProducts);
            panel3.Controls.Add(btnSearchProducts);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cmbProductCategory);
            panel3.Controls.Add(txtSearchProducts);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(276, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(1347, 190);
            panel3.TabIndex = 17;
            // 
            // numericProductMaxPrice
            // 
            numericProductMaxPrice.BackColor = SystemColors.InactiveBorder;
            numericProductMaxPrice.BorderStyle = BorderStyle.FixedSingle;
            numericProductMaxPrice.DecimalPlaces = 2;
            numericProductMaxPrice.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericProductMaxPrice.Location = new Point(784, 134);
            numericProductMaxPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericProductMaxPrice.Name = "numericProductMaxPrice";
            numericProductMaxPrice.Size = new Size(352, 31);
            numericProductMaxPrice.TabIndex = 39;
            // 
            // numericProductMinPrice
            // 
            numericProductMinPrice.BackColor = SystemColors.InactiveBorder;
            numericProductMinPrice.BorderStyle = BorderStyle.FixedSingle;
            numericProductMinPrice.DecimalPlaces = 2;
            numericProductMinPrice.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericProductMinPrice.Location = new Point(396, 134);
            numericProductMinPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericProductMinPrice.Name = "numericProductMinPrice";
            numericProductMinPrice.Size = new Size(352, 31);
            numericProductMinPrice.TabIndex = 21;
            // 
            // btnFilterProducts
            // 
            btnFilterProducts.BackColor = Color.Green;
            btnFilterProducts.FlatAppearance.BorderColor = Color.Green;
            btnFilterProducts.FlatAppearance.BorderSize = 0;
            btnFilterProducts.FlatAppearance.MouseDownBackColor = Color.Green;
            btnFilterProducts.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnFilterProducts.FlatStyle = FlatStyle.Flat;
            btnFilterProducts.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilterProducts.ForeColor = Color.White;
            btnFilterProducts.Location = new Point(1175, 134);
            btnFilterProducts.Name = "btnFilterProducts";
            btnFilterProducts.Size = new Size(119, 33);
            btnFilterProducts.TabIndex = 38;
            btnFilterProducts.Text = "Filter";
            btnFilterProducts.UseVisualStyleBackColor = false;
            btnFilterProducts.Click += btnFilterProducts_Click;
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.BackColor = Color.Green;
            btnSearchProducts.FlatAppearance.BorderColor = Color.Green;
            btnSearchProducts.FlatAppearance.BorderSize = 0;
            btnSearchProducts.FlatAppearance.MouseDownBackColor = Color.Green;
            btnSearchProducts.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnSearchProducts.FlatStyle = FlatStyle.Flat;
            btnSearchProducts.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchProducts.ForeColor = Color.White;
            btnSearchProducts.Location = new Point(1175, 49);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(119, 33);
            btnSearchProducts.TabIndex = 37;
            btnSearchProducts.Text = "Search";
            btnSearchProducts.UseVisualStyleBackColor = false;
            btnSearchProducts.Click += btnSearchProducts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(405, 99);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 36;
            label1.Text = "Min Price (LKR)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(787, 99);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 34;
            label3.Text = "Max Price (LKR)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(12, 99);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 32;
            label8.Text = "Category";
            // 
            // cmbProductCategory
            // 
            cmbProductCategory.BackColor = SystemColors.InactiveBorder;
            cmbProductCategory.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProductCategory.FormattingEnabled = true;
            cmbProductCategory.Items.AddRange(new object[] { "Fruits", "Vegitable", "Grains", "Dairy", "Dairy Alternatives", "Sweeteners" });
            cmbProductCategory.Location = new Point(12, 134);
            cmbProductCategory.Name = "cmbProductCategory";
            cmbProductCategory.Size = new Size(349, 31);
            cmbProductCategory.TabIndex = 31;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.BackColor = SystemColors.InactiveBorder;
            txtSearchProducts.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchProducts.Location = new Point(12, 49);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.PlaceholderText = "Search products by name...";
            txtSearchProducts.Size = new Size(1124, 31);
            txtSearchProducts.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(12, 7);
            label9.Name = "label9";
            label9.Size = new Size(168, 23);
            label9.TabIndex = 29;
            label9.Text = "Search And FIlter";
            // 
            // flowLayoutPanalForProducts
            // 
            flowLayoutPanalForProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanalForProducts.AutoScroll = true;
            flowLayoutPanalForProducts.BackColor = Color.Honeydew;
            flowLayoutPanalForProducts.Location = new Point(276, 424);
            flowLayoutPanalForProducts.Name = "flowLayoutPanalForProducts";
            flowLayoutPanalForProducts.Size = new Size(1347, 315);
            flowLayoutPanalForProducts.TabIndex = 18;
            flowLayoutPanalForProducts.Paint += flowLayoutPanalForProducts_Paint;
            // 
            // lblProductCount
            // 
            lblProductCount.AutoSize = true;
            lblProductCount.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductCount.ForeColor = SystemColors.ControlDark;
            lblProductCount.Location = new Point(276, 400);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Size = new Size(135, 20);
            lblProductCount.TabIndex = 19;
            lblProductCount.Text = "8 Products Found";
            // 
            // btnRefreshProducts
            // 
            btnRefreshProducts.BackgroundImage = Properties.Resources.png_clipart_computer_icons_synchronization_refresh_miscellaneous_leaf;
            btnRefreshProducts.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefreshProducts.Cursor = Cursors.Hand;
            btnRefreshProducts.FlatAppearance.BorderColor = Color.Green;
            btnRefreshProducts.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnRefreshProducts.FlatAppearance.MouseOverBackColor = Color.Green;
            btnRefreshProducts.FlatStyle = FlatStyle.Popup;
            btnRefreshProducts.Location = new Point(1537, 142);
            btnRefreshProducts.Name = "btnRefreshProducts";
            btnRefreshProducts.Size = new Size(55, 52);
            btnRefreshProducts.TabIndex = 20;
            btnRefreshProducts.UseVisualStyleBackColor = true;
            btnRefreshProducts.Click += btnRefreshProducts_Click;
            // 
            // frmSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1626, 739);
            Controls.Add(btnRefreshProducts);
            Controls.Add(lblProductCount);
            Controls.Add(flowLayoutPanalForProducts);
            Controls.Add(panel3);
            Controls.Add(lblCustomerSearchProductSubHading);
            Controls.Add(lblCustomerSearchProducts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            Load += frmSearchForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericProductMaxPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericProductMinPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCustomerLogout;
        private Label lblHeading;
        private Label lblSubHeading;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnNavigateProfile;
        private Button btnNavigateOrders;
        private Button btnNavigateCart;
        private Button btnNavigateSearch;
        private Button btnNavigateDashboard;
        private Label lblCustomerSearchProductSubHading;
        private Label lblCustomerSearchProducts;
        private Panel panel3;
        private Label label1;
        private Label label3;
        private Label label8;
        private ComboBox cmbProductCategory;
        private TextBox txtSearchProducts;
        private Label label9;
        private Button btnFilterProducts;
        private Button btnSearchProducts;
        private FlowLayoutPanel flowLayoutPanalForProducts;
        private Label lblProductCount;
        private Button btnRefreshProducts;
        private NumericUpDown numericProductMinPrice;
        private NumericUpDown numericProductMaxPrice;
    }
}