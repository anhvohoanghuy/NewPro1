namespace DuAn1
{
    partial class FormPromotion
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvListPromotion = new DataGridView();
            grbListCustomer = new GroupBox();
            label6 = new Label();
            cbbTimKiem = new ComboBox();
            btnSearch = new CustomButton.VBButton();
            btnExcel = new CustomButton.VBButton();
            label5 = new Label();
            txtDiscount = new TextBox();
            label4 = new Label();
            txtIdAccount = new TextBox();
            label3 = new Label();
            vbButton1 = new CustomButton.VBButton();
            textBox7 = new TextBox();
            vbButton2 = new CustomButton.VBButton();
            btnSua = new CustomButton.VBButton();
            btnThem = new CustomButton.VBButton();
            txtPromotionName = new TextBox();
            txtIdPromotion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnFillter = new CustomButton.VBButton();
            txtTo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtFrom = new TextBox();
            label8 = new Label();
            cbbFillter = new ComboBox();
            dtpEndTime = new DateTimePicker();
            label7 = new Label();
            dtpStartTime = new DateTimePicker();
            btnTimKiem = new CustomButton.VBButton();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvListPromotion).BeginInit();
            grbListCustomer.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListPromotion
            // 
            dgvListPromotion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListPromotion.BackgroundColor = SystemColors.ButtonFace;
            dgvListPromotion.BorderStyle = BorderStyle.None;
            dgvListPromotion.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListPromotion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListPromotion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListPromotion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListPromotion.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListPromotion.Dock = DockStyle.Fill;
            dgvListPromotion.EnableHeadersVisualStyles = false;
            dgvListPromotion.GridColor = Color.MediumSlateBlue;
            dgvListPromotion.Location = new Point(3, 27);
            dgvListPromotion.Name = "dgvListPromotion";
            dgvListPromotion.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListPromotion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListPromotion.RowHeadersVisible = false;
            dgvListPromotion.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvListPromotion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListPromotion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListPromotion.Size = new Size(1209, 320);
            dgvListPromotion.TabIndex = 0;
            dgvListPromotion.CellClick += dgvListPromotion_CellClick;
            // 
            // grbListCustomer
            // 
            grbListCustomer.Controls.Add(dgvListPromotion);
            grbListCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbListCustomer.Location = new Point(170, 371);
            grbListCustomer.Name = "grbListCustomer";
            grbListCustomer.Size = new Size(1215, 350);
            grbListCustomer.TabIndex = 8;
            grbListCustomer.TabStop = false;
            grbListCustomer.Text = "Danh sách promotion";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(34, 280);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 164;
            label6.Text = "Tìm theo";
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(34, 222);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(148, 33);
            cbbTimKiem.TabIndex = 163;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.BackColor = Color.White;
            btnSearch.BackgroundColor = Color.White;
            btnSearch.BorderColor = Color.White;
            btnSearch.BorderRadius = 0;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.search__1_3;
            btnSearch.Location = new Point(534, 311);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(72, 29);
            btnSearch.TabIndex = 162;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Left;
            btnExcel.BackColor = Color.MediumSlateBlue;
            btnExcel.BackgroundColor = Color.MediumSlateBlue;
            btnExcel.BorderColor = Color.PaleVioletRed;
            btnExcel.BorderRadius = 20;
            btnExcel.BorderSize = 0;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(920, 302);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(131, 40);
            btnExcel.TabIndex = 82;
            btnExcel.Text = "Xuất excel";
            btnExcel.TextColor = Color.White;
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(562, 22);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 87;
            label5.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(562, 50);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(211, 31);
            txtDiscount.TabIndex = 86;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(562, 112);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 85;
            label4.Text = "ID account";
            // 
            // txtIdAccount
            // 
            txtIdAccount.Location = new Point(562, 142);
            txtIdAccount.Name = "txtIdAccount";
            txtIdAccount.ReadOnly = true;
            txtIdAccount.Size = new Size(211, 31);
            txtIdAccount.TabIndex = 84;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 112);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 83;
            label3.Text = "Start time";
            // 
            // vbButton1
            // 
            vbButton1.Anchor = AnchorStyles.Left;
            vbButton1.BackColor = Color.White;
            vbButton1.BackgroundColor = Color.White;
            vbButton1.BorderColor = Color.White;
            vbButton1.BorderRadius = 0;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.ForeColor = Color.White;
            vbButton1.Image = Properties.Resources.search__1_3;
            vbButton1.Location = new Point(355, 445);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(72, 29);
            vbButton1.TabIndex = 81;
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(34, 444);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(403, 36);
            textBox7.TabIndex = 80;
            textBox7.Text = "Tìm kiếm";
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
            vbButton2.ForeColor = Color.White;
            vbButton2.Image = Properties.Resources.reset__1_;
            vbButton2.Location = new Point(920, 142);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(131, 40);
            vbButton2.TabIndex = 79;
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
            vbButton2.Click += vbButton2_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.MediumSlateBlue;
            btnSua.BackgroundColor = Color.MediumSlateBlue;
            btnSua.BorderColor = Color.PaleVioletRed;
            btnSua.BorderRadius = 20;
            btnSua.BorderSize = 0;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(920, 77);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 40);
            btnSua.TabIndex = 77;
            btnSua.Text = "Sửa";
            btnSua.TextColor = Color.White;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumSlateBlue;
            btnThem.BackgroundColor = Color.MediumSlateBlue;
            btnThem.BorderColor = Color.PaleVioletRed;
            btnThem.BorderRadius = 20;
            btnThem.BorderSize = 0;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(920, 14);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtPromotionName
            // 
            txtPromotionName.Location = new Point(275, 50);
            txtPromotionName.Name = "txtPromotionName";
            txtPromotionName.Size = new Size(211, 31);
            txtPromotionName.TabIndex = 7;
            // 
            // txtIdPromotion
            // 
            txtIdPromotion.Location = new Point(34, 50);
            txtIdPromotion.Name = "txtIdPromotion";
            txtIdPromotion.Size = new Size(175, 31);
            txtIdPromotion.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(275, 22);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 1;
            label2.Text = "Promotion name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "ID promotion";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFillter);
            panel1.Controls.Add(txtTo);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtFrom);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cbbFillter);
            panel1.Controls.Add(dtpEndTime);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dtpStartTime);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbbTimKiem);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnExcel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtIdAccount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(vbButton1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(vbButton2);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtPromotionName);
            panel1.Controls.Add(txtIdPromotion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTimKiem);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(57, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 272);
            panel1.TabIndex = 0;
            // 
            // btnFillter
            // 
            btnFillter.BackColor = Color.MediumSlateBlue;
            btnFillter.BackgroundColor = Color.MediumSlateBlue;
            btnFillter.BorderColor = Color.PaleVioletRed;
            btnFillter.BorderRadius = 20;
            btnFillter.BorderSize = 0;
            btnFillter.FlatAppearance.BorderSize = 0;
            btnFillter.FlatStyle = FlatStyle.Flat;
            btnFillter.ForeColor = Color.White;
            btnFillter.Location = new Point(1002, 217);
            btnFillter.Name = "btnFillter";
            btnFillter.Size = new Size(89, 40);
            btnFillter.TabIndex = 176;
            btnFillter.Text = "Lọc";
            btnFillter.TextColor = Color.White;
            btnFillter.UseVisualStyleBackColor = false;
            btnFillter.Click += btnFillter_Click;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(916, 225);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(80, 31);
            txtTo.TabIndex = 175;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(876, 225);
            label10.Name = "label10";
            label10.Size = new Size(34, 25);
            label10.TabIndex = 174;
            label10.Text = "To:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(735, 225);
            label9.Name = "label9";
            label9.Size = new Size(58, 25);
            label9.TabIndex = 173;
            label9.Text = "From:";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(790, 224);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(80, 31);
            txtFrom.TabIndex = 172;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(606, 194);
            label8.Name = "label8";
            label8.Size = new Size(54, 25);
            label8.TabIndex = 171;
            label8.Text = "Fillter";
            // 
            // cbbFillter
            // 
            cbbFillter.FormattingEnabled = true;
            cbbFillter.Location = new Point(606, 222);
            cbbFillter.Name = "cbbFillter";
            cbbFillter.Size = new Size(123, 33);
            cbbFillter.TabIndex = 170;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Short;
            dtpEndTime.Location = new Point(275, 140);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(172, 31);
            dtpEndTime.TabIndex = 169;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(275, 112);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 168;
            label7.Text = "End time";
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Short;
            dtpStartTime.Location = new Point(34, 140);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(172, 31);
            dtpStartTime.TabIndex = 167;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Left;
            btnTimKiem.BackColor = Color.White;
            btnTimKiem.BackgroundColor = Color.White;
            btnTimKiem.BorderColor = Color.White;
            btnTimKiem.BorderRadius = 0;
            btnTimKiem.BorderSize = 0;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Image = Properties.Resources.search__1_3;
            btnTimKiem.Location = new Point(485, 221);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(72, 29);
            btnTimKiem.TabIndex = 166;
            btnTimKiem.TextColor = Color.White;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Location = new Point(188, 219);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(369, 36);
            txtTimKiem.TabIndex = 165;
            txtTimKiem.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(113, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1272, 304);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // FormPromotion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 758);
            Controls.Add(grbListCustomer);
            Controls.Add(groupBox1);
            Name = "FormPromotion";
            Text = "FormPromotion";
            Load += FormPromotion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListPromotion).EndInit();
            grbListCustomer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListPromotion;
        private GroupBox grbListCustomer;
        private Label label6;
        private ComboBox cbbTimKiem;
        private CustomButton.VBButton btnSearch;
        private CustomButton.VBButton btnExcel;
        private Label label5;
        private TextBox txtDiscount;
        private Label label4;
        private TextBox txtIdAccount;
        private Label label3;
        private CustomButton.VBButton vbButton1;
        private TextBox textBox7;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton btnSua;
        private CustomButton.VBButton btnThem;
        private TextBox txtPromotionName;
        private TextBox txtIdPromotion;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private CustomButton.VBButton btnTimKiem;
        private TextBox txtTimKiem;
        private DateTimePicker dtpEndTime;
        private Label label7;
        private DateTimePicker dtpStartTime;
        private ComboBox cbbFillter;
        private CustomButton.VBButton btnFillter;
        private TextBox txtTo;
        private Label label10;
        private Label label9;
        private TextBox txtFrom;
        private Label label8;
    }
}