using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class VoucherDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<Voucher> GetAllVoucher()
        {
            return db.Vouchers.ToList();
        }
        public bool AddNewVoucher(Voucher voucher)
        {
            try
            {
                db.Vouchers.Add(voucher);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateVoucher(Voucher voucher)
        {
            try
            {
                var current = GetAllVoucher().FirstOrDefault(c => c.Idvoucher == voucher.Idvoucher);
                current.VoucherName= voucher.VoucherName;
                current.Discount= voucher.Discount;
                current.Idaccount= voucher.Idaccount;
                current.StartTime= voucher.StartTime;
                current.EndTime= voucher.EndTime;
                current.UsageCount= voucher.UsageCount;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
