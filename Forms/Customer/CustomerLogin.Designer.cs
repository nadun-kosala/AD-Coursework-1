namespace GreenLife_Organic_Store.Forms.Customer
{
    partial class frmCustomerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerLogin));
            lblSubHeading = new Label();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            btnSwitchAdmin = new Button();
            btnSwitchCustomer = new Button();
            btnCustomerRegister = new Button();
            btnCustomerLogin = new Button();
            txtCustomerPassword = new TextBox();
            lblPassword = new Label();
            txtCustomerUsername = new TextBox();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(97, 133);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(305, 27);
            lblSubHeading.TabIndex = 8;
            lblSubHeading.Text = "Freshness delivered naturally";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(27, 86);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(456, 47);
            lblHeading.TabIndex = 7;
            lblHeading.Text = "GreenLife Organic Store";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(208, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnSwitchAdmin
            // 
            btnSwitchAdmin.BackColor = Color.Green;
            btnSwitchAdmin.FlatAppearance.BorderColor = Color.Green;
            btnSwitchAdmin.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnSwitchAdmin.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnSwitchAdmin.FlatStyle = FlatStyle.Flat;
            btnSwitchAdmin.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSwitchAdmin.ForeColor = Color.White;
            btnSwitchAdmin.Location = new Point(250, 188);
            btnSwitchAdmin.Name = "btnSwitchAdmin";
            btnSwitchAdmin.Size = new Size(171, 43);
            btnSwitchAdmin.TabIndex = 10;
            btnSwitchAdmin.Text = "Admin";
            btnSwitchAdmin.UseVisualStyleBackColor = false;
            btnSwitchAdmin.Click += btnSwitchAdmin_Click;
            // 
            // btnSwitchCustomer
            // 
            btnSwitchCustomer.BackColor = Color.Green;
            btnSwitchCustomer.FlatAppearance.BorderColor = Color.Green;
            btnSwitchCustomer.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnSwitchCustomer.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnSwitchCustomer.FlatStyle = FlatStyle.Flat;
            btnSwitchCustomer.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSwitchCustomer.ForeColor = Color.White;
            btnSwitchCustomer.Location = new Point(63, 188);
            btnSwitchCustomer.Name = "btnSwitchCustomer";
            btnSwitchCustomer.Size = new Size(171, 43);
            btnSwitchCustomer.TabIndex = 9;
            btnSwitchCustomer.Text = "Customer";
            btnSwitchCustomer.UseVisualStyleBackColor = false;
            btnSwitchCustomer.Click += btnSwitchCustomer_Click;
            // 
            // btnCustomerRegister
            // 
            btnCustomerRegister.BackColor = SystemColors.ControlLightLight;
            btnCustomerRegister.FlatAppearance.BorderColor = Color.LimeGreen;
            btnCustomerRegister.FlatAppearance.MouseDownBackColor = Color.Ivory;
            btnCustomerRegister.FlatAppearance.MouseOverBackColor = Color.LightYellow;
            btnCustomerRegister.FlatStyle = FlatStyle.Flat;
            btnCustomerRegister.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerRegister.ForeColor = Color.LimeGreen;
            btnCustomerRegister.Location = new Point(27, 522);
            btnCustomerRegister.Name = "btnCustomerRegister";
            btnCustomerRegister.Size = new Size(438, 43);
            btnCustomerRegister.TabIndex = 16;
            btnCustomerRegister.Text = "Register New Account";
            btnCustomerRegister.UseVisualStyleBackColor = false;
            btnCustomerRegister.Click += btnCustomerRegister_Click;
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.BackColor = Color.Green;
            btnCustomerLogin.FlatAppearance.BorderColor = Color.Green;
            btnCustomerLogin.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnCustomerLogin.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnCustomerLogin.FlatStyle = FlatStyle.Flat;
            btnCustomerLogin.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerLogin.ForeColor = Color.White;
            btnCustomerLogin.Location = new Point(27, 464);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.Size = new Size(438, 43);
            btnCustomerLogin.TabIndex = 15;
            btnCustomerLogin.Text = "Login";
            btnCustomerLogin.UseVisualStyleBackColor = false;
            btnCustomerLogin.Click += btnCustomerLogin_Click;
            // 
            // txtCustomerPassword
            // 
            txtCustomerPassword.BackColor = SystemColors.InactiveBorder;
            txtCustomerPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerPassword.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerPassword.Location = new Point(27, 393);
            txtCustomerPassword.Name = "txtCustomerPassword";
            txtCustomerPassword.PasswordChar = '*';
            txtCustomerPassword.PlaceholderText = "Enter your password";
            txtCustomerPassword.Size = new Size(438, 31);
            txtCustomerPassword.TabIndex = 14;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.ForestGreen;
            lblPassword.Location = new Point(27, 357);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(99, 23);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // txtCustomerUsername
            // 
            txtCustomerUsername.BackColor = SystemColors.InactiveBorder;
            txtCustomerUsername.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerUsername.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerUsername.Location = new Point(27, 300);
            txtCustomerUsername.Name = "txtCustomerUsername";
            txtCustomerUsername.PlaceholderText = "Enter your username";
            txtCustomerUsername.Size = new Size(438, 31);
            txtCustomerUsername.TabIndex = 12;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.DarkGreen;
            lblUsername.Location = new Point(27, 264);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 23);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Username";
            // 
            // frmCustomerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(512, 607);
            Controls.Add(btnCustomerRegister);
            Controls.Add(btnCustomerLogin);
            Controls.Add(txtCustomerPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtCustomerUsername);
            Controls.Add(lblUsername);
            Controls.Add(btnSwitchAdmin);
            Controls.Add(btnSwitchCustomer);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCustomerLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Login";
            Load += frmCustomerLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private PictureBox pictureBox1;
        private Button btnSwitchAdmin;
        private Button btnSwitchCustomer;
        private Button btnCustomerRegister;
        private Button btnCustomerLogin;
        private TextBox txtCustomerPassword;
        private Label lblPassword;
        private TextBox txtCustomerUsername;
        private Label lblUsername;
    }
}