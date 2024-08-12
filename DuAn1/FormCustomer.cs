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
    public partial class FormCustomer : Form
    {
        string IDAccount;
        CustomerBUS customerBUS = new CustomerBUS();
        public FormCustomer()
        {
            InitializeComponent();
        }
        public FormCustomer(string idAccount)
        {
            IDAccount = idAccount;
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            dgvListCustomer.Columns.Add("IdCustomer", "ID customer");
            dgvListCustomer.Columns.Add("CustomerName", "Customer name");
            dgvListCustomer.Columns.Add("PhoneNumber", "Phone number");
            dgvListCustomer.Columns.Add("CustomerAddress", "Address");
            dgvListCustomer.Columns.Add("IdAccount", "ID account");
        }
        public void ShowOnDataGridView(List<Customer> list)
        {
            dgvListCustomer.Rows.Clear();
            if (list != null)
            {
                foreach (Customer customer in list)
                {
                    dgvListCustomer.Rows.Add(customer.Idcustomer, customer.CustomerName, customer.PhoneNumber, customer.CustomerAddress, customer.Idaccount);
                }
            }
        }
        public void ResetTexbox(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        public void ResetCombobox(params ComboBox[] comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                comboBox.Items.Clear();
                comboBox.Text = string.Empty;
            }
        }
        public void ResetForm()
        {
            ResetTexbox(txtIdCustomer, txtCustomerName, txtPhoneNumber, txtAddress, txtIdAccount);
            txtIdAccount.Text = IDAccount;
        }
        public bool CheckNull(params TextBox[] textBoxes)
        {
            foreach (var item in textBoxes)
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
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            cbbTimKiem.Items.AddRange(["By id customer", "By name", "By phone number","By address" ,"By id account"]);
            LoadDataGridView();
            ShowOnDataGridView(customerBUS.GetAllCustomer());
            txtIdAccount.Text = IDAccount;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = customerBUS.Search(cbbTimKiem.SelectedIndex, txtTimKiem.Text);
            ShowOnDataGridView(result);
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckNull(txtIdCustomer, txtCustomerName, txtPhoneNumber))
            {
                var check = CheckIsInt(txtPhoneNumber);
                if (check == null)
                {
                    if (customerBUS.AddNewCustomer(txtIdCustomer.Text, txtCustomerName.Text, txtPhoneNumber.Text, txtAddress.Text, txtIdAccount.Text))
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm thất bại");
                }
                else
                    MessageBox.Show(check);
            }
            else
                MessageBox.Show("Nhập đầy đủ thông tin");
            ShowOnDataGridView(customerBUS.GetAllCustomer());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckNull(txtIdCustomer, txtCustomerName, txtPhoneNumber))
            {
                if (customerBUS.CheckCustomerExsit(txtIdCustomer.Text))
                {
                    var check = CheckIsInt(txtPhoneNumber);
                    if (check == null)
                    {
                        if (customerBUS.UpdateCustomer(txtIdCustomer.Text, txtCustomerName.Text, txtPhoneNumber.Text, txtAddress.Text, txtIdAccount.Text))
                            MessageBox.Show("Sửa thành công");
                        else
                            MessageBox.Show("Sửa thất bại");
                    }
                    else
                        MessageBox.Show(check);
                }
                else
                    MessageBox.Show("Không có id khác hàng này");
            }
            else
                MessageBox.Show("Nhập đầy đủ thông tin");
            ShowOnDataGridView(customerBUS.GetAllCustomer());
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            txtIdCustomer.Text = txtPhoneNumber.Text;
        }

        private void dgvListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgvListCustomer.RowCount-1)
            {
                var row= dgvListCustomer.Rows[e.RowIndex];
                txtIdCustomer.Text = row.Cells[0].Value.ToString();
                txtCustomerName.Text = row.Cells[1].Value.ToString();
                txtPhoneNumber.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtIdAccount.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
