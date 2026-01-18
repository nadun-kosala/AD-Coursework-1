namespace GreenLife_Organic_Store.Forms.Admin
{
    partial class frmAdminOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminOrdersForm));
            panel1 = new Panel();
            btnAdminLogout = new Button();
            lblSubHeading = new Label();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnNavigateReports = new Button();
            btnNavigateOrders = new Button();
            btnNavigateCustomers = new Button();
            btnNavigateProducts = new Button();
            btnNavigateDashboard = new Button();
            lblManageOrdersSub = new Label();
            lblManageOrdersHeading = new Label();
            panel3 = new Panel();
            btnUpdateOrderStatus = new Button();
            tblOrders = new DataGridView();
            btnOrderSearch = new Button();
            txtOrderSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblOrders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnAdminLogout);
            panel1.Controls.Add(lblSubHeading);
            panel1.Controls.Add(lblHeading);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 2);
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
            btnAdminLogout.Location = new Point(1531, 42);
            btnAdminLogout.Name = "btnAdminLogout";
            btnAdminLogout.Size = new Size(141, 44);
            btnAdminLogout.TabIndex = 19;
            btnAdminLogout.Text = "Logout";
            btnAdminLogout.UseVisualStyleBackColor = false;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(94, 71);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(204, 27);
            lblSubHeading.TabIndex = 18;
            lblSubHeading.Text = "Management Portal";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(85, 24);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(329, 47);
            lblHeading.TabIndex = 17;
            lblHeading.Text = "GreenLife Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(1, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnNavigateReports);
            panel2.Controls.Add(btnNavigateOrders);
            panel2.Controls.Add(btnNavigateCustomers);
            panel2.Controls.Add(btnNavigateProducts);
            panel2.Controls.Add(btnNavigateDashboard);
            panel2.Location = new Point(1, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 665);
            panel2.TabIndex = 1;
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
            btnNavigateReports.Location = new Point(21, 315);
            btnNavigateReports.Name = "btnNavigateReports";
            btnNavigateReports.Size = new Size(227, 44);
            btnNavigateReports.TabIndex = 29;
            btnNavigateReports.Text = "Reports";
            btnNavigateReports.UseVisualStyleBackColor = false;
            btnNavigateReports.Click += btnNavigateReports_Click;
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
            btnNavigateOrders.Location = new Point(21, 237);
            btnNavigateOrders.Name = "btnNavigateOrders";
            btnNavigateOrders.Size = new Size(227, 44);
            btnNavigateOrders.TabIndex = 28;
            btnNavigateOrders.Text = "Orders";
            btnNavigateOrders.UseVisualStyleBackColor = false;
            btnNavigateOrders.Click += this.btnNavigateOrders_Click;
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
            btnNavigateCustomers.Location = new Point(21, 164);
            btnNavigateCustomers.Name = "btnNavigateCustomers";
            btnNavigateCustomers.Size = new Size(227, 44);
            btnNavigateCustomers.TabIndex = 27;
            btnNavigateCustomers.Text = "Customers";
            btnNavigateCustomers.UseVisualStyleBackColor = false;
            btnNavigateCustomers.Click += this.btnNavigateCustomers_Click;
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
            btnNavigateProducts.Location = new Point(21, 91);
            btnNavigateProducts.Name = "btnNavigateProducts";
            btnNavigateProducts.Size = new Size(227, 44);
            btnNavigateProducts.TabIndex = 26;
            btnNavigateProducts.Text = "Products";
            btnNavigateProducts.UseVisualStyleBackColor = false;
            btnNavigateProducts.Click += this.btnNavigateProducts_Click;
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
            btnNavigateDashboard.Location = new Point(21, 20);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 25;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += this.btnNavigateDashboard_Click;
            // 
            // lblManageOrdersSub
            // 
            lblManageOrdersSub.AutoSize = true;
            lblManageOrdersSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblManageOrdersSub.ForeColor = Color.LimeGreen;
            lblManageOrdersSub.Location = new Point(305, 185);
            lblManageOrdersSub.Name = "lblManageOrdersSub";
            lblManageOrdersSub.Size = new Size(267, 23);
            lblManageOrdersSub.TabIndex = 15;
            lblManageOrdersSub.Text = "Track and update order status";
            // 
            // lblManageOrdersHeading
            // 
            lblManageOrdersHeading.AutoSize = true;
            lblManageOrdersHeading.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageOrdersHeading.ForeColor = Color.ForestGreen;
            lblManageOrdersHeading.Location = new Point(301, 142);
            lblManageOrdersHeading.Name = "lblManageOrdersHeading";
            lblManageOrdersHeading.Size = new Size(277, 43);
            lblManageOrdersHeading.TabIndex = 16;
            lblManageOrdersHeading.Text = "Manage Orders";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(btnUpdateOrderStatus);
            panel3.Controls.Add(tblOrders);
            panel3.Controls.Add(btnOrderSearch);
            panel3.Controls.Add(txtOrderSearch);
            panel3.Location = new Point(305, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(1381, 550);
            panel3.TabIndex = 17;
            // 
            // btnUpdateOrderStatus
            // 
            btnUpdateOrderStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateOrderStatus.BackColor = Color.Green;
            btnUpdateOrderStatus.FlatAppearance.BorderColor = Color.Green;
            btnUpdateOrderStatus.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnUpdateOrderStatus.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnUpdateOrderStatus.FlatStyle = FlatStyle.Popup;
            btnUpdateOrderStatus.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateOrderStatus.ForeColor = Color.White;
            btnUpdateOrderStatus.Location = new Point(1087, 28);
            btnUpdateOrderStatus.Name = "btnUpdateOrderStatus";
            btnUpdateOrderStatus.Size = new Size(281, 33);
            btnUpdateOrderStatus.TabIndex = 16;
            btnUpdateOrderStatus.Text = "Update Order Status";
            btnUpdateOrderStatus.UseVisualStyleBackColor = false;
            // 
            // tblOrders
            // 
            tblOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblOrders.BackgroundColor = SystemColors.ControlLightLight;
            tblOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblOrders.Cursor = Cursors.Hand;
            tblOrders.GridColor = Color.LightGreen;
            tblOrders.Location = new Point(27, 91);
            tblOrders.MultiSelect = false;
            tblOrders.Name = "tblOrders";
            tblOrders.RowHeadersWidth = 51;
            tblOrders.Size = new Size(1349, 456);
            tblOrders.TabIndex = 15;
            // 
            // btnOrderSearch
            // 
            btnOrderSearch.BackColor = Color.Green;
            btnOrderSearch.FlatAppearance.BorderColor = Color.Green;
            btnOrderSearch.FlatAppearance.BorderSize = 0;
            btnOrderSearch.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnOrderSearch.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnOrderSearch.FlatStyle = FlatStyle.Popup;
            btnOrderSearch.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderSearch.ForeColor = Color.White;
            btnOrderSearch.Location = new Point(565, 27);
            btnOrderSearch.Name = "btnOrderSearch";
            btnOrderSearch.Size = new Size(119, 33);
            btnOrderSearch.TabIndex = 13;
            btnOrderSearch.Text = "Search";
            btnOrderSearch.UseVisualStyleBackColor = false;
            // 
            // txtOrderSearch
            // 
            txtOrderSearch.BackColor = SystemColors.MenuBar;
            txtOrderSearch.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderSearch.Location = new Point(27, 28);
            txtOrderSearch.Name = "txtOrderSearch";
            txtOrderSearch.PlaceholderText = "Search orders by order ID...";
            txtOrderSearch.Size = new Size(514, 31);
            txtOrderSearch.TabIndex = 12;
            // 
            // frmAdminOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1714, 791);
            Controls.Add(panel3);
            Controls.Add(lblManageOrdersSub);
            Controls.Add(lblManageOrdersHeading);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdminOrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            Load += frmAdminOrdersForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAdminLogout;
        private Label lblSubHeading;
        private Label lblHeading;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnNavigateReports;
        private Button btnNavigateOrders;
        private Button btnNavigateCustomers;
        private Button btnNavigateProducts;
        private Button btnNavigateDashboard;
        private Label lblManageOrdersSub;
        private Label lblManageOrdersHeading;
        private Panel panel3;
        private Button btnOrderSearch;
        private TextBox txtOrderSearch;
        private DataGridView tblOrders;
        private Button btnUpdateOrderStatus;
    }
}