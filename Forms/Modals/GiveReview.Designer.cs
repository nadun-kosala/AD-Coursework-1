namespace GreenLife_Organic_Store.Forms.Modals
{
    partial class frmGiveReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiveReview));
            lblSubHeading = new Label();
            lblHeading = new Label();
            cmbProductName = new ComboBox();
            lblProductName = new Label();
            cmbRating = new ComboBox();
            lblRating = new Label();
            lblDescription = new Label();
            txtReview = new RichTextBox();
            btnReviewCancel = new Button();
            btnAddReview = new Button();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(12, 42);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(314, 20);
            lblSubHeading.TabIndex = 9;
            lblSubHeading.Text = "Enter the product quality to inform others";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(12, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.RightToLeft = RightToLeft.No;
            lblHeading.Size = new Size(171, 33);
            lblHeading.TabIndex = 8;
            lblHeading.Text = "Review Now";
            // 
            // cmbProductName
            // 
            cmbProductName.BackColor = SystemColors.InactiveBorder;
            cmbProductName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProductName.FormattingEnabled = true;
            cmbProductName.Location = new Point(22, 141);
            cmbProductName.Name = "cmbProductName";
            cmbProductName.Size = new Size(600, 31);
            cmbProductName.TabIndex = 36;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = SystemColors.ControlText;
            lblProductName.Location = new Point(22, 105);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(82, 23);
            lblProductName.TabIndex = 35;
            lblProductName.Text = "Product";
            // 
            // cmbRating
            // 
            cmbRating.BackColor = SystemColors.InactiveBorder;
            cmbRating.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRating.FormattingEnabled = true;
            cmbRating.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbRating.Location = new Point(22, 235);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(600, 31);
            cmbRating.TabIndex = 38;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRating.ForeColor = SystemColors.ControlText;
            lblRating.Location = new Point(22, 199);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(69, 23);
            lblRating.TabIndex = 37;
            lblRating.Text = "Rating";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.ControlText;
            lblDescription.Location = new Point(22, 296);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(144, 23);
            lblDescription.TabIndex = 39;
            lblDescription.Text = "Write a review";
            // 
            // txtReview
            // 
            txtReview.BackColor = SystemColors.InactiveBorder;
            txtReview.BorderStyle = BorderStyle.FixedSingle;
            txtReview.Cursor = Cursors.Cross;
            txtReview.Location = new Point(22, 340);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(600, 120);
            txtReview.TabIndex = 40;
            txtReview.Text = "";
            // 
            // btnReviewCancel
            // 
            btnReviewCancel.BackColor = SystemColors.ControlLightLight;
            btnReviewCancel.FlatAppearance.BorderColor = Color.Lime;
            btnReviewCancel.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnReviewCancel.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnReviewCancel.FlatStyle = FlatStyle.Popup;
            btnReviewCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReviewCancel.ForeColor = SystemColors.ControlText;
            btnReviewCancel.Location = new Point(259, 490);
            btnReviewCancel.Name = "btnReviewCancel";
            btnReviewCancel.Size = new Size(166, 43);
            btnReviewCancel.TabIndex = 42;
            btnReviewCancel.Text = "Cancel";
            btnReviewCancel.UseVisualStyleBackColor = false;
            btnReviewCancel.Click += btnReviewCancel_Click;
            // 
            // btnAddReview
            // 
            btnAddReview.BackColor = Color.LimeGreen;
            btnAddReview.FlatAppearance.BorderColor = Color.LimeGreen;
            btnAddReview.FlatAppearance.MouseDownBackColor = Color.Green;
            btnAddReview.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnAddReview.FlatStyle = FlatStyle.Flat;
            btnAddReview.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddReview.ForeColor = Color.White;
            btnAddReview.Location = new Point(442, 490);
            btnAddReview.Name = "btnAddReview";
            btnAddReview.Size = new Size(180, 43);
            btnAddReview.TabIndex = 41;
            btnAddReview.Text = "Add Review";
            btnAddReview.UseVisualStyleBackColor = false;
            btnAddReview.Click += btnAddReview_Click;
            // 
            // frmGiveReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(665, 558);
            Controls.Add(btnReviewCancel);
            Controls.Add(btnAddReview);
            Controls.Add(txtReview);
            Controls.Add(lblDescription);
            Controls.Add(cmbRating);
            Controls.Add(lblRating);
            Controls.Add(cmbProductName);
            Controls.Add(lblProductName);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmGiveReview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Give Review";
            Load += frmGiveReview_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private ComboBox cmbProductName;
        private Label lblProductName;
        private ComboBox cmbRating;
        private Label lblRating;
        private Label lblDescription;
        private RichTextBox txtReview;
        private Button btnReviewCancel;
        private Button btnAddReview;
    }
}