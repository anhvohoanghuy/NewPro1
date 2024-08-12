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
    public partial class FormCPU : Form
    {

        string IDAccount;
        CpuBUS cpuBUS = new CpuBUS();
        public FormCPU()
        {
            InitializeComponent();
            LoadDataGridView();
            dgvListCPU.CellClick += dgvListCPU_CellClick; // Register the event handler
        }
        public FormCPU(string idAccount)
        {
            IDAccount = idAccount;
            InitializeComponent();
            LoadDataGridView();
            dgvListCPU.CellClick += dgvListCPU_CellClick; // Register the event handler

        }

        private void dgvListCPU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0&&e.RowIndex<=dgvListCPU.Rows.Count-1)
            {
                DataGridViewRow row = dgvListCPU.Rows[e.RowIndex];

                cPuID.Text = row.Cells["IDcpu"].Value.ToString();
                txtNAMECPU.Text = row.Cells["NameCpu"].Value.ToString();
                txtManufacturer.Text = row.Cells["Manufacturer"].Value.ToString();
            }
        }




        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string idCpu = cPuID.Text.Trim();
                string nameCpu = txtNAMECPU.Text.Trim();
                string manufacturer = txtManufacturer.Text.Trim();
                string idAccount = IDAccount;

                bool isAdded = cpuBUS.AddNewCPU(idCpu, nameCpu, manufacturer, idAccount);

                if (isAdded)
                {
                    MessageBox.Show("Thêm CPU thành công!");
                    ClearForm();
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Thêm CPU thất bại. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            cPuID.Clear();
            txtNAMECPU.Clear();
            txtManufacturer.Clear();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string idCpu = cPuID.Text.Trim();
                string nameCpu = txtNAMECPU.Text.Trim();
                string manufacturer = txtManufacturer.Text.Trim();
                string idAccount = IDAccount;

                bool isUpdated = cpuBUS.UpdateCPU(idCpu, nameCpu, manufacturer, idAccount);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật CPU thành công!");
                    ClearForm();
                    LoadDataGridView();
                }
                else
                {
                    MessageBox.Show("Cập nhật CPU thất bại. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }
        private void FormCPU_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            dgvListCPU.Columns.Clear();

            dgvListCPU.Columns.Add("IDcpu", "ID CPU");
            dgvListCPU.Columns.Add("NameCpu", "CPU Name");
            dgvListCPU.Columns.Add("Manufacturer", "Manufacturer");
            dgvListCPU.Columns.Add("IdAccount", "ID Account");

            dgvListCPU.Columns["IDcpu"].Width = 100;
            dgvListCPU.Columns["NameCpu"].Width = 200;
            dgvListCPU.Columns["Manufacturer"].Width = 150;
            dgvListCPU.Columns["IdAccount"].Width = 100;

            var cpuList = cpuBUS.GetAllCPU();

            dgvListCPU.Rows.Clear();

            foreach (var cpu in cpuList)
            {
                dgvListCPU.Rows.Add(cpu.Idcpu, cpu.NameCpu, cpu.Manufacturer, cpu.Idaccount);
            }

            dgvListCPU.RowTemplate.Height = 40;

            dgvListCPU.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormCPU_Load_1(object sender, EventArgs e)
        {

        }
    }
}
