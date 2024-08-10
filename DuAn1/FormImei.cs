using BUS;
using BUS.Services;
using DAL.Models;
using OfficeOpenXml;
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
    public partial class FormImei : Form
    {
        List<string> Imeis;
        ProductDetail ThisProductDetail;
        public bool Comfirm = false;
        public int inventory;
        ImeiBUS imeiBUS = new ImeiBUS();
        string Account;
        Validate validate = new Validate();
        public FormImei()
        {
            InitializeComponent();
        }
        public FormImei(ProductDetail productDetail, string account)
        {
            ThisProductDetail = productDetail;
            Account = account;
            InitializeComponent();
        }
        public void LoadDgvImei()
        {
            dgvImei.Columns.Add("STT", "STT");
            dgvImei.Columns.Add("Imei", "Imei");
            dgvImei.Columns.Add("Selled", "Selled");
        }
        public void ShowOnDataGridView(List<string> imeis)
        {
            dgvImei.Rows.Clear();
            var stt = 0;
            if (imeis != null)
            {
                foreach (string ime in imeis)
                {
                    stt++;

                    var imei = imeiBUS.GetImeiByID(ime);
                    if (imei != null)
                        dgvImei.Rows.Add(stt, ime, imei.Selled);
                    else
                        dgvImei.Rows.Add(stt, ime);
                }
            }
        }
        public string OpenFile(string fillter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn một file";
            openFileDialog.Filter = fillter;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                MessageBox.Show($"Đường dẫn file đã chọn: {filePath}");
                return filePath;
            }
            return null;
        }
        public List<string> OpenExcel()
        {
            var excel = OpenFile("Excel Files|*.xlsx;*.xls");
            if (excel != null)
            {
                FileInfo file = new FileInfo(excel);
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    List<string> imeis = new List<string>();
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    for (int i = 0; i < worksheet.Dimension.End.Row; i++)
                    {
                        imeis.Add(worksheet.Cells[i, 2].Text);
                    }
                    return imeis;
                }
            }
            else
                return null;
        }
        private void FormImei_Load(object sender, EventArgs e)
        {
            Imeis = imeiBUS.GetImeiNumberByIDProductDetail(ThisProductDetail.IdproductDetails);
            string idProductDetail = ThisProductDetail.IdproductDetails;
            txtIdProductDetail.Text = idProductDetail;
            LoadDgvImei();
            ShowOnDataGridView(Imeis);
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            List<string> imeis = OpenExcel();
            Imeis.AddRange(imeis);
            ShowOnDataGridView(Imeis);
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (Imeis != null)
            {
                var count = 0;
                foreach (string ime in Imeis)
                {
                    if (!imeiBUS.CheckImeiExists(ime))
                    {
                        count++;
                        imeiBUS.AddNewImei(ThisProductDetail.IdproductDetails, ime, Account, false);
                    }
                }
                MessageBox.Show($"Đã thêm {count} Imei");
                var listImei = imeiBUS.GetImeiByIdProductDetail(ThisProductDetail.IdproductDetails);
                inventory = listImei.Where(c=>c.Selled==false).Count();
                Comfirm = true;
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtImei.Text))
            {
                Imeis.Add(txtImei.Text);
                ShowOnDataGridView(Imeis);
            }
            else
            {
                MessageBox.Show("Hãy thêm Imei");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtImei.Text != null)
            {
                var check = imeiBUS.RemoveImeiFromList(txtImei.Text, Imeis);
                MessageBox.Show(check);
                ShowOnDataGridView(Imeis);
            }
            else
            {
                MessageBox.Show("Hãy thêm Imei");
            }
        }

        private void dgvImei_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0&&e.RowIndex<dgvImei.RowCount-1)
            {
                txtImei.Text = dgvImei.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
