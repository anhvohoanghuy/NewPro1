using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class ImeiDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<Imei> GetImeiByProductDetailID(string idProductDetail)
        {
            return db.Imeis.Where(c => c.IdproductDetails == idProductDetail).ToList();
        }
        public List<Imei> GetAllImei()
        {
            return db.Imeis.ToList();
        }
        public bool AddNewImei(Imei imei)
        {
            try
            {
                db.Imeis.Add(imei);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateImei(Imei imei)
        {
            try
            {
                var current = db.Imeis.FirstOrDefault(c => c.ImeiNumber == imei.ImeiNumber);
                if (current != null) 
                {
                    current.Selled = imei.Selled;
                    current.Idaccount = imei.Idaccount;
                    current.IdproductDetails = imei.IdproductDetails;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteImei(Imei imei)
        {
            try
            {
                var current = db.Imeis.FirstOrDefault(c => c.ImeiNumber == imei.ImeiNumber);
                if (current != null)
                {
                    db.Imeis.Remove(current);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
