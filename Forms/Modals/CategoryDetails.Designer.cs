namespace GreenLife_Organic_Store.Forms.Modals
{
    partial class frmCategoryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoryDetails));
            lblSubHeading = new Label();
            lblHeading = new Label();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            txtDiscription = new TextBox();
            lblDescription = new Label();
            btnCreate = new Button();
            dataGridCategory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).BeginInit();
            SuspendLayout();
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(12, 51);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(159, 20);
            lblSubHeading.TabIndex = 9;
            lblSubHeading.Text = "Create category here";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(12, 18);
            lblHeading.Name = "lblHeading";
            lblHeading.RightToLeft = RightToLeft.No;
            lblHeading.Size = new Size(227, 33);
            lblHeading.TabIndex = 8;
            lblHeading.Text = "Category Details";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = SystemColors.InactiveBorder;
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryName.Location = new Point(18, 136);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(320, 31);
            txtCategoryName.TabIndex = 17;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryName.ForeColor = SystemColors.ControlText;
            lblCategoryName.Location = new Point(18, 100);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(149, 23);
            lblCategoryName.TabIndex = 16;
            lblCategoryName.Text = "Category Name";
            // 
            // txtDiscription
            // 
            txtDiscription.BackColor = SystemColors.InactiveBorder;
            txtDiscription.BorderStyle = BorderStyle.FixedSingle;
            txtDiscription.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscription.Location = new Point(389, 136);
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(413, 31);
            txtDiscription.TabIndex = 19;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.ControlText;
            lblDescription.Location = new Point(389, 100);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(116, 23);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Description";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LimeGreen;
            btnCreate.FlatAppearance.BorderColor = Color.LimeGreen;
            btnCreate.FlatAppearance.MouseDownBackColor = Color.Green;
            btnCreate.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(622, 189);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(180, 43);
            btnCreate.TabIndex = 32;
            btnCreate.Text = "Add Category";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dataGridCategory
            // 
            dataGridCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCategory.BackgroundColor = Color.Honeydew;
            dataGridCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategory.GridColor = Color.Green;
            dataGridCategory.Location = new Point(12, 274);
            dataGridCategory.MultiSelect = false;
            dataGridCategory.Name = "dataGridCategory";
            dataGridCategory.ReadOnly = true;
            dataGridCategory.RowHeadersWidth = 51;
            dataGridCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCategory.Size = new Size(790, 255);
            dataGridCategory.TabIndex = 33;
            // 
            // frmCategoryDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(835, 567);
            Controls.Add(dataGridCategory);
            Controls.Add(btnCreate);
            Controls.Add(txtDiscription);
            Controls.Add(lblDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(lblCategoryName);
            Controls.Add(lblSubHeading);
            Controls.Add(lblHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCategoryDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Details";
            Load += frmCategoryDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubHeading;
        private Label lblHeading;
        private TextBox txtCategoryName;
        private Label lblCategoryName;
        private TextBox txtDiscription;
        private Label lblDescription;
        private Button btnCreate;
        private DataGridView dataGridCategory;
    }
}