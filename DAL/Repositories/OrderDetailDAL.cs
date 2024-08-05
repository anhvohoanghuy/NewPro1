using DAL.Models;

namespace DAL.Repositories
{
    public class OrderDetailDetailDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public OrderDetailDetailDAL()
        {

        }

        public OrderDetail GetDataById(string id)
        {
            return db.OrderDetails.Find(id);
        }

        public OrderDetail Insert(OrderDetail OrderDetail)
        {
            db.OrderDetails.Add(OrderDetail);
            db.SaveChanges();
            return OrderDetail;
        }
    }
}
