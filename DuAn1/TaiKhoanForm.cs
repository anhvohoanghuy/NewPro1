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
    public partial class TaiKhoanForm : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        public TaiKhoanForm()
        {
            InitializeComponent();
        }
    }
}
