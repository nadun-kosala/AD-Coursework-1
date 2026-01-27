namespace GreenLife_Organic_Store.Forms.Modals
{
    partial class frmSelectCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectCustomer));
            cmbCustomersList = new ComboBox();
            lblCusRegEmail = new Label();
            btnGenerateCustomerReport = new Button();
            SuspendLayout();
            // 
            // cmbCustomersList
            // 
            cmbCustomersList.BackColor = SystemColors.InactiveBorder;
            cmbCustomersList.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCustomersList.FormattingEnabled = true;
            cmbCustomersList.Items.AddRange(new object[] { "Fruits", "Vegitable", "Grains", "Dairy", "Dairy Alternatives", "Sweeteners" });
            cmbCustomersList.Location = new Point(12, 62);
            cmbCustomersList.Name = "cmbCustomersList";
            cmbCustomersList.Size = new Size(514, 31);
            cmbCustomersList.TabIndex = 24;
            // 
            // lblCusRegEmail
            // 
            lblCusRegEmail.AutoSize = true;
            lblCusRegEmail.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCusRegEmail.ForeColor = SystemColors.ControlText;
            lblCusRegEmail.Location = new Point(12, 26);
            lblCusRegEmail.Name = "lblCusRegEmail";
            lblCusRegEmail.Size = new Size(212, 23);
            lblCusRegEmail.TabIndex = 23;
            lblCusRegEmail.Text = "Select Customer name";
            // 
            // btnGenerateCustomerReport
            // 
            btnGenerateCustomerReport.BackColor = Color.Green;
            btnGenerateCustomerReport.FlatAppearance.BorderColor = Color.Green;
            btnGenerateCustomerReport.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnGenerateCustomerReport.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnGenerateCustomerReport.FlatStyle = FlatStyle.Flat;
            btnGenerateCustomerReport.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateCustomerReport.ForeColor = Color.White;
            btnGenerateCustomerReport.Location = new Point(346, 122);
            btnGenerateCustomerReport.Name = "btnGenerateCustomerReport";
            btnGenerateCustomerReport.Size = new Size(180, 43);
            btnGenerateCustomerReport.TabIndex = 32;
            btnGenerateCustomerReport.Text = "Generate";
            btnGenerateCustomerReport.UseVisualStyleBackColor = false;
            btnGenerateCustomerReport.Click += btnGenerateCustomerReport_Click;
            // 
            // frmSelectCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(545, 193);
            Controls.Add(btnGenerateCustomerReport);
            Controls.Add(cmbCustomersList);
            Controls.Add(lblCusRegEmail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "frmSelectCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Customer";
            Load += frmSelectCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCustomersList;
        private Label lblCusRegEmail;
        private Button btnGenerateCustomerReport;
    }
}