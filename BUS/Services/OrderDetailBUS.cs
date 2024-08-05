using DAL.Models;
using DAL.ModelViews;
using DAL.Repositories;

namespace BUS.Services
{
    public class OrderDetailBUS
    {
        private readonly OrderDetailDetailDAL orderDAL;
        private readonly CustomerBUS customerBUS;
        public OrderDetailBUS()
        {
            orderDAL = new OrderDetailDetailDAL();
            customerBUS = new CustomerBUS();
        }

        public OrderDetail GetById(string id)
        {
            return orderDAL.GetDataById(id);
        }

        public bool AddOrder(OrderDetailModelView order)
        {
            return orderDAL.Insert(new OrderDetail()
            {
                Idorder = order.Idorder,
                IdproductDetails = order.IdproductDetails,
                Quantity = order.Quantity,
                Amount = order.Amount,
                ReducedAmount = order.ReducedAmount
            }) != null;
        }
    }
}
