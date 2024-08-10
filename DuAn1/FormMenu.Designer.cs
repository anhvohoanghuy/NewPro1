namespace DuAn1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panel1 = new Panel();
            lblPhanQuyen = new Label();
            label2 = new Label();
            lblDateTime = new Label();
            lblUserName = new Label();
            panel6 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btnColor = new CustomButton.VBButton();
            vbButton2 = new CustomButton.VBButton();
            btnPromotion = new CustomButton.VBButton();
            btnKhachHang = new CustomButton.VBButton();
            btnVoucher = new CustomButton.VBButton();
            panel7 = new Panel();
            btnLogOut = new CustomButton.VBButton();
            btnStatistics = new CustomButton.VBButton();
            btnCpu = new CustomButton.VBButton();
            btnOrder = new CustomButton.VBButton();
            btnCreateOrder = new CustomButton.VBButton();
            btnProduct = new CustomButton.VBButton();
            vbButton1 = new CustomButton.VBButton();
            panel5 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(lblPhanQuyen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblDateTime);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(199, 4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 46);
            panel1.TabIndex = 0;
            // 
            // lblPhanQuyen
            // 
            lblPhanQuyen.AutoSize = true;
            lblPhanQuyen.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhanQuyen.ForeColor = SystemColors.ButtonHighlight;
            lblPhanQuyen.Location = new Point(336, 14);
            lblPhanQuyen.Name = "lblPhanQuyen";
            lblPhanQuyen.Size = new Size(33, 19);
            lblPhanQuyen.TabIndex = 7;
            lblPhanQuyen.Text = "Null";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(256, 14);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 6;
            label2.Text = "Chức vụ : ";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = SystemColors.ButtonHighlight;
            lblDateTime.Location = new Point(518, 13);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(88, 20);
            lblDateTime.TabIndex = 5;
            lblDateTime.Text = "ddd/mm/yy";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.ButtonHighlight;
            lblUserName.Location = new Point(139, 14);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(33, 19);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "Null";
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.add_user;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(108, 9);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(25, 28);
            panel6.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 44);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(956, 478);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.MediumSlateBlue;
            panel2.Controls.Add(btnColor);
            panel2.Controls.Add(vbButton2);
            panel2.Controls.Add(btnPromotion);
            panel2.Controls.Add(btnKhachHang);
            panel2.Controls.Add(btnVoucher);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnStatistics);
            panel2.Controls.Add(btnCpu);
            panel2.Controls.Add(btnOrder);
            panel2.Controls.Add(btnCreateOrder);
            panel2.Controls.Add(btnProduct);
            panel2.Controls.Add(vbButton1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-7, 2);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 788);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnColor
            // 
            btnColor.BackColor = Color.MediumSlateBlue;
            btnColor.BackgroundColor = Color.MediumSlateBlue;
            btnColor.BorderColor = Color.PaleVioletRed;
            btnColor.BorderRadius = 20;
            btnColor.BorderSize = 0;
            btnColor.FlatAppearance.BorderSize = 0;
            btnColor.FlatStyle = FlatStyle.Flat;
            btnColor.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnColor.ForeColor = Color.White;
            btnColor.Image = (Image)resources.GetObject("btnColor.Image");
            btnColor.ImageAlign = ContentAlignment.MiddleLeft;
            btnColor.Location = new Point(21, 521);
            btnColor.Margin = new Padding(3, 2, 3, 2);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(164, 38);
            btnColor.TabIndex = 25;
            btnColor.Text = "Color";
            btnColor.TextColor = Color.White;
            btnColor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnColor.UseVisualStyleBackColor = false;
            btnColor.Click += btnColor_Click;
            // 
            // vbButton2
            // 
            vbButton2.BackColor = Color.MediumSlateBlue;
            vbButton2.BackgroundColor = Color.MediumSlateBlue;
            vbButton2.BorderColor = Color.PaleVioletRed;
            vbButton2.BorderRadius = 20;
            vbButton2.BorderSize = 0;
            vbButton2.FlatAppearance.BorderSize = 0;
            vbButton2.FlatStyle = FlatStyle.Flat;
            vbButton2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton2.ForeColor = Color.White;
            vbButton2.Image = (Image)resources.GetObject("vbButton2.Image");
            vbButton2.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton2.Location = new Point(21, 375);
            vbButton2.Margin = new Padding(3, 2, 3, 2);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(164, 38);
            vbButton2.TabIndex = 24;
            vbButton2.Text = "Tài khoản";
            vbButton2.TextColor = Color.White;
            vbButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton2.UseVisualStyleBackColor = false;
            // 
            // btnPromotion
            // 
            btnPromotion.BackColor = Color.MediumSlateBlue;
            btnPromotion.BackgroundColor = Color.MediumSlateBlue;
            btnPromotion.BorderColor = Color.PaleVioletRed;
            btnPromotion.BorderRadius = 20;
            btnPromotion.BorderSize = 0;
            btnPromotion.FlatAppearance.BorderSize = 0;
            btnPromotion.FlatStyle = FlatStyle.Flat;
            btnPromotion.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPromotion.ForeColor = Color.White;
            btnPromotion.Image = (Image)resources.GetObject("btnPromotion.Image");
            btnPromotion.ImageAlign = ContentAlignment.MiddleLeft;
            btnPromotion.Location = new Point(15, 340);
            btnPromotion.Margin = new Padding(3, 2, 3, 2);
            btnPromotion.Name = "btnPromotion";
            btnPromotion.Size = new Size(164, 38);
            btnPromotion.TabIndex = 23;
            btnPromotion.Text = "Khuyến mãi";
            btnPromotion.TextColor = Color.White;
            btnPromotion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPromotion.UseVisualStyleBackColor = false;
            btnPromotion.Click += btnPromotion_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.MediumSlateBlue;
            btnKhachHang.BackgroundColor = Color.MediumSlateBlue;
            btnKhachHang.BorderColor = Color.PaleVioletRed;
            btnKhachHang.BorderRadius = 20;
            btnKhachHang.BorderSize = 0;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Image = (Image)resources.GetObject("btnKhachHang.Image");
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(18, 417);
            btnKhachHang.Margin = new Padding(3, 2, 3, 2);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(164, 38);
            btnKhachHang.TabIndex = 22;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextColor = Color.White;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnVoucher
            // 
            btnVoucher.BackColor = Color.MediumSlateBlue;
            btnVoucher.BackgroundColor = Color.MediumSlateBlue;
            btnVoucher.BorderColor = Color.PaleVioletRed;
            btnVoucher.BorderRadius = 20;
            btnVoucher.BorderSize = 0;
            btnVoucher.FlatAppearance.BorderSize = 0;
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoucher.ForeColor = Color.White;
            btnVoucher.Image = (Image)resources.GetObject("btnVoucher.Image");
            btnVoucher.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoucher.Location = new Point(18, 284);
            btnVoucher.Margin = new Padding(3, 2, 3, 2);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(164, 38);
            btnVoucher.TabIndex = 21;
            btnVoucher.Text = "Voucher";
            btnVoucher.TextColor = Color.White;
            btnVoucher.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoucher.UseVisualStyleBackColor = false;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BackgroundImageLayout = ImageLayout.None;
            panel7.Location = new Point(15, 573);
            panel7.Margin = new Padding(3, 0, 3, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(168, 2);
            panel7.TabIndex = 14;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogOut.BackColor = Color.MediumSlateBlue;
            btnLogOut.BackgroundColor = Color.MediumSlateBlue;
            btnLogOut.BorderColor = Color.PaleVioletRed;
            btnLogOut.BorderRadius = 20;
            btnLogOut.BorderSize = 0;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(18, 724);
            btnLogOut.Margin = new Padding(3, 2, 3, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(164, 54);
            btnLogOut.TabIndex = 20;
            btnLogOut.Text = "Đăng xuất";
            btnLogOut.TextColor = Color.White;
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = Color.MediumSlateBlue;
            btnStatistics.BackgroundColor = Color.MediumSlateBlue;
            btnStatistics.BorderColor = Color.PaleVioletRed;
            btnStatistics.BorderRadius = 20;
            btnStatistics.BorderSize = 0;
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatistics.ForeColor = Color.White;
            btnStatistics.Image = (Image)resources.GetObject("btnStatistics.Image");
            btnStatistics.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistics.Location = new Point(18, 591);
            btnStatistics.Margin = new Padding(3, 2, 3, 2);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(164, 38);
            btnStatistics.TabIndex = 19;
            btnStatistics.Text = "Thống kê";
            btnStatistics.TextColor = Color.White;
            btnStatistics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatistics.UseVisualStyleBackColor = false;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnCpu
            // 
            btnCpu.BackColor = Color.MediumSlateBlue;
            btnCpu.BackgroundColor = Color.MediumSlateBlue;
            btnCpu.BorderColor = Color.PaleVioletRed;
            btnCpu.BorderRadius = 20;
            btnCpu.BorderSize = 0;
            btnCpu.FlatAppearance.BorderSize = 0;
            btnCpu.FlatStyle = FlatStyle.Flat;
            btnCpu.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCpu.ForeColor = Color.White;
            btnCpu.Image = (Image)resources.GetObject("btnCpu.Image");
            btnCpu.ImageAlign = ContentAlignment.MiddleLeft;
            btnCpu.Location = new Point(21, 468);
            btnCpu.Margin = new Padding(3, 2, 3, 2);
            btnCpu.Name = "btnCpu";
            btnCpu.Size = new Size(164, 38);
            btnCpu.TabIndex = 18;
            btnCpu.Text = "CPU";
            btnCpu.TextColor = Color.White;
            btnCpu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCpu.UseVisualStyleBackColor = false;
            btnCpu.Click += btnCpu_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.MediumSlateBlue;
            btnOrder.BackgroundColor = Color.MediumSlateBlue;
            btnOrder.BorderColor = Color.PaleVioletRed;
            btnOrder.BorderRadius = 20;
            btnOrder.BorderSize = 0;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.White;
            btnOrder.Image = (Image)resources.GetObject("btnOrder.Image");
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(15, 178);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(164, 38);
            btnOrder.TabIndex = 17;
            btnOrder.Text = "Đơn hàng";
            btnOrder.TextColor = Color.White;
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.BackColor = Color.MediumSlateBlue;
            btnCreateOrder.BackgroundColor = Color.MediumSlateBlue;
            btnCreateOrder.BorderColor = Color.PaleVioletRed;
            btnCreateOrder.BorderRadius = 20;
            btnCreateOrder.BorderSize = 0;
            btnCreateOrder.FlatAppearance.BorderSize = 0;
            btnCreateOrder.FlatStyle = FlatStyle.Flat;
            btnCreateOrder.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateOrder.ForeColor = Color.White;
            btnCreateOrder.Image = (Image)resources.GetObject("btnCreateOrder.Image");
            btnCreateOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateOrder.Location = new Point(15, 119);
            btnCreateOrder.Margin = new Padding(3, 2, 3, 2);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(185, 38);
            btnCreateOrder.TabIndex = 16;
            btnCreateOrder.Text = "Tạo đơn hàng";
            btnCreateOrder.TextColor = Color.White;
            btnCreateOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateOrder.UseVisualStyleBackColor = false;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.MediumSlateBlue;
            btnProduct.BackgroundColor = Color.MediumSlateBlue;
            btnProduct.BorderColor = Color.PaleVioletRed;
            btnProduct.BorderRadius = 20;
            btnProduct.BorderSize = 0;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.White;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(15, 235);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(164, 38);
            btnProduct.TabIndex = 15;
            btnProduct.Text = "Sản Phẩm";
            btnProduct.TextColor = Color.White;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            vbButton1.BackColor = Color.MediumSlateBlue;
            vbButton1.BackgroundColor = Color.MediumSlateBlue;
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 20;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = Properties.Resources._25694__2_;
            vbButton1.ImageAlign = ContentAlignment.MiddleLeft;
            vbButton1.Location = new Point(15, 64);
            vbButton1.Margin = new Padding(3, 2, 3, 2);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(164, 38);
            vbButton1.TabIndex = 14;
            vbButton1.Text = "Trang chủ";
            vbButton1.TextColor = Color.White;
            vbButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            vbButton1.UseVisualStyleBackColor = false;
            vbButton1.Click += vbButton1_Click_2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Location = new Point(15, 43);
            panel5.Margin = new Padding(3, 0, 3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(168, 2);
            panel5.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(30, 3);
            label1.Name = "label1";
            label1.Size = new Size(128, 37);
            label1.TabIndex = 0;
            label1.Text = "Xin chào";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(201, 48);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(866, 742);
            panel4.TabIndex = 0;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1068, 791);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenu";
            Text = "FormMenu";
            FormClosing += FormMenu_FormClosing;
            Load += FormMenu_Load;
            Resize += FormMenu_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Label label1;
        private Panel panel4;
        private Label lblDateTime;
        private Label lblUserName;
        private Panel panel6;
        private CustomButton.VBButton btnLogOut;
        private CustomButton.VBButton btnStatistics;
        private CustomButton.VBButton btnEmployee;
        private CustomButton.VBButton btnOrder;
        private CustomButton.VBButton btnCreateOrder;
        private CustomButton.VBButton btnProduct;
        private CustomButton.VBButton vbButton1;
        private Panel panel7;
        private CustomButton.VBButton btnVoucher;
        private Label lblPhanQuyen;
        private Label label2;
        private CustomButton.VBButton btnKhachHang;
        private CustomButton.VBButton btnPromotion;
        private CustomButton.VBButton vbButton3;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton btnCpu;
        private CustomButton.VBButton btnColor;
    }
}