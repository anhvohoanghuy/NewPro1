namespace DuAn1
{
    partial class FormCPU
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
            cPuID = new TextBox();
            label6 = new Label();
            btnSearch = new CustomButton.VBButton();
            txtTimKiem = new TextBox();
            btnExcel = new CustomButton.VBButton();
            label5 = new Label();
            txtManufacturer = new TextBox();
            vbButton1 = new CustomButton.VBButton();
            textBox7 = new TextBox();
            btnSua = new CustomButton.VBButton();
            btnThem = new CustomButton.VBButton();
            txtNAMECPU = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBoxCPU = new GroupBox();
            dgvListCPU = new DataGridView();
            panel1.SuspendLayout();
            groupBoxCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListCPU).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cPuID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnExcel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtManufacturer);
            panel1.Controls.Add(vbButton1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtNAMECPU);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(87, 38);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 204);
            panel1.TabIndex = 1;
            // 
            // cPuID
            // 
            cPuID.Location = new Point(30, 38);
            cPuID.Margin = new Padding(3, 2, 3, 2);
            cPuID.Name = "cPuID";
            cPuID.Size = new Size(152, 27);
            cPuID.TabIndex = 165;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(30, 198);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 164;
            label6.Text = "Tìm theo";
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
            btnSearch.Location = new Point(467, 221);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 22);
            btnSearch.TabIndex = 162;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Location = new Point(186, 218);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(353, 28);
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
            btnExcel.Location = new Point(805, 214);
            btnExcel.Margin = new Padding(3, 2, 3, 2);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(115, 30);
            btnExcel.TabIndex = 82;
            btnExcel.Text = "Xuất excel";
            btnExcel.TextColor = Color.White;
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(492, 16);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 87;
            label5.Text = "Manufacturer";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(492, 38);
            txtManufacturer.Margin = new Padding(3, 2, 3, 2);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(218, 27);
            txtManufacturer.TabIndex = 86;
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
            vbButton1.Location = new Point(311, 321);
            vbButton1.Margin = new Padding(3, 2, 3, 2);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(63, 22);
            vbButton1.TabIndex = 81;
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(30, 320);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(353, 28);
            textBox7.TabIndex = 80;
            textBox7.Text = "Tìm kiếm";
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
            btnSua.Location = new Point(805, 58);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 30);
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
            btnThem.Location = new Point(805, 10);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 30);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtNAMECPU
            // 
            txtNAMECPU.Location = new Point(241, 38);
            txtNAMECPU.Margin = new Padding(3, 2, 3, 2);
            txtNAMECPU.Name = "txtNAMECPU";
            txtNAMECPU.Size = new Size(185, 27);
            txtNAMECPU.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(241, 16);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Name CPU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Id Cpu";
            // 
            // groupBoxCPU
            // 
            groupBoxCPU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxCPU.Controls.Add(dgvListCPU);
            groupBoxCPU.Font = new Font("Segoe UI", 12F);
            groupBoxCPU.Location = new Point(87, 268);
            groupBoxCPU.Margin = new Padding(3, 2, 3, 2);
            groupBoxCPU.Name = "groupBoxCPU";
            groupBoxCPU.Padding = new Padding(3, 2, 3, 2);
            groupBoxCPU.Size = new Size(981, 201);
            groupBoxCPU.TabIndex = 67;
            groupBoxCPU.TabStop = false;
            groupBoxCPU.Text = "Danh sách CPU ";
            // 
            // dgvListCPU
            // 
            dgvListCPU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListCPU.BackgroundColor = SystemColors.ButtonFace;
            dgvListCPU.BorderStyle = BorderStyle.None;
            dgvListCPU.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListCPU.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListCPU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListCPU.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListCPU.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListCPU.Dock = DockStyle.Fill;
            dgvListCPU.EnableHeadersVisualStyles = false;
            dgvListCPU.GridColor = Color.MediumSlateBlue;
            dgvListCPU.Location = new Point(3, 24);
            dgvListCPU.Margin = new Padding(3, 2, 3, 2);
            dgvListCPU.Name = "dgvListCPU";
            dgvListCPU.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListCPU.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListCPU.RowHeadersVisible = false;
            dgvListCPU.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvListCPU.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListCPU.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListCPU.Size = new Size(975, 175);
            dgvListCPU.TabIndex = 1;
            // 
            // FormCPU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 533);
            Controls.Add(groupBoxCPU);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FormCPU";
            Text = "FormCPU";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxCPU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListCPU).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private CustomButton.VBButton btnSearch;
        private TextBox txtTimKiem;
        private CustomButton.VBButton btnExcel;
        private Label label5;
        private TextBox txtManufacturer;
        private CustomButton.VBButton vbButton1;
        private TextBox textBox7;
        private CustomButton.VBButton btnSua;
        private CustomButton.VBButton btnThem;
        private TextBox txtNAMECPU;
        private Label label2;
        private Label label1;
        private TextBox cPuID;
        private GroupBox groupBoxCPU;
        private DataGridView dgvListCPU;
    }
}