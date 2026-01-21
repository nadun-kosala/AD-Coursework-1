namespace GreenLife_Organic_Store.Forms.Modals
{
    partial class frmOrderStatusUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderStatusUpdate));
            lblSubHeading = new Label();
            lblHeading = new Label();
            lblOrderCode = new Label();
            lblOrderCodeValue = new Label();
            lblOrderDate = new Label();
            lblFinalAmount = new Label();
            lblOrderDateValue = new Label();
            lblFinalAmountValue = new Label();
            cmbOrderStatus = new ComboBox();
            lblOrderStatus = new Label();
            btnProductCancel = new Button();
            btnUpdateStatus = new Button();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(12, 54);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(252, 20);
            lblSubHeading.TabIndex = 9;
            lblSubHeading.Text = "Update order status for next stage";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(12, 21);
            lblHeading.Name = "lblHeading";
            lblHeading.RightToLeft = RightToLeft.No;
            lblHeading.Size = new Size(191, 33);
            lblHeading.TabIndex = 8;
            lblHeading.Text = "Update Order";
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderCode.ForeColor = SystemColors.ControlText;
            lblOrderCode.Location = new Point(12, 128);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.Size = new Size(124, 23);
            lblOrderCode.TabIndex = 16;
            lblOrderCode.Text = "Order Code :";
            // 
            // lblOrderCodeValue
            // 
            lblOrderCodeValue.AutoSize = true;
            lblOrderCodeValue.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderCodeValue.ForeColor = SystemColors.ControlText;
            lblOrderCodeValue.Location = new Point(197, 128);
            lblOrderCodeValue.Name = "lblOrderCodeValue";
            lblOrderCodeValue.Size = new Size(99, 23);
            lblOrderCodeValue.TabIndex = 17;
            lblOrderCodeValue.Text = "ORD-0001";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDate.ForeColor = SystemColors.ControlText;
            lblOrderDate.Location = new Point(12, 183);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(122, 23);
            lblOrderDate.TabIndex = 18;
            lblOrderDate.Text = "Order Date :";
            // 
            // lblFinalAmount
            // 
            lblFinalAmount.AutoSize = true;
            lblFinalAmount.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalAmount.ForeColor = SystemColors.ControlText;
            lblFinalAmount.Location = new Point(14, 243);
            lblFinalAmount.Name = "lblFinalAmount";
            lblFinalAmount.Size = new Size(143, 23);
            lblFinalAmount.TabIndex = 19;
            lblFinalAmount.Text = "Final Amount :";
            // 
            // lblOrderDateValue
            // 
            lblOrderDateValue.AutoSize = true;
            lblOrderDateValue.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDateValue.ForeColor = SystemColors.ControlText;
            lblOrderDateValue.Location = new Point(197, 183);
            lblOrderDateValue.Name = "lblOrderDateValue";
            lblOrderDateValue.Size = new Size(176, 23);
            lblOrderDateValue.TabIndex = 20;
            lblOrderDateValue.Text = "2/10/2025 2.35AM";
            // 
            // lblFinalAmountValue
            // 
            lblFinalAmountValue.AutoSize = true;
            lblFinalAmountValue.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinalAmountValue.ForeColor = SystemColors.ControlText;
            lblFinalAmountValue.Location = new Point(197, 243);
            lblFinalAmountValue.Name = "lblFinalAmountValue";
            lblFinalAmountValue.Size = new Size(120, 23);
            lblFinalAmountValue.TabIndex = 21;
            lblFinalAmountValue.Text = "LKR 2350.00";
            // 
            // cmbOrderStatus
            // 
            cmbOrderStatus.BackColor = SystemColors.InactiveBorder;
            cmbOrderStatus.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbOrderStatus.FormattingEnabled = true;
            cmbOrderStatus.Items.AddRange(new object[] { "Pending", "Shipped", "Delivered", "Cancelled" });
            cmbOrderStatus.Location = new Point(197, 302);
            cmbOrderStatus.Name = "cmbOrderStatus";
            cmbOrderStatus.Size = new Size(254, 31);
            cmbOrderStatus.TabIndex = 24;
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderStatus.ForeColor = SystemColors.ControlText;
            lblOrderStatus.Location = new Point(14, 302);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(76, 23);
            lblOrderStatus.TabIndex = 23;
            lblOrderStatus.Text = "Status :";
            // 
            // btnProductCancel
            // 
            btnProductCancel.BackColor = SystemColors.ControlLightLight;
            btnProductCancel.FlatAppearance.BorderColor = Color.Lime;
            btnProductCancel.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnProductCancel.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnProductCancel.FlatStyle = FlatStyle.Popup;
            btnProductCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductCancel.ForeColor = SystemColors.ControlText;
            btnProductCancel.Location = new Point(34, 398);
            btnProductCancel.Name = "btnProductCancel";
            btnProductCancel.Size = new Size(166, 43);
            btnProductCancel.TabIndex = 34;
            btnProductCancel.Text = "Cancel";
            btnProductCancel.UseVisualStyleBackColor = false;
            btnProductCancel.Click += btnProductCancel_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.LimeGreen;
            btnUpdateStatus.FlatAppearance.BorderColor = Color.LimeGreen;
            btnUpdateStatus.FlatAppearance.MouseDownBackColor = Color.Green;
            btnUpdateStatus.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(217, 398);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(180, 43);
            btnUpdateStatus.TabIndex = 33;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // frmOrderStatusUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(463, 499);
            Controls.Add(btnProductCancel);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cmbOrderStatus);
            Controls.Add(lblOrderStatus);
            Controls.Add(lblFinalAmountValue);
            Controls.Add(lblOrderDateValue);
            Controls.Add(lblFinalAmount);
            Controls.Add(lblOrderDate);
            Controls.Add(lblOrderCodeValue);
            Controls.Add(lblOrderCode);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmOrderStatusUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Status Update";
            Load += frmOrderStatusUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private Label lblOrderCode;
        private Label lblOrderCodeValue;
        private Label lblOrderDate;
        private Label lblFinalAmount;
        private Label lblOrderDateValue;
        private Label lblFinalAmountValue;
        private ComboBox cmbOrderStatus;
        private Label lblOrderStatus;
        private Button btnProductCancel;
        private Button btnUpdateStatus;
    }
}