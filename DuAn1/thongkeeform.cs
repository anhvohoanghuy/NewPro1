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
using BUS;
using System.Drawing.Design;

namespace DuAn1
{

    public partial class thongkeeform : Form
    {
        ProductDetailBUS productDetailBUS=new ProductDetailBUS();
        ImeiBUS imeiBUS=new ImeiBUS();
        public thongkeeform()
        {
            InitializeComponent();
            dtpStartdate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
        }
        private void DisableCustomDates()
        {
            dtpStartdate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOk.Visible = false;
        }
        public void ShowOnDgvNewProduct(DateTime from, DateTime to)
        {
            dgvNewProduct.Rows.Clear();
            var result= productDetailBUS.GetNewProductDetailByTime(from, to);
            if (result != null)
            {
                foreach (var item in result)
                {
                    var current = productDetailBUS.GetProductDetailByID(item.Key);
                    var name= current.IdproductNavigation.ProductName;
                    var color = current.IdcolorNavigation.ColorName;
                    var storage = current.Storage;
                    dgvNewProduct.Rows.Add(name, color, storage, item.Value);
                }
            }
        }
        public void LoadDataGridView()
        {
            dgvNewProduct.Columns.Add("NameProduct", "Name");
            dgvNewProduct.Columns.Add("Color", "Color");
            dgvNewProduct.Columns.Add("Storage", "Storage");
            dgvNewProduct.Columns.Add("Quality", "Quality");
            dgvBestSeller.Columns.Add("NameProduct", "Name");
            dgvBestSeller.Columns.Add("Color", "Color");
            dgvBestSeller.Columns.Add("Storage", "Storage");
            dgvBestSeller.Columns.Add("Quality", "Quality");
        }
        private void thongkeeform_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            DisableCustomDates();
            ShowOnDgvNewProduct(dtpStartdate.Value, dtpEndDate.Value);
            lblProductsImported.Text = imeiBUS.GetAmountNewProduct(dtpStartdate.Value, dtpEndDate.Value).ToString();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;

            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;

            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;

            DisableCustomDates();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpStartdate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOk.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
