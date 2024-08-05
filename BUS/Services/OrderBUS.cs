using DAL.Models;
using DAL.ModelViews;
using DAL.Repositories;

namespace BUS.Services
{
    public class OrderBUS
    {
        private readonly OrderDAL orderDAL;
        private readonly CustomerBUS customerBUS;
        public OrderBUS()
        {
            orderDAL = new OrderDAL();
            customerBUS = new CustomerBUS();
        }

        public Order GetById(string id)
        {
            return orderDAL.GetDataById(id);
        }

        public bool AddOrder(OrderModelView order)
        {
            customerBUS.AddNewCustomer(order.CustomerId, order.CustomerName, order.PhoneNumber, order.Address, order.Idaccount);
            orderDAL.Insert(new Order()
            {
                Idorder = order.OrderId,
                Idaccount = order.Idaccount,
                Idcustomer = order.CustomerId,
                EstablishedDate = DateTime.Now,
                TotalAmount = order.TotalAmount,
                Idvoucher = order.Idvoucher,
                Paid = order.Paid,
            });
            return true;
        }
    }
}
