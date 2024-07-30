namespace DuAn1
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            dgvListAccount = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            vbButton3 = new CustomButton.VBButton();
            textBox1 = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            cbbLevel = new ComboBox();
            vbButton1 = new CustomButton.VBButton();
            textBox7 = new TextBox();
            vbButton2 = new CustomButton.VBButton();
            btnXoa = new CustomButton.VBButton();
            btnSua = new CustomButton.VBButton();
            btnThem = new CustomButton.VBButton();
            groupBox1 = new GroupBox();
            grpStatus = new GroupBox();
            rdoActivate = new RadioButton();
            rdoUnActivated = new RadioButton();
            comboBox1 = new ComboBox();
            label6 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            grpStatus.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvListAccount);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(142, 437);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1215, 350);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvListAccount
            // 
            dgvListAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListAccount.BackgroundColor = SystemColors.ButtonFace;
            dgvListAccount.BorderStyle = BorderStyle.None;
            dgvListAccount.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvListAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvListAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvListAccount.DefaultCellStyle = dataGridViewCellStyle6;
            dgvListAccount.Dock = DockStyle.Fill;
            dgvListAccount.EnableHeadersVisualStyles = false;
            dgvListAccount.GridColor = Color.MediumSlateBlue;
            dgvListAccount.Location = new Point(3, 27);
            dgvListAccount.Name = "dgvListAccount";
            dgvListAccount.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvListAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvListAccount.RowHeadersVisible = false;
            dgvListAccount.RowHeadersWidth = 62;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GradientActiveCaption;
            dgvListAccount.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvListAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListAccount.Size = new Size(1209, 320);
            dgvListAccount.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(313, 130);
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
            txtEmail.Size = new Size(230, 31);
            txtEmail.TabIndex = 82;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(313, 55);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(225, 31);
            txtPass.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(34, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(230, 31);
            txtId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(313, 22);
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
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(grpStatus);
            panel1.Controls.Add(vbButton3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbbLevel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(vbButton1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(vbButton2);
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
            vbButton3.Location = new Point(507, 254);
            vbButton3.Name = "vbButton3";
            vbButton3.Size = new Size(72, 29);
            vbButton3.TabIndex = 90;
            vbButton3.TextColor = Color.White;
            vbButton3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(176, 249);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 36);
            textBox1.TabIndex = 89;
            textBox1.Text = "Tìm kiếm";
            // 
            // txtName
            // 
            txtName.Location = new Point(605, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 31);
            txtName.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(605, 17);
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
            cbbLevel.Location = new Point(313, 160);
            cbbLevel.Name = "cbbLevel";
            cbbLevel.Size = new Size(225, 33);
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
            vbButton2.Location = new Point(936, 212);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(131, 40);
            vbButton2.TabIndex = 79;
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
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
            btnXoa.Location = new Point(936, 151);
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
            btnSua.Location = new Point(936, 97);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 40);
            btnSua.TabIndex = 77;
            btnSua.Text = "Sửa";
            btnSua.TextColor = Color.White;
            btnSua.UseVisualStyleBackColor = false;
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
            btnThem.Location = new Point(936, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
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
            // grpStatus
            // 
            grpStatus.Controls.Add(rdoActivate);
            grpStatus.Controls.Add(rdoUnActivated);
            grpStatus.Location = new Point(605, 151);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(306, 74);
            grpStatus.TabIndex = 91;
            grpStatus.TabStop = false;
            grpStatus.Text = "Status";
            // 
            // rdoActivate
            // 
            rdoActivate.AutoSize = true;
            rdoActivate.Location = new Point(171, 30);
            rdoActivate.Name = "rdoActivate";
            rdoActivate.Size = new Size(107, 29);
            rdoActivate.TabIndex = 1;
            rdoActivate.TabStop = true;
            rdoActivate.Text = "Activated";
            rdoActivate.UseVisualStyleBackColor = true;
            // 
            // rdoUnActivated
            // 
            rdoUnActivated.AutoSize = true;
            rdoUnActivated.Location = new Point(18, 32);
            rdoUnActivated.Name = "rdoUnActivated";
            rdoUnActivated.Size = new Size(129, 29);
            rdoUnActivated.TabIndex = 0;
            rdoUnActivated.TabStop = true;
            rdoUnActivated.Text = "UnActivated";
            rdoUnActivated.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2" });
            comboBox1.Location = new Point(37, 250);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(118, 33);
            comboBox1.TabIndex = 93;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 220);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 92;
            label6.Text = "Level";
            // 
            // TaiKhoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 850);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TaiKhoanForm";
            Text = "TaiKhoanForm";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListAccount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvListAccount;
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
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton btnXoa;
        private CustomButton.VBButton btnSua;
        private CustomButton.VBButton btnThem;
        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label5;
        private CustomButton.VBButton vbButton3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label6;
        private GroupBox grpStatus;
        private RadioButton rdoActivate;
        private RadioButton rdoUnActivated;
    }
}