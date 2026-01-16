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
            tabAdminProducts = new TabPage();
            tabAdminCustomers = new TabPage();
            tabAdminOrders = new TabPage();
            tabAdminReports = new TabPage();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
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
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(13, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 75);
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
    }
}