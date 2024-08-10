using BUS.Services;
using DAL.Models;
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
    public partial class FormProductColor : Form
    {

        private string IDAccount;
        private ProductColorBUS productColorBUS = new ProductColorBUS();

        public FormProductColor()
        {
            InitializeComponent();
            LoadDataGridView();
            dgvListColor.CellClick += dgvListProductColor_CellClick; // Register the event handler
        }

        public FormProductColor(string idAccount) : this()
        {
            IDAccount = idAccount;
        }

        private void dgvListProductColor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListColor.Rows[e.RowIndex];

                Idcolor.Text = row.Cells["Idcolor"].Value.ToString();
                txtColorName.Text = row.Cells["ColorName"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string idColor = Idcolor.Text.Trim();
                string colorName = txtColorName.Text.Trim();
                string idAccount = IDAccount;




                bool isAdded = productColorBUS.AddNewColor(idColor,colorName,idAccount);

                if (isAdded)
                {
                    MessageBox.Show("Thêm màu sản phẩm thành công!");
                    ClearForm();
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Thêm màu sản phẩm thất bại. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            Idcolor.Clear();
            txtColorName.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string idCol = Idcolor.Text.Trim();
                string colorName = txtColorName.Text.Trim();
                string idAccount = IDAccount;

              

                bool isUpdated = productColorBUS.UpdateProductColor(idCol, colorName,idAccount);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật màu sản phẩm thành công!");
                    ClearForm();
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Cập nhật màu sản phẩm thất bại. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void FormProductColor_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            dgvListColor.Columns.Clear();

            dgvListColor.Columns.Add("Idcolor", "ID Màu");
            dgvListColor.Columns.Add("ColorName", "Tên Màu");
            dgvListColor.Columns.Add("Idaccount", "ID Tài Khoản");

            dgvListColor.Columns["Idcolor"].Width = 100;
            dgvListColor.Columns["ColorName"].Width = 200;
            dgvListColor.Columns["Idaccount"].Width = 100;

            var productColorList = productColorBUS.GetAllColor();

            dgvListColor.Rows.Clear();

            foreach (var color in productColorList)
            {
                dgvListColor.Rows.Add(color.Idcolor, color.ColorName, color.Idaccount);
            }

            dgvListColor.RowTemplate.Height = 40;
            dgvListColor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
