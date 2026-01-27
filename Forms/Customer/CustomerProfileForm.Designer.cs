namespace GreenLife_Organic_Store.Forms.Customer
{
    partial class frmCustomerProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerProfileForm));
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
            lblMyProfilesSub = new Label();
            lblMyProfileHeadings = new Label();
            panel4 = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            lblProfileAddress = new Label();
            lblProfilePhoneNumber = new Label();
            lblProfileEmail = new Label();
            lblProfileEmailHead = new Label();
            pictureBox7 = new PictureBox();
            lblProfileName = new Label();
            panel7 = new Panel();
            btnUpdatePassword = new Button();
            txtConfirmNewPassword = new TextBox();
            lblConfirmNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblCurrentPassword = new Label();
            lblChangePasswordSub = new Label();
            lblChangePassword = new Label();
            panel6 = new Panel();
            btnEditProfile = new Button();
            txtProfileAddress = new TextBox();
            lblCusRegAddress = new Label();
            txtProfilePhone = new TextBox();
            label4 = new Label();
            txtProfileEmail = new TextBox();
            lblCusRegEmail = new Label();
            txtProfileFullName = new TextBox();
            lblCusRegFullName = new Label();
            lblProfileInformationSub = new Label();
            lblProfileInformation = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
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
            btnCustomerLogout.Location = new Point(1449, 41);
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
            lblHeading.Location = new Point(87, 26);
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
            lblSubHeading.Location = new Point(96, 73);
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
            pictureBox1.Location = new Point(3, 20);
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
            panel2.Location = new Point(2, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 992);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
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
            btnNavigateProfile.Location = new Point(10, 311);
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
            btnNavigateOrders.Location = new Point(10, 233);
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
            btnNavigateCart.Location = new Point(10, 160);
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
            btnNavigateSearch.Location = new Point(10, 87);
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
            btnNavigateDashboard.Location = new Point(10, 16);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 30;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += btnNavigateDashboard_Click;
            // 
            // lblMyProfilesSub
            // 
            lblMyProfilesSub.AutoSize = true;
            lblMyProfilesSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMyProfilesSub.ForeColor = Color.LimeGreen;
            lblMyProfilesSub.Location = new Point(277, 185);
            lblMyProfilesSub.Name = "lblMyProfilesSub";
            lblMyProfilesSub.Size = new Size(301, 23);
            lblMyProfilesSub.TabIndex = 17;
            lblMyProfilesSub.Text = "Manage your account information";
            lblMyProfilesSub.Click += lblMyProfilesSub_Click;
            // 
            // lblMyProfileHeadings
            // 
            lblMyProfileHeadings.AutoSize = true;
            lblMyProfileHeadings.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyProfileHeadings.ForeColor = Color.ForestGreen;
            lblMyProfileHeadings.Location = new Point(273, 142);
            lblMyProfileHeadings.Name = "lblMyProfileHeadings";
            lblMyProfileHeadings.Size = new Size(193, 43);
            lblMyProfileHeadings.TabIndex = 18;
            lblMyProfileHeadings.Text = "My Profile";
            lblMyProfileHeadings.Click += lblMyProfileHeadings_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(pictureBox10);
            panel4.Controls.Add(pictureBox9);
            panel4.Controls.Add(pictureBox8);
            panel4.Controls.Add(lblProfileAddress);
            panel4.Controls.Add(lblProfilePhoneNumber);
            panel4.Controls.Add(lblProfileEmail);
            panel4.Controls.Add(lblProfileEmailHead);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(lblProfileName);
            panel4.Location = new Point(277, 226);
            panel4.Name = "panel4";
            panel4.Size = new Size(368, 892);
            panel4.TabIndex = 19;
            panel4.Paint += panel4_Paint_1;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImageLayout = ImageLayout.Center;
            pictureBox10.Image = Properties.Resources.images__5_;
            pictureBox10.Location = new Point(6, 394);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(43, 41);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 25;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImageLayout = ImageLayout.Center;
            pictureBox9.Image = Properties.Resources._3da7b352e0afb625e50ee95a6470c2e7;
            pictureBox9.Location = new Point(6, 338);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(46, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 24;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImageLayout = ImageLayout.Center;
            pictureBox8.Image = Properties.Resources.images__4_;
            pictureBox8.Location = new Point(10, 295);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(39, 38);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            // 
            // lblProfileAddress
            // 
            lblProfileAddress.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfileAddress.ForeColor = SystemColors.GrayText;
            lblProfileAddress.Location = new Point(52, 379);
            lblProfileAddress.Name = "lblProfileAddress";
            lblProfileAddress.Size = new Size(300, 91);
            lblProfileAddress.TabIndex = 23;
            lblProfileAddress.Text = "123 Green Street, Portland, OR 97201";
            lblProfileAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProfilePhoneNumber
            // 
            lblProfilePhoneNumber.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfilePhoneNumber.ForeColor = SystemColors.GrayText;
            lblProfilePhoneNumber.Location = new Point(52, 342);
            lblProfilePhoneNumber.Name = "lblProfilePhoneNumber";
            lblProfilePhoneNumber.Size = new Size(300, 37);
            lblProfilePhoneNumber.TabIndex = 22;
            lblProfilePhoneNumber.Text = "+94 77 123-4567";
            lblProfilePhoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProfileEmail
            // 
            lblProfileEmail.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfileEmail.ForeColor = SystemColors.GrayText;
            lblProfileEmail.Location = new Point(52, 296);
            lblProfileEmail.Name = "lblProfileEmail";
            lblProfileEmail.Size = new Size(300, 37);
            lblProfileEmail.TabIndex = 21;
            lblProfileEmail.Text = "emily.j@email.com";
            lblProfileEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProfileEmailHead
            // 
            lblProfileEmailHead.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfileEmailHead.ForeColor = SystemColors.ControlDark;
            lblProfileEmailHead.Location = new Point(3, 236);
            lblProfileEmailHead.Name = "lblProfileEmailHead";
            lblProfileEmailHead.Size = new Size(362, 30);
            lblProfileEmailHead.TabIndex = 20;
            lblProfileEmailHead.Text = "emily.j@email.com";
            lblProfileEmailHead.TextAlign = ContentAlignment.MiddleCenter;
            lblProfileEmailHead.Click += lblProfilEmail_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImageLayout = ImageLayout.Center;
            pictureBox7.Image = Properties.Resources.images__3_;
            pictureBox7.Location = new Point(114, 36);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(150, 154);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 19;
            pictureBox7.TabStop = false;
            // 
            // lblProfileName
            // 
            lblProfileName.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfileName.ForeColor = Color.ForestGreen;
            lblProfileName.Location = new Point(3, 193);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(362, 43);
            lblProfileName.TabIndex = 18;
            lblProfileName.Text = "Emily Johnson";
            lblProfileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlLightLight;
            panel7.Controls.Add(btnUpdatePassword);
            panel7.Controls.Add(txtConfirmNewPassword);
            panel7.Controls.Add(lblConfirmNewPassword);
            panel7.Controls.Add(txtNewPassword);
            panel7.Controls.Add(lblNewPassword);
            panel7.Controls.Add(txtCurrentPassword);
            panel7.Controls.Add(lblCurrentPassword);
            panel7.Controls.Add(lblChangePasswordSub);
            panel7.Controls.Add(lblChangePassword);
            panel7.Location = new Point(678, 662);
            panel7.Name = "panel7";
            panel7.Size = new Size(893, 456);
            panel7.TabIndex = 21;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdatePassword.AutoSize = true;
            btnUpdatePassword.BackColor = Color.Green;
            btnUpdatePassword.FlatAppearance.BorderColor = Color.Green;
            btnUpdatePassword.FlatAppearance.MouseDownBackColor = Color.Green;
            btnUpdatePassword.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnUpdatePassword.FlatStyle = FlatStyle.Flat;
            btnUpdatePassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePassword.ForeColor = SystemColors.ControlLightLight;
            btnUpdatePassword.Location = new Point(633, 387);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(198, 44);
            btnUpdatePassword.TabIndex = 36;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.BackColor = SystemColors.InactiveBorder;
            txtConfirmNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmNewPassword.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmNewPassword.Location = new Point(18, 326);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.Size = new Size(813, 31);
            txtConfirmNewPassword.TabIndex = 35;
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmNewPassword.ForeColor = Color.ForestGreen;
            lblConfirmNewPassword.Location = new Point(18, 290);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(222, 23);
            lblConfirmNewPassword.TabIndex = 34;
            lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = SystemColors.InactiveBorder;
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(18, 226);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(813, 31);
            txtNewPassword.TabIndex = 33;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.ForestGreen;
            lblNewPassword.Location = new Point(18, 190);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(144, 23);
            lblNewPassword.TabIndex = 32;
            lblNewPassword.Text = "New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BackColor = SystemColors.InactiveBorder;
            txtCurrentPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPassword.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(18, 135);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(813, 31);
            txtCurrentPassword.TabIndex = 31;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPassword.ForeColor = Color.ForestGreen;
            lblCurrentPassword.Location = new Point(18, 99);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(174, 23);
            lblCurrentPassword.TabIndex = 30;
            lblCurrentPassword.Text = "Current Password";
            // 
            // lblChangePasswordSub
            // 
            lblChangePasswordSub.AutoSize = true;
            lblChangePasswordSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChangePasswordSub.ForeColor = SystemColors.ControlDark;
            lblChangePasswordSub.Location = new Point(18, 44);
            lblChangePasswordSub.Name = "lblChangePasswordSub";
            lblChangePasswordSub.Size = new Size(307, 23);
            lblChangePasswordSub.TabIndex = 20;
            lblChangePasswordSub.Text = "Update your password for security";
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePassword.ForeColor = Color.ForestGreen;
            lblChangePassword.Location = new Point(17, 18);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(170, 23);
            lblChangePassword.TabIndex = 21;
            lblChangePassword.Text = "Change Password";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(btnEditProfile);
            panel6.Controls.Add(txtProfileAddress);
            panel6.Controls.Add(lblCusRegAddress);
            panel6.Controls.Add(txtProfilePhone);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(txtProfileEmail);
            panel6.Controls.Add(lblCusRegEmail);
            panel6.Controls.Add(txtProfileFullName);
            panel6.Controls.Add(lblCusRegFullName);
            panel6.Controls.Add(lblProfileInformationSub);
            panel6.Controls.Add(lblProfileInformation);
            panel6.Location = new Point(678, 226);
            panel6.Name = "panel6";
            panel6.Size = new Size(893, 397);
            panel6.TabIndex = 22;
            // 
            // btnEditProfile
            // 
            btnEditProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditProfile.AutoSize = true;
            btnEditProfile.BackColor = SystemColors.ControlLightLight;
            btnEditProfile.FlatAppearance.BorderColor = Color.LimeGreen;
            btnEditProfile.FlatAppearance.MouseDownBackColor = Color.Ivory;
            btnEditProfile.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProfile.ForeColor = Color.LimeGreen;
            btnEditProfile.Location = new Point(717, 23);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(143, 44);
            btnEditProfile.TabIndex = 30;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // txtProfileAddress
            // 
            txtProfileAddress.BackColor = SystemColors.InactiveBorder;
            txtProfileAddress.BorderStyle = BorderStyle.FixedSingle;
            txtProfileAddress.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfileAddress.Location = new Point(18, 310);
            txtProfileAddress.Name = "txtProfileAddress";
            txtProfileAddress.PlaceholderText = "123 Green St, City, State 12345";
            txtProfileAddress.ReadOnly = true;
            txtProfileAddress.Size = new Size(813, 31);
            txtProfileAddress.TabIndex = 29;
            // 
            // lblCusRegAddress
            // 
            lblCusRegAddress.AutoSize = true;
            lblCusRegAddress.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegAddress.ForeColor = Color.ForestGreen;
            lblCusRegAddress.Location = new Point(18, 274);
            lblCusRegAddress.Name = "lblCusRegAddress";
            lblCusRegAddress.Size = new Size(85, 23);
            lblCusRegAddress.TabIndex = 28;
            lblCusRegAddress.Text = "Address";
            // 
            // txtProfilePhone
            // 
            txtProfilePhone.BackColor = SystemColors.InactiveBorder;
            txtProfilePhone.BorderStyle = BorderStyle.FixedSingle;
            txtProfilePhone.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfilePhone.Location = new Point(18, 217);
            txtProfilePhone.Name = "txtProfilePhone";
            txtProfilePhone.PlaceholderText = "+94 77-1234-567";
            txtProfilePhone.ReadOnly = true;
            txtProfilePhone.Size = new Size(381, 31);
            txtProfilePhone.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(18, 181);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 24;
            label4.Text = "Phone";
            // 
            // txtProfileEmail
            // 
            txtProfileEmail.BackColor = SystemColors.InactiveBorder;
            txtProfileEmail.BorderStyle = BorderStyle.FixedSingle;
            txtProfileEmail.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfileEmail.Location = new Point(450, 125);
            txtProfileEmail.Name = "txtProfileEmail";
            txtProfileEmail.PlaceholderText = "john@example.com";
            txtProfileEmail.ReadOnly = true;
            txtProfileEmail.Size = new Size(381, 31);
            txtProfileEmail.TabIndex = 23;
            // 
            // lblCusRegEmail
            // 
            lblCusRegEmail.AutoSize = true;
            lblCusRegEmail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegEmail.ForeColor = Color.ForestGreen;
            lblCusRegEmail.Location = new Point(450, 89);
            lblCusRegEmail.Name = "lblCusRegEmail";
            lblCusRegEmail.Size = new Size(63, 23);
            lblCusRegEmail.TabIndex = 22;
            lblCusRegEmail.Text = "Email";
            // 
            // txtProfileFullName
            // 
            txtProfileFullName.BackColor = SystemColors.InactiveBorder;
            txtProfileFullName.BorderStyle = BorderStyle.FixedSingle;
            txtProfileFullName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfileFullName.Location = new Point(18, 125);
            txtProfileFullName.Name = "txtProfileFullName";
            txtProfileFullName.PlaceholderText = "John Doe";
            txtProfileFullName.ReadOnly = true;
            txtProfileFullName.Size = new Size(381, 31);
            txtProfileFullName.TabIndex = 21;
            // 
            // lblCusRegFullName
            // 
            lblCusRegFullName.AutoSize = true;
            lblCusRegFullName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegFullName.ForeColor = Color.ForestGreen;
            lblCusRegFullName.Location = new Point(18, 89);
            lblCusRegFullName.Name = "lblCusRegFullName";
            lblCusRegFullName.Size = new Size(103, 23);
            lblCusRegFullName.TabIndex = 20;
            lblCusRegFullName.Text = "Full Name";
            // 
            // lblProfileInformationSub
            // 
            lblProfileInformationSub.AutoSize = true;
            lblProfileInformationSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfileInformationSub.ForeColor = SystemColors.ControlDark;
            lblProfileInformationSub.Location = new Point(18, 44);
            lblProfileInformationSub.Name = "lblProfileInformationSub";
            lblProfileInformationSub.Size = new Size(257, 23);
            lblProfileInformationSub.TabIndex = 19;
            lblProfileInformationSub.Text = "Update your personal details";
            // 
            // lblProfileInformation
            // 
            lblProfileInformation.AutoSize = true;
            lblProfileInformation.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfileInformation.ForeColor = Color.ForestGreen;
            lblProfileInformation.Location = new Point(18, 17);
            lblProfileInformation.Name = "lblProfileInformation";
            lblProfileInformation.Size = new Size(187, 23);
            lblProfileInformation.TabIndex = 19;
            lblProfileInformation.Text = "Profile Information";
            // 
            // frmCustomerProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1626, 684);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(lblMyProfilesSub);
            Controls.Add(lblMyProfileHeadings);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCustomerProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += CustomerProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Label lblMyProfilesSub;
        private Label lblMyProfileHeadings;
        private Panel panel4;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Label lblProfileAddress;
        private Label lblProfilePhoneNumber;
        private Label lblProfileEmail;
        private Label lblProfileEmailHead;
        private PictureBox pictureBox7;
        private Label lblProfileName;
        private Panel panel7;
        private Button btnUpdatePassword;
        private TextBox txtConfirmNewPassword;
        private Label lblConfirmNewPassword;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private TextBox txtCurrentPassword;
        private Label lblCurrentPassword;
        private Label lblChangePasswordSub;
        private Label lblChangePassword;
        private Panel panel6;
        private TextBox txtProfileAddress;
        private Label lblCusRegAddress;
        private TextBox txtProfilePhone;
        private Label label4;
        private TextBox txtProfileEmail;
        private Label lblCusRegEmail;
        private TextBox txtProfileFullName;
        private Label lblCusRegFullName;
        private Label lblProfileInformationSub;
        private Label lblProfileInformation;
        private Button btnEditProfile;
    }
}