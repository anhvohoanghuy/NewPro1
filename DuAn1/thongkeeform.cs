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
using System.Windows.Documents;
using System.Windows.Forms;
using BUS;

namespace DuAn1
{

    public partial class thongkeeform : Form
    {
        thongkeBLL tkbll = new thongkeBLL();
        List<DAL.Models.Order> listsO;
        List<OrderDetail> listsOD;
        List<Customer> listsC;
        List<Product> listP;
        List<ProductDetail> listPD;
        public thongkeeform()
        {
            InitializeComponent();
            dtpStartdate.Value = DateTime.Today.AddDays(-7);
            dtpEnđate.Value = DateTime.Now;
            btnLast7Days.Select();
        }
        private void DisableCustomDates()
        {
            dtpStartdate.Enabled = false;
            dtpEnđate.Enabled = false;
            btnOk.Visible = false;
        }
        public void LoadDataGridView1()
        {



            listsO = tkbll.GetListO().ToList();
            listsOD = tkbll.GetListOD().ToList();
            listP = tkbll.GetListP().ToList();
            listPD = tkbll.GetListPD().ToList();


        }



        private void thongkeeform_Load(object sender, EventArgs e)
        {
            //LoadDataGridView1();

            //var query =  tkbll.GetListO().Select(s => new { s.Idaccount,  s.Idcustomer, s.Paid }).ToList();

            //var resultList = query.ToList();

            //// Hiển thị kết quả trong DataGridView
            //dgvnbOrder.DataSource = resultList;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = DateTime.Today;
            dtpEnđate.Value = DateTime.Now;

            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = DateTime.Today.AddDays(-7);
            dtpEnđate.Value = DateTime.Now;

            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = DateTime.Today.AddDays(-30);
            dtpEnđate.Value = DateTime.Now;

            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartdate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEnđate.Value = DateTime.Now;

            DisableCustomDates();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpStartdate.Enabled = true;
            dtpEnđate.Enabled = true;
            btnOk.Visible = true;
        }
    }
}
