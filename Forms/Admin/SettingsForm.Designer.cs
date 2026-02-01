namespace GreenLife_Organic_Store.Forms.Admin
{
    partial class frmSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingsForm));
            panel1 = new Panel();
            btnAdminLogout = new Button();
            lblSubHeading = new Label();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnNavigateSettings = new Button();
            btnNavigateReports = new Button();
            btnNavigateOrders = new Button();
            btnNavigateCustomers = new Button();
            btnNavigateProducts = new Button();
            btnNavigateDashboard = new Button();
            lblHeadingsSub = new Label();
            lblSettingsHeadings = new Label();
            btnCategory = new Button();
            btnDiscount = new Button();
            btnSupplier = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnAdminLogout);
            panel1.Controls.Add(lblSubHeading);
            panel1.Controls.Add(lblHeading);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 125);
            panel1.TabIndex = 0;
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
            btnAdminLogout.TabIndex = 27;
            btnAdminLogout.Text = "Logout";
            btnAdminLogout.UseVisualStyleBackColor = false;
            btnAdminLogout.Click += btnAdminLogout_Click;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(95, 73);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(204, 27);
            lblSubHeading.TabIndex = 26;
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
            lblHeading.TabIndex = 25;
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
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnNavigateSettings);
            panel2.Controls.Add(btnNavigateReports);
            panel2.Controls.Add(btnNavigateOrders);
            panel2.Controls.Add(btnNavigateCustomers);
            panel2.Controls.Add(btnNavigateProducts);
            panel2.Controls.Add(btnNavigateDashboard);
            panel2.Location = new Point(5, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 665);
            panel2.TabIndex = 1;
            // 
            // btnNavigateSettings
            // 
            btnNavigateSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateSettings.AutoSize = true;
            btnNavigateSettings.BackColor = Color.DarkGreen;
            btnNavigateSettings.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateSettings.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateSettings.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateSettings.FlatStyle = FlatStyle.Flat;
            btnNavigateSettings.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateSettings.ForeColor = Color.White;
            btnNavigateSettings.Location = new Point(22, 396);
            btnNavigateSettings.Name = "btnNavigateSettings";
            btnNavigateSettings.Size = new Size(227, 44);
            btnNavigateSettings.TabIndex = 40;
            btnNavigateSettings.Text = "Settings";
            btnNavigateSettings.UseVisualStyleBackColor = false;
            btnNavigateSettings.Click += btnNavigateSettings_Click;
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
            btnNavigateReports.Location = new Point(22, 325);
            btnNavigateReports.Name = "btnNavigateReports";
            btnNavigateReports.Size = new Size(227, 44);
            btnNavigateReports.TabIndex = 39;
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
            btnNavigateOrders.Location = new Point(22, 247);
            btnNavigateOrders.Name = "btnNavigateOrders";
            btnNavigateOrders.Size = new Size(227, 44);
            btnNavigateOrders.TabIndex = 38;
            btnNavigateOrders.Text = "Orders";
            btnNavigateOrders.UseVisualStyleBackColor = false;
            btnNavigateOrders.Click += btnNavigateOrders_Click;
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
            btnNavigateCustomers.Location = new Point(22, 174);
            btnNavigateCustomers.Name = "btnNavigateCustomers";
            btnNavigateCustomers.Size = new Size(227, 44);
            btnNavigateCustomers.TabIndex = 37;
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
            btnNavigateProducts.Location = new Point(22, 101);
            btnNavigateProducts.Name = "btnNavigateProducts";
            btnNavigateProducts.Size = new Size(227, 44);
            btnNavigateProducts.TabIndex = 36;
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
            btnNavigateDashboard.Location = new Point(22, 30);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 35;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += btnNavigateDashboard_Click;
            // 
            // lblHeadingsSub
            // 
            lblHeadingsSub.AutoSize = true;
            lblHeadingsSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeadingsSub.ForeColor = Color.LimeGreen;
            lblHeadingsSub.Location = new Point(306, 181);
            lblHeadingsSub.Name = "lblHeadingsSub";
            lblHeadingsSub.Size = new Size(263, 23);
            lblHeadingsSub.TabIndex = 19;
            lblHeadingsSub.Text = "Make the admin settings here";
            // 
            // lblSettingsHeadings
            // 
            lblSettingsHeadings.AutoSize = true;
            lblSettingsHeadings.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSettingsHeadings.ForeColor = Color.ForestGreen;
            lblSettingsHeadings.Location = new Point(302, 138);
            lblSettingsHeadings.Name = "lblSettingsHeadings";
            lblSettingsHeadings.Size = new Size(156, 43);
            lblSettingsHeadings.TabIndex = 20;
            lblSettingsHeadings.Text = "Settings";
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.Green;
            btnCategory.FlatAppearance.BorderColor = Color.Green;
            btnCategory.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnCategory.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnCategory.FlatStyle = FlatStyle.Popup;
            btnCategory.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategory.ForeColor = Color.White;
            btnCategory.Location = new Point(306, 238);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(281, 116);
            btnCategory.TabIndex = 23;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = Color.Green;
            btnDiscount.FlatAppearance.BorderColor = Color.Green;
            btnDiscount.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnDiscount.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnDiscount.FlatStyle = FlatStyle.Popup;
            btnDiscount.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiscount.ForeColor = Color.White;
            btnDiscount.Location = new Point(621, 238);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(281, 116);
            btnDiscount.TabIndex = 24;
            btnDiscount.Text = "Discount";
            btnDiscount.UseVisualStyleBackColor = false;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.Green;
            btnSupplier.FlatAppearance.BorderColor = Color.Green;
            btnSupplier.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnSupplier.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnSupplier.FlatStyle = FlatStyle.Popup;
            btnSupplier.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplier.ForeColor = Color.White;
            btnSupplier.Location = new Point(940, 238);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(281, 116);
            btnSupplier.TabIndex = 25;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = false;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // frmSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1714, 791);
            Controls.Add(btnSupplier);
            Controls.Add(btnDiscount);
            Controls.Add(btnCategory);
            Controls.Add(lblHeadingsSub);
            Controls.Add(lblSettingsHeadings);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += frmSettingsForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button btnNavigateSettings;
        private Button btnNavigateReports;
        private Button btnNavigateOrders;
        private Button btnNavigateCustomers;
        private Button btnNavigateProducts;
        private Button btnNavigateDashboard;
        private Label lblHeadingsSub;
        private Label lblSettingsHeadings;
        private Button btnCategory;
        private Button btnDiscount;
        private Button btnSupplier;
    }
}