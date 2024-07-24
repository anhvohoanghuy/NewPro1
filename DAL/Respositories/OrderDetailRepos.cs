using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderDetailRepos
    {
        Pro1QuanLiDienThoaiFinalContext context = new Pro1QuanLiDienThoaiFinalContext();
        public OrderDetailRepos()
        {
            
        }
        public List<OrderDetail> GetOrderDetails()
        {
            return context.OrderDetails.ToList();
        }
        //Tim theo idorder
        public List<OrderDetail> GetByIdOrder(string idorder)
        {
            return context.OrderDetails.Where(p=>p.Idorder == idorder).ToList();
        }
        //Them OrderDetail
        public bool AddOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Sua OrderDetail
        public bool UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                var updateitem = context.OrderDetails.Find(orderDetail.Idorder);
                updateitem.Idorder= orderDetail.Idorder;
                updateitem.IdproductDetails = orderDetail.IdproductDetails;
                updateitem.Quantity = orderDetail.Quantity;
                updateitem.Amount = orderDetail.Amount;
                updateitem.ReducedAmount = orderDetail.ReducedAmount;
                context.OrderDetails.Update(updateitem);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Xóa OrderDetail
        public bool DeleteOrderDetail(string idorder)
        {
            try
            {
                var deleteitem = context.OrderDetails.Find(idorder);
                context.OrderDetails.Remove(deleteitem);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
