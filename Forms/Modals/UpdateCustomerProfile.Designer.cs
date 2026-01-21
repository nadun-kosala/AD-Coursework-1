namespace GreenLife_Organic_Store
{
    partial class frmUpdateCustomerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateCustomerProfile));
            lblSubHeading = new Label();
            lblHeading = new Label();
            txtProfileAddress = new TextBox();
            lblCusRegAddress = new Label();
            txtProfilePhone = new TextBox();
            label4 = new Label();
            txtProfileEmail = new TextBox();
            lblCusRegEmail = new Label();
            txtProfileFullName = new TextBox();
            lblCusRegFullName = new Label();
            btnUpdateProfileConfirm = new Button();
            btnCancelUpdateProfile = new Button();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(16, 55);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(216, 20);
            lblSubHeading.TabIndex = 9;
            lblSubHeading.Text = "Update your personal details";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(12, 20);
            lblHeading.Name = "lblHeading";
            lblHeading.RightToLeft = RightToLeft.No;
            lblHeading.Size = new Size(268, 33);
            lblHeading.TabIndex = 8;
            lblHeading.Text = "Update User Profile";
            // 
            // txtProfileAddress
            // 
            txtProfileAddress.BackColor = SystemColors.InactiveBorder;
            txtProfileAddress.BorderStyle = BorderStyle.FixedSingle;
            txtProfileAddress.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfileAddress.Location = new Point(16, 327);
            txtProfileAddress.Name = "txtProfileAddress";
            txtProfileAddress.PlaceholderText = "123 Green St, City, State 12345";
            txtProfileAddress.Size = new Size(704, 31);
            txtProfileAddress.TabIndex = 39;
            // 
            // lblCusRegAddress
            // 
            lblCusRegAddress.AutoSize = true;
            lblCusRegAddress.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegAddress.ForeColor = Color.ForestGreen;
            lblCusRegAddress.Location = new Point(16, 291);
            lblCusRegAddress.Name = "lblCusRegAddress";
            lblCusRegAddress.Size = new Size(85, 23);
            lblCusRegAddress.TabIndex = 38;
            lblCusRegAddress.Text = "Address";
            // 
            // txtProfilePhone
            // 
            txtProfilePhone.BackColor = SystemColors.InactiveBorder;
            txtProfilePhone.BorderStyle = BorderStyle.FixedSingle;
            txtProfilePhone.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfilePhone.Location = new Point(16, 234);
            txtProfilePhone.Name = "txtProfilePhone";
            txtProfilePhone.PlaceholderText = "+94 77-1234-567";
            txtProfilePhone.Size = new Size(316, 31);
            txtProfilePhone.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(16, 198);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 34;
            label4.Text = "Phone";
            // 
            // txtProfileEmail
            // 
            txtProfileEmail.BackColor = SystemColors.InactiveBorder;
            txtProfileEmail.BorderStyle = BorderStyle.FixedSingle;
            txtProfileEmail.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfileEmail.Location = new Point(404, 142);
            txtProfileEmail.Name = "txtProfileEmail";
            txtProfileEmail.PlaceholderText = "john@example.com";
            txtProfileEmail.Size = new Size(316, 31);
            txtProfileEmail.TabIndex = 33;
            // 
            // lblCusRegEmail
            // 
            lblCusRegEmail.AutoSize = true;
            lblCusRegEmail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegEmail.ForeColor = Color.ForestGreen;
            lblCusRegEmail.Location = new Point(404, 106);
            lblCusRegEmail.Name = "lblCusRegEmail";
            lblCusRegEmail.Size = new Size(63, 23);
            lblCusRegEmail.TabIndex = 32;
            lblCusRegEmail.Text = "Email";
            // 
            // txtProfileFullName
            // 
            txtProfileFullName.BackColor = SystemColors.InactiveBorder;
            txtProfileFullName.BorderStyle = BorderStyle.FixedSingle;
            txtProfileFullName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfileFullName.Location = new Point(16, 142);
            txtProfileFullName.Name = "txtProfileFullName";
            txtProfileFullName.PlaceholderText = "John Doe";
            txtProfileFullName.Size = new Size(316, 31);
            txtProfileFullName.TabIndex = 31;
            // 
            // lblCusRegFullName
            // 
            lblCusRegFullName.AutoSize = true;
            lblCusRegFullName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegFullName.ForeColor = Color.ForestGreen;
            lblCusRegFullName.Location = new Point(16, 106);
            lblCusRegFullName.Name = "lblCusRegFullName";
            lblCusRegFullName.Size = new Size(103, 23);
            lblCusRegFullName.TabIndex = 30;
            lblCusRegFullName.Text = "Full Name";
            // 
            // btnUpdateProfileConfirm
            // 
            btnUpdateProfileConfirm.AutoSize = true;
            btnUpdateProfileConfirm.BackColor = Color.Green;
            btnUpdateProfileConfirm.FlatAppearance.BorderColor = Color.Green;
            btnUpdateProfileConfirm.FlatAppearance.MouseDownBackColor = Color.Green;
            btnUpdateProfileConfirm.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnUpdateProfileConfirm.FlatStyle = FlatStyle.Flat;
            btnUpdateProfileConfirm.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateProfileConfirm.ForeColor = SystemColors.ControlLightLight;
            btnUpdateProfileConfirm.Location = new Point(578, 395);
            btnUpdateProfileConfirm.Name = "btnUpdateProfileConfirm";
            btnUpdateProfileConfirm.Size = new Size(143, 44);
            btnUpdateProfileConfirm.TabIndex = 40;
            btnUpdateProfileConfirm.Text = "Edit Profile";
            btnUpdateProfileConfirm.UseVisualStyleBackColor = false;
            btnUpdateProfileConfirm.Click += btnUpdateProfileConfirm_Click;
            // 
            // btnCancelUpdateProfile
            // 
            btnCancelUpdateProfile.AutoSize = true;
            btnCancelUpdateProfile.BackColor = SystemColors.ControlLightLight;
            btnCancelUpdateProfile.FlatAppearance.BorderColor = Color.LimeGreen;
            btnCancelUpdateProfile.FlatAppearance.MouseDownBackColor = Color.Ivory;
            btnCancelUpdateProfile.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnCancelUpdateProfile.FlatStyle = FlatStyle.Flat;
            btnCancelUpdateProfile.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelUpdateProfile.ForeColor = Color.LimeGreen;
            btnCancelUpdateProfile.Location = new Point(405, 395);
            btnCancelUpdateProfile.Name = "btnCancelUpdateProfile";
            btnCancelUpdateProfile.Size = new Size(143, 44);
            btnCancelUpdateProfile.TabIndex = 41;
            btnCancelUpdateProfile.Text = "Cancel";
            btnCancelUpdateProfile.UseVisualStyleBackColor = false;
            btnCancelUpdateProfile.Click += btnCancelUpdateProfile_Click;
            // 
            // frmUpdateCustomerProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(753, 488);
            Controls.Add(btnCancelUpdateProfile);
            Controls.Add(btnUpdateProfileConfirm);
            Controls.Add(txtProfileAddress);
            Controls.Add(lblCusRegAddress);
            Controls.Add(txtProfilePhone);
            Controls.Add(label4);
            Controls.Add(txtProfileEmail);
            Controls.Add(lblCusRegEmail);
            Controls.Add(txtProfileFullName);
            Controls.Add(lblCusRegFullName);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdateCustomerProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Customer Profile";
            Load += frmUpdateCustomerProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private TextBox txtProfileAddress;
        private Label lblCusRegAddress;
        private TextBox txtProfilePhone;
        private Label label4;
        private TextBox txtProfileEmail;
        private Label lblCusRegEmail;
        private TextBox txtProfileFullName;
        private Label lblCusRegFullName;
        private Button btnUpdateProfileConfirm;
        private Button btnCancelUpdateProfile;
    }
}