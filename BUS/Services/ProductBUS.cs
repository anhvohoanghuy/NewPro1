using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Respositories;
using DAL.Models;

namespace BUS.Services
{
    public class ProductBUS
    {
        ProductDAL productDAL = new ProductDAL();
        ProductDetailDAL productDetailDAL = new DAL.Respositories.ProductDetailDAL();
        ProductColorDAL productColorDAL = new ProductColorDAL();
        public List<Product> GetAllProduct()
        {
            var list= productDAL.GetAllProduct();
            return list;
        }
        public List<Product> SearchByID(string id)
        {
            return GetAllProduct().Where(c=>c.Idproduct.Contains(id)).ToList();
        }
        public Product GetProductByID(string id)
        {
            return productDAL.GetAllProduct().FirstOrDefault(c => c.Idproduct == id);
        }
        public bool CheckProductIfExist(string idProduct)
        {
            var check= GetProductByID(idProduct);
            if (check != null)
                return false;
            return true;
        }
        public bool AddNewProduct(string idProduct, string productImage, string productName, string idCompany, int ram,string idCPU, double screenSize, string screenResolution, int refeshRate, double cameraResolution,int pin, string idAccount,bool productStatus)
        {
            Product product = new Product()
            {
                Idproduct= idProduct,
                ProductImage= productImage,
                ProductName= productName,
                Idcompany= idCompany,
                Ram=ram,
                Idcpu=idCPU,
                ScreenSize=screenSize,
                ScreenResolution=screenResolution,
                RefreshRate=refeshRate,
                CameraResolution=cameraResolution,
                Pin=pin,
                Idaccount=idAccount,
            };
            if (productDAL.AddNewProduct(product))
            {
                return true;
            }
            else
                return false;
        }
        public bool UpdateProduct(string idProduct, string productImage, string productName, string idCompany, int ram, string idCPU, double screenSize, string screenResolution, int refeshRate, double cameraResolution, int pin, string idAccount, bool productStatus)
        {
            Product product = new Product()
            {
                Idproduct = idProduct,
                ProductImage = productImage,
                ProductName = productName,
                Idcompany = idCompany,
                Ram = ram,
                Idcpu = idCPU,
                ScreenSize = screenSize,
                ScreenResolution = screenResolution,
                RefreshRate = refeshRate,
                CameraResolution = cameraResolution,
                Pin = pin,
                Idaccount = idAccount,
            };
            if (productDAL.UpdateProduct(product))
            {
                return true;
            }
            else
                return false;
        }
        public List<Product> GetProductByIdAccount(string idaccount)
        {
            return GetAllProduct().Where(c => c.Idaccount== idaccount).ToList();
        }
        public List<Product> GetProductByName(string name)
        {
            return GetAllProduct().Where(c => c.ProductName.ToLower().Contains(name.ToLower().Trim())).ToList();
        }
        public List<Product> GetProductByIDProductCompany(string idCompany)
        {
            return productDAL.GetAllProduct().Where(c => c.Idcompany == idCompany).ToList();
        }
        public List<Product> GetProducstByCompanyName(string companyName)
        {
            var list = GetAllProduct();
            var result = list.Where(c => c.IdcompanyNavigation.CompanyName.ToLower().Contains(companyName.ToLower().Trim())).ToList();
            return result;
        }
        public List<Product> GetProductByIdCPU(string idCpu)
        {
            return productDAL.GetAllProduct().Where(c => c.Idcpu == idCpu).ToList();
        }
        public List<Product> GetProductByCPUName(string Cpu)
        {
            return productDAL.GetAllProduct().Where(c => c.IdcpuNavigation.NameCpu.ToLower().Contains(Cpu.ToLower().Trim())).ToList();
        }
        public List<Product> GetProductByRameSize(double from, double to)
        {
            return productDAL.GetAllProduct().Where(c => c.Ram <= to && c.Ram >= from).ToList();
        }
        public List<Product> GetProductByScreenSize(double from, double to)
        {
            return productDAL.GetAllProduct().Where(c => c.ScreenSize <= to && c.ScreenSize >= from).ToList();
        }
        public List<Product> GetProductByPin(double from, double to)
        {
            return productDAL.GetAllProduct().Where(c => c.Pin <= to && c.Pin >= from).ToList();
        }
        public List<Product> GetProductByRefreshRate(double from, double to)
        {
            return productDAL.GetAllProduct().Where(c => c.RefreshRate <= to && c.RefreshRate >= from).ToList();
        }
        public List<ProductColor> GetAllColorOfProduct(Product current)
        {
            List<ProductDetail> listProductDetail = productDetailDAL.GetAllProductDetail().Where(c => c.Idproduct == current.Idproduct).ToList();
            List<DAL.Models.ProductColor> listColor = new List<DAL.Models.ProductColor>();
            foreach (var productDetail in listProductDetail)
            {
                listColor.Add(productColorDAL.GetAllColor().FirstOrDefault(c => c.Idcolor == productDetail.Idcolor));
            }
            return listColor.Distinct().ToList();
        }
        public List<int> GetAllStorageOfProduct(Product current)
        {
            List<ProductDetail> listProductDetail = productDetailDAL.GetAllProductDetail().Where(c => c.Idproduct == current.Idproduct).ToList();
            List<int> listStorage = new List<int>();
            foreach (var productDetail in listProductDetail)
            {
                listStorage.Add(productDetail.Storage);
            }
            listStorage.Sort();
            return listStorage.Distinct().ToList();
        }
        public List<string> GetAllIDProduct()
        {
            var listProduct= GetAllProduct();
            var listIDProduct = new List<string>();
            foreach (var product in listProduct)
            {
                listIDProduct.Add(product.Idproduct);
            }
            return listIDProduct;
        }
        public List<Product> FilterProduct(int sw,double from,double to)
        {
            var listProduct = GetAllProduct();
            switch (sw)
            {
                case 0:
                    return GetProductByRameSize(from, to);
                case 1:
                    return GetProductByPin(from, to);
                case 2:
                    return GetProductByRefreshRate(from, to);
                case 3:
                    return GetProductByScreenSize(from, to);
                default:
                    return null;
                    break;
            }
        }
    }
}
