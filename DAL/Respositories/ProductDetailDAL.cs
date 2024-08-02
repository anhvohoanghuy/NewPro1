using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class ProductDetailDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<ProductDetail> GetAllProductDetail()
        { 
            var result = db.ProductDetails.Include(c=>c.IdcolorNavigation).ToList();
            return result; 
        }
        public bool AddNewProductDetail(ProductDetail productDetail)
        {
            try
            {
                db.ProductDetails.Add(productDetail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateProductDetail(ProductDetail productDetail)
        {
            try
            {
                var currentProductDetail=db.ProductDetails.FirstOrDefault(c=>c.IdproductDetails==productDetail.IdproductDetails);
                if (currentProductDetail != null)
                {
                    currentProductDetail.Idproduct=productDetail.Idproduct;
                    currentProductDetail.Idcolor=productDetail.Idcolor;
                    currentProductDetail.Storage=productDetail.Storage;
                    currentProductDetail.Price=productDetail.Price;
                    currentProductDetail.Idpromotion=productDetail.Idpromotion;
                    currentProductDetail.WarrantyPeriod=productDetail.WarrantyPeriod;
                    currentProductDetail.Inventory=productDetail.Inventory;
                    currentProductDetail.Idaccount=productDetail.Idaccount;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
