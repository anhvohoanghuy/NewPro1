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
        public List<Order> GetListO()
        {
            return db.Orders.ToList<Order>();
        }
        public List<OrderDetail> GetListOD()
        {
            return db.OrderDetails.ToList<OrderDetail>();
        }
    }
}
