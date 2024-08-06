namespace DuAn1
{
    partial class FormVoucher
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
            panel1 = new Panel();
            label5 = new Label();
            txtUsageCount = new TextBox();
            lblIDAccount = new Label();
            txtIdAccount = new TextBox();
            btnTimKiem = new CustomButton.VBButton();
            txtTimKiem = new TextBox();
            vbButton2 = new CustomButton.VBButton();
            btnXoa = new CustomButton.VBButton();
            btnSua = new CustomButton.VBButton();
            btnThem = new CustomButton.VBButton();
            dtpEndTime = new DateTimePicker();
            dtpStarTime = new DateTimePicker();
            label7 = new Label();
            txtIdVoucher = new TextBox();
            txtDiscount = new TextBox();
            txtVoucherName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgvListVoucher = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListVoucher).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtUsageCount);
            panel1.Controls.Add(lblIDAccount);
            panel1.Controls.Add(txtIdAccount);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(vbButton2);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(dtpEndTime);
            panel1.Controls.Add(dtpStarTime);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtIdVoucher);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(txtVoucherName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(21, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1127, 255);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(785, 22);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 85;
            label5.Text = "Usage count";
            // 
            // txtUsageCount
            // 
            txtUsageCount.Location = new Point(785, 52);
            txtUsageCount.Name = "txtUsageCount";
            txtUsageCount.Size = new Size(137, 31);
            txtUsageCount.TabIndex = 84;
            // 
            // lblIDAccount
            // 
            lblIDAccount.AutoSize = true;
            lblIDAccount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDAccount.Location = new Point(607, 94);
            lblIDAccount.Name = "lblIDAccount";
            lblIDAccount.Size = new Size(95, 25);
            lblIDAccount.TabIndex = 83;
            lblIDAccount.Text = "Id account";
            // 
            // txtIdAccount
            // 
            txtIdAccount.Location = new Point(607, 124);
            txtIdAccount.Name = "txtIdAccount";
            txtIdAccount.ReadOnly = true;
            txtIdAccount.Size = new Size(137, 31);
            txtIdAccount.TabIndex = 82;
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
            btnTimKiem.Location = new Point(355, 196);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(72, 29);
            btnTimKiem.TabIndex = 81;
            btnTimKiem.TextColor = Color.White;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Location = new Point(34, 195);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(403, 36);
            txtTimKiem.TabIndex = 80;
            txtTimKiem.Text = "Tìm kiếm";
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
            vbButton2.Location = new Point(947, 185);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(131, 40);
            vbButton2.TabIndex = 79;
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
            vbButton2.Click += vbButton2_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.MediumSlateBlue;
            btnXoa.BackgroundColor = Color.MediumSlateBlue;
            btnXoa.BorderColor = Color.PaleVioletRed;
            btnXoa.BorderRadius = 20;
            btnXoa.BorderSize = 0;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(947, 124);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 40);
            btnXoa.TabIndex = 78;
            btnXoa.Text = "Xóa";
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
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
            btnSua.Location = new Point(947, 70);
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
            btnThem.Location = new Point(947, 14);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Location = new Point(280, 127);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(250, 31);
            dtpEndTime.TabIndex = 15;
            // 
            // dtpStarTime
            // 
            dtpStarTime.Location = new Point(280, 50);
            dtpStarTime.Name = "dtpStarTime";
            dtpStarTime.Size = new Size(250, 31);
            dtpStarTime.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(607, 22);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 13;
            label7.Text = "Id voucher";
            // 
            // txtIdVoucher
            // 
            txtIdVoucher.Location = new Point(607, 52);
            txtIdVoucher.Name = "txtIdVoucher";
            txtIdVoucher.Size = new Size(137, 31);
            txtIdVoucher.TabIndex = 10;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(34, 127);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(158, 31);
            txtDiscount.TabIndex = 7;
            // 
            // txtVoucherName
            // 
            txtVoucherName.Location = new Point(34, 50);
            txtVoucherName.Name = "txtVoucherName";
            txtVoucherName.Size = new Size(158, 31);
            txtVoucherName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 99);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 3;
            label4.Text = "End time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 22);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "Start time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 94);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Discount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Voucher name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(179, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1181, 287);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvListVoucher);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(179, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1181, 350);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Voucher";
            // 
            // dgvListVoucher
            // 
            dgvListVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListVoucher.BackgroundColor = SystemColors.ButtonFace;
            dgvListVoucher.BorderStyle = BorderStyle.None;
            dgvListVoucher.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListVoucher.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListVoucher.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListVoucher.Dock = DockStyle.Fill;
            dgvListVoucher.EnableHeadersVisualStyles = false;
            dgvListVoucher.GridColor = Color.MediumSlateBlue;
            dgvListVoucher.Location = new Point(3, 27);
            dgvListVoucher.Name = "dgvListVoucher";
            dgvListVoucher.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListVoucher.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListVoucher.RowHeadersVisible = false;
            dgvListVoucher.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvListVoucher.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListVoucher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListVoucher.Size = new Size(1175, 320);
            dgvListVoucher.TabIndex = 1;
            dgvListVoucher.CellClick += dgvListVoucher_CellClick;
            // 
            // FormVoucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 695);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormVoucher";
            Text = "FormVoucher";
            Load += FormVoucher_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListVoucher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtIdVoucher;
        private TextBox txtDiscount;
        private TextBox txtVoucherName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpEndTime;
        private DateTimePicker dtpStarTime;
        private Label label7;
        private CustomButton.VBButton btnThem;
        private CustomButton.VBButton btnSua;
        private CustomButton.VBButton btnXoa;
        private CustomButton.VBButton vbButton2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTimKiem;
        private CustomButton.VBButton btnTimKiem;
        private DataGridView dgvListVoucher;
        private Label lblIDAccount;
        private TextBox txtIdAccount;
        private Label label5;
        private TextBox txtUsageCount;
    }
}