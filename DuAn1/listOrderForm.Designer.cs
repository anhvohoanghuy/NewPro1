namespace DuAn1
{
    partial class listOrderForm
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
            groupBox1 = new GroupBox();
            btnCustom = new CustomButton.VBButton();
            btnOk = new CustomButton.VBButton();
            btnRefesh = new CustomButton.VBButton();
            btnTimKiem = new CustomButton.VBButton();
            txtTImKiem = new TextBox();
            btnThisMonth = new CustomButton.VBButton();
            btnLast30Days = new CustomButton.VBButton();
            btnLast7Days = new CustomButton.VBButton();
            btnToday = new CustomButton.VBButton();
            dtpStartdate = new DateTimePicker();
            dtpEndate = new DateTimePicker();
            btnExcel = new CustomButton.VBButton();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(121, 388);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1455, 350);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách order";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
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
            dataGridView1.Size = new Size(1449, 320);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(btnCustom);
            groupBox1.Controls.Add(btnOk);
            groupBox1.Controls.Add(btnRefesh);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTImKiem);
            groupBox1.Controls.Add(btnThisMonth);
            groupBox1.Controls.Add(btnLast30Days);
            groupBox1.Controls.Add(btnLast7Days);
            groupBox1.Controls.Add(btnToday);
            groupBox1.Controls.Add(dtpStartdate);
            groupBox1.Controls.Add(dtpEndate);
            groupBox1.Location = new Point(121, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1176, 266);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // btnCustom
            // 
            btnCustom.BackColor = Color.MediumSlateBlue;
            btnCustom.BackgroundColor = Color.MediumSlateBlue;
            btnCustom.BorderColor = Color.PaleVioletRed;
            btnCustom.BorderRadius = 20;
            btnCustom.BorderSize = 0;
            btnCustom.FlatAppearance.BorderSize = 0;
            btnCustom.FlatStyle = FlatStyle.Flat;
            btnCustom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustom.ForeColor = Color.White;
            btnCustom.Location = new Point(516, 37);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(127, 37);
            btnCustom.TabIndex = 6;
            btnCustom.Text = "Custom";
            btnCustom.TextColor = Color.White;
            btnCustom.UseVisualStyleBackColor = false;
            btnCustom.Click += btnCustom_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.MediumSlateBlue;
            btnOk.BackgroundColor = Color.MediumSlateBlue;
            btnOk.BorderColor = Color.PaleVioletRed;
            btnOk.BorderRadius = 20;
            btnOk.BorderSize = 0;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(455, 27);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(55, 49);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.TextColor = Color.White;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Visible = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnRefesh
            // 
            btnRefesh.BackColor = Color.MediumSlateBlue;
            btnRefesh.BackgroundColor = Color.MediumSlateBlue;
            btnRefesh.BorderColor = Color.PaleVioletRed;
            btnRefesh.BorderRadius = 20;
            btnRefesh.BorderSize = 0;
            btnRefesh.FlatAppearance.BorderSize = 0;
            btnRefesh.FlatStyle = FlatStyle.Flat;
            btnRefesh.ForeColor = Color.White;
            btnRefesh.Location = new Point(864, 101);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(131, 40);
            btnRefesh.TabIndex = 102;
            btnRefesh.Text = "Refesh";
            btnRefesh.TextColor = Color.White;
            btnRefesh.UseVisualStyleBackColor = false;
            btnRefesh.Click += btnRefesh_Click;
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
            btnTimKiem.Location = new Point(377, 192);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(72, 29);
            btnTimKiem.TabIndex = 92;
            btnTimKiem.TextColor = Color.White;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTImKiem
            // 
            txtTImKiem.Anchor = AnchorStyles.Left;
            txtTImKiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTImKiem.ForeColor = Color.Gray;
            txtTImKiem.Location = new Point(55, 189);
            txtTImKiem.Multiline = true;
            txtTImKiem.Name = "txtTImKiem";
            txtTImKiem.Size = new Size(403, 36);
            txtTImKiem.TabIndex = 91;
            txtTImKiem.Text = "Tìm kiếm";
            txtTImKiem.Click += txtTImKiem_Click;
            // 
            // btnThisMonth
            // 
            btnThisMonth.BackColor = Color.MediumSlateBlue;
            btnThisMonth.BackgroundColor = Color.MediumSlateBlue;
            btnThisMonth.BorderColor = Color.PaleVioletRed;
            btnThisMonth.BorderRadius = 20;
            btnThisMonth.BorderSize = 0;
            btnThisMonth.FlatAppearance.BorderSize = 0;
            btnThisMonth.FlatStyle = FlatStyle.Flat;
            btnThisMonth.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThisMonth.ForeColor = Color.White;
            btnThisMonth.Location = new Point(864, 34);
            btnThisMonth.Name = "btnThisMonth";
            btnThisMonth.Size = new Size(118, 37);
            btnThisMonth.TabIndex = 8;
            btnThisMonth.Text = "This Month";
            btnThisMonth.TextColor = Color.White;
            btnThisMonth.UseVisualStyleBackColor = false;
            btnThisMonth.Click += btnThisMonth_Click;
            // 
            // btnLast30Days
            // 
            btnLast30Days.BackColor = Color.MediumSlateBlue;
            btnLast30Days.BackgroundColor = Color.MediumSlateBlue;
            btnLast30Days.BorderColor = Color.PaleVioletRed;
            btnLast30Days.BorderRadius = 16;
            btnLast30Days.BorderSize = 0;
            btnLast30Days.FlatAppearance.BorderSize = 0;
            btnLast30Days.FlatStyle = FlatStyle.Flat;
            btnLast30Days.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLast30Days.ForeColor = Color.White;
            btnLast30Days.Location = new Point(680, 101);
            btnLast30Days.Name = "btnLast30Days";
            btnLast30Days.Size = new Size(131, 40);
            btnLast30Days.TabIndex = 7;
            btnLast30Days.Text = "Last 30 Days";
            btnLast30Days.TextColor = Color.White;
            btnLast30Days.UseVisualStyleBackColor = false;
            btnLast30Days.Click += btnLast30Days_Click;
            // 
            // btnLast7Days
            // 
            btnLast7Days.BackColor = Color.MediumSlateBlue;
            btnLast7Days.BackgroundColor = Color.MediumSlateBlue;
            btnLast7Days.BorderColor = Color.PaleVioletRed;
            btnLast7Days.BorderRadius = 20;
            btnLast7Days.BorderSize = 0;
            btnLast7Days.FlatAppearance.BorderSize = 0;
            btnLast7Days.FlatStyle = FlatStyle.Flat;
            btnLast7Days.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLast7Days.ForeColor = Color.White;
            btnLast7Days.Location = new Point(680, 34);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(132, 42);
            btnLast7Days.TabIndex = 5;
            btnLast7Days.Text = "Last 7 Days";
            btnLast7Days.TextColor = Color.White;
            btnLast7Days.UseVisualStyleBackColor = false;
            btnLast7Days.Click += btnLast7Days_Click;
            // 
            // btnToday
            // 
            btnToday.BackColor = Color.MediumSlateBlue;
            btnToday.BackgroundColor = Color.MediumSlateBlue;
            btnToday.BorderColor = Color.PaleVioletRed;
            btnToday.BorderRadius = 20;
            btnToday.BorderSize = 0;
            btnToday.FlatAppearance.BorderSize = 0;
            btnToday.FlatStyle = FlatStyle.Flat;
            btnToday.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToday.ForeColor = Color.White;
            btnToday.Location = new Point(516, 104);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(127, 37);
            btnToday.TabIndex = 4;
            btnToday.Text = "Today";
            btnToday.TextColor = Color.White;
            btnToday.UseVisualStyleBackColor = false;
            btnToday.Click += btnToday_Click;
            // 
            // dtpStartdate
            // 
            dtpStartdate.Enabled = false;
            dtpStartdate.Format = DateTimePickerFormat.Short;
            dtpStartdate.Location = new Point(55, 41);
            dtpStartdate.Name = "dtpStartdate";
            dtpStartdate.Size = new Size(186, 27);
            dtpStartdate.TabIndex = 2;
            // 
            // dtpEndate
            // 
            dtpEndate.Enabled = false;
            dtpEndate.Format = DateTimePickerFormat.Short;
            dtpEndate.Location = new Point(263, 41);
            dtpEndate.Name = "dtpEndate";
            dtpEndate.Size = new Size(186, 27);
            dtpEndate.TabIndex = 3;
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
            btnExcel.Location = new Point(680, 163);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(135, 40);
            btnExcel.TabIndex = 103;
            btnExcel.Text = "Xuất excel";
            btnExcel.TextColor = Color.White;
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // listOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1627, 906);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "listOrderForm";
            Text = "listOrderForm";
            Load += listOrderForm_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private CustomButton.VBButton btnThisMonth;
        private CustomButton.VBButton btnLast30Days;
        private CustomButton.VBButton btnCustom;
        private CustomButton.VBButton btnLast7Days;
        private CustomButton.VBButton btnToday;
        private DateTimePicker dtpStartdate;
        private CustomButton.VBButton btnOk;
        private DateTimePicker dtpEndate;
        private CustomButton.VBButton btnTimKiem;
        private TextBox txtTImKiem;
        private CustomButton.VBButton btnRefesh;
        private CustomButton.VBButton btnExcel;
    }
}