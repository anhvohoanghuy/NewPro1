using DAL.Models;
using DAL.ModelViews;
using Microsoft.EntityFrameworkCore;

namespace DAL.Respositories
{
    public class ProductDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public ProductDAL()
        {

        }
        public List<Product> GetAllProduct()
        {
            var result = db.Products.Include(c => c.IdcompanyNavigation).Include(c => c.IdcpuNavigation).ToList();
            return result;
        }
        public bool AddNewProduct(Product newProduct)
        {
            try
            {
                db.Products.Add(newProduct);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateProduct(Product updateProduct)
        {
            try
            {
                var current = GetAllProduct().FirstOrDefault(c => c.Idproduct == updateProduct.Idproduct);
                if (current != null)
                {
                    current.ProductImage = updateProduct.ProductImage;
                    current.ProductName = updateProduct.ProductName;
                    current.Idcompany = updateProduct.Idcompany;
                    current.Ram = updateProduct.Ram;
                    current.Idcpu = updateProduct.Idcpu;
                    current.ScreenSize = updateProduct.ScreenSize;
                    current.ScreenResolution = updateProduct.ScreenResolution;
                    current.RefreshRate = updateProduct.RefreshRate;
                    current.CameraResolution = updateProduct.CameraResolution;
                    current.Pin = updateProduct.Pin;
                    current.Idaccount = updateProduct.Idaccount;
                    current.ProductStatus = updateProduct.ProductStatus;
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
        public bool ChangeStatusProduct(Product updateProduct)
        {
            try
            {
                updateProduct.ProductStatus = false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<ProductModelView> GetDataIncludeAll()
        {
            var list = from p in db.Products
                       join pd in db.ProductDetails on p.Idproduct equals pd.Idproduct
                       join c in db.ProductCompanys on p.Idcompany equals c.Idcompany
                       join cpu in db.Cpus on p.Idcpu equals cpu.Idcpu
                       join col in db.ProductColors on pd.Idcolor equals col.Idcolor
                       join pro in db.Promotions on pd.Idpromotion equals pro.Idpromotion into proGroup
                       from pro in proGroup.DefaultIfEmpty()
                       where pro == null || (pro.StartTime <= DateTime.Now && pro.EndTime >= DateTime.Now)
                       orderby p.Idproduct
                       select new ProductModelView()
                       {
                           Idproduct = p.Idproduct,
                           ProductImage = p.ProductImage,
                           ProductName = p.ProductName,
                           Ram = p.Ram,
                           Idcompany = p.Idcompany,
                           CompanyName = c.CompanyName,
                           Idcpu = p.Idcpu,
                           NameCpu = cpu.NameCpu,
                           Manufacturer = cpu.Manufacturer,
                           IdproductDetails = pd.IdproductDetails,
                           Idcolor = pd.Idcolor,
                           ColorName = col.ColorName,
                           Storage = pd.Storage,
                           Price = pd.Price,
                           Idpromotion = pro.Idpromotion,
                           PromotionName = pro.PromotionName,
                           Discount = pro.Discount
                       };
            return list.ToList();
        }
    }
}
