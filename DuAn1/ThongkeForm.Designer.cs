namespace DuAn1
{
    partial class ThongkeForm
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
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            vbButton3 = new CustomButton.VBButton();
            vbButton2 = new CustomButton.VBButton();
            btninfoOrder = new CustomButton.VBButton();
            vbButton1 = new CustomButton.VBButton();
            textBox7 = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            idOrder = new DataGridViewTextBoxColumn();
            IdStaff = new DataGridViewTextBoxColumn();
            IdProd = new DataGridViewTextBoxColumn();
            NameProd = new DataGridViewTextBoxColumn();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1356, 427);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "List Bill";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idOrder, IdStaff, IdProd, NameProd });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.MediumSlateBlue;
            dataGridView1.Location = new Point(0, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.HighlightText;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1350, 397);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(vbButton3);
            groupBox1.Controls.Add(vbButton2);
            groupBox1.Controls.Add(btninfoOrder);
            groupBox1.Controls.Add(vbButton1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Location = new Point(56, 492);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1087, 93);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // vbButton3
            // 
            vbButton3.BackColor = Color.MediumSlateBlue;
            vbButton3.BackgroundColor = Color.MediumSlateBlue;
            vbButton3.BorderColor = Color.PaleVioletRed;
            vbButton3.BorderRadius = 20;
            vbButton3.BorderSize = 0;
            vbButton3.FlatAppearance.BorderSize = 0;
            vbButton3.FlatStyle = FlatStyle.Flat;
            vbButton3.ForeColor = Color.White;
            vbButton3.Location = new Point(865, 32);
            vbButton3.Name = "vbButton3";
            vbButton3.Size = new Size(129, 40);
            vbButton3.TabIndex = 107;
            vbButton3.Text = "Refesh";
            vbButton3.TextColor = Color.White;
            vbButton3.UseVisualStyleBackColor = false;
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
            vbButton2.Location = new Point(666, 32);
            vbButton2.Name = "vbButton2";
            vbButton2.Size = new Size(168, 40);
            vbButton2.TabIndex = 106;
            vbButton2.Text = "Xuất Excel";
            vbButton2.TextColor = Color.White;
            vbButton2.UseVisualStyleBackColor = false;
            // 
            // btninfoOrder
            // 
            btninfoOrder.BackColor = Color.MediumSlateBlue;
            btninfoOrder.BackgroundColor = Color.MediumSlateBlue;
            btninfoOrder.BorderColor = Color.PaleVioletRed;
            btninfoOrder.BorderRadius = 20;
            btninfoOrder.BorderSize = 0;
            btninfoOrder.FlatAppearance.BorderSize = 0;
            btninfoOrder.FlatStyle = FlatStyle.Flat;
            btninfoOrder.ForeColor = Color.White;
            btninfoOrder.Location = new Point(460, 32);
            btninfoOrder.Name = "btninfoOrder";
            btninfoOrder.Size = new Size(168, 40);
            btninfoOrder.TabIndex = 105;
            btninfoOrder.Text = "Xem chi tiết đơn hàng";
            btninfoOrder.TextColor = Color.White;
            btninfoOrder.UseVisualStyleBackColor = false;
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
            vbButton1.Location = new Point(350, 32);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(72, 29);
            vbButton1.TabIndex = 76;
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.Gray;
            textBox7.Location = new Point(28, 32);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(403, 36);
            textBox7.TabIndex = 75;
            textBox7.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(56, 591);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(825, 90);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(249, 36);
            label2.Name = "label2";
            label2.Size = new Size(69, 31);
            label2.TabIndex = 1;
            label2.Text = "Value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 0;
            label1.Text = "Tổng doanh thu: ";
            // 
            // idOrder
            // 
            idOrder.HeaderText = "Id Order";
            idOrder.MinimumWidth = 6;
            idOrder.Name = "idOrder";
            idOrder.ReadOnly = true;
            // 
            // IdStaff
            // 
            IdStaff.HeaderText = "IdStaff";
            IdStaff.MinimumWidth = 6;
            IdStaff.Name = "IdStaff";
            IdStaff.ReadOnly = true;
            // 
            // IdProd
            // 
            IdProd.HeaderText = "IDprod";
            IdProd.MinimumWidth = 6;
            IdProd.Name = "IdProd";
            IdProd.ReadOnly = true;
            // 
            // NameProd
            // 
            NameProd.HeaderText = "NameProd";
            NameProd.MinimumWidth = 6;
            NameProd.Name = "NameProd";
            NameProd.ReadOnly = true;
            // 
            // ThongkeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 790);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "ThongkeForm";
            Text = "ThongkeForm";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private CustomButton.VBButton vbButton1;
        private TextBox textBox7;
        private CustomButton.VBButton vbButton3;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton btninfoOrder;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn idOrder;
        private DataGridViewTextBoxColumn IdStaff;
        private DataGridViewTextBoxColumn IdProd;
        private DataGridViewTextBoxColumn NameProd;
    }
}