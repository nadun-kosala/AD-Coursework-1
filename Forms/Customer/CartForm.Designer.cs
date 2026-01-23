namespace GreenLife_Organic_Store.Forms.Customer
{
    partial class frmCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartForm));
            panel1 = new Panel();
            btnCustomerLogout = new Button();
            lblHeading = new Label();
            lblSubHeading = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnNavigateProfile = new Button();
            btnNavigateOrders = new Button();
            btnNavigateCart = new Button();
            btnNavigateSearch = new Button();
            btnNavigateDashboard = new Button();
            lblShoppingCartSub = new Label();
            lblShoppingCartHeading = new Label();
            flowLayoutPanalForCartItem = new FlowLayoutPanel();
            panel5 = new Panel();
            btnContinueShopping = new Button();
            btnPlaceOrder = new Button();
            lblDiscountCodeShow = new Label();
            btnDiscountApply = new Button();
            txtDiscountCode = new TextBox();
            lblDiscountAmmount = new Label();
            label13 = new Label();
            lblFinalAmmount = new Label();
            label11 = new Label();
            label10 = new Label();
            lblSubTotal = new Label();
            lblSubTotalHead = new Label();
            lblOrderSummary = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnCustomerLogout);
            panel1.Controls.Add(lblHeading);
            panel1.Controls.Add(lblSubHeading);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1622, 125);
            panel1.TabIndex = 0;
            // 
            // btnCustomerLogout
            // 
            btnCustomerLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCustomerLogout.AutoSize = true;
            btnCustomerLogout.BackColor = SystemColors.ControlLightLight;
            btnCustomerLogout.FlatAppearance.BorderColor = Color.LimeGreen;
            btnCustomerLogout.FlatAppearance.MouseDownBackColor = Color.Ivory;
            btnCustomerLogout.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnCustomerLogout.FlatStyle = FlatStyle.Flat;
            btnCustomerLogout.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerLogout.ForeColor = Color.LimeGreen;
            btnCustomerLogout.Location = new Point(1436, 42);
            btnCustomerLogout.Name = "btnCustomerLogout";
            btnCustomerLogout.Size = new Size(141, 44);
            btnCustomerLogout.TabIndex = 21;
            btnCustomerLogout.Text = "Logout";
            btnCustomerLogout.UseVisualStyleBackColor = false;
            btnCustomerLogout.Click += btnCustomerLogout_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.ForestGreen;
            lblHeading.Location = new Point(87, 24);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(456, 47);
            lblHeading.TabIndex = 19;
            lblHeading.Text = "GreenLife Organic Store";
            // 
            // lblSubHeading
            // 
            lblSubHeading.AutoSize = true;
            lblSubHeading.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubHeading.ForeColor = Color.LimeGreen;
            lblSubHeading.Location = new Point(96, 71);
            lblSubHeading.Name = "lblSubHeading";
            lblSubHeading.Size = new Size(226, 27);
            lblSubHeading.TabIndex = 20;
            lblSubHeading.Text = "Welcome to GreenLife";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.images__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(3, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnNavigateProfile);
            panel2.Controls.Add(btnNavigateOrders);
            panel2.Controls.Add(btnNavigateCart);
            panel2.Controls.Add(btnNavigateSearch);
            panel2.Controls.Add(btnNavigateDashboard);
            panel2.Location = new Point(1, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 556);
            panel2.TabIndex = 1;
            // 
            // btnNavigateProfile
            // 
            btnNavigateProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateProfile.AutoSize = true;
            btnNavigateProfile.BackColor = Color.DarkGreen;
            btnNavigateProfile.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateProfile.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateProfile.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateProfile.FlatStyle = FlatStyle.Flat;
            btnNavigateProfile.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateProfile.ForeColor = Color.White;
            btnNavigateProfile.Location = new Point(11, 315);
            btnNavigateProfile.Name = "btnNavigateProfile";
            btnNavigateProfile.Size = new Size(227, 44);
            btnNavigateProfile.TabIndex = 34;
            btnNavigateProfile.Text = "Profile";
            btnNavigateProfile.UseVisualStyleBackColor = false;
            btnNavigateProfile.Click += btnNavigateProfile_Click;
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
            btnNavigateOrders.Location = new Point(11, 237);
            btnNavigateOrders.Name = "btnNavigateOrders";
            btnNavigateOrders.Size = new Size(227, 44);
            btnNavigateOrders.TabIndex = 33;
            btnNavigateOrders.Text = "Orders";
            btnNavigateOrders.UseVisualStyleBackColor = false;
            btnNavigateOrders.Click += btnNavigateOrders_Click;
            // 
            // btnNavigateCart
            // 
            btnNavigateCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateCart.AutoSize = true;
            btnNavigateCart.BackColor = Color.DarkGreen;
            btnNavigateCart.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateCart.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateCart.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateCart.FlatStyle = FlatStyle.Flat;
            btnNavigateCart.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateCart.ForeColor = Color.White;
            btnNavigateCart.Location = new Point(11, 164);
            btnNavigateCart.Name = "btnNavigateCart";
            btnNavigateCart.Size = new Size(227, 44);
            btnNavigateCart.TabIndex = 32;
            btnNavigateCart.Text = "Cart";
            btnNavigateCart.UseVisualStyleBackColor = false;
            btnNavigateCart.Click += btnNavigateCart_Click;
            // 
            // btnNavigateSearch
            // 
            btnNavigateSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavigateSearch.AutoSize = true;
            btnNavigateSearch.BackColor = Color.DarkGreen;
            btnNavigateSearch.FlatAppearance.BorderColor = Color.DarkGreen;
            btnNavigateSearch.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnNavigateSearch.FlatAppearance.MouseOverBackColor = Color.Green;
            btnNavigateSearch.FlatStyle = FlatStyle.Flat;
            btnNavigateSearch.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavigateSearch.ForeColor = Color.White;
            btnNavigateSearch.Location = new Point(11, 91);
            btnNavigateSearch.Name = "btnNavigateSearch";
            btnNavigateSearch.Size = new Size(227, 44);
            btnNavigateSearch.TabIndex = 31;
            btnNavigateSearch.Text = "Search";
            btnNavigateSearch.UseVisualStyleBackColor = false;
            btnNavigateSearch.Click += btnNavigateSearch_Click;
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
            btnNavigateDashboard.Location = new Point(11, 20);
            btnNavigateDashboard.Name = "btnNavigateDashboard";
            btnNavigateDashboard.Size = new Size(227, 44);
            btnNavigateDashboard.TabIndex = 30;
            btnNavigateDashboard.Text = "Dashboard";
            btnNavigateDashboard.UseVisualStyleBackColor = false;
            btnNavigateDashboard.Click += btnNavigateDashboard_Click;
            // 
            // lblShoppingCartSub
            // 
            lblShoppingCartSub.AutoSize = true;
            lblShoppingCartSub.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShoppingCartSub.ForeColor = Color.LimeGreen;
            lblShoppingCartSub.Location = new Point(278, 188);
            lblShoppingCartSub.Name = "lblShoppingCartSub";
            lblShoppingCartSub.Size = new Size(177, 23);
            lblShoppingCartSub.TabIndex = 13;
            lblShoppingCartSub.Text = "2 items in your cart";
            // 
            // lblShoppingCartHeading
            // 
            lblShoppingCartHeading.AutoSize = true;
            lblShoppingCartHeading.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShoppingCartHeading.ForeColor = Color.ForestGreen;
            lblShoppingCartHeading.Location = new Point(274, 145);
            lblShoppingCartHeading.Name = "lblShoppingCartHeading";
            lblShoppingCartHeading.Size = new Size(258, 43);
            lblShoppingCartHeading.TabIndex = 14;
            lblShoppingCartHeading.Text = "Shopping Cart";
            // 
            // flowLayoutPanalForCartItem
            // 
            flowLayoutPanalForCartItem.AutoScroll = true;
            flowLayoutPanalForCartItem.Location = new Point(282, 230);
            flowLayoutPanalForCartItem.Name = "flowLayoutPanalForCartItem";
            flowLayoutPanalForCartItem.Size = new Size(867, 473);
            flowLayoutPanalForCartItem.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(btnContinueShopping);
            panel5.Controls.Add(btnPlaceOrder);
            panel5.Controls.Add(lblDiscountCodeShow);
            panel5.Controls.Add(btnDiscountApply);
            panel5.Controls.Add(txtDiscountCode);
            panel5.Controls.Add(lblDiscountAmmount);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(lblFinalAmmount);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(lblSubTotal);
            panel5.Controls.Add(lblSubTotalHead);
            panel5.Controls.Add(lblOrderSummary);
            panel5.Location = new Point(1175, 230);
            panel5.Name = "panel5";
            panel5.Size = new Size(403, 473);
            panel5.TabIndex = 16;
            // 
            // btnContinueShopping
            // 
            btnContinueShopping.BackColor = SystemColors.ControlLightLight;
            btnContinueShopping.FlatAppearance.BorderColor = Color.LimeGreen;
            btnContinueShopping.FlatAppearance.MouseDownBackColor = Color.Ivory;
            btnContinueShopping.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnContinueShopping.FlatStyle = FlatStyle.Flat;
            btnContinueShopping.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinueShopping.ForeColor = Color.Green;
            btnContinueShopping.Location = new Point(19, 390);
            btnContinueShopping.Name = "btnContinueShopping";
            btnContinueShopping.Size = new Size(364, 51);
            btnContinueShopping.TabIndex = 33;
            btnContinueShopping.Text = "Continue Shopping";
            btnContinueShopping.UseVisualStyleBackColor = false;
            btnContinueShopping.Click += btnContinueShopping_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.Green;
            btnPlaceOrder.FlatAppearance.BorderColor = Color.Green;
            btnPlaceOrder.FlatAppearance.BorderSize = 0;
            btnPlaceOrder.FlatAppearance.MouseDownBackColor = Color.Green;
            btnPlaceOrder.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(19, 311);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(364, 51);
            btnPlaceOrder.TabIndex = 32;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // lblDiscountCodeShow
            // 
            lblDiscountCodeShow.AutoSize = true;
            lblDiscountCodeShow.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscountCodeShow.ForeColor = SystemColors.ControlDark;
            lblDiscountCodeShow.Location = new Point(19, 261);
            lblDiscountCodeShow.Name = "lblDiscountCodeShow";
            lblDiscountCodeShow.Size = new Size(277, 23);
            lblDiscountCodeShow.TabIndex = 31;
            lblDiscountCodeShow.Text = "Try code: GREEN10 for 10% off";
            // 
            // btnDiscountApply
            // 
            btnDiscountApply.BackColor = SystemColors.ControlLightLight;
            btnDiscountApply.FlatAppearance.BorderColor = Color.LimeGreen;
            btnDiscountApply.FlatAppearance.MouseDownBackColor = Color.Ivory;
            btnDiscountApply.FlatAppearance.MouseOverBackColor = Color.Honeydew;
            btnDiscountApply.FlatStyle = FlatStyle.Flat;
            btnDiscountApply.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiscountApply.ForeColor = Color.DarkGreen;
            btnDiscountApply.Location = new Point(264, 213);
            btnDiscountApply.Name = "btnDiscountApply";
            btnDiscountApply.Size = new Size(119, 33);
            btnDiscountApply.TabIndex = 30;
            btnDiscountApply.Text = "Apply";
            btnDiscountApply.UseVisualStyleBackColor = false;
            // 
            // txtDiscountCode
            // 
            txtDiscountCode.BackColor = SystemColors.MenuBar;
            txtDiscountCode.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscountCode.Location = new Point(19, 214);
            txtDiscountCode.Name = "txtDiscountCode";
            txtDiscountCode.PlaceholderText = "Discount code";
            txtDiscountCode.Size = new Size(228, 31);
            txtDiscountCode.TabIndex = 28;
            // 
            // lblDiscountAmmount
            // 
            lblDiscountAmmount.AutoSize = true;
            lblDiscountAmmount.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscountAmmount.ForeColor = Color.Green;
            lblDiscountAmmount.Location = new Point(289, 105);
            lblDiscountAmmount.Name = "lblDiscountAmmount";
            lblDiscountAmmount.Size = new Size(94, 23);
            lblDiscountAmmount.TabIndex = 21;
            lblDiscountAmmount.Text = "-1.35 LKR";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Green;
            label13.Location = new Point(19, 105);
            label13.Name = "label13";
            label13.Size = new Size(87, 23);
            label13.TabIndex = 20;
            label13.Text = "Discount";
            // 
            // lblFinalAmmount
            // 
            lblFinalAmmount.AutoSize = true;
            lblFinalAmmount.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalAmmount.ForeColor = Color.ForestGreen;
            lblFinalAmmount.Location = new Point(264, 151);
            lblFinalAmmount.Name = "lblFinalAmmount";
            lblFinalAmmount.Size = new Size(122, 27);
            lblFinalAmmount.TabIndex = 19;
            lblFinalAmmount.Text = "12.12 LKR";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(19, 151);
            label11.Name = "label11";
            label11.Size = new Size(65, 27);
            label11.TabIndex = 18;
            label11.Text = "Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDark;
            label10.Location = new Point(19, 122);
            label10.Name = "label10";
            label10.Size = new Size(367, 23);
            label10.TabIndex = 17;
            label10.Text = "___________________________________________________";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.ForeColor = SystemColors.ControlDark;
            lblSubTotal.Location = new Point(285, 72);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(98, 23);
            lblSubTotal.TabIndex = 16;
            lblSubTotal.Text = "13.47 LKR";
            lblSubTotal.Click += lblSubTotal_Click;
            // 
            // lblSubTotalHead
            // 
            lblSubTotalHead.AutoSize = true;
            lblSubTotalHead.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotalHead.ForeColor = SystemColors.ControlDark;
            lblSubTotalHead.Location = new Point(19, 72);
            lblSubTotalHead.Name = "lblSubTotalHead";
            lblSubTotalHead.Size = new Size(82, 23);
            lblSubTotalHead.TabIndex = 15;
            lblSubTotalHead.Text = "Subtotal";
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderSummary.ForeColor = Color.ForestGreen;
            lblOrderSummary.Location = new Point(19, 15);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(158, 23);
            lblOrderSummary.TabIndex = 14;
            lblOrderSummary.Text = "Order Summary";
            // 
            // frmCartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1626, 689);
            Controls.Add(panel5);
            Controls.Add(flowLayoutPanalForCartItem);
            Controls.Add(lblShoppingCartSub);
            Controls.Add(lblShoppingCartHeading);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            Load += frmCartForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCustomerLogout;
        private Label lblHeading;
        private Label lblSubHeading;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnNavigateProfile;
        private Button btnNavigateOrders;
        private Button btnNavigateCart;
        private Button btnNavigateSearch;
        private Button btnNavigateDashboard;
        private Label lblShoppingCartSub;
        private Label lblShoppingCartHeading;
        private FlowLayoutPanel flowLayoutPanalForCartItem;
        private Panel panel5;
        private Button btnContinueShopping;
        private Button btnPlaceOrder;
        private Label lblDiscountCodeShow;
        private Button btnDiscountApply;
        private TextBox txtDiscountCode;
        private Label lblDiscountAmmount;
        private Label label13;
        private Label lblFinalAmmount;
        private Label label11;
        private Label label10;
        private Label lblSubTotal;
        private Label lblSubTotalHead;
        private Label lblOrderSummary;
    }
}