namespace GreenLife_Organic_Store.Forms.Admin
{
    partial class frmAdminCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCustomerForm));
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
            lblMangeCustomersSub = new Label();
            lblManageCustomersHeading = new Label();
            panel3 = new Panel();
            btnCustomerEdit = new Button();
            btnCustomerDelete = new Button();
            tblCustomers = new DataGridView();
            btnCustomerSearch = new Button();
            txtCustomerSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblCustomers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnAdminLogout);
            panel1.Controls.Add(lblSubHeading);
            panel1.Controls.Add(lblHeading);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
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
            btnAdminLogout.Location = new Point(1522, 43);
            btnAdminLogout.Name = "btnAdminLogout";
            btnAdminLogout.Size = new Size(141, 44);
            btnAdminLogout.TabIndex = 15;
            btnAdminLogout.Text = "Logout";
            btnAdminLogout.UseVisualStyleBackColor = false;
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(96, 74);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(204, 27);
            lblSubHeading.TabIndex = 14;
            lblSubHeading.Text = "Management Portal";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(87, 27);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(329, 47);
            lblHeading.TabIndex = 13;
            lblHeading.Text = "GreenLife Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(3, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
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
            panel2.Location = new Point(1, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 665);
            panel2.TabIndex = 1;
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
            btnNavigateReports.Location = new Point(14, 320);
            btnNavigateReports.Name = "btnNavigateReports";
            btnNavigateReports.Size = new Size(227, 44);
            btnNavigateReports.TabIndex = 24;
            btnNavigateReports.Text = "Reports";
            btnNavigateReports.UseVisualStyleBackColor = false;
            btnNavigateReports.Click += btnNavigateReports_Click;
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
            btnNavigateOrders.Location = new Point(14, 242);
            btnNavigateOrders.Name = "btnNavigateOrders";
            btnNavigateOrders.Size = new Size(227, 44);
            btnNavigateOrders.TabIndex = 23;
            btnNavigateOrders.Text = "Orders";
            btnNavigateOrders.UseVisualStyleBackColor = false;
            btnNavigateOrders.Click += btnNavigateOrders_Click;
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
            btnNavigateCustomers.Location = new Point(14, 169);
            btnNavigateCustomers.Name = "btnNavigateCustomers";
            btnNavigateCustomers.Size = new Size(227, 44);
            btnNavigateCustomers.TabIndex = 22;
            btnNavigateCustomers.Text = "Customers";
            btnNavigateCustomers.UseVisualStyleBackColor = false;
            btnNavigateCustomers.Click += btnNavigateCustomers_Click;
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
            btnNavigateProducts.Location = new Point(14, 96);
            btnNavigateProducts.Name = "btnNavigateProducts";
            btnNavigateProducts.Size = new Size(227, 44);
            btnNavigateProducts.TabIndex = 21;
            btnNavigateProducts.Text = "Products";
            btnNavigateProducts.UseVisualStyleBackColor = false;
            btnNavigateProducts.Click += btnNavigateProducts_Click;
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
            btnNavigateDashboard.Location = new Point(14, 25);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 20;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += btnNavigateDashboard_Click;
            // 
            // lblMangeCustomersSub
            // 
            lblMangeCustomersSub.AutoSize = true;
            lblMangeCustomersSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMangeCustomersSub.ForeColor = Color.LimeGreen;
            lblMangeCustomersSub.Location = new Point(307, 190);
            lblMangeCustomersSub.Name = "lblMangeCustomersSub";
            lblMangeCustomersSub.Size = new Size(355, 23);
            lblMangeCustomersSub.TabIndex = 13;
            lblMangeCustomersSub.Text = "View and manage customer information";
            // 
            // lblManageCustomersHeading
            // 
            lblManageCustomersHeading.AutoSize = true;
            lblManageCustomersHeading.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManageCustomersHeading.ForeColor = Color.ForestGreen;
            lblManageCustomersHeading.Location = new Point(303, 147);
            lblManageCustomersHeading.Name = "lblManageCustomersHeading";
            lblManageCustomersHeading.Size = new Size(340, 43);
            lblManageCustomersHeading.TabIndex = 14;
            lblManageCustomersHeading.Text = "Manage Customers";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(btnCustomerEdit);
            panel3.Controls.Add(btnCustomerDelete);
            panel3.Controls.Add(tblCustomers);
            panel3.Controls.Add(btnCustomerSearch);
            panel3.Controls.Add(txtCustomerSearch);
            panel3.Location = new Point(307, 223);
            panel3.Name = "panel3";
            panel3.Size = new Size(1379, 557);
            panel3.TabIndex = 15;
            // 
            // btnCustomerEdit
            // 
            btnCustomerEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCustomerEdit.BackColor = Color.Green;
            btnCustomerEdit.FlatAppearance.BorderColor = Color.Green;
            btnCustomerEdit.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnCustomerEdit.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnCustomerEdit.FlatStyle = FlatStyle.Popup;
            btnCustomerEdit.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerEdit.ForeColor = Color.White;
            btnCustomerEdit.Location = new Point(1103, 30);
            btnCustomerEdit.Name = "btnCustomerEdit";
            btnCustomerEdit.Size = new Size(119, 33);
            btnCustomerEdit.TabIndex = 12;
            btnCustomerEdit.Text = "Edit";
            btnCustomerEdit.UseVisualStyleBackColor = false;
            btnCustomerEdit.Click += btnCustomerEdit_Click;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCustomerDelete.BackColor = Color.OrangeRed;
            btnCustomerDelete.FlatAppearance.BorderColor = Color.OrangeRed;
            btnCustomerDelete.FlatAppearance.BorderSize = 0;
            btnCustomerDelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btnCustomerDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCustomerDelete.FlatStyle = FlatStyle.Popup;
            btnCustomerDelete.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerDelete.ForeColor = Color.White;
            btnCustomerDelete.Location = new Point(1238, 30);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(119, 33);
            btnCustomerDelete.TabIndex = 11;
            btnCustomerDelete.Text = "Delete";
            btnCustomerDelete.UseVisualStyleBackColor = false;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // tblCustomers
            // 
            tblCustomers.AllowUserToAddRows = false;
            tblCustomers.AllowUserToDeleteRows = false;
            tblCustomers.AllowUserToResizeColumns = false;
            tblCustomers.AllowUserToResizeRows = false;
            tblCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblCustomers.BackgroundColor = SystemColors.ControlLightLight;
            tblCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblCustomers.Cursor = Cursors.Hand;
            tblCustomers.GridColor = Color.LightGreen;
            tblCustomers.Location = new Point(25, 92);
            tblCustomers.MultiSelect = false;
            tblCustomers.Name = "tblCustomers";
            tblCustomers.RowHeadersVisible = false;
            tblCustomers.RowHeadersWidth = 51;
            tblCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblCustomers.Size = new Size(1332, 450);
            tblCustomers.TabIndex = 10;
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.BackColor = Color.Green;
            btnCustomerSearch.FlatAppearance.BorderColor = Color.Green;
            btnCustomerSearch.FlatAppearance.BorderSize = 0;
            btnCustomerSearch.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnCustomerSearch.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnCustomerSearch.FlatStyle = FlatStyle.Popup;
            btnCustomerSearch.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerSearch.ForeColor = Color.White;
            btnCustomerSearch.Location = new Point(563, 31);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(119, 33);
            btnCustomerSearch.TabIndex = 8;
            btnCustomerSearch.Text = "Search";
            btnCustomerSearch.UseVisualStyleBackColor = false;
            btnCustomerSearch.Click += btnCustomerSearch_Click;
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.BackColor = SystemColors.MenuBar;
            txtCustomerSearch.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerSearch.Location = new Point(25, 32);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.PlaceholderText = "Search customers by name or email...";
            txtCustomerSearch.Size = new Size(514, 31);
            txtCustomerSearch.TabIndex = 7;
            // 
            // frmAdminCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1714, 791);
            Controls.Add(panel3);
            Controls.Add(lblMangeCustomersSub);
            Controls.Add(lblManageCustomersHeading);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAdminCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            Load += frmAdminCustomerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblCustomers).EndInit();
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
        private Label lblMangeCustomersSub;
        private Label lblManageCustomersHeading;
        private Panel panel3;
        private Button btnCustomerSearch;
        private TextBox txtCustomerSearch;
        private DataGridView tblCustomers;
        private Button btnCustomerEdit;
        private Button btnCustomerDelete;
    }
}