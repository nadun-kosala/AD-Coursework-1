namespace GreenLife_Organic_Store
{
    partial class frmAdminProductFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminProductFrom));
            panel1 = new Panel();
            btnAdminLogout = new Button();
            lblSubHeading = new Label();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnNavigateReports = new Button();
            btnNavigateOrders = new Button();
            btnNavigateCustomers = new Button();
            btnNavigateProducts = new Button();
            btnNavigateDashboard = new Button();
            lblManageProductsSub = new Label();
            lblManageProductsHeading = new Label();
            btnAddNewProduct = new Button();
            panel2 = new Panel();
            tblProducts = new DataGridView();
            btnEditProducts = new Button();
            btnDeleteProducts = new Button();
            btnProductSearch = new Button();
            txtProductSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnAdminLogout);
            panel1.Controls.Add(lblSubHeading);
            panel1.Controls.Add(lblHeading);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnAdminLogout
            // 
            btnAdminLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdminLogout.AutoSize = true;
            btnAdminLogout.BackColor = SystemColors.ControlLightLight;
            btnAdminLogout.FlatAppearance.BorderColor = Color.LimeGreen;
            btnAdminLogout.FlatAppearance.MouseDownBackColor = Color.Chartreuse;
            btnAdminLogout.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnAdminLogout.FlatStyle = FlatStyle.Flat;
            btnAdminLogout.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLogout.ForeColor = Color.LimeGreen;
            btnAdminLogout.Location = new Point(1518, 43);
            btnAdminLogout.Name = "btnAdminLogout";
            btnAdminLogout.Size = new Size(141, 44);
            btnAdminLogout.TabIndex = 11;
            btnAdminLogout.Text = "Logout";
            btnAdminLogout.UseVisualStyleBackColor = false;
            btnAdminLogout.Click += btnAdminLogout_Click;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(96, 71);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(204, 27);
            lblSubHeading.TabIndex = 10;
            lblSubHeading.Text = "Management Portal";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(87, 24);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(329, 47);
            lblHeading.TabIndex = 9;
            lblHeading.Text = "GreenLife Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(3, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(btnNavigateReports);
            panel3.Controls.Add(btnNavigateOrders);
            panel3.Controls.Add(btnNavigateCustomers);
            panel3.Controls.Add(btnNavigateProducts);
            panel3.Controls.Add(btnNavigateDashboard);
            panel3.Location = new Point(3, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 665);
            panel3.TabIndex = 0;
            // 
            // btnNavigateReports
            // 
            btnNavigateReports.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateReports.AutoSize = true;
            btnNavigateReports.BackColor = Color.DarkGreen;
            btnNavigateReports.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateReports.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateReports.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateReports.FlatStyle = FlatStyle.Flat;
            btnNavigateReports.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateReports.ForeColor = Color.White;
            btnNavigateReports.Location = new Point(19, 313);
            btnNavigateReports.Name = "btnNavigateReports";
            btnNavigateReports.Size = new Size(227, 44);
            btnNavigateReports.TabIndex = 19;
            btnNavigateReports.Text = "Reports";
            btnNavigateReports.UseVisualStyleBackColor = false;
            btnNavigateReports.Click += btnNavigateReports_Click_1;
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
            btnNavigateOrders.Location = new Point(19, 235);
            btnNavigateOrders.Name = "btnNavigateOrders";
            btnNavigateOrders.Size = new Size(227, 44);
            btnNavigateOrders.TabIndex = 18;
            btnNavigateOrders.Text = "Orders";
            btnNavigateOrders.UseVisualStyleBackColor = false;
            btnNavigateOrders.Click += btnNavigateOrders_Click_1;
            // 
            // btnNavigateCustomers
            // 
            btnNavigateCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateCustomers.AutoSize = true;
            btnNavigateCustomers.BackColor = Color.DarkGreen;
            btnNavigateCustomers.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateCustomers.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateCustomers.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateCustomers.FlatStyle = FlatStyle.Flat;
            btnNavigateCustomers.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateCustomers.ForeColor = Color.White;
            btnNavigateCustomers.Location = new Point(19, 162);
            btnNavigateCustomers.Name = "btnNavigateCustomers";
            btnNavigateCustomers.Size = new Size(227, 44);
            btnNavigateCustomers.TabIndex = 17;
            btnNavigateCustomers.Text = "Customers";
            btnNavigateCustomers.UseVisualStyleBackColor = false;
            btnNavigateCustomers.Click += btnNavigateCustomers_Click;
            // 
            // btnNavigateProducts
            // 
            btnNavigateProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateProducts.AutoSize = true;
            btnNavigateProducts.BackColor = Color.DarkGreen;
            btnNavigateProducts.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateProducts.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateProducts.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateProducts.FlatStyle = FlatStyle.Flat;
            btnNavigateProducts.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateProducts.ForeColor = Color.White;
            btnNavigateProducts.Location = new Point(19, 89);
            btnNavigateProducts.Name = "btnNavigateProducts";
            btnNavigateProducts.Size = new Size(227, 44);
            btnNavigateProducts.TabIndex = 16;
            btnNavigateProducts.Text = "Products";
            btnNavigateProducts.UseVisualStyleBackColor = false;
            btnNavigateProducts.Click += btnNavigateProducts_Click_1;
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
            btnNavigateDashboard.Location = new Point(19, 18);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 15;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += btnNavigateDashboard_Click;
            // 
            // lblManageProductsSub
            // 
            lblManageProductsSub.AutoSize = true;
            lblManageProductsSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblManageProductsSub.ForeColor = Color.LimeGreen;
            lblManageProductsSub.Location = new Point(326, 183);
            lblManageProductsSub.Name = "lblManageProductsSub";
            lblManageProductsSub.Size = new Size(398, 23);
            lblManageProductsSub.TabIndex = 11;
            lblManageProductsSub.Text = "Add, edit, or remove products from inventory";
            // 
            // lblManageProductsHeading
            // 
            lblManageProductsHeading.AutoSize = true;
            lblManageProductsHeading.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageProductsHeading.ForeColor = Color.ForestGreen;
            lblManageProductsHeading.Location = new Point(322, 140);
            lblManageProductsHeading.Name = "lblManageProductsHeading";
            lblManageProductsHeading.Size = new Size(311, 43);
            lblManageProductsHeading.TabIndex = 12;
            lblManageProductsHeading.Text = "Manage Products";
            // 
            // btnAddNewProduct
            // 
            btnAddNewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewProduct.BackColor = Color.DarkGreen;
            btnAddNewProduct.FlatAppearance.BorderColor = Color.DarkGreen;
            btnAddNewProduct.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnAddNewProduct.FlatAppearance.MouseOverBackColor = Color.Green;
            btnAddNewProduct.FlatStyle = FlatStyle.Flat;
            btnAddNewProduct.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewProduct.ForeColor = Color.White;
            btnAddNewProduct.Location = new Point(1330, 172);
            btnAddNewProduct.Name = "btnAddNewProduct";
            btnAddNewProduct.Size = new Size(269, 44);
            btnAddNewProduct.TabIndex = 13;
            btnAddNewProduct.Text = "+  Add New Product";
            btnAddNewProduct.UseVisualStyleBackColor = false;
            btnAddNewProduct.Click += btnAddNewProduct_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(tblProducts);
            panel2.Controls.Add(btnEditProducts);
            panel2.Controls.Add(btnDeleteProducts);
            panel2.Controls.Add(btnProductSearch);
            panel2.Controls.Add(txtProductSearch);
            panel2.Location = new Point(322, 266);
            panel2.Name = "panel2";
            panel2.Size = new Size(1366, 513);
            panel2.TabIndex = 14;
            // 
            // tblProducts
            // 
            tblProducts.AllowUserToAddRows = false;
            tblProducts.AllowUserToDeleteRows = false;
            tblProducts.AllowUserToResizeColumns = false;
            tblProducts.AllowUserToResizeRows = false;
            tblProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblProducts.BackgroundColor = SystemColors.ControlLightLight;
            tblProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblProducts.Cursor = Cursors.Hand;
            tblProducts.GridColor = Color.LightGreen;
            tblProducts.Location = new Point(33, 82);
            tblProducts.MultiSelect = false;
            tblProducts.Name = "tblProducts";
            tblProducts.RowHeadersVisible = false;
            tblProducts.RowHeadersWidth = 51;
            tblProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblProducts.Size = new Size(1307, 419);
            tblProducts.TabIndex = 6;
            tblProducts.CellContentClick += tblProducts_CellContentClick;
            // 
            // btnEditProducts
            // 
            btnEditProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditProducts.BackColor = Color.Green;
            btnEditProducts.FlatAppearance.BorderColor = Color.Green;
            btnEditProducts.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnEditProducts.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnEditProducts.FlatStyle = FlatStyle.Popup;
            btnEditProducts.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProducts.ForeColor = Color.White;
            btnEditProducts.Location = new Point(1086, 34);
            btnEditProducts.Name = "btnEditProducts";
            btnEditProducts.Size = new Size(119, 33);
            btnEditProducts.TabIndex = 5;
            btnEditProducts.Text = "Edit";
            btnEditProducts.UseVisualStyleBackColor = false;
            btnEditProducts.Click += btnEditProducts_Click;
            // 
            // btnDeleteProducts
            // 
            btnDeleteProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteProducts.BackColor = Color.OrangeRed;
            btnDeleteProducts.FlatAppearance.BorderColor = Color.OrangeRed;
            btnDeleteProducts.FlatAppearance.BorderSize = 0;
            btnDeleteProducts.FlatAppearance.MouseDownBackColor = Color.Red;
            btnDeleteProducts.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDeleteProducts.FlatStyle = FlatStyle.Popup;
            btnDeleteProducts.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteProducts.ForeColor = Color.White;
            btnDeleteProducts.Location = new Point(1221, 34);
            btnDeleteProducts.Name = "btnDeleteProducts";
            btnDeleteProducts.Size = new Size(119, 33);
            btnDeleteProducts.TabIndex = 4;
            btnDeleteProducts.Text = "Delete";
            btnDeleteProducts.UseVisualStyleBackColor = false;
            btnDeleteProducts.Click += btnDeleteProducts_Click;
            // 
            // btnProductSearch
            // 
            btnProductSearch.BackColor = Color.Green;
            btnProductSearch.FlatAppearance.BorderColor = Color.Green;
            btnProductSearch.FlatAppearance.BorderSize = 0;
            btnProductSearch.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnProductSearch.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnProductSearch.FlatStyle = FlatStyle.Popup;
            btnProductSearch.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductSearch.ForeColor = Color.White;
            btnProductSearch.Location = new Point(571, 34);
            btnProductSearch.Name = "btnProductSearch";
            btnProductSearch.Size = new Size(119, 33);
            btnProductSearch.TabIndex = 3;
            btnProductSearch.Text = "Search";
            btnProductSearch.UseVisualStyleBackColor = false;
            btnProductSearch.Click += btnProductSearch_Click;
            // 
            // txtProductSearch
            // 
            txtProductSearch.BackColor = SystemColors.MenuBar;
            txtProductSearch.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductSearch.Location = new Point(33, 33);
            txtProductSearch.Name = "txtProductSearch";
            txtProductSearch.PlaceholderText = "Search products by name...";
            txtProductSearch.Size = new Size(514, 31);
            txtProductSearch.TabIndex = 2;
            // 
            // frmAdminProductFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1712, 791);
            Controls.Add(panel2);
            Controls.Add(btnAddNewProduct);
            Controls.Add(lblManageProductsSub);
            Controls.Add(lblManageProductsHeading);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAdminProductFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += frmProductFrom_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAdminLogout;
        private Label lblSubHeading;
        private Label lblHeading;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label lblManageProductsSub;
        private Label lblManageProductsHeading;
        private Button btnAddNewProduct;
        private Panel panel2;
        private Button btnProductSearch;
        private TextBox txtProductSearch;
        private Button btnEditProducts;
        private Button btnDeleteProducts;
        private DataGridView tblProducts;
        private Button btnNavigateDashboard;
        private Button btnNavigateReports;
        private Button btnNavigateOrders;
        private Button btnNavigateCustomers;
        private Button btnNavigateProducts;
    }
}