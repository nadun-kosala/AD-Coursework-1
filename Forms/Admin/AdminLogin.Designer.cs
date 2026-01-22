namespace GreenLife_Organic_Store.Forms.Admin
{
    partial class frmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLogin));
            lblSubHeading = new Label();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            btnSwitchCustomer = new Button();
            btnSwitchAdmin = new Button();
            btnAdminLogin = new Button();
            txtAdminPassword = new TextBox();
            label1 = new Label();
            txtAdminUsername = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(117, 133);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(305, 27);
            lblSubHeading.TabIndex = 5;
            lblSubHeading.Text = "Freshness delivered naturally";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(47, 86);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(456, 47);
            lblHeading.TabIndex = 4;
            lblHeading.Text = "GreenLife Organic Store";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(228, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            btnSwitchCustomer.Location = new Point(83, 204);
            btnSwitchCustomer.Name = "btnSwitchCustomer";
            btnSwitchCustomer.Size = new Size(171, 43);
            btnSwitchCustomer.TabIndex = 6;
            btnSwitchCustomer.Text = "Customer";
            btnSwitchCustomer.UseVisualStyleBackColor = false;
            btnSwitchCustomer.Click += btnSwitchCustomer_Click;
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
            btnSwitchAdmin.Location = new Point(270, 204);
            btnSwitchAdmin.Name = "btnSwitchAdmin";
            btnSwitchAdmin.Size = new Size(171, 43);
            btnSwitchAdmin.TabIndex = 7;
            btnSwitchAdmin.Text = "Admin";
            btnSwitchAdmin.UseVisualStyleBackColor = false;
            btnSwitchAdmin.Click += btnSwitchAdmin_Click;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.Green;
            btnAdminLogin.FlatAppearance.BorderColor = Color.Green;
            btnAdminLogin.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnAdminLogin.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(47, 503);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(438, 43);
            btnAdminLogin.TabIndex = 15;
            btnAdminLogin.Text = "Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.BackColor = SystemColors.InactiveBorder;
            txtAdminPassword.BorderStyle = BorderStyle.FixedSingle;
            txtAdminPassword.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdminPassword.Location = new Point(47, 434);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '*';
            txtAdminPassword.PlaceholderText = "Enter your password";
            txtAdminPassword.Size = new Size(438, 31);
            txtAdminPassword.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(47, 398);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 13;
            label1.Text = "Password";
            // 
            // txtAdminUsername
            // 
            txtAdminUsername.BackColor = SystemColors.InactiveBorder;
            txtAdminUsername.BorderStyle = BorderStyle.FixedSingle;
            txtAdminUsername.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdminUsername.Location = new Point(47, 341);
            txtAdminUsername.Name = "txtAdminUsername";
            txtAdminUsername.PlaceholderText = "Enter your username";
            txtAdminUsername.Size = new Size(438, 31);
            txtAdminUsername.TabIndex = 12;
            txtAdminUsername.TextChanged += txtAdminUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(47, 305);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 11;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // frmAdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(555, 606);
            Controls.Add(btnAdminLogin);
            Controls.Add(txtAdminPassword);
            Controls.Add(label1);
            Controls.Add(txtAdminUsername);
            Controls.Add(label2);
            Controls.Add(btnSwitchAdmin);
            Controls.Add(btnSwitchCustomer);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            Load += frmAdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private PictureBox pictureBox1;
        private Button btnSwitchCustomer;
        private Button btnSwitchAdmin;
        private Button btnAdminLogin;
        private TextBox txtAdminPassword;
        private Label label1;
        private TextBox txtAdminUsername;
        private Label label2;
    }
}