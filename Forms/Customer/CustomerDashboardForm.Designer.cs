namespace GreenLife_Organic_Store.Forms.Customer
{
    partial class frmCustomerDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerDashboardForm));
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
            panel3 = new Panel();
            lblWelcomeHeadingName = new Label();
            pictureBox6 = new PictureBox();
            lblWelcomeHeading = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnDashboardViewCartNav = new Button();
            lblDashboardCartItem = new Label();
            lblDashboardShoppingCart = new Label();
            pictureBox5 = new PictureBox();
            groupBox2 = new GroupBox();
            btnBrowseProducts = new Button();
            lblTotalSalesSub = new Label();
            pictureBox2 = new PictureBox();
            lblDashboardSearch = new Label();
            groupBox4 = new GroupBox();
            btnDashboardEditProfileNav = new Button();
            lblDashboardManageAcc = new Label();
            lblDashboardMyProfile = new Label();
            pictureBox4 = new PictureBox();
            groupBox5 = new GroupBox();
            btnDashboardTrackOrdersNav = new Button();
            lblDashboardActiveOrders = new Label();
            lblDashboardMyOrders = new Label();
            pictureBox3 = new PictureBox();
            flowLayoutPanalTopRateProducts = new FlowLayoutPanel();
            lblTopRatedHeading = new Label();
            lblTopRatedSub = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            btnCustomerLogout.Location = new Point(1448, 42);
            btnCustomerLogout.Name = "btnCustomerLogout";
            btnCustomerLogout.Size = new Size(141, 44);
            btnCustomerLogout.TabIndex = 22;
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
            lblHeading.TabIndex = 18;
            lblHeading.Text = "GreenLife Organic Store";
            lblHeading.Click += lblHeading_Click;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(95, 73);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(226, 27);
            lblSubHeading.TabIndex = 19;
            lblSubHeading.Text = "Welcome to GreenLife";
            lblSubHeading.Click += lblSubHeading_Click;
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
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnNavigateProfile);
            panel2.Controls.Add(btnNavigateOrders);
            panel2.Controls.Add(btnNavigateCart);
            panel2.Controls.Add(btnNavigateSearch);
            panel2.Controls.Add(btnNavigateDashboard);
            panel2.Location = new Point(2, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 902);
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
            btnNavigateProfile.Location = new Point(11, 316);
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
            btnNavigateOrders.Location = new Point(11, 238);
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
            btnNavigateCart.Location = new Point(11, 165);
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
            btnNavigateSearch.Location = new Point(11, 92);
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
            btnNavigateDashboard.Location = new Point(11, 21);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 30;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += btnNavigateDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSeaGreen;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(lblWelcomeHeadingName);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(lblWelcomeHeading);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(280, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(1343, 124);
            panel3.TabIndex = 16;
            // 
            // lblWelcomeHeadingName
            // 
            lblWelcomeHeadingName.AutoSize = true;
            lblWelcomeHeadingName.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeHeadingName.ForeColor = SystemColors.ControlLightLight;
            lblWelcomeHeadingName.Location = new Point(287, 26);
            lblWelcomeHeadingName.Name = "lblWelcomeHeadingName";
            lblWelcomeHeadingName.Size = new Size(273, 43);
            lblWelcomeHeadingName.TabIndex = 14;
            lblWelcomeHeadingName.Text = "Emily Johnson!";
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.BackgroundImageLayout = ImageLayout.Center;
            pictureBox6.Image = Properties.Resources._9309051;
            pictureBox6.Location = new Point(1242, 24);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(92, 85);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // lblWelcomeHeading
            // 
            lblWelcomeHeading.AutoSize = true;
            lblWelcomeHeading.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeHeading.ForeColor = SystemColors.ControlLightLight;
            lblWelcomeHeading.Location = new Point(15, 26);
            lblWelcomeHeading.Name = "lblWelcomeHeading";
            lblWelcomeHeading.Size = new Size(281, 43);
            lblWelcomeHeading.TabIndex = 8;
            lblWelcomeHeading.Text = "Welcome back, ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(21, 69);
            label2.Name = "label2";
            label2.Size = new Size(480, 23);
            label2.TabIndex = 8;
            label2.Text = "Discover fresh organic products delivered to your door";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLightLight;
            groupBox3.BackgroundImageLayout = ImageLayout.Center;
            groupBox3.Controls.Add(btnDashboardViewCartNav);
            groupBox3.Controls.Add(lblDashboardCartItem);
            groupBox3.Controls.Add(lblDashboardShoppingCart);
            groupBox3.Controls.Add(pictureBox5);
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.ForeColor = Color.DarkGreen;
            groupBox3.Location = new Point(613, 301);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(302, 298);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            // 
            // btnDashboardViewCartNav
            // 
            btnDashboardViewCartNav.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDashboardViewCartNav.AutoSize = true;
            btnDashboardViewCartNav.BackColor = Color.MediumSeaGreen;
            btnDashboardViewCartNav.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            btnDashboardViewCartNav.FlatAppearance.MouseDownBackColor = Color.Green;
            btnDashboardViewCartNav.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnDashboardViewCartNav.FlatStyle = FlatStyle.Flat;
            btnDashboardViewCartNav.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboardViewCartNav.ForeColor = SystemColors.ControlLightLight;
            btnDashboardViewCartNav.Location = new Point(23, 222);
            btnDashboardViewCartNav.Name = "btnDashboardViewCartNav";
            btnDashboardViewCartNav.Size = new Size(258, 44);
            btnDashboardViewCartNav.TabIndex = 14;
            btnDashboardViewCartNav.Text = "View Cart";
            btnDashboardViewCartNav.UseVisualStyleBackColor = false;
            btnDashboardViewCartNav.Click += btnDashboardViewCartNav_Click;
            // 
            // lblDashboardCartItem
            // 
            lblDashboardCartItem.AutoSize = true;
            lblDashboardCartItem.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardCartItem.ForeColor = Color.LimeGreen;
            lblDashboardCartItem.Location = new Point(22, 162);
            lblDashboardCartItem.Name = "lblDashboardCartItem";
            lblDashboardCartItem.Size = new Size(133, 23);
            lblDashboardCartItem.TabIndex = 14;
            lblDashboardCartItem.Text = "0 items in cart";
            // 
            // lblDashboardShoppingCart
            // 
            lblDashboardShoppingCart.AutoSize = true;
            lblDashboardShoppingCart.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardShoppingCart.Location = new Point(22, 122);
            lblDashboardShoppingCart.Name = "lblDashboardShoppingCart";
            lblDashboardShoppingCart.Size = new Size(161, 27);
            lblDashboardShoppingCart.TabIndex = 14;
            lblDashboardShoppingCart.Text = "Shopping Cart";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Image = Properties.Resources._293058_middle;
            pictureBox5.Location = new Point(22, 35);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(68, 66);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.BackgroundImageLayout = ImageLayout.Center;
            groupBox2.Controls.Add(btnBrowseProducts);
            groupBox2.Controls.Add(lblTotalSalesSub);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(lblDashboardSearch);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.ForeColor = Color.DarkGreen;
            groupBox2.Location = new Point(280, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 298);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // btnBrowseProducts
            // 
            btnBrowseProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseProducts.AutoSize = true;
            btnBrowseProducts.BackColor = Color.MediumSeaGreen;
            btnBrowseProducts.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            btnBrowseProducts.FlatAppearance.MouseDownBackColor = Color.Green;
            btnBrowseProducts.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnBrowseProducts.FlatStyle = FlatStyle.Flat;
            btnBrowseProducts.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseProducts.ForeColor = SystemColors.ControlLightLight;
            btnBrowseProducts.Location = new Point(23, 223);
            btnBrowseProducts.Name = "btnBrowseProducts";
            btnBrowseProducts.Size = new Size(258, 44);
            btnBrowseProducts.TabIndex = 15;
            btnBrowseProducts.Text = "Browse Now";
            btnBrowseProducts.UseVisualStyleBackColor = false;
            btnBrowseProducts.Click += btnBrowseProducts_Click;
            // 
            // lblTotalSalesSub
            // 
            lblTotalSalesSub.AutoSize = true;
            lblTotalSalesSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSalesSub.ForeColor = Color.LimeGreen;
            lblTotalSalesSub.Location = new Point(21, 162);
            lblTotalSalesSub.Name = "lblTotalSalesSub";
            lblTotalSalesSub.Size = new Size(260, 23);
            lblTotalSalesSub.TabIndex = 11;
            lblTotalSalesSub.Text = "Browse our organic selection";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__7_;
            pictureBox2.Location = new Point(23, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // lblDashboardSearch
            // 
            lblDashboardSearch.AutoSize = true;
            lblDashboardSearch.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardSearch.Location = new Point(23, 120);
            lblDashboardSearch.Name = "lblDashboardSearch";
            lblDashboardSearch.Size = new Size(185, 27);
            lblDashboardSearch.TabIndex = 0;
            lblDashboardSearch.Text = "Search Products";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ControlLightLight;
            groupBox4.BackgroundImageLayout = ImageLayout.Center;
            groupBox4.Controls.Add(btnDashboardEditProfileNav);
            groupBox4.Controls.Add(lblDashboardManageAcc);
            groupBox4.Controls.Add(lblDashboardMyProfile);
            groupBox4.Controls.Add(pictureBox4);
            groupBox4.FlatStyle = FlatStyle.Popup;
            groupBox4.ForeColor = Color.DarkGreen;
            groupBox4.Location = new Point(1302, 301);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(302, 298);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            // 
            // btnDashboardEditProfileNav
            // 
            btnDashboardEditProfileNav.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDashboardEditProfileNav.AutoSize = true;
            btnDashboardEditProfileNav.BackColor = Color.MediumSeaGreen;
            btnDashboardEditProfileNav.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            btnDashboardEditProfileNav.FlatAppearance.MouseDownBackColor = Color.Green;
            btnDashboardEditProfileNav.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnDashboardEditProfileNav.FlatStyle = FlatStyle.Flat;
            btnDashboardEditProfileNav.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboardEditProfileNav.ForeColor = SystemColors.ControlLightLight;
            btnDashboardEditProfileNav.Location = new Point(24, 223);
            btnDashboardEditProfileNav.Name = "btnDashboardEditProfileNav";
            btnDashboardEditProfileNav.Size = new Size(258, 44);
            btnDashboardEditProfileNav.TabIndex = 16;
            btnDashboardEditProfileNav.Text = "Edit Profile";
            btnDashboardEditProfileNav.UseVisualStyleBackColor = false;
            btnDashboardEditProfileNav.Click += btnDashboardEditProfileNav_Click;
            // 
            // lblDashboardManageAcc
            // 
            lblDashboardManageAcc.AutoSize = true;
            lblDashboardManageAcc.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardManageAcc.ForeColor = Color.LimeGreen;
            lblDashboardManageAcc.Location = new Point(24, 161);
            lblDashboardManageAcc.Name = "lblDashboardManageAcc";
            lblDashboardManageAcc.Size = new Size(193, 23);
            lblDashboardManageAcc.TabIndex = 16;
            lblDashboardManageAcc.Text = "Manage your account";
            // 
            // lblDashboardMyProfile
            // 
            lblDashboardMyProfile.AutoSize = true;
            lblDashboardMyProfile.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardMyProfile.Location = new Point(24, 122);
            lblDashboardMyProfile.Name = "lblDashboardMyProfile";
            lblDashboardMyProfile.Size = new Size(120, 27);
            lblDashboardMyProfile.TabIndex = 16;
            lblDashboardMyProfile.Text = "My Profile";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.person_user_avatar_user_profile_system_green_plant_symbol_png_clipart;
            pictureBox4.Location = new Point(24, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 66);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ControlLightLight;
            groupBox5.BackgroundImageLayout = ImageLayout.Center;
            groupBox5.Controls.Add(btnDashboardTrackOrdersNav);
            groupBox5.Controls.Add(lblDashboardActiveOrders);
            groupBox5.Controls.Add(lblDashboardMyOrders);
            groupBox5.Controls.Add(pictureBox3);
            groupBox5.FlatStyle = FlatStyle.Popup;
            groupBox5.ForeColor = Color.DarkGreen;
            groupBox5.Location = new Point(952, 301);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(302, 298);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            // 
            // btnDashboardTrackOrdersNav
            // 
            btnDashboardTrackOrdersNav.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDashboardTrackOrdersNav.AutoSize = true;
            btnDashboardTrackOrdersNav.BackColor = Color.MediumSeaGreen;
            btnDashboardTrackOrdersNav.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            btnDashboardTrackOrdersNav.FlatAppearance.MouseDownBackColor = Color.Green;
            btnDashboardTrackOrdersNav.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnDashboardTrackOrdersNav.FlatStyle = FlatStyle.Flat;
            btnDashboardTrackOrdersNav.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboardTrackOrdersNav.ForeColor = SystemColors.ControlLightLight;
            btnDashboardTrackOrdersNav.Location = new Point(23, 223);
            btnDashboardTrackOrdersNav.Name = "btnDashboardTrackOrdersNav";
            btnDashboardTrackOrdersNav.Size = new Size(258, 44);
            btnDashboardTrackOrdersNav.TabIndex = 15;
            btnDashboardTrackOrdersNav.Text = "Track Orders";
            btnDashboardTrackOrdersNav.UseVisualStyleBackColor = false;
            btnDashboardTrackOrdersNav.Click += btnDashboardTrackOrdersNav_Click;
            // 
            // lblDashboardActiveOrders
            // 
            lblDashboardActiveOrders.AutoSize = true;
            lblDashboardActiveOrders.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboardActiveOrders.ForeColor = Color.LimeGreen;
            lblDashboardActiveOrders.Location = new Point(29, 161);
            lblDashboardActiveOrders.Name = "lblDashboardActiveOrders";
            lblDashboardActiveOrders.Size = new Size(138, 23);
            lblDashboardActiveOrders.TabIndex = 15;
            lblDashboardActiveOrders.Text = "0 active orders";
            // 
            // lblDashboardMyOrders
            // 
            lblDashboardMyOrders.AutoSize = true;
            lblDashboardMyOrders.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardMyOrders.Location = new Point(25, 122);
            lblDashboardMyOrders.Name = "lblDashboardMyOrders";
            lblDashboardMyOrders.Size = new Size(123, 27);
            lblDashboardMyOrders.TabIndex = 15;
            lblDashboardMyOrders.Text = "My Orders";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.paper_cardboard_box_green_png_favpng_xRbZH9Y9aFcMr7tAMPUetKHcu;
            pictureBox3.Location = new Point(25, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // flowLayoutPanalTopRateProducts
            // 
            flowLayoutPanalTopRateProducts.AutoScroll = true;
            flowLayoutPanalTopRateProducts.Location = new Point(286, 678);
            flowLayoutPanalTopRateProducts.Name = "flowLayoutPanalTopRateProducts";
            flowLayoutPanalTopRateProducts.Size = new Size(1318, 350);
            flowLayoutPanalTopRateProducts.TabIndex = 21;
            flowLayoutPanalTopRateProducts.Paint += flowLayoutPanalTopRateProducts_Paint;
            // 
            // lblTopRatedHeading
            // 
            lblTopRatedHeading.AutoSize = true;
            lblTopRatedHeading.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopRatedHeading.ForeColor = Color.ForestGreen;
            lblTopRatedHeading.Location = new Point(280, 617);
            lblTopRatedHeading.Name = "lblTopRatedHeading";
            lblTopRatedHeading.Size = new Size(310, 27);
            lblTopRatedHeading.TabIndex = 22;
            lblTopRatedHeading.Text = "Top-Rated Organic Products";
            // 
            // lblTopRatedSub
            // 
            lblTopRatedSub.AutoSize = true;
            lblTopRatedSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTopRatedSub.ForeColor = Color.LimeGreen;
            lblTopRatedSub.Location = new Point(286, 648);
            lblTopRatedSub.Name = "lblTopRatedSub";
            lblTopRatedSub.Size = new Size(259, 23);
            lblTopRatedSub.TabIndex = 23;
            lblTopRatedSub.Text = "Fresh picks for you this week";
            // 
            // frmCustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1626, 684);
            Controls.Add(lblTopRatedSub);
            Controls.Add(lblTopRatedHeading);
            Controls.Add(flowLayoutPanalTopRateProducts);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCustomerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += frmCustomerDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblHeading;
        private Label lblSubHeading;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnNavigateProfile;
        private Button btnNavigateOrders;
        private Button btnNavigateCart;
        private Button btnNavigateSearch;
        private Button btnNavigateDashboard;
        private Panel panel3;
        private Label lblWelcomeHeadingName;
        private Label lblWelcomeHeading;
        private Label label2;
        private PictureBox pictureBox6;
        private GroupBox groupBox3;
        private Button btnDashboardViewCartNav;
        private Label lblDashboardCartItem;
        private Label lblDashboardShoppingCart;
        private PictureBox pictureBox5;
        private GroupBox groupBox2;
        private Label lblTotalSalesSub;
        private PictureBox pictureBox2;
        private Label lblDashboardSearch;
        private GroupBox groupBox4;
        private Button btnDashboardEditProfileNav;
        private Label lblDashboardManageAcc;
        private Label lblDashboardMyProfile;
        private PictureBox pictureBox4;
        private GroupBox groupBox5;
        private Button btnDashboardTrackOrdersNav;
        private Label lblDashboardActiveOrders;
        private Label lblDashboardMyOrders;
        private PictureBox pictureBox3;
        private Button btnBrowseProducts;
        private Button btnCustomerLogout;
        private FlowLayoutPanel flowLayoutPanalTopRateProducts;
        private Label lblTopRatedHeading;
        private Label lblTopRatedSub;
    }
}