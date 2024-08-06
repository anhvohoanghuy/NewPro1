using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderDAL
    {
        Pro1QuanLiDienThoaiFinalContext db= new Pro1QuanLiDienThoaiFinalContext();
        public List<Order> GetAllOrder()
        {
            return db.Orders.Include(c=>c.IdcustomerNavigation).Include(c=>c.IdaccountNavigation).ToList();
        }
        public bool AddNewOrder(Order order)
        {
            try
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateOrder(Order order)
        {
            try
            {
                var current = GetAllOrder().FirstOrDefault(c => c.Idorder == order.Idorder);
                if (current != null)
                {
                    current.Idaccount= order.Idaccount;
                    current.Idcustomer= order.Idcustomer;
                    current.EstablishedDate = order.EstablishedDate;
                    current.TotalAmount= order.TotalAmount;
                    current.Idvoucher= order.Idvoucher;
                    current.OrderStatus = order.OrderStatus;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
