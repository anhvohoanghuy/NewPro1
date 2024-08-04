using BUS.Services;
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
    public partial class listOrderForm : Form
    {
        listOrderBLL listorderBLL = new listOrderBLL();
        public listOrderForm()
        {
            InitializeComponent();
            dtpStartdate.Value = DateTime.Today.AddDays(-7);
            dtpEndate.Value = DateTime.Now;
            // Không cần thiết đặt CurrentCell = null ở đây
        }

        private void DisableCustomDates()
        {
            dtpStartdate.Enabled = false;
            dtpEndate.Enabled = false;
            btnOk.Visible = false;
        }

        public void LoadDataGridView(string searchCriteria = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            dataGridView1.DataSource = listorderBLL.GetAllDonHang(searchCriteria, startDate, endDate);
        }

        private void listOrderForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoadDataGridView(null, dtpStartdate.Value, dtpEndate.Value);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            dtpStartdate.Enabled = true;
            dtpEndate.Enabled = true;
            btnOk.Visible = true;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            LoadDataGridView(null, today, today);
            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Today.AddDays(-7);
            var endDate = DateTime.Now;
            LoadDataGridView(null, startDate, endDate);
            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            var startDate = DateTime.Today.AddDays(-30);
            var endDate = DateTime.Now;
            LoadDataGridView(null, startDate, endDate);
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            var startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var endDate = DateTime.Now;
            LoadDataGridView(null, startDate, endDate);
            DisableCustomDates();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchCriteria = txtTImKiem.Text.Trim();
            LoadDataGridView(searchCriteria);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void txtTImKiem_Click(object sender, EventArgs e)
        {
            txtTImKiem.Text = "";
        }
    }
}
