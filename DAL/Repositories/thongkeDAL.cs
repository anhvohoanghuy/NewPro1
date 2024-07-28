using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class thongkeDAL
    {

        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<Order> listO()
        {
            return db.Orders.ToList<Order>();
        }
        public List<OrderDetail> GetListOD()
        {
            return db.OrderDetails.ToList<OrderDetail>();
        }
        public List<Customer> GetListC()
        {
            return db.Customers.ToList<Customer>();
        }
        public List<ProductDetail> GetListPD()
        {
            return db.ProductDetails.ToList<ProductDetail>();
        }
        public List<Product> GetListP()
        {
            return db.Products.ToList<Product>();
        }
    }
}
