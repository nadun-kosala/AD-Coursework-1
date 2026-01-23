namespace GreenLife_Organic_Store.Forms.Modals
{
    partial class frmViewOrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewOrderDetails));
            lblOrderDate = new Label();
            lblOrderCode = new Label();
            lblOrderStatusHeading = new Label();
            flowLayoutOrderDetails = new FlowLayoutPanel();
            btnGiveReview = new Button();
            lblOrderStatus = new Label();
            SuspendLayout();
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderDate.ForeColor = Color.DarkOliveGreen;
            lblOrderDate.Location = new Point(12, 42);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(252, 23);
            lblOrderDate.TabIndex = 11;
            lblOrderDate.Text = "Order placed on 2026-01-10";
            // 
            // lblOrderCode
            // 
            lblOrderCode.AutoSize = true;
            lblOrderCode.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderCode.ForeColor = Color.ForestGreen;
            lblOrderCode.Location = new Point(12, 9);
            lblOrderCode.Name = "lblOrderCode";
            lblOrderCode.RightToLeft = RightToLeft.No;
            lblOrderCode.Size = new Size(319, 33);
            lblOrderCode.TabIndex = 10;
            lblOrderCode.Text = "Order Details - ORD001";
            // 
            // lblOrderStatusHeading
            // 
            lblOrderStatusHeading.AutoSize = true;
            lblOrderStatusHeading.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderStatusHeading.ForeColor = Color.DarkSlateGray;
            lblOrderStatusHeading.Location = new Point(12, 87);
            lblOrderStatusHeading.Name = "lblOrderStatusHeading";
            lblOrderStatusHeading.Size = new Size(118, 23);
            lblOrderStatusHeading.TabIndex = 12;
            lblOrderStatusHeading.Text = "Order Status";
            // 
            // flowLayoutOrderDetails
            // 
            flowLayoutOrderDetails.AutoScroll = true;
            flowLayoutOrderDetails.FlowDirection = FlowDirection.TopDown;
            flowLayoutOrderDetails.Location = new Point(12, 191);
            flowLayoutOrderDetails.Name = "flowLayoutOrderDetails";
            flowLayoutOrderDetails.Padding = new Padding(10);
            flowLayoutOrderDetails.Size = new Size(540, 409);
            flowLayoutOrderDetails.TabIndex = 14;
            flowLayoutOrderDetails.WrapContents = false;
            // 
            // btnGiveReview
            // 
            btnGiveReview.BackColor = Color.Green;
            btnGiveReview.FlatAppearance.BorderColor = Color.Green;
            btnGiveReview.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnGiveReview.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnGiveReview.FlatStyle = FlatStyle.Flat;
            btnGiveReview.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGiveReview.ForeColor = SystemColors.ControlLightLight;
            btnGiveReview.Location = new Point(372, 119);
            btnGiveReview.Name = "btnGiveReview";
            btnGiveReview.Size = new Size(180, 34);
            btnGiveReview.TabIndex = 15;
            btnGiveReview.Text = "Give Review";
            btnGiveReview.UseVisualStyleBackColor = false;
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderStatus.ForeColor = Color.DarkSlateGray;
            lblOrderStatus.Location = new Point(12, 119);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(125, 23);
            lblOrderStatus.TabIndex = 16;
            lblOrderStatus.Text = "Order Status";
            // 
            // frmViewOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(564, 611);
            Controls.Add(lblOrderStatus);
            Controls.Add(btnGiveReview);
            Controls.Add(flowLayoutOrderDetails);
            Controls.Add(lblOrderStatusHeading);
            Controls.Add(lblOrderDate);
            Controls.Add(lblOrderCode);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmViewOrderDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Order Details";
            Load += frmViewOrderDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderDate;
        private Label lblOrderCode;
        private Label lblOrderStatusHeading;
        private FlowLayoutPanel flowLayoutOrderDetails;
        private Button btnGiveReview;
        private Label lblOrderStatus;
    }
}