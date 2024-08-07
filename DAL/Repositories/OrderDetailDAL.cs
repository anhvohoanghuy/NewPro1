using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderDetailDAL
    {
        Pro1QuanLiDienThoaiFinalContext _context = new Pro1QuanLiDienThoaiFinalContext();
        public List<OrderDetail> GetAllOrderDetail()
        {
            return _context.OrderDetails.Include(c=>c.IdproductDetailsNavigation).Include(c=>c.ImeiNumbers).ToList();
        }
        public bool AddNewOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                _context.OrderDetails.Add(orderDetail);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                var current = GetAllOrderDetail().FirstOrDefault(c => c.Idorder == orderDetail.Idorder && c.IdproductDetails == orderDetail.IdproductDetails);
                if (current != null)
                {
                    current.Quantity = orderDetail.Quantity;
                    current.Amount = orderDetail.Amount;
                    current.ReducedAmount = orderDetail.ReducedAmount;
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false ;
            }
        }
        public void AddImeiToOrderDetail(OrderDetail orderDetail, Imei imei)
        {
            var thisImei = _context.Imeis.FirstOrDefault(c => c.ImeiNumber == imei.ImeiNumber);
            var current = GetAllOrderDetail().FirstOrDefault(c => c.Idorder == orderDetail.Idorder && c.IdproductDetails == orderDetail.IdproductDetails);
            current.ImeiNumbers.Add(thisImei);
            _context.SaveChanges();
        }
        public bool DeleteOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                if (_context.Orders.FirstOrDefault(c=>c.Idorder==orderDetail.Idorder).OrderStatus == 0)
                {
                    _context.OrderDetails.Remove(orderDetail);
                    _context.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
