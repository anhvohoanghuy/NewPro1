namespace DuAn1
{
    partial class FormImei
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
            dgvImei = new DataGridView();
            btnComfirm = new CustomButton.VBButton();
            btnRetry = new CustomButton.VBButton();
            lblImei = new Label();
            textBox1 = new TextBox();
            btnThem = new CustomButton.VBButton();
            btnXoa = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)dgvImei).BeginInit();
            SuspendLayout();
            // 
            // dgvImei
            // 
            dgvImei.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImei.Location = new Point(40, 28);
            dgvImei.Name = "dgvImei";
            dgvImei.RowHeadersWidth = 51;
            dgvImei.Size = new Size(333, 411);
            dgvImei.TabIndex = 0;
            // 
            // btnComfirm
            // 
            btnComfirm.Anchor = AnchorStyles.Left;
            btnComfirm.BackColor = Color.MediumSlateBlue;
            btnComfirm.BackgroundColor = Color.MediumSlateBlue;
            btnComfirm.BorderColor = Color.PaleVioletRed;
            btnComfirm.BorderRadius = 20;
            btnComfirm.BorderSize = 0;
            btnComfirm.FlatAppearance.BorderSize = 0;
            btnComfirm.FlatStyle = FlatStyle.Flat;
            btnComfirm.ForeColor = Color.White;
            btnComfirm.Location = new Point(51, 468);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(135, 40);
            btnComfirm.TabIndex = 134;
            btnComfirm.Text = "Xác nhận";
            btnComfirm.TextColor = Color.White;
            btnComfirm.UseVisualStyleBackColor = false;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // btnRetry
            // 
            btnRetry.Anchor = AnchorStyles.Left;
            btnRetry.BackColor = Color.MediumSlateBlue;
            btnRetry.BackgroundColor = Color.MediumSlateBlue;
            btnRetry.BorderColor = Color.PaleVioletRed;
            btnRetry.BorderRadius = 20;
            btnRetry.BorderSize = 0;
            btnRetry.FlatAppearance.BorderSize = 0;
            btnRetry.FlatStyle = FlatStyle.Flat;
            btnRetry.ForeColor = Color.White;
            btnRetry.Location = new Point(207, 468);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(135, 40);
            btnRetry.TabIndex = 135;
            btnRetry.Text = "Thêm lại";
            btnRetry.TextColor = Color.White;
            btnRetry.UseVisualStyleBackColor = false;
            btnRetry.Click += btnRetry_Click;
            // 
            // lblImei
            // 
            lblImei.AutoSize = true;
            lblImei.Location = new Point(409, 44);
            lblImei.Name = "lblImei";
            lblImei.Size = new Size(38, 20);
            lblImei.TabIndex = 136;
            lblImei.Text = "Imei";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(409, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 27);
            textBox1.TabIndex = 137;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Left;
            btnThem.BackColor = Color.MediumSlateBlue;
            btnThem.BackgroundColor = Color.MediumSlateBlue;
            btnThem.BorderColor = Color.PaleVioletRed;
            btnThem.BorderRadius = 20;
            btnThem.BorderSize = 0;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(433, 126);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 40);
            btnThem.TabIndex = 138;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Left;
            btnXoa.BackColor = Color.MediumSlateBlue;
            btnXoa.BackgroundColor = Color.MediumSlateBlue;
            btnXoa.BorderColor = Color.PaleVioletRed;
            btnXoa.BorderRadius = 20;
            btnXoa.BorderSize = 0;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(433, 188);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(135, 40);
            btnXoa.TabIndex = 139;
            btnXoa.Text = "Xóa";
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // FormImei
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 547);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(textBox1);
            Controls.Add(lblImei);
            Controls.Add(btnRetry);
            Controls.Add(btnComfirm);
            Controls.Add(dgvImei);
            Name = "FormImei";
            Text = "FormImei";
            Load += FormImei_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImei).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvImei;
        private CustomButton.VBButton btnComfirm;
        private CustomButton.VBButton btnRetry;
        private Label lblImei;
        private TextBox textBox1;
        private CustomButton.VBButton btnThem;
        private CustomButton.VBButton btnXoa;
    }
}