using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class OrderDetailBUS
    {
        OrderDetailDAL orderDetailDAL= new OrderDetailDAL();
        public List<OrderDetail> GetOrderDetails()
        {
            return orderDetailDAL.GetAllOrderDetail();
        }
        public bool AddNewOrderDetail(string idOrder, string idProductDetail, int quantity, decimal amount, decimal reduceAmount)
        {
            var orderDetail = new OrderDetail()
            {
                Idorder = idOrder,
                IdproductDetails = idProductDetail,
                Quantity = quantity,
                Amount = amount,
                ReducedAmount = reduceAmount
            };
            return orderDetailDAL.AddNewOrderDetail(orderDetail);
        }
        public bool DeleteOrderDetail(string idOrder, string idProductDetail, int quantity, decimal amount, decimal reduceAmount)
        {
            var orderDetail = new OrderDetail()
            {
                Idorder = idOrder,
                IdproductDetails = idProductDetail,
                Quantity = quantity,
                Amount = amount,
                ReducedAmount = reduceAmount
            };
            return orderDetailDAL.DeleteOrderDetail(orderDetail);
        }
        public bool UpdateOrderDetail(string idOrder, string idProductDetail, int quantity, decimal amount, decimal reduceAmount)
        {
            var orderDetail = new OrderDetail()
            {
                Idorder = idOrder,
                IdproductDetails = idProductDetail,
                Quantity = quantity,
                Amount = amount,
                ReducedAmount = reduceAmount
            };
            return orderDetailDAL.UpdateOrderDetail(orderDetail);
        }
    }
}
