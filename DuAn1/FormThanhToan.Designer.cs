namespace DuAn1
{
    partial class FormThanhToan
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
            label1 = new Label();
            txtTienNhan = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtTongTien = new TextBox();
            label4 = new Label();
            txtTienTra = new TextBox();
            btnXacNhan = new CustomButton.VBButton();
            vbButton1 = new CustomButton.VBButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 30);
            label1.Name = "label1";
            label1.Size = new Size(265, 62);
            label1.TabIndex = 0;
            label1.Text = "Thanh toán";
            // 
            // txtTienNhan
            // 
            txtTienNhan.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienNhan.Location = new Point(39, 316);
            txtTienNhan.Name = "txtTienNhan";
            txtTienNhan.Size = new Size(307, 47);
            txtTienNhan.TabIndex = 1;
            txtTienNhan.Leave += txtTienNhan_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 256);
            label2.Name = "label2";
            label2.Size = new Size(166, 46);
            label2.TabIndex = 2;
            label2.Text = "Tiền nhận";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 107);
            label3.Name = "label3";
            label3.Size = new Size(163, 46);
            label3.TabIndex = 3;
            label3.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(39, 165);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(307, 47);
            txtTongTien.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 388);
            label4.Name = "label4";
            label4.Size = new Size(133, 46);
            label4.TabIndex = 6;
            label4.Text = "Tiền trả";
            // 
            // txtTienTra
            // 
            txtTienTra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienTra.Location = new Point(39, 448);
            txtTienTra.Name = "txtTienTra";
            txtTienTra.ReadOnly = true;
            txtTienTra.Size = new Size(307, 47);
            txtTienTra.TabIndex = 5;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.MediumSlateBlue;
            btnXacNhan.BackgroundColor = Color.MediumSlateBlue;
            btnXacNhan.BorderColor = Color.PaleVioletRed;
            btnXacNhan.BorderRadius = 20;
            btnXacNhan.BorderSize = 0;
            btnXacNhan.FlatAppearance.BorderSize = 0;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.Font = new Font("Segoe UI", 19.8000011F);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(490, 182);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(205, 88);
            btnXacNhan.TabIndex = 77;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.TextColor = Color.White;
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // vbButton1
            // 
            vbButton1.BackColor = Color.MediumSlateBlue;
            vbButton1.BackgroundColor = Color.MediumSlateBlue;
            vbButton1.BorderColor = Color.PaleVioletRed;
            vbButton1.BorderRadius = 20;
            vbButton1.BorderSize = 0;
            vbButton1.FlatAppearance.BorderSize = 0;
            vbButton1.FlatStyle = FlatStyle.Flat;
            vbButton1.Font = new Font("Segoe UI", 19.8000011F);
            vbButton1.ForeColor = Color.White;
            vbButton1.Location = new Point(490, 360);
            vbButton1.Name = "vbButton1";
            vbButton1.Size = new Size(205, 88);
            vbButton1.TabIndex = 78;
            vbButton1.Text = "Hủy";
            vbButton1.TextColor = Color.White;
            vbButton1.UseVisualStyleBackColor = false;
            // 
            // FormThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(vbButton1);
            Controls.Add(btnXacNhan);
            Controls.Add(label4);
            Controls.Add(txtTienTra);
            Controls.Add(txtTongTien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTienNhan);
            Controls.Add(label1);
            Name = "FormThanhToan";
            Text = "FormThanhToan";
            Load += FormThanhToan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTienNhan;
        private Label label2;
        private Label label3;
        private TextBox txtTongTien;
        private Label label4;
        private TextBox txtTienTra;
        private CustomButton.VBButton btnXacNhan;
        private CustomButton.VBButton vbButton1;
    }
}