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
            txtImei = new TextBox();
            btnThem = new CustomButton.VBButton();
            btnXoa = new CustomButton.VBButton();
            grbUpdate = new GroupBox();
            lblIDProductDetail = new Label();
            txtIdProductDetail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvImei).BeginInit();
            grbUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // dgvImei
            // 
            dgvImei.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImei.Location = new Point(40, 59);
            dgvImei.Name = "dgvImei";
            dgvImei.RowHeadersWidth = 51;
            dgvImei.Size = new Size(333, 380);
            dgvImei.TabIndex = 0;
            dgvImei.CellClick += dgvImei_CellClick;
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
            lblImei.Location = new Point(34, 31);
            lblImei.Name = "lblImei";
            lblImei.Size = new Size(38, 20);
            lblImei.TabIndex = 136;
            lblImei.Text = "Imei";
            // 
            // txtImei
            // 
            txtImei.Location = new Point(34, 65);
            txtImei.Name = "txtImei";
            txtImei.Size = new Size(193, 27);
            txtImei.TabIndex = 137;
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
            btnThem.Location = new Point(58, 97);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 40);
            btnThem.TabIndex = 138;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.White;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
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
            btnXoa.Location = new Point(58, 159);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(135, 40);
            btnXoa.TabIndex = 139;
            btnXoa.Text = "Xóa";
            btnXoa.TextColor = Color.White;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // grbUpdate
            // 
            grbUpdate.Controls.Add(txtImei);
            grbUpdate.Controls.Add(btnXoa);
            grbUpdate.Controls.Add(lblImei);
            grbUpdate.Controls.Add(btnThem);
            grbUpdate.Location = new Point(379, 59);
            grbUpdate.Name = "grbUpdate";
            grbUpdate.Size = new Size(250, 217);
            grbUpdate.TabIndex = 140;
            grbUpdate.TabStop = false;
            grbUpdate.Text = "Update";
            // 
            // lblIDProductDetail
            // 
            lblIDProductDetail.AutoSize = true;
            lblIDProductDetail.Location = new Point(73, 19);
            lblIDProductDetail.Name = "lblIDProductDetail";
            lblIDProductDetail.Size = new Size(122, 20);
            lblIDProductDetail.TabIndex = 141;
            lblIDProductDetail.Text = "ID product detail";
            // 
            // txtIdProductDetail
            // 
            txtIdProductDetail.AcceptsReturn = true;
            txtIdProductDetail.Location = new Point(201, 16);
            txtIdProductDetail.Name = "txtIdProductDetail";
            txtIdProductDetail.ReadOnly = true;
            txtIdProductDetail.Size = new Size(237, 27);
            txtIdProductDetail.TabIndex = 142;
            // 
            // FormImei
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 547);
            Controls.Add(txtIdProductDetail);
            Controls.Add(lblIDProductDetail);
            Controls.Add(grbUpdate);
            Controls.Add(btnRetry);
            Controls.Add(btnComfirm);
            Controls.Add(dgvImei);
            Name = "FormImei";
            Text = "FormImei";
            Load += FormImei_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImei).EndInit();
            grbUpdate.ResumeLayout(false);
            grbUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvImei;
        private CustomButton.VBButton btnComfirm;
        private CustomButton.VBButton btnRetry;
        private Label lblImei;
        private TextBox txtImei;
        private CustomButton.VBButton btnThem;
        private CustomButton.VBButton btnXoa;
        private GroupBox grbUpdate;
        private Label lblIDProductDetail;
        private TextBox txtIdProductDetail;
    }
}