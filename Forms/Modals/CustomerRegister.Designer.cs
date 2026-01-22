namespace GreenLife_Organic_Store
{
    partial class frmCustomerRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRegister));
            lblSubHeading = new Label();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            txtCusRegFullName = new TextBox();
            lblCusRegFullName = new Label();
            txtCusRegEmail = new TextBox();
            lblCusRegEmail = new Label();
            txtCusRegUsername = new TextBox();
            lblCusRegUsername = new Label();
            txtCusRegPhone = new TextBox();
            label2 = new Label();
            txtCusRegAddress = new TextBox();
            lblCusRegAddress = new Label();
            txtCusRegConfirmPassword = new TextBox();
            lblCusRegConfirmPassword = new Label();
            txtCusRegPassword = new TextBox();
            lblCusRegPasswod = new Label();
            btnCusRegBackToLogin = new Button();
            btnCusRegRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(222, 136);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(359, 27);
            lblSubHeading.TabIndex = 5;
            lblSubHeading.Text = "Join GreenLife for organic goodness";
            lblSubHeading.Click += lblSubHeading_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(207, 89);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(389, 47);
            lblHeading.TabIndex = 4;
            lblHeading.Text = "Create Your Account";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(363, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtCusRegFullName
            // 
            txtCusRegFullName.BackColor = SystemColors.InactiveBorder;
            txtCusRegFullName.BorderStyle = BorderStyle.FixedSingle;
            txtCusRegFullName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusRegFullName.Location = new Point(61, 255);
            txtCusRegFullName.Name = "txtCusRegFullName";
            txtCusRegFullName.PlaceholderText = "John Doe";
            txtCusRegFullName.Size = new Size(320, 31);
            txtCusRegFullName.TabIndex = 7;
            // 
            // lblCusRegFullName
            // 
            lblCusRegFullName.AutoSize = true;
            lblCusRegFullName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegFullName.ForeColor = Color.DarkGreen;
            lblCusRegFullName.Location = new Point(61, 219);
            lblCusRegFullName.Name = "lblCusRegFullName";
            lblCusRegFullName.Size = new Size(116, 23);
            lblCusRegFullName.TabIndex = 6;
            lblCusRegFullName.Text = "Full Name *";
            // 
            // txtCusRegEmail
            // 
            txtCusRegEmail.BackColor = SystemColors.InactiveBorder;
            txtCusRegEmail.BorderStyle = BorderStyle.FixedSingle;
            txtCusRegEmail.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusRegEmail.Location = new Point(436, 255);
            txtCusRegEmail.Name = "txtCusRegEmail";
            txtCusRegEmail.PlaceholderText = "john@example.com";
            txtCusRegEmail.Size = new Size(320, 31);
            txtCusRegEmail.TabIndex = 9;
            // 
            // lblCusRegEmail
            // 
            lblCusRegEmail.AutoSize = true;
            lblCusRegEmail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegEmail.ForeColor = Color.DarkGreen;
            lblCusRegEmail.Location = new Point(436, 219);
            lblCusRegEmail.Name = "lblCusRegEmail";
            lblCusRegEmail.Size = new Size(76, 23);
            lblCusRegEmail.TabIndex = 8;
            lblCusRegEmail.Text = "Email *";
            // 
            // txtCusRegUsername
            // 
            txtCusRegUsername.BackColor = SystemColors.InactiveBorder;
            txtCusRegUsername.BorderStyle = BorderStyle.FixedSingle;
            txtCusRegUsername.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusRegUsername.Location = new Point(436, 347);
            txtCusRegUsername.Name = "txtCusRegUsername";
            txtCusRegUsername.PlaceholderText = "johndoe";
            txtCusRegUsername.Size = new Size(320, 31);
            txtCusRegUsername.TabIndex = 13;
            // 
            // lblCusRegUsername
            // 
            lblCusRegUsername.AutoSize = true;
            lblCusRegUsername.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegUsername.ForeColor = Color.DarkGreen;
            lblCusRegUsername.Location = new Point(436, 311);
            lblCusRegUsername.Name = "lblCusRegUsername";
            lblCusRegUsername.Size = new Size(118, 23);
            lblCusRegUsername.TabIndex = 12;
            lblCusRegUsername.Text = "Username *";
            // 
            // txtCusRegPhone
            // 
            txtCusRegPhone.BackColor = SystemColors.InactiveBorder;
            txtCusRegPhone.BorderStyle = BorderStyle.FixedSingle;
            txtCusRegPhone.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusRegPhone.Location = new Point(61, 347);
            txtCusRegPhone.Name = "txtCusRegPhone";
            txtCusRegPhone.PlaceholderText = "+94 77-1234-567";
            txtCusRegPhone.Size = new Size(320, 31);
            txtCusRegPhone.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(61, 311);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 10;
            label2.Text = "Phone *";
            // 
            // txtCusRegAddress
            // 
            txtCusRegAddress.BackColor = SystemColors.InactiveBorder;
            txtCusRegAddress.BorderStyle = BorderStyle.FixedSingle;
            txtCusRegAddress.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusRegAddress.Location = new Point(61, 440);
            txtCusRegAddress.Name = "txtCusRegAddress";
            txtCusRegAddress.PlaceholderText = "123 Green St, City, State 12345";
            txtCusRegAddress.Size = new Size(695, 31);
            txtCusRegAddress.TabIndex = 15;
            // 
            // lblCusRegAddress
            // 
            lblCusRegAddress.AutoSize = true;
            lblCusRegAddress.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegAddress.ForeColor = Color.DarkGreen;
            lblCusRegAddress.Location = new Point(61, 404);
            lblCusRegAddress.Name = "lblCusRegAddress";
            lblCusRegAddress.Size = new Size(98, 23);
            lblCusRegAddress.TabIndex = 14;
            lblCusRegAddress.Text = "Address *";
            // 
            // txtCusRegConfirmPassword
            // 
            txtCusRegConfirmPassword.BackColor = SystemColors.InactiveBorder;
            txtCusRegConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCusRegConfirmPassword.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusRegConfirmPassword.Location = new Point(436, 535);
            txtCusRegConfirmPassword.Name = "txtCusRegConfirmPassword";
            txtCusRegConfirmPassword.PasswordChar = '*';
            txtCusRegConfirmPassword.PlaceholderText = "Re-enter password";
            txtCusRegConfirmPassword.Size = new Size(320, 31);
            txtCusRegConfirmPassword.TabIndex = 19;
            // 
            // lblCusRegConfirmPassword
            // 
            lblCusRegConfirmPassword.AutoSize = true;
            lblCusRegConfirmPassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegConfirmPassword.ForeColor = Color.DarkGreen;
            lblCusRegConfirmPassword.Location = new Point(436, 499);
            lblCusRegConfirmPassword.Name = "lblCusRegConfirmPassword";
            lblCusRegConfirmPassword.Size = new Size(190, 23);
            lblCusRegConfirmPassword.TabIndex = 18;
            lblCusRegConfirmPassword.Text = "Confirm Password *";
            // 
            // txtCusRegPassword
            // 
            txtCusRegPassword.BackColor = SystemColors.InactiveBorder;
            txtCusRegPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCusRegPassword.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusRegPassword.Location = new Point(61, 535);
            txtCusRegPassword.Name = "txtCusRegPassword";
            txtCusRegPassword.PasswordChar = '*';
            txtCusRegPassword.PlaceholderText = "Min. 6 characters";
            txtCusRegPassword.Size = new Size(320, 31);
            txtCusRegPassword.TabIndex = 17;
            // 
            // lblCusRegPasswod
            // 
            lblCusRegPasswod.AutoSize = true;
            lblCusRegPasswod.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegPasswod.ForeColor = Color.DarkGreen;
            lblCusRegPasswod.Location = new Point(61, 499);
            lblCusRegPasswod.Name = "lblCusRegPasswod";
            lblCusRegPasswod.Size = new Size(112, 23);
            lblCusRegPasswod.TabIndex = 16;
            lblCusRegPasswod.Text = "Password *";
            // 
            // btnCusRegBackToLogin
            // 
            btnCusRegBackToLogin.BackColor = SystemColors.ControlLightLight;
            btnCusRegBackToLogin.FlatAppearance.BorderColor = Color.LimeGreen;
            btnCusRegBackToLogin.FlatAppearance.BorderSize = 2;
            btnCusRegBackToLogin.FlatAppearance.MouseDownBackColor = Color.Ivory;
            btnCusRegBackToLogin.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            btnCusRegBackToLogin.FlatStyle = FlatStyle.Flat;
            btnCusRegBackToLogin.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCusRegBackToLogin.ForeColor = Color.LimeGreen;
            btnCusRegBackToLogin.Location = new Point(61, 659);
            btnCusRegBackToLogin.Name = "btnCusRegBackToLogin";
            btnCusRegBackToLogin.Size = new Size(695, 43);
            btnCusRegBackToLogin.TabIndex = 21;
            btnCusRegBackToLogin.Text = " Back to Login";
            btnCusRegBackToLogin.UseVisualStyleBackColor = false;
            btnCusRegBackToLogin.Click += btnCusRegBackToLogin_Click;
            // 
            // btnCusRegRegister
            // 
            btnCusRegRegister.BackColor = Color.Green;
            btnCusRegRegister.FlatAppearance.BorderColor = Color.Green;
            btnCusRegRegister.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnCusRegRegister.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnCusRegRegister.FlatStyle = FlatStyle.Flat;
            btnCusRegRegister.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCusRegRegister.ForeColor = Color.White;
            btnCusRegRegister.Location = new Point(61, 597);
            btnCusRegRegister.Name = "btnCusRegRegister";
            btnCusRegRegister.Size = new Size(695, 43);
            btnCusRegRegister.TabIndex = 20;
            btnCusRegRegister.Text = "Register";
            btnCusRegRegister.UseVisualStyleBackColor = false;
            btnCusRegRegister.Click += btnCusRegRegister_Click;
            // 
            // frmCustomerRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(829, 730);
            Controls.Add(btnCusRegBackToLogin);
            Controls.Add(btnCusRegRegister);
            Controls.Add(txtCusRegConfirmPassword);
            Controls.Add(lblCusRegConfirmPassword);
            Controls.Add(txtCusRegPassword);
            Controls.Add(lblCusRegPasswod);
            Controls.Add(txtCusRegAddress);
            Controls.Add(lblCusRegAddress);
            Controls.Add(txtCusRegUsername);
            Controls.Add(lblCusRegUsername);
            Controls.Add(txtCusRegPhone);
            Controls.Add(label2);
            Controls.Add(txtCusRegEmail);
            Controls.Add(lblCusRegEmail);
            Controls.Add(txtCusRegFullName);
            Controls.Add(lblCusRegFullName);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCustomerRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Register";
            Load += frmCustomerRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private PictureBox pictureBox1;
        private TextBox txtCusRegFullName;
        private Label lblCusRegFullName;
        private TextBox txtCusRegEmail;
        private Label lblCusRegEmail;
        private TextBox txtCusRegUsername;
        private Label lblCusRegUsername;
        private TextBox txtCusRegPhone;
        private Label label2;
        private TextBox txtCusRegAddress;
        private Label lblCusRegAddress;
        private TextBox txtCusRegConfirmPassword;
        private Label lblCusRegConfirmPassword;
        private TextBox txtCusRegPassword;
        private Label lblCusRegPasswod;
        private Button btnCusRegBackToLogin;
        private Button btnCusRegRegister;
    }
}