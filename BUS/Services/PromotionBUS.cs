using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class PromotionBUS
    {
        PromotionDAL promotionDAL = new PromotionDAL();
        public List<Promotion> GetAllPromotion()
        {
            return promotionDAL.GetAllPromotion();
        }
        public bool CheckPromotionExist(string id)
        {
            var check = GetPromotionById(id);
            return check != null;
        }
        public List<string> GetAllIdPromotion()
        {
            var listPromotion= GetAllPromotion();
            var listID= new List<string>();
            foreach (var id in listPromotion)
            {
                listID.Add(id.Idpromotion);
            }
            return listID;
        }
        public bool AddNewPromotion(string idPromotion,string promotionName, decimal discount, DateTime startTime, DateTime endTime,string idAccount)
        {
            Promotion promotion = new Promotion()
            {
                Idpromotion = idPromotion,
                PromotionName = promotionName,
                Discount = discount,
                StartTime = startTime,
                EndTime = endTime,
                Idaccount = idAccount
            };
            if(promotionDAL.AddNewPromotion(promotion))
                return true;
            else
                return false;
        }
        public bool UpdatePromotion(string idPromotion, string promotionName, decimal discount, DateTime startTime, DateTime endTime, string idAccount)
        {
            Promotion promotion = new Promotion()
            {
                Idpromotion = idPromotion,
                PromotionName = promotionName,
                Discount = discount,
                StartTime = startTime,
                EndTime = endTime,
                Idaccount = idAccount
            };
            if (promotionDAL.UpdatePromotion(promotion))
                return true;
            else
                return false;
        }
        public Promotion GetPromotionById(string idPromotion) 
        {
            return GetAllPromotion().FirstOrDefault(c=>c.Idpromotion==idPromotion);
        }
        public List<Promotion> SearchByIdPromotion(string id)
        {
            return GetAllPromotion().Where(c=>c.Idpromotion.Contains(id)).ToList();
        }
        public List<Promotion> SearchByPromotionName(string name)
        {
            return GetAllPromotion().Where(c => c.PromotionName.Contains(name)).ToList();
        }
        public List<Promotion> FillterByDiscount(string from, string to)
        {
            decimal from1;
            decimal to1;
            if (string.IsNullOrEmpty(from))
                from1 = -1;
            else
                from1 = decimal.Parse(from);
            if (string.IsNullOrEmpty(to))
                to1 = int.MaxValue;
            else
                to1 = decimal.Parse(to);
            return GetAllPromotion().Where(c=>c.Discount<=to1&&c.Discount>=from1).ToList();
        }
        public List<Promotion> FillterByTime(DateTime from, DateTime to)
        {
            return GetAllPromotion().Where(c => c.StartTime >=from && c.EndTime <=to).ToList();
        }
        public List<Promotion> Search(int sw,string key)
        {
            switch (sw)
            {
                case 0:
                    return SearchByIdPromotion(key);
                case 1:
                    return SearchByPromotionName(key);
                default:
                    return null;
                    break;
            }
        }

    }
}
