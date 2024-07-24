using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderRepos
    {
        Pro1QuanLiDienThoaiFinalContext context = new Pro1QuanLiDienThoaiFinalContext();
        public OrderRepos()
        {
            
        }
        public List<Order> GetOrders()
        {
            return context.Orders.ToList();
        }
        //Tim theo Idorder
        public List<Order> GetByIdOrder(string idorder)
        {
            return context.Orders.Where(p=>p.Idorder == idorder).ToList();
        }
        //Tim theo Idaccount
        public List<Order> GetByIdAccount(string idaccount)
        {
            return context.Orders.Where(p=>p.Idaccount == idaccount).ToList();
        }
        //Tim theo idcustom
        public List<Order> GetByIdCustom(string idcustom)
        {
            return context.Orders.Where(p=>p.Idcustomer == idcustom).ToList();
        }
        //Tim theo EstablishedDate
        public List<Order> GetByEstablishedDate(DateTime fromdate, DateTime todate)
        {
            return context.Orders.Where(p=>p.EstablishedDate>=fromdate&&p.EstablishedDate<=todate).ToList();
        }
        //Them Order
        public bool AddOrder(Order order)
        {
            try
            {
                context.Orders.Add(order);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Sua Order
        public bool UpdateOrder(Order order)
        {
            try
            {
                var updateorder = context.Orders.Find(order.Idorder);
                updateorder.Idorder = order.Idorder;
                updateorder.Idaccount = order.Idaccount;
                updateorder.Idcustomer = order.Idcustomer;
                updateorder.EstablishedDate = order.EstablishedDate;
                updateorder.TotalAmount = order.TotalAmount;
                updateorder.Idvoucher = order.Idvoucher;
                updateorder.Paid = order.Paid;
                context.Orders.Update(updateorder);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Xoa Order
        public bool DeleteOrder(string idorder)
        {
            try
            {
                var deleteorder = context.Orders.Find(idorder);
                
                context.Orders.Remove(deleteorder);
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
