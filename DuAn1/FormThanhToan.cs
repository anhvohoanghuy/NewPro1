using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1
{
    public partial class FormThanhToan : Form
    {
        decimal TongTien;
        public bool XacNhan = false;
        public FormThanhToan()
        {
            InitializeComponent();
        }
        public FormThanhToan(decimal tongTien)
        {
            TongTien = tongTien;
            InitializeComponent();
        }
        public string CheckIsDouble(params TextBox[] textBoxs)
        {
            foreach (var textBox in textBoxs)
            {
                if (!double.TryParse(textBox.Text, out _))
                    return $"{textBox.Name} phải là số";
                else if (double.Parse(textBox.Text) < 0)
                    return $"{textBox.Name} phải lớn hơn 0";
            }
            return null;
        }
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = (TongTien).ToString();
        }

        private void txtTienNhan_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTienNhan.Text))
            {
                var check = CheckIsDouble(txtTienNhan);
                if (check == null)
                {
                    txtTienTra.Text = (decimal.Parse(txtTienNhan.Text) - decimal.Parse(txtTongTien.Text)).ToString();
                }
                else
                    MessageBox.Show(check);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTienTra.Text))
            {
                var check = CheckIsDouble(txtTienTra);
                if (check == null)
                {
                    if (decimal.Parse(txtTienTra.Text) >= 0)
                    {
                        XacNhan = true;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Không đủ tiền thanh toán");
                }
                else
                    MessageBox.Show(check);
            }
        }

    }
}
