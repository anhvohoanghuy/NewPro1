using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class ImeiRepos
    {
        Pro1QuanLiDienThoaiFinalContext context = new Pro1QuanLiDienThoaiFinalContext();
        public ImeiRepos()
        {
            
        }
        public List<Imei> GetImei()
        {
            return context.Imeis.ToList();
        }
        //Tìm theo IdProducDetail
        public List<Imei> GetByIdProducDetail(string idproducdetail)
        {
            return context.Imeis.Where(p=>p.IdproductDetails==idproducdetail).ToList();
        }
        //Tìm theo ImeiNumber
        public List<Imei> GetByImeiNumber(string imeinumber)
        {
            return context.Imeis.Where(p=>p.ImeiNumber==imeinumber).ToList();
        }
        //Tìm theo IdAccount
        public List<Imei> GetByIdAccount(string idaccount)
        {
            return context.Imeis.Where(p=>p.Idaccount==idaccount).ToList();
        }
        //Thêm Imei
        public bool AddImei(Imei imei)
        {
            try
            {
                context.Imeis.Add(imei);
                context.SaveChanges();
                return true;

            }
            catch { return false; }
        }
        //Sửa Imei
        public bool UpdateImei(Imei imei)
        {
            try
            {
                var updateimei = context.Imeis.Find(imei.ImeiNumber);
                updateimei.IdproductDetails = imei.IdproductDetails;
                updateimei.ImeiNumber = imei.ImeiNumber;
                updateimei.Idaccount = imei.Idaccount;
                context.Imeis.Update(imei);
                context.SaveChanges();
                return true;

            }
            catch { return false; }
        }
        //Xóa Imei
        public bool DeleteImei(string imei)
        {
            try
            {
                var deleteimei = context.Imeis.Find(imei);
                context.Imeis.Remove(deleteimei);
                context.SaveChanges();
                return true;

            }
            catch { return false; }
        }
    }
}
