﻿namespace DuAn1
{
    partial class TaiKhoanForm
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            IdAcount = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            level = new DataGridViewTextBoxColumn();
            NameAcount = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnExcel = new CustomButton.VBButton();
            vbButton3 = new CustomButton.VBButton();
            txtTImKiem = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            cbbLevel = new ComboBox();
            vbButton1 = new CustomButton.VBButton();
            textBox7 = new TextBox();
            btnresset = new CustomButton.VBButton();
            btnXoa = new CustomButton.VBButton();
            btnSua = new CustomButton.VBButton();
            btnThem = new CustomButton.VBButton();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(142, 437);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1215, 350);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdAcount, Password, level, NameAcount, Email });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.MediumSlateBlue;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1209, 320);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // IdAcount
            // 
            IdAcount.DataPropertyName = "Idaccount";
            IdAcount.HeaderText = "Id Account";
            IdAcount.MinimumWidth = 6;
            IdAcount.Name = "IdAcount";
            IdAcount.ReadOnly = true;
            // 
            // Password
            // 
            Password.DataPropertyName = "PassAccount";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // level
            // 
            level.DataPropertyName = "AccountLevel";
            level.HeaderText = "Level";
            level.MinimumWidth = 6;
            level.Name = "level";
            level.ReadOnly = true;
            // 
            // NameAcount
            // 
            NameAcount.DataPropertyName = "AccountName";
            NameAcount.HeaderText = "Name";
            NameAcount.MinimumWidth = 6;
            NameAcount.Name = "NameAcount";
            NameAcount.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(364, 124);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 85;
            label4.Text = "Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 130);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 83;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(34, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 31);
            txtEmail.TabIndex = 82;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(364, 50);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(158, 31);
            txtPass.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(34, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(158, 31);
            txtId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(364, 17);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Id account";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExcel);
            panel1.Controls.Add(vbButton3);
            panel1.Controls.Add(txtTImKiem);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbbLevel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(vbButton1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(btnresset);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(57, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 309);
            panel1.TabIndex = 0;
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
            btnExcel.Location = new Point(837, 238);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(135, 40);
            btnExcel.TabIndex = 91;
            btnExcel.Text = "Xuất excel";
            btnExcel.TextColor = Color.White;
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // vbButton3
            // 
            vbButton3.Anchor = AnchorStyles.Left;
            vbButton3.BackColor = Color.White;
            vbButton3.BackgroundColor = Color.White;
            vbButton3.BorderColor = Color.White;
            vbButton3.BorderRadius = 0;
            vbButton3.BorderSize = 0;
            vbButton3.FlatAppearance.BorderSize = 0;
            vbButton3.FlatStyle = FlatStyle.Flat;
            vbButton3.ForeColor = Color.White;
            vbButton3.Image = Properties.Resources.search__1_3;
            vbButton3.Location = new Point(389, 238);
            vbButton3.Name = "vbButton3";
            vbButton3.Size = new Size(72, 29);
            vbButton3.TabIndex = 90;
            vbButton3.TextColor = Color.White;
            vbButton3.UseVisualStyleBackColor = false;
            vbButton3.Click += vbButton3_Click;
            // 
            // txtTImKiem
            // 
            txtTImKiem.Anchor = AnchorStyles.Left;
            txtTImKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTImKiem.ForeColor = Color.Gray;
            txtTImKiem.Location = new Point(67, 235);
            txtTImKiem.Multiline = true;
            txtTImKiem.Name = "txtTImKiem";
            txtTImKiem.Size = new Size(403, 36);
            txtTImKiem.TabIndex = 89;
            txtTImKiem.Text = "Tìm kiếm";
            txtTImKiem.Click += txtTImKiem_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(625, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(158, 31);
            txtName.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(625, 17);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 87;
            label5.Text = "Name";
            // 
            // cbbLevel
            // 
            cbbLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbLevel.FormattingEnabled = true;
            cbbLevel.Items.AddRange(new object[] { "1", "2" });
            cbbLevel.Location = new Point(364, 154);
            cbbLevel.Name = "cbbLevel";
            cbbLevel.Size = new Size(151, 33);
            cbbLevel.TabIndex = 86;
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
            vbButton1.Location = new Point(355, 377);
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
            textBox7.Location = new Point(34, 376);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(403, 36);
            textBox7.TabIndex = 80;
            textBox7.Text = "Tìm kiếm";
            // 
            // btnresset
            // 
            btnresset.BackColor = Color.MediumSlateBlue;
            btnresset.BackgroundColor = Color.MediumSlateBlue;
            btnresset.BorderColor = Color.PaleVioletRed;
            btnresset.BorderRadius = 20;
            btnresset.BorderSize = 0;
            btnresset.FlatAppearance.BorderSize = 0;
            btnresset.FlatStyle = FlatStyle.Flat;
            btnresset.ForeColor = Color.White;
            btnresset.Image = Properties.Resources.reset__1_;
            btnresset.Location = new Point(837, 185);
            btnresset.Name = "btnresset";
            btnresset.Size = new Size(131, 40);
            btnresset.TabIndex = 79;
            btnresset.TextColor = Color.White;
            btnresset.UseVisualStyleBackColor = false;
            btnresset.Click += btnresset_Click;
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
            btnXoa.Location = new Point(837, 124);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 40);
            btnXoa.TabIndex = 78;
            btnXoa.Text = "Xóa";
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
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
            btnSua.Location = new Point(837, 70);
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
            btnThem.Location = new Point(837, 14);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(85, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1272, 367);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // TaiKhoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1442, 850);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TaiKhoanForm";
            Text = "TaiKhoanForm";
            Load += TaiKhoanForm_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPass;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private ComboBox cbbLevel;
        private CustomButton.VBButton vbButton1;
        private TextBox textBox7;
        private CustomButton.VBButton btnresset;
        private CustomButton.VBButton btnXoa;
        private CustomButton.VBButton btnSua;
        private CustomButton.VBButton btnThem;
        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label5;
        private CustomButton.VBButton vbButton3;
        private TextBox txtTImKiem;
        private DataGridViewTextBoxColumn IdAcount;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn level;
        private DataGridViewTextBoxColumn NameAcount;
        private DataGridViewTextBoxColumn Email;
        private CustomButton.VBButton btnExcel;
    }
}