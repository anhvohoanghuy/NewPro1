﻿using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class VoucherBUS
    {
        VoucherDAL voucherDAL=new VoucherDAL();
        public List<Voucher> GetAllVoucher()
        {
            return voucherDAL.GetAllVoucher();
        }
        public Voucher GetVoucherById(string idVoucher)
        {
            return GetAllVoucher().FirstOrDefault(c => c.Idvoucher == idVoucher);
        }
        public List<Voucher> GetVoucherByName(string voucherName)
        {
            return GetAllVoucher().Where(c=>c.VoucherName.Contains(voucherName)).ToList();
        }
        public bool CheckVoucherExist(string idVoucher)
        {
            var check=GetVoucherById(idVoucher);
            if (check != null)
                return true;
            else
                return false;
        }
        public bool AddNewVoucher(string idVoucher,string voucherName, decimal discount, DateTime startTime,DateTime endTime,string idAccount)
        {
            if (!CheckVoucherExist(idVoucher))
            {
                var voucher = new Voucher()
                {
                    Idvoucher = idVoucher,
                    VoucherName = voucherName,
                    Discount = discount,
                    StartTime = startTime,
                    EndTime = endTime,
                    Idaccount = idAccount
                };
                return voucherDAL.AddNewVoucher(voucher);
            }
            else
                return false;
        }
        public bool UpdateVoucher(string idVoucher, string voucherName, decimal discount, DateTime startTime, DateTime endTime, string idAccount)
        {
            if (CheckVoucherExist(idVoucher))
            {
                var voucher = new Voucher()
                {
                    Idvoucher = idVoucher,
                    VoucherName = voucherName,
                    Discount = discount,
                    StartTime = startTime,
                    EndTime = endTime,
                    Idaccount = idAccount
                };
                return voucherDAL.UpdateVoucher(voucher);
            }
            else
                return false;
        }
    }
}
