namespace GreenLife_Organic_Store.Forms.Modals
{
    partial class frmPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentForm));
            lblSubHeading = new Label();
            lblHeading = new Label();
            txtCardNumber = new TextBox();
            lblProductName = new Label();
            lblExpireYear = new Label();
            dateTimeExpire = new DateTimePicker();
            txtCVV = new TextBox();
            lblCVV = new Label();
            lblShippingAddress = new Label();
            txtShippingAddress = new TextBox();
            lblShippingAddressSub = new Label();
            checkProfileAddress = new CheckBox();
            lblTotalAmount = new Label();
            lblTotalAmountShow = new Label();
            btnCancelPayNow = new Button();
            btnPayNow = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(12, 52);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(279, 20);
            lblSubHeading.TabIndex = 9;
            lblSubHeading.Text = "Enter card details to pocess  payment";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(12, 19);
            lblHeading.Name = "lblHeading";
            lblHeading.RightToLeft = RightToLeft.No;
            lblHeading.Size = new Size(233, 33);
            lblHeading.TabIndex = 8;
            lblHeading.Text = "Process Payment";
            // 
            // txtCardNumber
            // 
            txtCardNumber.BackColor = SystemColors.InactiveBorder;
            txtCardNumber.BorderStyle = BorderStyle.FixedSingle;
            txtCardNumber.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCardNumber.Location = new Point(12, 140);
            txtCardNumber.MaxLength = 16;
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(725, 31);
            txtCardNumber.TabIndex = 17;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = SystemColors.ControlText;
            lblProductName.Location = new Point(12, 104);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(133, 23);
            lblProductName.TabIndex = 16;
            lblProductName.Text = "Card Number";
            // 
            // lblExpireYear
            // 
            lblExpireYear.AutoSize = true;
            lblExpireYear.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpireYear.ForeColor = SystemColors.ControlText;
            lblExpireYear.Location = new Point(12, 193);
            lblExpireYear.Name = "lblExpireYear";
            lblExpireYear.Size = new Size(116, 23);
            lblExpireYear.TabIndex = 18;
            lblExpireYear.Text = "Expire Year";
            // 
            // dateTimeExpire
            // 
            dateTimeExpire.CalendarFont = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeExpire.CustomFormat = "02/25";
            dateTimeExpire.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimeExpire.Format = DateTimePickerFormat.Short;
            dateTimeExpire.Location = new Point(12, 236);
            dateTimeExpire.Name = "dateTimeExpire";
            dateTimeExpire.Size = new Size(459, 31);
            dateTimeExpire.TabIndex = 19;
            // 
            // txtCVV
            // 
            txtCVV.BackColor = SystemColors.InactiveBorder;
            txtCVV.BorderStyle = BorderStyle.FixedSingle;
            txtCVV.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCVV.Location = new Point(500, 236);
            txtCVV.MaxLength = 3;
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(237, 31);
            txtCVV.TabIndex = 21;
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCVV.ForeColor = SystemColors.ControlText;
            lblCVV.Location = new Point(500, 193);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(47, 23);
            lblCVV.TabIndex = 20;
            lblCVV.Text = "CVV";
            // 
            // lblShippingAddress
            // 
            lblShippingAddress.AutoSize = true;
            lblShippingAddress.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShippingAddress.ForeColor = Color.ForestGreen;
            lblShippingAddress.Location = new Point(12, 293);
            lblShippingAddress.Name = "lblShippingAddress";
            lblShippingAddress.RightToLeft = RightToLeft.No;
            lblShippingAddress.Size = new Size(199, 27);
            lblShippingAddress.TabIndex = 22;
            lblShippingAddress.Text = "Shipping Address";
            // 
            // txtShippingAddress
            // 
            txtShippingAddress.BackColor = SystemColors.InactiveBorder;
            txtShippingAddress.BorderStyle = BorderStyle.FixedSingle;
            txtShippingAddress.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtShippingAddress.Location = new Point(12, 379);
            txtShippingAddress.Name = "txtShippingAddress";
            txtShippingAddress.Size = new Size(725, 31);
            txtShippingAddress.TabIndex = 24;
            // 
            // lblShippingAddressSub
            // 
            lblShippingAddressSub.AutoSize = true;
            lblShippingAddressSub.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShippingAddressSub.ForeColor = SystemColors.ControlText;
            lblShippingAddressSub.Location = new Point(12, 343);
            lblShippingAddressSub.Name = "lblShippingAddressSub";
            lblShippingAddressSub.Size = new Size(85, 23);
            lblShippingAddressSub.TabIndex = 23;
            lblShippingAddressSub.Text = "Address";
            // 
            // checkProfileAddress
            // 
            checkProfileAddress.AutoSize = true;
            checkProfileAddress.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkProfileAddress.ForeColor = SystemColors.ControlText;
            checkProfileAddress.Location = new Point(12, 427);
            checkProfileAddress.Name = "checkProfileAddress";
            checkProfileAddress.Size = new Size(369, 27);
            checkProfileAddress.TabIndex = 25;
            checkProfileAddress.Text = "Use deafult profile address for shipping";
            checkProfileAddress.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = SystemColors.ControlDarkDark;
            lblTotalAmount.Location = new Point(421, 500);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.RightToLeft = RightToLeft.No;
            lblTotalAmount.Size = new Size(133, 23);
            lblTotalAmount.TabIndex = 26;
            lblTotalAmount.Text = "Total Amount";
            // 
            // lblTotalAmountShow
            // 
            lblTotalAmountShow.AutoSize = true;
            lblTotalAmountShow.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmountShow.ForeColor = SystemColors.ControlDarkDark;
            lblTotalAmountShow.Location = new Point(591, 500);
            lblTotalAmountShow.Name = "lblTotalAmountShow";
            lblTotalAmountShow.RightToLeft = RightToLeft.Yes;
            lblTotalAmountShow.Size = new Size(146, 23);
            lblTotalAmountShow.TabIndex = 27;
            lblTotalAmountShow.Text = "LKR 20,000.00";
            lblTotalAmountShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelPayNow
            // 
            btnCancelPayNow.BackColor = SystemColors.ControlLightLight;
            btnCancelPayNow.FlatAppearance.BorderColor = Color.Lime;
            btnCancelPayNow.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnCancelPayNow.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnCancelPayNow.FlatStyle = FlatStyle.Popup;
            btnCancelPayNow.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelPayNow.ForeColor = SystemColors.ControlText;
            btnCancelPayNow.Location = new Point(374, 547);
            btnCancelPayNow.Name = "btnCancelPayNow";
            btnCancelPayNow.Size = new Size(166, 43);
            btnCancelPayNow.TabIndex = 34;
            btnCancelPayNow.Text = "Cancel";
            btnCancelPayNow.UseVisualStyleBackColor = false;
            btnCancelPayNow.Click += btnCancelPayNow_Click;
            // 
            // btnPayNow
            // 
            btnPayNow.BackColor = Color.LimeGreen;
            btnPayNow.FlatAppearance.BorderColor = Color.LimeGreen;
            btnPayNow.FlatAppearance.MouseDownBackColor = Color.Green;
            btnPayNow.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnPayNow.FlatStyle = FlatStyle.Flat;
            btnPayNow.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayNow.ForeColor = Color.White;
            btnPayNow.Location = new Point(557, 547);
            btnPayNow.Name = "btnPayNow";
            btnPayNow.Size = new Size(180, 43);
            btnPayNow.TabIndex = 33;
            btnPayNow.Text = "Pay Now";
            btnPayNow.UseVisualStyleBackColor = false;
            btnPayNow.Click += btnPayNow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(90, 349);
            label1.Name = "label1";
            label1.Size = new Size(549, 15);
            label1.TabIndex = 35;
            label1.Text = "(If you use the shipping address as the profile address, tick the button below and leave this empty)";
            // 
            // frmPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(785, 602);
            Controls.Add(label1);
            Controls.Add(btnCancelPayNow);
            Controls.Add(btnPayNow);
            Controls.Add(lblTotalAmountShow);
            Controls.Add(lblTotalAmount);
            Controls.Add(checkProfileAddress);
            Controls.Add(txtShippingAddress);
            Controls.Add(lblShippingAddressSub);
            Controls.Add(lblShippingAddress);
            Controls.Add(txtCVV);
            Controls.Add(lblCVV);
            Controls.Add(dateTimeExpire);
            Controls.Add(lblExpireYear);
            Controls.Add(txtCardNumber);
            Controls.Add(lblProductName);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            ForeColor = SystemColors.ControlLightLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += frmPaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private TextBox txtCardNumber;
        private Label lblProductName;
        private Label lblExpireYear;
        private DateTimePicker dateTimeExpire;
        private TextBox txtCVV;
        private Label lblCVV;
        private Label lblShippingAddress;
        private TextBox txtShippingAddress;
        private Label lblShippingAddressSub;
        private CheckBox checkProfileAddress;
        private Label lblTotalAmount;
        private Label lblTotalAmountShow;
        private Button btnCancelPayNow;
        private Button btnPayNow;
        private Label label1;
    }
}