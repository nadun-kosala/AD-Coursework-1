namespace GreenLife_Organic_Store.Forms.Admin
{
    partial class frmAdminReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminReportsForm));
            panel1 = new Panel();
            btnAdminLogout = new Button();
            lblSubHeading = new Label();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnNavigateReports = new Button();
            btnNavigateOrders = new Button();
            btnNavigateCustomers = new Button();
            btnNavigateProducts = new Button();
            btnNavigateDashboard = new Button();
            lblReportsSub = new Label();
            lblReportsHeadings = new Label();
            panel3 = new Panel();
            btnGenerateReport = new Button();
            lblEndDate = new Label();
            dtEndDate = new DateTimePicker();
            lblStartDate = new Label();
            dtStartDate = new DateTimePicker();
            cmbReportType = new ComboBox();
            lblReportType = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnAdminLogout);
            panel1.Controls.Add(lblSubHeading);
            panel1.Controls.Add(lblHeading);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnAdminLogout
            // 
            btnAdminLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdminLogout.AutoSize = true;
            btnAdminLogout.BackColor = SystemColors.ControlLightLight;
            btnAdminLogout.FlatAppearance.BorderColor = Color.LimeGreen;
            btnAdminLogout.FlatAppearance.MouseDownBackColor = Color.Chartreuse;
            btnAdminLogout.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnAdminLogout.FlatStyle = FlatStyle.Flat;
            btnAdminLogout.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLogout.ForeColor = Color.LimeGreen;
            btnAdminLogout.Location = new Point(1527, 43);
            btnAdminLogout.Name = "btnAdminLogout";
            btnAdminLogout.Size = new Size(141, 44);
            btnAdminLogout.TabIndex = 23;
            btnAdminLogout.Text = "Logout";
            btnAdminLogout.UseVisualStyleBackColor = false;
            btnAdminLogout.Click += btnAdminLogout_Click;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(95, 68);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(204, 27);
            lblSubHeading.TabIndex = 22;
            lblSubHeading.Text = "Management Portal";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(86, 21);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(329, 47);
            lblHeading.TabIndex = 21;
            lblHeading.Text = "GreenLife Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(2, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnNavigateReports);
            panel2.Controls.Add(btnNavigateOrders);
            panel2.Controls.Add(btnNavigateCustomers);
            panel2.Controls.Add(btnNavigateProducts);
            panel2.Controls.Add(btnNavigateDashboard);
            panel2.Location = new Point(1, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 665);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnNavigateReports
            // 
            btnNavigateReports.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateReports.AutoSize = true;
            btnNavigateReports.BackColor = Color.DarkGreen;
            btnNavigateReports.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateReports.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateReports.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateReports.FlatStyle = FlatStyle.Flat;
            btnNavigateReports.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateReports.ForeColor = Color.White;
            btnNavigateReports.Location = new Point(25, 316);
            btnNavigateReports.Name = "btnNavigateReports";
            btnNavigateReports.Size = new Size(227, 44);
            btnNavigateReports.TabIndex = 34;
            btnNavigateReports.Text = "Reports";
            btnNavigateReports.UseVisualStyleBackColor = false;
            btnNavigateReports.Click += btnNavigateReports_Click_1;
            // 
            // btnNavigateOrders
            // 
            btnNavigateOrders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateOrders.AutoSize = true;
            btnNavigateOrders.BackColor = Color.DarkGreen;
            btnNavigateOrders.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateOrders.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateOrders.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateOrders.FlatStyle = FlatStyle.Flat;
            btnNavigateOrders.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateOrders.ForeColor = Color.White;
            btnNavigateOrders.Location = new Point(25, 238);
            btnNavigateOrders.Name = "btnNavigateOrders";
            btnNavigateOrders.Size = new Size(227, 44);
            btnNavigateOrders.TabIndex = 33;
            btnNavigateOrders.Text = "Orders";
            btnNavigateOrders.UseVisualStyleBackColor = false;
            btnNavigateOrders.Click += btnNavigateOrders_Click_1;
            // 
            // btnNavigateCustomers
            // 
            btnNavigateCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateCustomers.AutoSize = true;
            btnNavigateCustomers.BackColor = Color.DarkGreen;
            btnNavigateCustomers.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateCustomers.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateCustomers.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateCustomers.FlatStyle = FlatStyle.Flat;
            btnNavigateCustomers.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateCustomers.ForeColor = Color.White;
            btnNavigateCustomers.Location = new Point(25, 165);
            btnNavigateCustomers.Name = "btnNavigateCustomers";
            btnNavigateCustomers.Size = new Size(227, 44);
            btnNavigateCustomers.TabIndex = 32;
            btnNavigateCustomers.Text = "Customers";
            btnNavigateCustomers.UseVisualStyleBackColor = false;
            btnNavigateCustomers.Click += btnNavigateCustomers_Click_1;
            // 
            // btnNavigateProducts
            // 
            btnNavigateProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateProducts.AutoSize = true;
            btnNavigateProducts.BackColor = Color.DarkGreen;
            btnNavigateProducts.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateProducts.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateProducts.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateProducts.FlatStyle = FlatStyle.Flat;
            btnNavigateProducts.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateProducts.ForeColor = Color.White;
            btnNavigateProducts.Location = new Point(25, 92);
            btnNavigateProducts.Name = "btnNavigateProducts";
            btnNavigateProducts.Size = new Size(227, 44);
            btnNavigateProducts.TabIndex = 31;
            btnNavigateProducts.Text = "Products";
            btnNavigateProducts.UseVisualStyleBackColor = false;
            btnNavigateProducts.Click += btnNavigateProducts_Click_1;
            // 
            // btnNavigateDashboard
            // 
            btnNavigateDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateDashboard.AutoSize = true;
            btnNavigateDashboard.BackColor = Color.DarkGreen;
            btnNavigateDashboard.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateDashboard.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateDashboard.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateDashboard.FlatStyle = FlatStyle.Flat;
            btnNavigateDashboard.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateDashboard.ForeColor = Color.White;
            btnNavigateDashboard.Location = new Point(25, 21);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 30;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += btnNavigateDashboard_Click_1;
            // 
            // lblReportsSub
            // 
            lblReportsSub.AutoSize = true;
            lblReportsSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportsSub.ForeColor = Color.LimeGreen;
            lblReportsSub.Location = new Point(306, 187);
            lblReportsSub.Name = "lblReportsSub";
            lblReportsSub.Size = new Size(358, 23);
            lblReportsSub.TabIndex = 17;
            lblReportsSub.Text = "Generate business insights and analytics";
            // 
            // lblReportsHeadings
            // 
            lblReportsHeadings.AutoSize = true;
            lblReportsHeadings.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportsHeadings.ForeColor = Color.ForestGreen;
            lblReportsHeadings.Location = new Point(302, 144);
            lblReportsHeadings.Name = "lblReportsHeadings";
            lblReportsHeadings.Size = new Size(153, 43);
            lblReportsHeadings.TabIndex = 18;
            lblReportsHeadings.Text = "Reports";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(btnGenerateReport);
            panel3.Controls.Add(lblEndDate);
            panel3.Controls.Add(dtEndDate);
            panel3.Controls.Add(lblStartDate);
            panel3.Controls.Add(dtStartDate);
            panel3.Controls.Add(cmbReportType);
            panel3.Controls.Add(lblReportType);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(306, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(1027, 305);
            panel3.TabIndex = 19;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.Green;
            btnGenerateReport.FlatAppearance.BorderColor = Color.Green;
            btnGenerateReport.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnGenerateReport.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnGenerateReport.FlatStyle = FlatStyle.Popup;
            btnGenerateReport.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(20, 194);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(281, 33);
            btnGenerateReport.TabIndex = 22;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.ForeColor = SystemColors.ActiveCaptionText;
            lblEndDate.Location = new Point(657, 79);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(79, 20);
            lblEndDate.TabIndex = 21;
            lblEndDate.Text = "End Date";
            // 
            // dtEndDate
            // 
            dtEndDate.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtEndDate.CalendarMonthBackground = SystemColors.Menu;
            dtEndDate.CalendarTrailingForeColor = SystemColors.Menu;
            dtEndDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtEndDate.Location = new Point(657, 116);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(250, 30);
            dtEndDate.TabIndex = 20;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = SystemColors.ActiveCaptionText;
            lblStartDate.Location = new Point(354, 79);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(87, 20);
            lblStartDate.TabIndex = 19;
            lblStartDate.Text = "Start Date";
            // 
            // dtStartDate
            // 
            dtStartDate.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtStartDate.CalendarMonthBackground = SystemColors.Menu;
            dtStartDate.CalendarTrailingForeColor = SystemColors.Menu;
            dtStartDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtStartDate.Location = new Point(354, 116);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(250, 30);
            dtStartDate.TabIndex = 18;
            // 
            // cmbReportType
            // 
            cmbReportType.BackColor = SystemColors.Menu;
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FlatStyle = FlatStyle.Popup;
            cmbReportType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Sales Report", "Stock Report", "Customer Order History" });
            cmbReportType.Location = new Point(19, 116);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(282, 31);
            cmbReportType.TabIndex = 17;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportType.ForeColor = SystemColors.ActiveCaptionText;
            lblReportType.Location = new Point(19, 79);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(106, 20);
            lblReportType.TabIndex = 16;
            lblReportType.Text = "Report Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(19, 24);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 15;
            label3.Text = "Generate Report";
            // 
            // frmAdminReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1714, 791);
            Controls.Add(panel3);
            Controls.Add(lblReportsSub);
            Controls.Add(lblReportsHeadings);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAdminReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += frmAdminReportsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAdminLogout;
        private Label lblSubHeading;
        private Label lblHeading;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnNavigateReports;
        private Button btnNavigateOrders;
        private Button btnNavigateCustomers;
        private Button btnNavigateProducts;
        private Button btnNavigateDashboard;
        private Label lblReportsSub;
        private Label lblReportsHeadings;
        private Panel panel3;
        private Button btnGenerateReport;
        private Label lblEndDate;
        private DateTimePicker dtEndDate;
        private Label lblStartDate;
        private DateTimePicker dtStartDate;
        private ComboBox cmbReportType;
        private Label lblReportType;
        private Label label3;
    }
}