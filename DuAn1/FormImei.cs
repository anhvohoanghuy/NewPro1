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
        
        public FormImei()
        {
            InitializeComponent();
        }
        public FormImei(ProductDetail productDetail)
        {
            ThisProductDetail = productDetail;
        }
        public void LoadDgvImei()
        {
            dgvImei.Columns.Add("STT", "STT");
            dgvImei.Columns.Add("Imei", "Imei");
        }
        public void ShowOnDataGridView(List<string> imeis)
        {
            dgvImei.Rows.Clear();
            var stt = 0;
            foreach (string ime in imeis)
            {
                stt++;
                dgvImei.Rows.Add(stt, ime);
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
            if (ThisProductDetail == null)
            {
                List<string> imeis = OpenExcel();
                Imeis = imeis;
                LoadDgvImei();
                ShowOnDataGridView(Imeis);
            }
            else
            {
                Imeis = productDetailBUS.
                LoadDgvImei();
                ShowOnDataGridView(Imeis);
            }
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            List<string> imeis = OpenExcel();
            Imeis = imeis;
            LoadDgvImei();
            ShowOnDataGridView(Imeis);
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            Comfirm = true;
        }
    }
}
