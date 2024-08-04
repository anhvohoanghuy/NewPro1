namespace DuAn1
{
    partial class FormCustomer
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
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            label6 = new Label();
            cbbTimKiem = new ComboBox();
            btnSearch = new CustomButton.VBButton();
            txtTimKiem = new TextBox();
            btnExcel = new CustomButton.VBButton();
            label5 = new Label();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            txtIdAccount = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            vbButton1 = new CustomButton.VBButton();
            textBox7 = new TextBox();
            vbButton2 = new CustomButton.VBButton();
            btnSua = new CustomButton.VBButton();
            btnThem = new CustomButton.VBButton();
            txtCustomerName = new TextBox();
            txtIdCustomer = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grbListCustomer = new GroupBox();
            dgvListCustomer = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            grbListCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListCustomer).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(78, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1272, 304);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbbTimKiem);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnExcel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtIdAccount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(vbButton1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(vbButton2);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtCustomerName);
            panel1.Controls.Add(txtIdCustomer);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(57, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 272);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(34, 194);
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
            cbbTimKiem.Size = new Size(172, 33);
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
            btnSearch.Location = new Point(534, 225);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(72, 29);
            btnSearch.TabIndex = 162;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Location = new Point(212, 222);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(403, 36);
            txtTimKiem.TabIndex = 161;
            txtTimKiem.Text = "Tìm kiếm";
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
            btnExcel.Location = new Point(920, 216);
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
            label5.Size = new Size(129, 25);
            label5.TabIndex = 87;
            label5.Text = "Phone number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(562, 50);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(248, 31);
            txtPhoneNumber.TabIndex = 86;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 112);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 85;
            label4.Text = "ID account";
            // 
            // txtIdAccount
            // 
            txtIdAccount.Location = new Point(275, 142);
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
            label3.Size = new Size(77, 25);
            label3.TabIndex = 83;
            label3.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(34, 142);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(175, 31);
            txtAddress.TabIndex = 82;
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
            vbButton1.Location = new Point(355, 359);
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
            textBox7.Location = new Point(34, 358);
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
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(275, 50);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(211, 31);
            txtCustomerName.TabIndex = 7;
            // 
            // txtIdCustomer
            // 
            txtIdCustomer.Location = new Point(34, 50);
            txtIdCustomer.Name = "txtIdCustomer";
            txtIdCustomer.ReadOnly = true;
            txtIdCustomer.Size = new Size(175, 31);
            txtIdCustomer.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(275, 22);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 1;
            label2.Text = "Customer name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "ID customer";
            // 
            // grbListCustomer
            // 
            grbListCustomer.Controls.Add(dgvListCustomer);
            grbListCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbListCustomer.Location = new Point(135, 396);
            grbListCustomer.Name = "grbListCustomer";
            grbListCustomer.Size = new Size(1215, 350);
            grbListCustomer.TabIndex = 6;
            grbListCustomer.TabStop = false;
            grbListCustomer.Text = "Danh sách khách hàng";
            // 
            // dgvListCustomer
            // 
            dgvListCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListCustomer.BackgroundColor = SystemColors.ButtonFace;
            dgvListCustomer.BorderStyle = BorderStyle.None;
            dgvListCustomer.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListCustomer.Dock = DockStyle.Fill;
            dgvListCustomer.EnableHeadersVisualStyles = false;
            dgvListCustomer.GridColor = Color.MediumSlateBlue;
            dgvListCustomer.Location = new Point(3, 27);
            dgvListCustomer.Name = "dgvListCustomer";
            dgvListCustomer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListCustomer.RowHeadersVisible = false;
            dgvListCustomer.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.HighlightText;
            dgvListCustomer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListCustomer.Size = new Size(1209, 320);
            dgvListCustomer.TabIndex = 0;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 758);
            Controls.Add(groupBox1);
            Controls.Add(grbListCustomer);
            Name = "FormCustomer";
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbListCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private CustomButton.VBButton btnExcel;
        private Label label5;
        private TextBox txtPhoneNumber;
        private Label label4;
        private TextBox txtIdAccount;
        private Label label3;
        private TextBox txtAddress;
        private CustomButton.VBButton vbButton1;
        private TextBox textBox7;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton btnSua;
        private CustomButton.VBButton btnThem;
        private TextBox txtCustomerName;
        private TextBox txtIdCustomer;
        private Label label2;
        private Label label1;
        private GroupBox grbListCustomer;
        private DataGridView dgvListCustomer;
        private Label label6;
        private ComboBox cbbTimKiem;
        private CustomButton.VBButton btnSearch;
        private TextBox txtTimKiem;
    }
}