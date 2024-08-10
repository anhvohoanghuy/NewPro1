using BUS.Services;
using DAL.Models;
using Microsoft.IdentityModel.Tokens;
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
    public partial class FormVoucher : Form
    {
        FormMenu menu = new FormMenu();
        VoucherBUS voucherBUS = new VoucherBUS();
        public FormVoucher()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            dgvListVoucher.Columns.Add("IdVoucher", "ID voucher");
            dgvListVoucher.Columns.Add("VoucherName", "Voucher name");
            dgvListVoucher.Columns.Add("DisCount", "Discount");
            dgvListVoucher.Columns.Add("StartTime", "Start time");
            dgvListVoucher.Columns.Add("EndTime", "End time");
            dgvListVoucher.Columns.Add("usageCount", "Usage count");
            dgvListVoucher.Columns.Add("IdAccount", "ID account");
        }
        public void ShowOnDataGridView(List<Voucher> vouchers)
        {
            dgvListVoucher.Rows.Clear();
            if (vouchers != null)
            {
                foreach (Voucher voucher in vouchers)
                {
                    dgvListVoucher.Rows.Add(voucher.Idvoucher, voucher.VoucherName, voucher.Discount, voucher.StartTime, voucher.EndTime, voucher.UsageCount, voucher.Idaccount);
                }
            }
        }
        public string CheckIsInt(params TextBox[] textBoxs)
        {
            foreach (var textBox in textBoxs)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return null;
                else if (!int.TryParse(textBox.Text, out _))
                    return $"{textBox.Name} phải là số nguyên";
                else if (int.Parse(textBox.Text) < 0)
                    return $"{textBox.Name} phải lớn hơn 0";
                else if (int.Parse(textBox.Text) != float.Parse(textBox.Text))
                    return $"{textBox.Name} phải là số nguyên";
            }
            return null;
        }
        public void ResetTexbox(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        public void ResetFormVoucher()
        {
            ResetTexbox(txtVoucherName, txtIdVoucher, txtDiscount);
            txtIdAccount.Text = menu.IdAccountMenu;
            dtpStarTime.Value = DateTime.Now;
            dtpEndTime.Value = new DateTime(2100, 12, 31);
            ShowOnDataGridView(voucherBUS.GetAllVoucher());
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
        public bool CheckNull(params TextBox[] textBoxs)
        {
            foreach (var textBox in textBoxs)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return true;
            }
            return false;
        }
        private void FormVoucher_Load(object sender, EventArgs e)
        {
            dtpEndTime.Value = new DateTime(2100, 12, 31);
            dtpStarTime.Value = DateTime.Now;
            txtIdAccount.Text = menu.IdAccountMenu;
            LoadDataGridView();
            ShowOnDataGridView(voucherBUS.GetAllVoucher());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckNull(txtIdVoucher, txtVoucherName, txtDiscount, txtIdAccount, txtUsageCount))
            {
                var check = CheckIsDouble(txtDiscount);
                if (check == null)
                {
                    var check2 = CheckIsInt(txtUsageCount);
                    if (check2 == null)
                    {
                        if (dtpEndTime.Value > dtpStarTime.Value)
                        {
                            if (voucherBUS.AddNewVoucher(txtIdVoucher.Text, txtVoucherName.Text, decimal.Parse(txtDiscount.Text), dtpStarTime.Value, dtpEndTime.Value, int.Parse(txtUsageCount.Text), txtIdAccount.Text))
                                MessageBox.Show("Thêm thành công");
                            else
                                MessageBox.Show("Thêm thất bại");
                        }
                        else
                            MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                    }
                    else
                        MessageBox.Show(check2);
                }
                else
                    MessageBox.Show(check);
            }
            else
                MessageBox.Show("Không được để trống thông tin");
            ShowOnDataGridView(voucherBUS.GetAllVoucher());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckNull(txtIdVoucher, txtVoucherName, txtDiscount, txtIdAccount))
            {
                var check = CheckIsDouble(txtDiscount);
                if (check == null)
                {
                    var check2 = CheckIsInt(txtUsageCount);
                    if (check2 == null)
                    {
                        if (dtpEndTime.Value > dtpStarTime.Value)
                        {
                            if (voucherBUS.UpdateVoucher(txtIdVoucher.Text, txtVoucherName.Text, decimal.Parse(txtDiscount.Text), dtpStarTime.Value, dtpEndTime.Value, int.Parse(txtUsageCount.Text), txtIdAccount.Text))
                                MessageBox.Show("Sửa thành công");
                            else
                                MessageBox.Show("Sửa thất bại");
                        }
                        else
                            MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                    }
                    else
                        MessageBox.Show(check2);
                }
                else
                    MessageBox.Show(check);
            }
            else
                MessageBox.Show("Không được để trống thông tin");
            ShowOnDataGridView(voucherBUS.GetAllVoucher());
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            ResetFormVoucher();
            ShowOnDataGridView(voucherBUS.GetAllVoucher());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<Voucher> list = voucherBUS.GetVoucherByName(txtTimKiem.Text);
            ShowOnDataGridView(list);
        }

        private void dgvListVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvListVoucher.RowCount - 1)
            {
                var row = dgvListVoucher.Rows[e.RowIndex];
                txtIdVoucher.Text = row.Cells[0].Value.ToString();
                txtVoucherName.Text = row.Cells[1].Value.ToString();
                txtDiscount.Text = row.Cells[2].Value.ToString();
                dtpStarTime.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                dtpEndTime.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                txtUsageCount.Text = row.Cells[5].Value.ToString();
                txtIdAccount.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
