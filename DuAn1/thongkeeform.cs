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
        ThongKeBLL thongkeBLL = new ThongKeBLL();
        ProductDetailBUS productDetailBUS = new ProductDetailBUS();
        CustomerBUS customerBUS = new CustomerBUS();
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
            var result= thongkeBLL.GetNewProduct(from, to);
            foreach( var item in result)
            {
                var productDetail = productDetailBUS.GetProductDetailByID(item.Key);
                dgvNewProduct.Rows.Add(productDetail.IdproductNavigation.ProductName, productDetail.IdcolorNavigation.ColorName, productDetail.Storage, item.Value);
            }
        }
        public void ShowOnDgvBestSeller(DateTime from, DateTime to)
        {
            dgvBestSeller.Rows.Clear();
            var result= thongkeBLL.GetBestSeller(from, to);
            foreach ( var item in result)
            {
                var productDetail = productDetailBUS.GetProductDetailByID(item.Key);
                dgvBestSeller.Rows.Add(productDetail.IdproductNavigation.ProductName, productDetail.IdcolorNavigation.ColorName, productDetail.Storage, item.Value);
            }
        }
        public void ShowOnDgvBestCustomer(DateTime from, DateTime to)
        {
            dgvBestCustomer.Rows.Clear();
            var result=thongkeBLL.GetBestCustomer(from, to);
            foreach(var item in result)
            {
                var customer= customerBUS.GetCustomerByID(item.Key);
                var num= thongkeBLL.NumberOrderOfCustomer(customer,from,to);
                dgvBestCustomer.Rows.Add(customer.Idcustomer,customer.CustomerName,item.Value,num);
            }
        }
        public void ThongKe(DateTime from, DateTime to)
        {
            ShowOnDgvBestCustomer(from, to);
            ShowOnDgvBestSeller(from, to);
            ShowOnDgvNewProduct(from, to);
            txtNumberOfOder.Text = thongkeBLL.NumberOfOrder(from, to).ToString();
            txtProductsImported.Text=thongkeBLL.NumberOfNewProduct(from, to).ToString();
            txtNewCustomer.Text=thongkeBLL.NumberOfNewCustomer(from, to).ToString();
            txtGrossRevenue.Text=thongkeBLL.GetGrossRevenue(from, to).ToString();
        }
        public void LoadDataGridView()
        {
            //dgvNewProduct
            dgvNewProduct.Columns.Add("NameProduct", "Name");
            dgvNewProduct.Columns.Add("Color", "Color");
            dgvNewProduct.Columns.Add("Storage", "Storage");
            dgvNewProduct.Columns.Add("Quality", "Quality");
            //dgvBestSeler
            dgvBestSeller.Columns.Add("NameProduct", "Name");
            dgvBestSeller.Columns.Add("Color", "Color");
            dgvBestSeller.Columns.Add("Storage", "Storage");
            dgvBestSeller.Columns.Add("Quality", "Quality");
            //dgvBestCustomer
            dgvBestCustomer.Columns.Add("IdCustomer", "ID customer");
            dgvBestCustomer.Columns.Add("CustomerName", "Name");
            dgvBestCustomer.Columns.Add("TotalAmount", "Total amount");
            dgvBestCustomer.Columns.Add("NumberOfOrder", "Number of order");
        }
        private void thongkeeform_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtProductOnSale.Text = thongkeBLL.ProductOnSale().ToString();
            txtNumberOfCustomer.Text = thongkeBLL.NumberOfCustomer().ToString();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            DisableCustomDates();
            ThongKe(dtpStartdate.Value, dtpEndDate.Value);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            DisableCustomDates();
            ThongKe(dtpStartdate.Value, dtpEndDate.Value);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            DisableCustomDates();
            ThongKe(dtpStartdate.Value, dtpEndDate.Value);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            DisableCustomDates();
            ThongKe(dtpStartdate.Value, dtpEndDate.Value);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpStartdate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOk.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThongKe(dtpStartdate.Value,dtpEndDate.Value);
        }

        private void dgvNewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
