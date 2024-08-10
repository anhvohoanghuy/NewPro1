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
    public partial class ChiTietDonHangForm : Form
    {
        OrderBUS orderBUS=new OrderBUS();
        string IdOrder;
        string IdVoucher;
        VoucherBUS voucherBUS=new VoucherBUS();
        public ChiTietDonHangForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        public ChiTietDonHangForm(string idOrder)
        {
            this.IdOrder = idOrder;
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        public ChiTietDonHangForm(string idOrder,string idVoucher)
        {
            IdVoucher=idVoucher;
            this.IdOrder = idOrder;
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
        private void ChiTietDonHangForm_Load(object sender, EventArgs e)
        {
            var order= orderBUS.GetOrderById(IdOrder);
            if (order != null)
            {
                txtIdOrder.Text=order.Idorder;
                txtIdCustomer.Text=order.Idcustomer;
                txtCustomerName.Text=order.IdcustomerNavigation.CustomerName;
                txtPhone.Text = order.IdcustomerNavigation.PhoneNumber;
                txtAddress.Text=order.IdcustomerNavigation.CustomerAddress;
                txtDate.Text = DateTime.Now.ToString();
                txtAccountName.Text=order.IdaccountNavigation.AccountName;
                txtAmount.Text=orderBUS.GetAmountOfOrder(order).ToString();
                if (!string.IsNullOrEmpty(IdVoucher))
                {
                    var voucher= voucherBUS.GetVoucherById(IdVoucher);
                    if (voucher != null)
                    {
                        txtVoucher.Text = voucher.Discount.ToString();
                    }
                    else
                        txtVoucher.Text = "0";
                }
                else
                    txtVoucher.Text="0";
                txtTotal.Text=(decimal.Parse(txtAmount.Text)-decimal.Parse(txtVoucher.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Không có id order này");
                this.Close();
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private void btnOkScan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
