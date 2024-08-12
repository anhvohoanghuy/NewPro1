namespace DuAn1
{
    partial class FormProductColor
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
            dgvListColor = new DataGridView();
            Idcolor = new TextBox();
            label6 = new Label();
            btnSearch = new CustomButton.VBButton();
            txtTimKiem = new TextBox();
            btnExcel = new CustomButton.VBButton();
            vbButton1 = new CustomButton.VBButton();
            textBox7 = new TextBox();
            btnSua = new CustomButton.VBButton();
            btnThem = new CustomButton.VBButton();
            txtColorName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBoxCPU = new GroupBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvListColor).BeginInit();
            groupBoxCPU.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListColor
            // 
            dgvListColor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListColor.BackgroundColor = SystemColors.ButtonFace;
            dgvListColor.BorderStyle = BorderStyle.None;
            dgvListColor.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListColor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListColor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListColor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListColor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListColor.Dock = DockStyle.Fill;
            dgvListColor.EnableHeadersVisualStyles = false;
            dgvListColor.GridColor = Color.MediumSlateBlue;
            dgvListColor.Location = new Point(3, 30);
            dgvListColor.Name = "dgvListColor";
            dgvListColor.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListColor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListColor.RowHeadersVisible = false;
            dgvListColor.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvListColor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListColor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListColor.Size = new Size(1115, 235);
            dgvListColor.TabIndex = 1;
            // 
            // Idcolor
            // 
            Idcolor.Location = new Point(34, 51);
            Idcolor.Name = "Idcolor";
            Idcolor.Size = new Size(173, 31);
            Idcolor.TabIndex = 165;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(34, 333);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
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
            btnSearch.Location = new Point(534, 364);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(72, 29);
            btnSearch.TabIndex = 162;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Left;
            txtTimKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Location = new Point(213, 360);
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
            btnExcel.Location = new Point(920, 355);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(131, 40);
            btnExcel.TabIndex = 82;
            btnExcel.Text = "Xuất excel";
            btnExcel.TextColor = Color.White;
            btnExcel.UseVisualStyleBackColor = false;
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
            vbButton1.Location = new Point(355, 497);
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
            textBox7.Location = new Point(34, 496);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(403, 36);
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
            btnThem.Location = new Point(920, 13);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 40);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtColorName
            // 
            txtColorName.Location = new Point(275, 51);
            txtColorName.Name = "txtColorName";
            txtColorName.Size = new Size(211, 31);
            txtColorName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(275, 21);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Name Color";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Id Color";
            // 
            // groupBoxCPU
            // 
            groupBoxCPU.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxCPU.Controls.Add(dgvListColor);
            groupBoxCPU.Font = new Font("Segoe UI", 12F);
            groupBoxCPU.Location = new Point(182, 320);
            groupBoxCPU.Name = "groupBoxCPU";
            groupBoxCPU.Size = new Size(1121, 268);
            groupBoxCPU.TabIndex = 69;
            groupBoxCPU.TabStop = false;
            groupBoxCPU.Text = "Danh sách Color";
            // 
            // panel1
            // 
            panel1.Controls.Add(Idcolor);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnExcel);
            panel1.Controls.Add(vbButton1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtColorName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(182, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 272);
            panel1.TabIndex = 68;
            // 
            // FormProductColor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 600);
            Controls.Add(groupBoxCPU);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProductColor";
            Text = "FormProductColor";
            Load += FormProductColor_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvListColor).EndInit();
            groupBoxCPU.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListColor;
        private TextBox Idcolor;
        private Label label6;
        private CustomButton.VBButton btnSearch;
        private TextBox txtTimKiem;
        private CustomButton.VBButton btnExcel;
        private CustomButton.VBButton vbButton1;
        private TextBox textBox7;
        private CustomButton.VBButton btnSua;
        private CustomButton.VBButton btnThem;
        private TextBox txtColorName;
        private Label label2;
        private Label label1;
        private GroupBox groupBoxCPU;
        private Panel panel1;
    }
}