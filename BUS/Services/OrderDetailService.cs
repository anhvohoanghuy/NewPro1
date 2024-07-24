using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class OrderDetailService
    {
        OrderDetailRepos repos = new OrderDetailRepos();
        public OrderDetailService()
        {
            
        }
        public List<OrderDetail> Show()
        {
            return repos.GetOrderDetails();
        }
        public List <OrderDetail> CNTimTheoIdOrder(string orderId)
        {
            return repos.GetByIdOrder(orderId);
        }
        public string CNAddOrderDetail(string idorder, string idproducdetail, int quantity, decimal amount, decimal reducedamount)
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                Idorder = idorder,
                IdproductDetails = idproducdetail,
                Quantity = quantity,
                Amount = amount,
                ReducedAmount = reducedamount
            };
            if (repos.AddOrderDetail(orderDetail))
            {
                return "Thêm hóa đơn chi tiết thành công";
            }
            else return "Thêm hóa đơn chi tiết thất bại";
        }
        public string UpdateOrderDetail(string idorder, string idproducdetail, int quantity, decimal amount, decimal reducedamount)
        {
            OrderDetail orderDetail = new OrderDetail()
            {
                Idorder = idorder,
                IdproductDetails = idproducdetail,
                Quantity = quantity,
                Amount = amount,
                ReducedAmount = reducedamount
            };
            if (repos.UpdateOrderDetail(orderDetail))
            {
                return "Sửa hóa đơn chi tiết thành công";
            }
            else return "Sửa hóa đơn chi tiết thất bại";
        }
        public string CNDeleteOrderDetail(string idorder)
        {
            
            if (repos.DeleteOrderDetail(idorder))
            {
                return "Thêm hóa đơn chi tiết thành công";
            }
            else return "Thêm hóa đơn chi tiết thất bại";
        }
    }
}
