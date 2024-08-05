using DAL.Models;

namespace DAL.Repositories
{
    public class OrderDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public OrderDAL()
        {

        }

        public Order GetDataById(string id)
        {
            return db.Orders.Find(id);
        }

        public Order Insert(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order;
        }
    }
}
