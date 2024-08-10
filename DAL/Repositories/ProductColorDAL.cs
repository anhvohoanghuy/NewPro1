using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class ProductColorDAL
    {
        Pro1QuanLiDienThoaiFinalContext db= new Pro1QuanLiDienThoaiFinalContext();
        public List<ProductColor> GetAllColor()
        {
            return db.ProductColors.AsNoTracking().ToList();
        }
        public bool AddNewColor(ProductColor productColor)
        {
            try
            {
                if (db.ProductColors.Local.Any(c => c.Idcolor == productColor.Idcolor))
                {
                    return false;
                }

                db.ProductColors.Add(productColor);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateColor(ProductColor productColor)
        {
            try
            {
                // Find the existing entity in the context
                var existingColor = db.ProductColors.Local.FirstOrDefault(c => c.Idcolor == productColor.Idcolor);

                if (existingColor != null)
                {
                    // Detach the existing entity if it's being tracked
                    db.Entry(existingColor).State = EntityState.Detached;
                }

                // Attach and update the entity
                db.ProductColors.Attach(productColor);
                db.Entry(productColor).State = EntityState.Modified;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
