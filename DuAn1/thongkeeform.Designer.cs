namespace DuAn1
{
    partial class thongkeeform
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label1 = new Label();
            btnOk = new CustomButton.VBButton();
            dtpStartdate = new DateTimePicker();
            dtpEnđate = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnThisMonth = new CustomButton.VBButton();
            btnLast30Days = new CustomButton.VBButton();
            btnCustom = new CustomButton.VBButton();
            btnLast7Days = new CustomButton.VBButton();
            btnToday = new CustomButton.VBButton();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            dgvnbOrder = new DataGridView();
            a = new DataGridViewTextBoxColumn();
            STT = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox6 = new GroupBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            groupBox7 = new GroupBox();
            label11 = new Label();
            label12 = new Label();
            groupBox8 = new GroupBox();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox9 = new GroupBox();
            label16 = new Label();
            label17 = new Label();
            groupBox10 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label15 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnbOrder).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 52);
            label1.Name = "label1";
            label1.Size = new Size(151, 38);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
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
            btnOk.Location = new Point(406, 39);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(55, 49);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.TextColor = Color.White;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Visible = false;
            // 
            // dtpStartdate
            // 
            dtpStartdate.Enabled = false;
            dtpStartdate.Format = DateTimePickerFormat.Short;
            dtpStartdate.Location = new Point(6, 51);
            dtpStartdate.Name = "dtpStartdate";
            dtpStartdate.Size = new Size(186, 27);
            dtpStartdate.TabIndex = 2;
            // 
            // dtpEnđate
            // 
            dtpEnđate.Enabled = false;
            dtpEnđate.Format = DateTimePickerFormat.Short;
            dtpEnđate.Location = new Point(214, 51);
            dtpEnđate.Name = "dtpEnđate";
            dtpEnđate.Size = new Size(186, 27);
            dtpEnđate.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThisMonth);
            groupBox1.Controls.Add(btnLast30Days);
            groupBox1.Controls.Add(btnCustom);
            groupBox1.Controls.Add(btnLast7Days);
            groupBox1.Controls.Add(btnToday);
            groupBox1.Controls.Add(dtpStartdate);
            groupBox1.Controls.Add(btnOk);
            groupBox1.Controls.Add(dtpEnđate);
            groupBox1.Location = new Point(189, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1176, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
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
            btnThisMonth.Location = new Point(1042, 45);
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
            btnLast30Days.Location = new Point(891, 42);
            btnLast30Days.Name = "btnLast30Days";
            btnLast30Days.Size = new Size(131, 40);
            btnLast30Days.TabIndex = 7;
            btnLast30Days.Text = "btnLast30Days";
            btnLast30Days.TextColor = Color.White;
            btnLast30Days.UseVisualStyleBackColor = false;
            btnLast30Days.Click += btnLast30Days_Click;
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
            btnCustom.Location = new Point(467, 45);
            btnCustom.Name = "btnCustom";
            btnCustom.Size = new Size(110, 37);
            btnCustom.TabIndex = 6;
            btnCustom.Text = "Custom";
            btnCustom.TextColor = Color.White;
            btnCustom.UseVisualStyleBackColor = false;
            btnCustom.Click += btnCustom_Click;
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
            btnLast7Days.Location = new Point(733, 42);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(132, 42);
            btnLast7Days.TabIndex = 5;
            btnLast7Days.Text = "btnLast7Days";
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
            btnToday.Location = new Point(583, 45);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(127, 37);
            btnToday.TabIndex = 4;
            btnToday.Text = "btnToday";
            btnToday.TextColor = Color.White;
            btnToday.UseVisualStyleBackColor = false;
            btnToday.Click += btnToday_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(1293, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 104);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumOrchid;
            label6.Location = new Point(145, 58);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 2;
            label6.Text = "+value%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(67, 61);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 1;
            label5.Text = "valueNumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkViolet;
            label4.Location = new Point(33, 23);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 0;
            label4.Text = "number of orders";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvnbOrder);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(64, 173);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(370, 555);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "số lượng đơn hàng";
            // 
            // dgvnbOrder
            // 
            dgvnbOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvnbOrder.BackgroundColor = SystemColors.ButtonFace;
            dgvnbOrder.BorderStyle = BorderStyle.None;
            dgvnbOrder.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvnbOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvnbOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvnbOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnbOrder.Columns.AddRange(new DataGridViewColumn[] { a, STT, Column1, Column2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvnbOrder.DefaultCellStyle = dataGridViewCellStyle2;
            dgvnbOrder.EnableHeadersVisualStyles = false;
            dgvnbOrder.GridColor = Color.MediumSlateBlue;
            dgvnbOrder.Location = new Point(6, 26);
            dgvnbOrder.Name = "dgvnbOrder";
            dgvnbOrder.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvnbOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvnbOrder.RowHeadersVisible = false;
            dgvnbOrder.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.HighlightText;
            dgvnbOrder.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvnbOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvnbOrder.Size = new Size(358, 255);
            dgvnbOrder.TabIndex = 6;
            // 
            // a
            // 
            a.HeaderText = "IdOrder";
            a.MinimumWidth = 6;
            a.Name = "a";
            a.ReadOnly = true;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name Product";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "total(money)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(468, 173);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(370, 564);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sản phẩm bán chạy";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column3 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.MediumSlateBlue;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.HighlightText;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(358, 255);
            dataGridView1.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "IdProduct";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name Product";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Price";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity sold";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label9);
            groupBox5.Location = new Point(1293, 283);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 104);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumOrchid;
            label7.Location = new Point(145, 58);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 2;
            label7.Text = "+value%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(67, 61);
            label8.Name = "label8";
            label8.Size = new Size(36, 25);
            label8.TabIndex = 1;
            label8.Text = "VN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkViolet;
            label9.Location = new Point(33, 23);
            label9.Name = "label9";
            label9.Size = new Size(177, 28);
            label9.TabIndex = 0;
            label9.Text = "products imported";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView2);
            groupBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(861, 173);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(370, 564);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Sản phẩm đã nhập";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Quantity });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.MediumSlateBlue;
            dataGridView2.Location = new Point(6, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.HighlightText;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(358, 538);
            dataGridView2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "IdProd";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Name Product";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Brand";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(label12);
            groupBox7.Location = new Point(1293, 393);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(250, 104);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(67, 61);
            label11.Name = "label11";
            label11.Size = new Size(118, 25);
            label11.TabIndex = 1;
            label11.Text = "valueNumber";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkViolet;
            label12.Location = new Point(33, 23);
            label12.Name = "label12";
            label12.Size = new Size(125, 28);
            label12.TabIndex = 0;
            label12.Text = "New Product";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label10);
            groupBox8.Controls.Add(label13);
            groupBox8.Controls.Add(label14);
            groupBox8.Location = new Point(1293, 503);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(250, 104);
            groupBox8.TabIndex = 8;
            groupBox8.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MediumOrchid;
            label10.Location = new Point(145, 58);
            label10.Name = "label10";
            label10.Size = new Size(88, 28);
            label10.TabIndex = 2;
            label10.Text = "+value%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(67, 61);
            label13.Name = "label13";
            label13.Size = new Size(36, 25);
            label13.TabIndex = 1;
            label13.Text = "VN";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DarkViolet;
            label14.Location = new Point(33, 23);
            label14.Name = "label14";
            label14.Size = new Size(96, 28);
            label14.TabIndex = 0;
            label14.Text = "Customer";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(label16);
            groupBox9.Controls.Add(label17);
            groupBox9.Location = new Point(1293, 613);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(250, 104);
            groupBox9.TabIndex = 9;
            groupBox9.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(67, 61);
            label16.Name = "label16";
            label16.Size = new Size(36, 25);
            label16.TabIndex = 1;
            label16.Text = "VN";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.DarkViolet;
            label17.Location = new Point(33, 23);
            label17.Name = "label17";
            label17.Size = new Size(140, 28);
            label17.TabIndex = 0;
            label17.Text = "New Customer";
            label17.Click += label17_Click;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(label2);
            groupBox10.Controls.Add(label3);
            groupBox10.Controls.Add(label15);
            groupBox10.Location = new Point(1293, 723);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(250, 104);
            groupBox10.TabIndex = 9;
            groupBox10.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumOrchid;
            label2.Location = new Point(145, 58);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 2;
            label2.Text = "+value%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 61);
            label3.Name = "label3";
            label3.Size = new Size(36, 25);
            label3.TabIndex = 1;
            label3.Text = "VN";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DarkViolet;
            label15.Location = new Point(33, 23);
            label15.Name = "label15";
            label15.Size = new Size(135, 28);
            label15.TabIndex = 0;
            label15.Text = "Gross revenue";
            // 
            // thongkeeform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 978);
            Controls.Add(groupBox10);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "thongkeeform";
            Text = "thongkeeform";
            Load += thongkeeform_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvnbOrder).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton.VBButton btnOk;
        private DateTimePicker dtpStartdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpEnđate;
        private GroupBox groupBox1;
        private CustomButton.VBButton btnLast7Days;
        private CustomButton.VBButton btnToday;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox3;
        private DataGridView dgvnbOrder;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox5;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private CustomButton.VBButton btnThisMonth;
        private CustomButton.VBButton btnLast30Days;
        private CustomButton.VBButton btnCustom;
        private GroupBox groupBox7;
        private Label label11;
        private Label label12;
        private GroupBox groupBox8;
        private Label label10;
        private Label label13;
        private Label label14;
        private GroupBox groupBox9;
        private Label label16;
        private Label label17;
        private GroupBox groupBox10;
        private Label label15;
    }
}