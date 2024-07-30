using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ImeiBUS
    {
        ImeiDAL imeisDAL = new ImeiDAL();
        public List<Imei> GetImeiByIdProductDetail(string idProductDetail)
        {
            return imeisDAL.GetImeiByProductDetailID(idProductDetail);
        }
        public Imei GetImeiByID(string imei)
        {
            return imeisDAL.GetAllImei().FirstOrDefault(c => c.ImeiNumber == imei);
        }
        public string RemoveImeiFromList(string imei,List<string> list)
        {
            if (list.Contains(imei) && !CheckImeiExists(imei))
            {
                list.Remove(imei);
                return "Xóa thành công";
            }
            else if(list.Contains(imei) && DeleteImei(imei))
            {
                list.Remove(imei);
                return "Xóa thành công";
            }
            else if (list.Contains(imei) && !DeleteImei(imei))
            {
                return "Imei này đã bán ";
            }
            else
                return "Không có Imei này";
        }
        public List<string> GetImeiNumberByIDProductDetail(string idProductDetail)
        {
            var list = imeisDAL.GetAllImei().Where(c=>c.IdproductDetails==idProductDetail);
            var imeis = new List<string>();
            foreach (var item in list)
            {
                imeis.Add(item.ImeiNumber);
            }
            return imeis;
        }
        public bool AddNewImei(string idProductDetail, string imeiNumber, string idAccount, bool selled)
        {
            Imei imei = new Imei()
            {
                IdproductDetails = idProductDetail,
                ImeiNumber = imeiNumber,
                Idaccount = idAccount,
                Selled = selled
            };
            return imeisDAL.AddNewImei(imei);
        }
        public bool CheckImeiExists(string imei)
        {
            var check = GetImeiByID(imei);
            if (check != null)
                return true;
            return false;
        }
        public bool UpdateImei(string idProductDetail, string imeiNumber, string idAccount, bool selled)
        {
            Imei imei = new Imei()
            {
                IdproductDetails = idProductDetail,
                ImeiNumber = imeiNumber,
                Idaccount = idAccount,
                Selled = selled
            };
            return imeisDAL.UpdateImei(imei);
        }
        public bool DeleteImei(string imeiNumber)
        {
            Imei imei = GetImeiByID(imeiNumber);
            if (imei==null)
                return false;
            else if(imei.Selled==true)
                return false;
            return imeisDAL.DeleteImei(imei);
        }
    }
}
