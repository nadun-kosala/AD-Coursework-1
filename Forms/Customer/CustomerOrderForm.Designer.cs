namespace GreenLife_Organic_Store.Forms.Customer
{
    partial class frmCustomerOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerOrderForm));
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
            lblTrackOrdersSub = new Label();
            lblTrackOrdersHeading = new Label();
            flowLayoutShowOrders = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnCustomerLogout);
            panel1.Controls.Add(lblHeading);
            panel1.Controls.Add(lblSubHeading);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1622, 125);
            panel1.TabIndex = 0;
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
            btnCustomerLogout.Location = new Point(1456, 43);
            btnCustomerLogout.Name = "btnCustomerLogout";
            btnCustomerLogout.Size = new Size(141, 44);
            btnCustomerLogout.TabIndex = 20;
            btnCustomerLogout.Text = "Logout";
            btnCustomerLogout.UseVisualStyleBackColor = false;
            btnCustomerLogout.Click += btnCustomerLogout_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(86, 25);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(456, 47);
            lblHeading.TabIndex = 18;
            lblHeading.Text = "GreenLife Organic Store";
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(95, 72);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(226, 27);
            lblSubHeading.TabIndex = 19;
            lblSubHeading.Text = "Welcome to GreenLife";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(2, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnNavigateProfile);
            panel2.Controls.Add(btnNavigateOrders);
            panel2.Controls.Add(btnNavigateCart);
            panel2.Controls.Add(btnNavigateSearch);
            panel2.Controls.Add(btnNavigateDashboard);
            panel2.Location = new Point(1, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 556);
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
            btnNavigateProfile.Location = new Point(11, 312);
            btnNavigateProfile.Name = "btnNavigateProfile";
            btnNavigateProfile.Size = new Size(227, 44);
            btnNavigateProfile.TabIndex = 34;
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
            btnNavigateOrders.Location = new Point(11, 234);
            btnNavigateOrders.Name = "btnNavigateOrders";
            btnNavigateOrders.Size = new Size(227, 44);
            btnNavigateOrders.TabIndex = 33;
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
            btnNavigateCart.Location = new Point(11, 161);
            btnNavigateCart.Name = "btnNavigateCart";
            btnNavigateCart.Size = new Size(227, 44);
            btnNavigateCart.TabIndex = 32;
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
            btnNavigateSearch.Location = new Point(11, 88);
            btnNavigateSearch.Name = "btnNavigateSearch";
            btnNavigateSearch.Size = new Size(227, 44);
            btnNavigateSearch.TabIndex = 31;
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
            btnNavigateDashboard.Location = new Point(11, 17);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 30;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += btnNavigateDashboard_Click;
            // 
            // lblTrackOrdersSub
            // 
            lblTrackOrdersSub.AutoSize = true;
            lblTrackOrdersSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrackOrdersSub.ForeColor = Color.LimeGreen;
            lblTrackOrdersSub.Location = new Point(276, 188);
            lblTrackOrdersSub.Name = "lblTrackOrdersSub";
            lblTrackOrdersSub.Size = new Size(308, 23);
            lblTrackOrdersSub.TabIndex = 15;
            lblTrackOrdersSub.Text = "View your order history and status";
            // 
            // lblTrackOrdersHeading
            // 
            lblTrackOrdersHeading.AutoSize = true;
            lblTrackOrdersHeading.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrackOrdersHeading.ForeColor = Color.ForestGreen;
            lblTrackOrdersHeading.Location = new Point(272, 145);
            lblTrackOrdersHeading.Name = "lblTrackOrdersHeading";
            lblTrackOrdersHeading.Size = new Size(243, 43);
            lblTrackOrdersHeading.TabIndex = 16;
            lblTrackOrdersHeading.Text = "Track Orders";
            // 
            // flowLayoutShowOrders
            // 
            flowLayoutShowOrders.AutoScroll = true;
            flowLayoutShowOrders.BackColor = Color.Honeydew;
            flowLayoutShowOrders.FlowDirection = FlowDirection.TopDown;
            flowLayoutShowOrders.Location = new Point(276, 229);
            flowLayoutShowOrders.Name = "flowLayoutShowOrders";
            flowLayoutShowOrders.Size = new Size(1338, 443);
            flowLayoutShowOrders.TabIndex = 17;
            flowLayoutShowOrders.WrapContents = false;
            // 
            // frmCustomerOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1626, 684);
            Controls.Add(flowLayoutShowOrders);
            Controls.Add(lblTrackOrdersSub);
            Controls.Add(lblTrackOrdersHeading);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCustomerOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            Load += frmCustomerOrderForm_Load;
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
        private Label lblTrackOrdersSub;
        private Label lblTrackOrdersHeading;
        private FlowLayoutPanel flowLayoutShowOrders;
    }
}