using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1
{
    public partial class FormPromotion : Form
    {
        PromotionBUS promotionBUS = new PromotionBUS();
        string IDAccount;
        public FormPromotion()
        {
            InitializeComponent();
        }
        public FormPromotion(string idAccount)
        {
            IDAccount = idAccount;
            InitializeComponent();
        }
        public void ResetTexbox(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        public void ResetForm()
        {
            ResetTexbox(txtIdPromotion, txtPromotionName, txtDiscount);
            txtIdAccount.Text = IDAccount;
            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = new DateTime(2100, 12, 31);
        }
        public bool CheckNull(params TextBox[] textBoxs)
        {
            foreach (var item in textBoxs)
            {
                if (string.IsNullOrEmpty(item.Text))
                    return true;
            }
            return false;
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
        public string CheckIsDouble(params TextBox[] textBoxs)
        {
            foreach (var textBox in textBoxs)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return null;
                else if (!double.TryParse(textBox.Text, out _))
                    return $"{textBox.Name} phải là số";
                else if (double.Parse(textBox.Text) < 0)
                    return $"{textBox.Name} phải lớn hơn 0";
            }
            return null;
        }
        public void LoadDataGridView()
        {
            dgvListPromotion.Columns.Add("IdPromotion", "ID promotion");
            dgvListPromotion.Columns.Add("PromotionName", "Promotion name");
            dgvListPromotion.Columns.Add("Discount", "Discount");
            dgvListPromotion.Columns.Add("StarTime", "Start time");
            dgvListPromotion.Columns.Add("EndTime", "End time");
            dgvListPromotion.Columns.Add("IdAccount", "ID account");
        }
        public void ShowOnDataGridView(List<Promotion> list)
        {
            foreach (var promotion in list)
            {
                dgvListPromotion.Rows.Add(promotion.Idpromotion, promotion.PromotionName, promotion.Discount, promotion.StartTime, promotion.EndTime, promotion.Idaccount);
            }
        }
        private void FormPromotion_Load(object sender, EventArgs e)
        {
            cbbTimKiem.Items.AddRange(["By id promotion", "By promotion name", "By id account"]);
            cbbFillter.Items.AddRange(["By discount", "Time"]);
            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = new DateTime(2100, 12, 31);
            LoadDataGridView();
            ShowOnDataGridView(promotionBUS.GetAllPromotion());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckNull(txtIdPromotion, txtPromotionName, txtDiscount))
            {
                var check = CheckIsDouble(txtDiscount);
                if (check == null)
                {
                    if (promotionBUS.AddNewPromotion(txtIdPromotion.Text, txtPromotionName.Text, decimal.Parse(txtDiscount.Text), dtpStartTime.Value, dtpEndTime.Value, txtIdAccount.Text))
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm thất bại");
                }
                else
                    MessageBox.Show(check);
            }
            MessageBox.Show("Điền đầy đủ thông tin");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckNull(txtIdPromotion, txtPromotionName, txtDiscount))
            {
                if (promotionBUS.CheckPromotionExist(txtIdPromotion.Text))
                {
                    var check = CheckIsDouble(txtDiscount);
                    if (check == null)
                    {
                        if (promotionBUS.UpdatePromotion(txtIdPromotion.Text, txtPromotionName.Text, decimal.Parse(txtDiscount.Text), dtpStartTime.Value, dtpEndTime.Value, txtIdAccount.Text))
                            MessageBox.Show("Sửa thành công");
                        else
                            MessageBox.Show("Sửa thất bại");
                    }
                    else
                        MessageBox.Show(check);
                }
                else
                    MessageBox.Show("Không có ID này");
            }
            MessageBox.Show("Điền đầy đủ thông tin");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var result = promotionBUS.Search(cbbTimKiem.SelectedIndex, txtTimKiem.Text);
            ShowOnDataGridView(result);
        }

        private void btnFillter_Click(object sender, EventArgs e)
        {
            List<Promotion> result = new List<Promotion>();
            if (cbbFillter.SelectedIndex == 0)
            {
                result = promotionBUS.FillterByDiscount(txtFrom.Text, txtTo.Text);
            }
            else if (cbbFillter.SelectedIndex == 1)
            {
                try
                {
                    var format = "dd-MM-yyyy";
                    DateTime from = DateTime.ParseExact(txtFrom.Text, format, CultureInfo.InvariantCulture);
                    DateTime to = DateTime.ParseExact(txtTo.Text, format, CultureInfo.InvariantCulture);
                    result = promotionBUS.FillterByTime(from, to);
                }
                catch
                {
                    MessageBox.Show("Ngày tháng có định dạng dd-MM-yyyy");
                }
            }
            ShowOnDataGridView(result);
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
