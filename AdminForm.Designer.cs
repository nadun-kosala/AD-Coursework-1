namespace GreenLife_Organic_Store
{
    partial class frmAdminForm
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
            groupBox1 = new GroupBox();
            btnAdminLogout = new Button();
            lblSubHeading = new Label();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabAdminDashboard = new TabPage();
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
            label2 = new Label();
            label1 = new Label();
            tabAdminProducts = new TabPage();
            tabAdminCustomers = new TabPage();
            tabAdminOrders = new TabPage();
            tabAdminReports = new TabPage();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabAdminDashboard.SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdminLogout);
            groupBox1.Controls.Add(lblSubHeading);
            groupBox1.Controls.Add(lblHeading);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1605, 107);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnAdminLogout
            // 
            btnAdminLogout.AutoSize = true;
            btnAdminLogout.BackColor = SystemColors.ControlLightLight;
            btnAdminLogout.FlatAppearance.BorderColor = Color.LimeGreen;
            btnAdminLogout.FlatAppearance.MouseDownBackColor = Color.Chartreuse;
            btnAdminLogout.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnAdminLogout.FlatStyle = FlatStyle.Flat;
            btnAdminLogout.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLogout.ForeColor = Color.LimeGreen;
            btnAdminLogout.Location = new Point(1441, 40);
            btnAdminLogout.Name = "btnAdminLogout";
            btnAdminLogout.Size = new Size(141, 44);
            btnAdminLogout.TabIndex = 7;
            btnAdminLogout.Text = "Logout";
            btnAdminLogout.UseVisualStyleBackColor = false;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(106, 69);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(204, 27);
            lblSubHeading.TabIndex = 6;
            lblSubHeading.Text = "Management Portal";
            lblSubHeading.Click += lblSubHeading_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(97, 22);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(329, 47);
            lblHeading.TabIndex = 5;
            lblHeading.Text = "GreenLife Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(13, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.AccessibleRole = AccessibleRole.MenuBar;
            tabControl1.AllowDrop = true;
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabAdminDashboard);
            tabControl1.Controls.Add(tabAdminProducts);
            tabControl1.Controls.Add(tabAdminCustomers);
            tabControl1.Controls.Add(tabAdminOrders);
            tabControl1.Controls.Add(tabAdminReports);
            tabControl1.Location = new Point(12, 125);
            tabControl1.Margin = new Padding(5);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1605, 661);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 1;
            // 
            // tabAdminDashboard
            // 
            tabAdminDashboard.AutoScroll = true;
            tabAdminDashboard.BackColor = Color.Honeydew;
            tabAdminDashboard.Controls.Add(groupBox4);
            tabAdminDashboard.Controls.Add(groupBox3);
            tabAdminDashboard.Controls.Add(groupBox5);
            tabAdminDashboard.Controls.Add(groupBox2);
            tabAdminDashboard.Controls.Add(label2);
            tabAdminDashboard.Controls.Add(label1);
            tabAdminDashboard.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabAdminDashboard.ForeColor = SystemColors.ControlLight;
            tabAdminDashboard.Location = new Point(4, 32);
            tabAdminDashboard.Name = "tabAdminDashboard";
            tabAdminDashboard.Padding = new Padding(10);
            tabAdminDashboard.RightToLeft = RightToLeft.No;
            tabAdminDashboard.Size = new Size(1597, 625);
            tabAdminDashboard.TabIndex = 0;
            tabAdminDashboard.Text = "Dashboard";
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
            groupBox4.Location = new Point(918, 109);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(248, 178);
            groupBox4.TabIndex = 14;
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
            groupBox3.Location = new Point(312, 109);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(248, 178);
            groupBox3.TabIndex = 12;
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
            groupBox5.Location = new Point(610, 109);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(248, 178);
            groupBox5.TabIndex = 13;
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
            lblActiveOrders.Click += label7_Click;
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
            groupBox2.Location = new Point(17, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 178);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(17, 53);
            label2.Name = "label2";
            label2.Size = new Size(275, 23);
            label2.TabIndex = 8;
            label2.Text = "Overview of your organic store";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(326, 43);
            label1.TabIndex = 8;
            label1.Text = "Admin Dashboard";
            // 
            // tabAdminProducts
            // 
            tabAdminProducts.BackColor = Color.Honeydew;
            tabAdminProducts.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabAdminProducts.Location = new Point(4, 32);
            tabAdminProducts.Name = "tabAdminProducts";
            tabAdminProducts.Padding = new Padding(3);
            tabAdminProducts.Size = new Size(1597, 625);
            tabAdminProducts.TabIndex = 1;
            tabAdminProducts.Text = "Products";
            // 
            // tabAdminCustomers
            // 
            tabAdminCustomers.BackColor = Color.Honeydew;
            tabAdminCustomers.Location = new Point(4, 32);
            tabAdminCustomers.Name = "tabAdminCustomers";
            tabAdminCustomers.Size = new Size(1597, 625);
            tabAdminCustomers.TabIndex = 2;
            tabAdminCustomers.Text = "Customers";
            // 
            // tabAdminOrders
            // 
            tabAdminOrders.BackColor = Color.Honeydew;
            tabAdminOrders.Location = new Point(4, 32);
            tabAdminOrders.Name = "tabAdminOrders";
            tabAdminOrders.Size = new Size(1597, 625);
            tabAdminOrders.TabIndex = 3;
            tabAdminOrders.Text = "Orders";
            // 
            // tabAdminReports
            // 
            tabAdminReports.BackColor = Color.Honeydew;
            tabAdminReports.Location = new Point(4, 32);
            tabAdminReports.Name = "tabAdminReports";
            tabAdminReports.Size = new Size(1597, 625);
            tabAdminReports.TabIndex = 4;
            tabAdminReports.Text = "Reports";
            // 
            // frmAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1629, 798);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "frmAdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabAdminDashboard.ResumeLayout(false);
            tabAdminDashboard.PerformLayout();
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
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabAdminDashboard;
        private TabPage tabAdminProducts;
        private TabPage tabAdminCustomers;
        private TabPage tabAdminOrders;
        private TabPage tabAdminReports;
        private PictureBox pictureBox1;
        private Label lblHeading;
        private Label lblSubHeading;
        private Button btnAdminLogout;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label lblTotalSalesSub;
        private PictureBox pictureBox2;
        private Label lblTotalSale;
        private Label lblTotalSaleHeading;
        private GroupBox groupBox3;
        private Label lblProductInStockSub;
        private PictureBox pictureBox3;
        private Label lblProductInStock;
        private Label lblProductInStockHeading;
        private GroupBox groupBox4;
        private Label lblTotalCustomersSub;
        private PictureBox pictureBox4;
        private Label lblTotalCustomers;
        private Label lblTotalCustomersHeading;
        private GroupBox groupBox5;
        private Label lblTotalOrdersSub;
        private PictureBox pictureBox5;
        private Label lblActiveOrders;
        private Label lblActiveOrdersHeading;
    }
}