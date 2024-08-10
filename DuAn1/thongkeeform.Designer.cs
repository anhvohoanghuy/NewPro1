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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            label1 = new Label();
            btnOk = new CustomButton.VBButton();
            dtpStartdate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnThisMonth = new CustomButton.VBButton();
            btnLast30Days = new CustomButton.VBButton();
            btnCustom = new CustomButton.VBButton();
            btnLast7Days = new CustomButton.VBButton();
            btnToday = new CustomButton.VBButton();
            groupBox2 = new GroupBox();
            txtNumberOfOder = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            dgvBestCustomer = new DataGridView();
            groupBox4 = new GroupBox();
            dgvBestSeller = new DataGridView();
            groupBox5 = new GroupBox();
            txtProductsImported = new Label();
            label9 = new Label();
            groupBox6 = new GroupBox();
            dgvNewProduct = new DataGridView();
            groupBox7 = new GroupBox();
            txtProductOnSale = new Label();
            label12 = new Label();
            groupBox8 = new GroupBox();
            txtNumberOfCustomer = new Label();
            label14 = new Label();
            groupBox9 = new GroupBox();
            txtNewCustomer = new Label();
            label17 = new Label();
            groupBox10 = new GroupBox();
            txtGrossRevenue = new Label();
            label15 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestCustomer).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSeller).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNewProduct).BeginInit();
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
            btnOk.Location = new Point(427, 45);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(56, 37);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.TextColor = Color.White;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Visible = false;
            btnOk.Click += btnOk_Click;
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
            // dtpEndDate
            // 
            dtpEndDate.Enabled = false;
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(214, 51);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(186, 27);
            dtpEndDate.TabIndex = 3;
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
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Location = new Point(189, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1233, 125);
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
            btnThisMonth.Location = new Point(1092, 45);
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
            btnLast30Days.Location = new Point(926, 45);
            btnLast30Days.Name = "btnLast30Days";
            btnLast30Days.Size = new Size(142, 37);
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
            btnCustom.Location = new Point(503, 45);
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
            btnLast7Days.Location = new Point(769, 45);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(126, 37);
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
            btnToday.Location = new Point(619, 45);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(128, 37);
            btnToday.TabIndex = 4;
            btnToday.Text = "btnToday";
            btnToday.TextColor = Color.White;
            btnToday.UseVisualStyleBackColor = false;
            btnToday.Click += btnToday_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNumberOfOder);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(1293, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 104);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // txtNumberOfOder
            // 
            txtNumberOfOder.AutoSize = true;
            txtNumberOfOder.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumberOfOder.Location = new Point(67, 61);
            txtNumberOfOder.Name = "txtNumberOfOder";
            txtNumberOfOder.Size = new Size(118, 25);
            txtNumberOfOder.TabIndex = 1;
            txtNumberOfOder.Text = "valueNumber";
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
            groupBox3.Controls.Add(dgvBestCustomer);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(64, 173);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(370, 564);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Khách hàng mua nhiều";
            // 
            // dgvBestCustomer
            // 
            dgvBestCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBestCustomer.BackgroundColor = SystemColors.ButtonFace;
            dgvBestCustomer.BorderStyle = BorderStyle.None;
            dgvBestCustomer.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvBestCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvBestCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvBestCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvBestCustomer.DefaultCellStyle = dataGridViewCellStyle14;
            dgvBestCustomer.EnableHeadersVisualStyles = false;
            dgvBestCustomer.GridColor = Color.MediumSlateBlue;
            dgvBestCustomer.Location = new Point(6, 26);
            dgvBestCustomer.Name = "dgvBestCustomer";
            dgvBestCustomer.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvBestCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvBestCustomer.RowHeadersVisible = false;
            dgvBestCustomer.RowHeadersWidth = 62;
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.HighlightText;
            dgvBestCustomer.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvBestCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBestCustomer.Size = new Size(358, 529);
            dgvBestCustomer.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvBestSeller);
            groupBox4.Location = new Point(468, 173);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(370, 564);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sản phẩm bán chạy";
            // 
            // dgvBestSeller
            // 
            dgvBestSeller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBestSeller.BackgroundColor = SystemColors.ButtonFace;
            dgvBestSeller.BorderStyle = BorderStyle.None;
            dgvBestSeller.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvBestSeller.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgvBestSeller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvBestSeller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dgvBestSeller.DefaultCellStyle = dataGridViewCellStyle18;
            dgvBestSeller.EnableHeadersVisualStyles = false;
            dgvBestSeller.GridColor = Color.MediumSlateBlue;
            dgvBestSeller.Location = new Point(6, 26);
            dgvBestSeller.Name = "dgvBestSeller";
            dgvBestSeller.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = SystemColors.Control;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgvBestSeller.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgvBestSeller.RowHeadersVisible = false;
            dgvBestSeller.RowHeadersWidth = 62;
            dataGridViewCellStyle20.ForeColor = Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.HighlightText;
            dgvBestSeller.RowsDefaultCellStyle = dataGridViewCellStyle20;
            dgvBestSeller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBestSeller.Size = new Size(358, 529);
            dgvBestSeller.TabIndex = 6;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtProductsImported);
            groupBox5.Controls.Add(label9);
            groupBox5.Location = new Point(1293, 283);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 104);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            // 
            // txtProductsImported
            // 
            txtProductsImported.AutoSize = true;
            txtProductsImported.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductsImported.Location = new Point(33, 64);
            txtProductsImported.Name = "txtProductsImported";
            txtProductsImported.Size = new Size(36, 25);
            txtProductsImported.TabIndex = 1;
            txtProductsImported.Text = "VN";
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
            groupBox6.Controls.Add(dgvNewProduct);
            groupBox6.Location = new Point(861, 173);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(370, 564);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Sản phẩm đã nhập";
            // 
            // dgvNewProduct
            // 
            dgvNewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNewProduct.BackgroundColor = SystemColors.ButtonFace;
            dgvNewProduct.BorderStyle = BorderStyle.None;
            dgvNewProduct.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvNewProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle21.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dgvNewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dgvNewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            dgvNewProduct.DefaultCellStyle = dataGridViewCellStyle22;
            dgvNewProduct.EnableHeadersVisualStyles = false;
            dgvNewProduct.GridColor = Color.MediumSlateBlue;
            dgvNewProduct.Location = new Point(6, 26);
            dgvNewProduct.Name = "dgvNewProduct";
            dgvNewProduct.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.Control;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle23.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dgvNewProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dgvNewProduct.RowHeadersVisible = false;
            dgvNewProduct.RowHeadersWidth = 62;
            dataGridViewCellStyle24.ForeColor = Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = SystemColors.HighlightText;
            dgvNewProduct.RowsDefaultCellStyle = dataGridViewCellStyle24;
            dgvNewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNewProduct.Size = new Size(358, 529);
            dgvNewProduct.TabIndex = 6;
            dgvNewProduct.CellContentClick += dgvNewProduct_CellContentClick;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtProductOnSale);
            groupBox7.Controls.Add(label12);
            groupBox7.Location = new Point(1293, 393);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(250, 104);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            // 
            // txtProductOnSale
            // 
            txtProductOnSale.AutoSize = true;
            txtProductOnSale.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductOnSale.Location = new Point(67, 61);
            txtProductOnSale.Name = "txtProductOnSale";
            txtProductOnSale.Size = new Size(118, 25);
            txtProductOnSale.TabIndex = 1;
            txtProductOnSale.Text = "valueNumber";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkViolet;
            label12.Location = new Point(33, 23);
            label12.Name = "label12";
            label12.Size = new Size(147, 28);
            label12.TabIndex = 0;
            label12.Text = "Product on sale";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtNumberOfCustomer);
            groupBox8.Controls.Add(label14);
            groupBox8.Location = new Point(1293, 503);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(250, 104);
            groupBox8.TabIndex = 8;
            groupBox8.TabStop = false;
            // 
            // txtNumberOfCustomer
            // 
            txtNumberOfCustomer.AutoSize = true;
            txtNumberOfCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumberOfCustomer.Location = new Point(67, 61);
            txtNumberOfCustomer.Name = "txtNumberOfCustomer";
            txtNumberOfCustomer.Size = new Size(36, 25);
            txtNumberOfCustomer.TabIndex = 1;
            txtNumberOfCustomer.Text = "VN";
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
            groupBox9.Controls.Add(txtNewCustomer);
            groupBox9.Controls.Add(label17);
            groupBox9.Location = new Point(1293, 613);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(250, 104);
            groupBox9.TabIndex = 9;
            groupBox9.TabStop = false;
            // 
            // txtNewCustomer
            // 
            txtNewCustomer.AutoSize = true;
            txtNewCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewCustomer.Location = new Point(67, 61);
            txtNewCustomer.Name = "txtNewCustomer";
            txtNewCustomer.Size = new Size(36, 25);
            txtNewCustomer.TabIndex = 1;
            txtNewCustomer.Text = "VN";
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
            groupBox10.Controls.Add(txtGrossRevenue);
            groupBox10.Controls.Add(label15);
            groupBox10.Location = new Point(1293, 723);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(250, 104);
            groupBox10.TabIndex = 9;
            groupBox10.TabStop = false;
            // 
            // txtGrossRevenue
            // 
            txtGrossRevenue.AutoSize = true;
            txtGrossRevenue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrossRevenue.Location = new Point(67, 61);
            txtGrossRevenue.Name = "txtGrossRevenue";
            txtGrossRevenue.Size = new Size(36, 25);
            txtGrossRevenue.TabIndex = 1;
            txtGrossRevenue.Text = "VN";
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
            ((System.ComponentModel.ISupportInitialize)dgvBestCustomer).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBestSeller).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNewProduct).EndInit();
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
        private Label txtGrossRevenue;
        private DateTimePicker dtpEndDate;
        private GroupBox groupBox1;
        private CustomButton.VBButton btnLast7Days;
        private CustomButton.VBButton btnToday;
        private GroupBox groupBox2;
        private Label label6;
        private Label txtNumberOfOder;
        private Label label4;
        private GroupBox groupBox3;
        private DataGridView dgvBestCustomer;
        private GroupBox groupBox4;
        private DataGridView dgvBestSeller;
        private GroupBox groupBox5;
        private Label label7;
        private Label txtProductsImported;
        private Label label9;
        private GroupBox groupBox6;
        private DataGridView dgvNewProduct;
        private CustomButton.VBButton btnThisMonth;
        private CustomButton.VBButton btnLast30Days;
        private CustomButton.VBButton btnCustom;
        private GroupBox groupBox7;
        private Label txtProductOnSale;
        private Label label12;
        private GroupBox groupBox8;
        private Label label10;
        private Label txtNumberOfCustomer;
        private Label label14;
        private GroupBox groupBox9;
        private Label txtNewCustomer;
        private Label label17;
        private GroupBox groupBox10;
        private Label label15;
    }
}