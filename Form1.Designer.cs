namespace GreenLife_Organic_Store
{
    partial class frmFirst
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirst));
            pictureBox1 = new PictureBox();
            lblHeading = new Label();
            lblSubHeading = new Label();
            tabControl1 = new TabControl();
            tabCustomer = new TabPage();
            btnCustomerRegister = new Button();
            btnCustomerLogin = new Button();
            txtCustomerPassword = new TextBox();
            lblPassword = new Label();
            txtCustomerUsername = new TextBox();
            lblUsername = new Label();
            tabAdmin = new TabPage();
            button2 = new Button();
            txtAdminPassword = new TextBox();
            label1 = new Label();
            txtAdminUsername = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCustomer.SuspendLayout();
            tabAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(249, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(68, 114);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(456, 47);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "GreenLife Organic Store";
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(138, 161);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(305, 27);
            lblSubHeading.TabIndex = 2;
            lblSubHeading.Text = "Freshness delivered naturally";
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabCustomer);
            tabControl1.Controls.Add(tabAdmin);
            tabControl1.Location = new Point(36, 240);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(30, 10);
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(503, 444);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            // 
            // tabCustomer
            // 
            tabCustomer.BackColor = SystemColors.ButtonHighlight;
            tabCustomer.BackgroundImageLayout = ImageLayout.Center;
            tabCustomer.Controls.Add(btnCustomerRegister);
            tabCustomer.Controls.Add(btnCustomerLogin);
            tabCustomer.Controls.Add(txtCustomerPassword);
            tabCustomer.Controls.Add(lblPassword);
            tabCustomer.Controls.Add(txtCustomerUsername);
            tabCustomer.Controls.Add(lblUsername);
            tabCustomer.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabCustomer.ForeColor = Color.LimeGreen;
            tabCustomer.Location = new Point(4, 46);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new Padding(3);
            tabCustomer.Size = new Size(495, 394);
            tabCustomer.TabIndex = 0;
            tabCustomer.Text = "Customer";
            tabCustomer.UseVisualStyleBackColor = true;
            tabCustomer.Click += tabCustomer_Click;
            // 
            // btnCustomerRegister
            // 
            btnCustomerRegister.BackColor = SystemColors.ControlLightLight;
            btnCustomerRegister.ForeColor = Color.LimeGreen;
            btnCustomerRegister.Location = new Point(28, 321);
            btnCustomerRegister.Name = "btnCustomerRegister";
            btnCustomerRegister.Size = new Size(438, 43);
            btnCustomerRegister.TabIndex = 5;
            btnCustomerRegister.Text = "Register New Account";
            btnCustomerRegister.UseVisualStyleBackColor = false;
            // 
            // btnCustomerLogin
            // 
            btnCustomerLogin.BackColor = Color.LimeGreen;
            btnCustomerLogin.ForeColor = Color.White;
            btnCustomerLogin.Location = new Point(28, 263);
            btnCustomerLogin.Name = "btnCustomerLogin";
            btnCustomerLogin.Size = new Size(438, 43);
            btnCustomerLogin.TabIndex = 4;
            btnCustomerLogin.Text = "Login";
            btnCustomerLogin.UseVisualStyleBackColor = false;
            // 
            // txtCustomerPassword
            // 
            txtCustomerPassword.BackColor = SystemColors.InactiveBorder;
            txtCustomerPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerPassword.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerPassword.Location = new Point(28, 180);
            txtCustomerPassword.Name = "txtCustomerPassword";
            txtCustomerPassword.PasswordChar = '*';
            txtCustomerPassword.PlaceholderText = "Enter your password";
            txtCustomerPassword.Size = new Size(438, 31);
            txtCustomerPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.ForestGreen;
            lblPassword.Location = new Point(28, 144);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(99, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtCustomerUsername
            // 
            txtCustomerUsername.BackColor = SystemColors.InactiveBorder;
            txtCustomerUsername.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerUsername.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerUsername.Location = new Point(28, 87);
            txtCustomerUsername.Name = "txtCustomerUsername";
            txtCustomerUsername.PlaceholderText = "Enter your username";
            txtCustomerUsername.Size = new Size(438, 31);
            txtCustomerUsername.TabIndex = 1;
            txtCustomerUsername.TextChanged += textBox1_TextChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.ForestGreen;
            lblUsername.Location = new Point(28, 51);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // tabAdmin
            // 
            tabAdmin.BackColor = SystemColors.ButtonHighlight;
            tabAdmin.Controls.Add(button2);
            tabAdmin.Controls.Add(txtAdminPassword);
            tabAdmin.Controls.Add(label1);
            tabAdmin.Controls.Add(txtAdminUsername);
            tabAdmin.Controls.Add(label2);
            tabAdmin.ForeColor = Color.Lime;
            tabAdmin.Location = new Point(4, 46);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(495, 394);
            tabAdmin.TabIndex = 1;
            tabAdmin.Text = "Admin";
            tabAdmin.UseVisualStyleBackColor = true;
            tabAdmin.Click += tabAdmin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(28, 278);
            button2.Name = "button2";
            button2.Size = new Size(438, 43);
            button2.TabIndex = 10;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.BackColor = SystemColors.InactiveBorder;
            txtAdminPassword.BorderStyle = BorderStyle.FixedSingle;
            txtAdminPassword.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdminPassword.Location = new Point(28, 201);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '*';
            txtAdminPassword.PlaceholderText = "Enter your password";
            txtAdminPassword.Size = new Size(438, 31);
            txtAdminPassword.TabIndex = 9;
            txtAdminPassword.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(28, 165);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 8;
            label1.Text = "Password";
            // 
            // txtAdminUsername
            // 
            txtAdminUsername.BackColor = SystemColors.InactiveBorder;
            txtAdminUsername.BorderStyle = BorderStyle.FixedSingle;
            txtAdminUsername.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdminUsername.Location = new Point(28, 108);
            txtAdminUsername.Name = "txtAdminUsername";
            txtAdminUsername.PlaceholderText = "Enter your username";
            txtAdminUsername.Size = new Size(438, 31);
            txtAdminUsername.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(28, 72);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // frmFirst
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(600, 727);
            Controls.Add(tabControl1);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Controls.Add(pictureBox1);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmFirst";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GreenLife Organic Store";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCustomer.ResumeLayout(false);
            tabCustomer.PerformLayout();
            tabAdmin.ResumeLayout(false);
            tabAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeading;
        private Label lblSubHeading;
        private TabControl tabControl1;
        private TabPage tabCustomer;
        private TabPage tabAdmin;
        private TextBox txtCustomerUsername;
        private Label lblUsername;
        private TextBox txtCustomerPassword;
        private Label lblPassword;
        private Button btnCustomerLogin;
        private Button btnCustomerRegister;
        private Button button2;
        private TextBox txtAdminPassword;
        private Label label1;
        private TextBox txtAdminUsername;
        private Label label2;
    }
}
