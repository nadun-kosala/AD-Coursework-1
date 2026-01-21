namespace GreenLife_Organic_Store.Forms.Admin
{
    partial class frmAdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboardForm));
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
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            lblTotalCustomersSub = new Label();
            pictureBox4 = new PictureBox();
            lblTotalCustomers = new Label();
            lblTotalCustomersHeading = new Label();
            groupBox3 = new GroupBox();
            lblProductInStockSub = new Label();
            pictureBox3 = new PictureBox();
            lblProductInStock = new Label();
            lblProductInStockHeading = new Label();
            groupBox5 = new GroupBox();
            lblTotalOrdersSub = new Label();
            pictureBox5 = new PictureBox();
            lblActiveOrders = new Label();
            lblActiveOrdersHeading = new Label();
            groupBox2 = new GroupBox();
            lblTotalSalesSub = new Label();
            pictureBox2 = new PictureBox();
            lblTotalSale = new Label();
            lblTotalSaleHeading = new Label();
            flowLayoutPanelLowStock = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnAdminLogout);
            panel1.Controls.Add(lblSubHeading);
            panel1.Controls.Add(lblHeading);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 2);
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
            btnAdminLogout.Location = new Point(1526, 45);
            btnAdminLogout.Name = "btnAdminLogout";
            btnAdminLogout.Size = new Size(141, 44);
            btnAdminLogout.TabIndex = 23;
            btnAdminLogout.Text = "Logout";
            btnAdminLogout.UseVisualStyleBackColor = false;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(95, 73);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(204, 27);
            lblSubHeading.TabIndex = 22;
            lblSubHeading.Text = "Management Portal";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(86, 26);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(329, 47);
            lblHeading.TabIndex = 21;
            lblHeading.Text = "GreenLife Admin";
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
            pictureBox1.TabIndex = 20;
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
            panel2.Location = new Point(1, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 665);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
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
            btnNavigateReports.Location = new Point(22, 317);
            btnNavigateReports.Name = "btnNavigateReports";
            btnNavigateReports.Size = new Size(227, 44);
            btnNavigateReports.TabIndex = 34;
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
            btnNavigateOrders.Location = new Point(22, 239);
            btnNavigateOrders.Name = "btnNavigateOrders";
            btnNavigateOrders.Size = new Size(227, 44);
            btnNavigateOrders.TabIndex = 33;
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
            btnNavigateCustomers.Location = new Point(22, 166);
            btnNavigateCustomers.Name = "btnNavigateCustomers";
            btnNavigateCustomers.Size = new Size(227, 44);
            btnNavigateCustomers.TabIndex = 32;
            btnNavigateCustomers.Text = "Customers";
            btnNavigateCustomers.UseVisualStyleBackColor = false;
            btnNavigateCustomers.Click += btnNavigateCustomers_Click_1;
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
            btnNavigateProducts.Location = new Point(22, 93);
            btnNavigateProducts.Name = "btnNavigateProducts";
            btnNavigateProducts.Size = new Size(227, 44);
            btnNavigateProducts.TabIndex = 31;
            btnNavigateProducts.Text = "Products";
            btnNavigateProducts.UseVisualStyleBackColor = false;
            btnNavigateProducts.Click += btnNavigateProducts_Click;
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
            btnNavigateDashboard.Location = new Point(22, 22);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 30;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += btnNavigateDashboard_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(300, 188);
            label2.Name = "label2";
            label2.Size = new Size(275, 23);
            label2.TabIndex = 9;
            label2.Text = "Overview of your organic store";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(296, 145);
            label1.Name = "label1";
            label1.Size = new Size(326, 43);
            label1.TabIndex = 10;
            label1.Text = "Admin Dashboard";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ControlLightLight;
            groupBox4.BackgroundImageLayout = ImageLayout.Center;
            groupBox4.Controls.Add(lblTotalCustomersSub);
            groupBox4.Controls.Add(pictureBox4);
            groupBox4.Controls.Add(lblTotalCustomers);
            groupBox4.Controls.Add(lblTotalCustomersHeading);
            groupBox4.FlatStyle = FlatStyle.Popup;
            groupBox4.ForeColor = Color.DarkGreen;
            groupBox4.Location = new Point(1213, 243);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(248, 178);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            // 
            // lblTotalCustomersSub
            // 
            lblTotalCustomersSub.AutoSize = true;
            lblTotalCustomersSub.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCustomersSub.ForeColor = Color.LimeGreen;
            lblTotalCustomersSub.Location = new Point(21, 132);
            lblTotalCustomersSub.Name = "lblTotalCustomersSub";
            lblTotalCustomersSub.Size = new Size(109, 20);
            lblTotalCustomersSub.TabIndex = 11;
            lblTotalCustomersSub.Text = "+3 this month";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.png_clipart_multi_user_end_user_users_group_information_others_miscellaneous_leaf;
            pictureBox4.Location = new Point(180, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCustomers.Location = new Point(17, 96);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(33, 36);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "4";
            // 
            // lblTotalCustomersHeading
            // 
            lblTotalCustomersHeading.AutoSize = true;
            lblTotalCustomersHeading.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCustomersHeading.Location = new Point(17, 35);
            lblTotalCustomersHeading.Name = "lblTotalCustomersHeading";
            lblTotalCustomersHeading.Size = new Size(157, 23);
            lblTotalCustomersHeading.TabIndex = 0;
            lblTotalCustomersHeading.Text = "Total Customers";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLightLight;
            groupBox3.BackgroundImageLayout = ImageLayout.Center;
            groupBox3.Controls.Add(lblProductInStockSub);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(lblProductInStock);
            groupBox3.Controls.Add(lblProductInStockHeading);
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.ForeColor = Color.DarkGreen;
            groupBox3.Location = new Point(607, 243);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(248, 178);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // lblProductInStockSub
            // 
            lblProductInStockSub.AutoSize = true;
            lblProductInStockSub.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductInStockSub.ForeColor = Color.LimeGreen;
            lblProductInStockSub.Location = new Point(21, 132);
            lblProductInStockSub.Name = "lblProductInStockSub";
            lblProductInStockSub.Size = new Size(139, 20);
            lblProductInStockSub.TabIndex = 11;
            lblProductInStockSub.Text = "8 unique products";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.paper_cardboard_box_green_png_favpng_xRbZH9Y9aFcMr7tAMPUetKHcu;
            pictureBox3.Location = new Point(187, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // lblProductInStock
            // 
            lblProductInStock.AutoSize = true;
            lblProductInStock.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductInStock.Location = new Point(17, 96);
            lblProductInStock.Name = "lblProductInStock";
            lblProductInStock.Size = new Size(69, 36);
            lblProductInStock.TabIndex = 1;
            lblProductInStock.Text = "198";
            // 
            // lblProductInStockHeading
            // 
            lblProductInStockHeading.AutoSize = true;
            lblProductInStockHeading.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductInStockHeading.Location = new Point(17, 35);
            lblProductInStockHeading.Name = "lblProductInStockHeading";
            lblProductInStockHeading.Size = new Size(157, 23);
            lblProductInStockHeading.TabIndex = 0;
            lblProductInStockHeading.Text = "Product in Stock";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ControlLightLight;
            groupBox5.BackgroundImageLayout = ImageLayout.Center;
            groupBox5.Controls.Add(lblTotalOrdersSub);
            groupBox5.Controls.Add(pictureBox5);
            groupBox5.Controls.Add(lblActiveOrders);
            groupBox5.Controls.Add(lblActiveOrdersHeading);
            groupBox5.FlatStyle = FlatStyle.Popup;
            groupBox5.ForeColor = Color.DarkGreen;
            groupBox5.Location = new Point(905, 243);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(248, 178);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            // 
            // lblTotalOrdersSub
            // 
            lblTotalOrdersSub.AutoSize = true;
            lblTotalOrdersSub.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalOrdersSub.ForeColor = Color.LimeGreen;
            lblTotalOrdersSub.Location = new Point(22, 132);
            lblTotalOrdersSub.Name = "lblTotalOrdersSub";
            lblTotalOrdersSub.Size = new Size(107, 20);
            lblTotalOrdersSub.TabIndex = 11;
            lblTotalOrdersSub.Text = "3 total orders";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Image = Properties.Resources._293058_middle;
            pictureBox5.Location = new Point(175, 35);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // lblActiveOrders
            // 
            lblActiveOrders.AutoSize = true;
            lblActiveOrders.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveOrders.Location = new Point(17, 96);
            lblActiveOrders.Name = "lblActiveOrders";
            lblActiveOrders.Size = new Size(33, 36);
            lblActiveOrders.TabIndex = 1;
            lblActiveOrders.Text = "2";
            // 
            // lblActiveOrdersHeading
            // 
            lblActiveOrdersHeading.AutoSize = true;
            lblActiveOrdersHeading.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveOrdersHeading.Location = new Point(17, 35);
            lblActiveOrdersHeading.Name = "lblActiveOrdersHeading";
            lblActiveOrdersHeading.Size = new Size(133, 23);
            lblActiveOrdersHeading.TabIndex = 0;
            lblActiveOrdersHeading.Text = "Active Orders";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.BackgroundImageLayout = ImageLayout.Center;
            groupBox2.Controls.Add(lblTotalSalesSub);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(lblTotalSale);
            groupBox2.Controls.Add(lblTotalSaleHeading);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.ForeColor = Color.DarkGreen;
            groupBox2.Location = new Point(312, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 178);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblTotalSalesSub
            // 
            lblTotalSalesSub.AutoSize = true;
            lblTotalSalesSub.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSalesSub.ForeColor = Color.LimeGreen;
            lblTotalSalesSub.Location = new Point(17, 132);
            lblTotalSalesSub.Name = "lblTotalSalesSub";
            lblTotalSalesSub.Size = new Size(183, 20);
            lblTotalSalesSub.TabIndex = 11;
            lblTotalSalesSub.Text = "+12.5% from last month";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.isolated_green_upward_arrow_depicting_growth_and_success_on_transparent_backdrop_png;
            pictureBox2.Location = new Point(177, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // lblTotalSale
            // 
            lblTotalSale.AutoSize = true;
            lblTotalSale.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSale.Location = new Point(17, 96);
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(110, 36);
            lblTotalSale.TabIndex = 1;
            lblTotalSale.Text = "$67.39";
            // 
            // lblTotalSaleHeading
            // 
            lblTotalSaleHeading.AutoSize = true;
            lblTotalSaleHeading.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSaleHeading.Location = new Point(17, 35);
            lblTotalSaleHeading.Name = "lblTotalSaleHeading";
            lblTotalSaleHeading.Size = new Size(107, 23);
            lblTotalSaleHeading.TabIndex = 0;
            lblTotalSaleHeading.Text = "Total Sales";
            // 
            // flowLayoutPanelLowStock
            // 
            flowLayoutPanelLowStock.BackColor = SystemColors.ControlLightLight;
            flowLayoutPanelLowStock.Location = new Point(312, 463);
            flowLayoutPanelLowStock.Name = "flowLayoutPanelLowStock";
            flowLayoutPanelLowStock.Size = new Size(1149, 318);
            flowLayoutPanelLowStock.TabIndex = 19;
            flowLayoutPanelLowStock.Paint += flowLayoutPanelLowStock_Paint;
            // 
            // frmAdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1714, 791);
            Controls.Add(flowLayoutPanelLowStock);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += frmAdminDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private Label lblTotalCustomersSub;
        private PictureBox pictureBox4;
        private Label lblTotalCustomers;
        private Label lblTotalCustomersHeading;
        private GroupBox groupBox3;
        private Label lblProductInStockSub;
        private PictureBox pictureBox3;
        private Label lblProductInStock;
        private Label lblProductInStockHeading;
        private GroupBox groupBox5;
        private Label lblTotalOrdersSub;
        private PictureBox pictureBox5;
        private Label lblActiveOrders;
        private Label lblActiveOrdersHeading;
        private GroupBox groupBox2;
        private Label lblTotalSalesSub;
        private PictureBox pictureBox2;
        private Label lblTotalSale;
        private Label lblTotalSaleHeading;
        private FlowLayoutPanel flowLayoutPanelLowStock;
    }
}