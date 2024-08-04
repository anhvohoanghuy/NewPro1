using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ProductDetailBUS
    {
        ProductDetailDAL productDetailDAL = new ProductDetailDAL();
        PromotionDAL promotionDAL = new PromotionDAL();
        ImeiBUS imeiBUS = new ImeiBUS();
        public List<ProductDetail> GetAllProductDetail()
        {
            return productDetailDAL.GetAllProductDetail();
        }
        public decimal GetPriceOfProductDetail(ProductDetail productDetail)
        {
            return productDetail.Price;
        }
        public bool AddNewProductDetail(string idProduct,string idProductDetail, string idColor,int storage, decimal price, string idPromotion, int wrrantyPeriod, int inventory, string idAccount)
        {
            ProductDetail productDetail = new ProductDetail()
            {
                Idproduct = idProduct,
                IdproductDetails = idProductDetail,
                Idcolor = idColor,
                Storage = storage,
                Price = price,
                Idpromotion = idPromotion==null?null:idPromotion,
                WarrantyPeriod = wrrantyPeriod,
                Inventory = inventory,
                Idaccount = idAccount
            };
            if (productDetailDAL.AddNewProductDetail(productDetail))
                return true;
            else 
                return false;
        }
        public bool UpdateProductDetail(string idProduct, string idProductDetail, string idColor, int storage, decimal price, string idPromotion, int wrrantyPeriod, int inventory, string idAccount)
        {
            ProductDetail productDetail = new ProductDetail()
            {
                Idproduct = idProduct,
                IdproductDetails = idProductDetail,
                Idcolor = idColor,
                Storage = storage,
                Price = price,
                Idpromotion = idPromotion,
                WarrantyPeriod = wrrantyPeriod,
                Inventory = inventory,
                Idaccount = idAccount
            };
            if (productDetailDAL.UpdateProductDetail(productDetail))
                return true;
            else
                return false;
        }
        public List<ProductDetail> GetProductDetailByIdColor(string IdColor)
        {
            return productDetailDAL.GetAllProductDetail().Where(c => c.Idcolor.ToLower().Contains(IdColor.ToLower())).ToList();
        }
        public int GetInventoryOfProductDetail(ProductDetail productDetail)
        {
            return productDetail.Inventory;
        }
        public decimal GetDiscountOfProductDetail(ProductDetail productDetail)
        {
            return promotionDAL.GetAllPromotion().FirstOrDefault(c => c.Idpromotion == productDetail.Idpromotion).Discount;
        }
        public int GetWarrantyPeriodOfProductDetail(ProductDetail productDetail)
        {
            return productDetail.WarrantyPeriod;
        }
        public ProductDetail GetProductDetailByID(string idProductDetail)
        {
            return GetAllProductDetail().FirstOrDefault(c => c.IdproductDetails == idProductDetail);
        }
        public List<ProductDetail> SearchByIdProductDetail(string id)
        {
            return GetAllProductDetail().Where(c => c.IdproductDetails.ToLower().Contains(id.ToLower())).ToList();
        }
        public List<ProductDetail> SearchByIDProduct(string id)
        {
            return GetAllProductDetail().Where(c => c.Idproduct.ToLower().Contains(id.ToLower())).ToList();
        }
        public List<ProductDetail> SearchByColorName(string colorName)
        {
            return GetAllProductDetail().Where(c => c.IdcolorNavigation.ColorName.ToLower().Contains(colorName.ToLower())).ToList();
        }
        public List<ProductDetail> SearchByIdPromotion(string idPromotion)
        {
            return GetAllProductDetail().Where(c => c.Idpromotion.ToLower().Contains(idPromotion.ToLower())).ToList();
        }
        public List<ProductDetail> FillterByStorage(double from, double to)
        {
            return GetAllProductDetail().Where(c => c.Storage >= from && c.Storage <= to).ToList();
        }
        public List<ProductDetail> FillterByPrice(double from, double to)
        {
            return GetAllProductDetail().Where(c => c.Price >= (decimal)from && c.Price <= (decimal)to).ToList();
        }
        public List<ProductDetail> FillterByWarrantyPeriod(double from, double to)
        {
            return GetAllProductDetail().Where(c => c.WarrantyPeriod >= from && c.WarrantyPeriod <= to).ToList();
        }
        public List<ProductDetail> FillterByInventory(double from, double to)
        {
            return GetAllProductDetail().Where(c => c.Inventory >= from && c.Inventory <= to).ToList();
        }
        public List<ProductDetail> Search(int sw, string key)
        {
            switch (sw)
            {
                case 0:
                    return SearchByIdProductDetail(key);
                case 1:
                    return SearchByIDProduct(key);
                case 2:
                    return GetProductDetailByIdColor(key);
                case 3:
                    return SearchByColorName(key);
                case 4:
                    return SearchByIdPromotion(key);
                default:
                    return null;
            }
        }
        public List<ProductDetail> Filter(int sw,double from,double to)
        {
            switch (sw)
            {
                case 0:
                    return FillterByStorage(from, to);
                case 1:
                    return FillterByPrice(from, to);
                case 2:
                    return FillterByWarrantyPeriod(from, to);
                case 3:
                    return FillterByInventory(from, to);
                default:
                    return null;
            }
        }
        public Dictionary<string,int> GetNewProductDetailByTime(DateTime from, DateTime to)
        {
            List<Imei> imeis = imeiBUS.GetImeiByTime(from, to);
            List<string> idproductDetails = new List<string>();
            foreach (Imei imei in imeis)
            {
                idproductDetails.Add(imei.IdproductDetails);
            }
            var resul = idproductDetails.GroupBy(x=>x).ToDictionary(g=>g.Key,g=>g.Count());
            return resul;
        }
    }
}
