using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class OrderBUS
    {
        OrderDAL orderDAL= new OrderDAL();
        public List<Order> GetAllOrder()
        {
            return orderDAL.GetAllOrder();
        }
        public List<Order> GetAllOrderByIdCustomer(string idCustomer)
        {
            return orderDAL.GetAllOrder().Where(c=>c.Idcustomer==idCustomer).ToList();
        }
        public bool AddNewOrder(string idOrder, string idAccount,string idCustomer, DateTime establishedDate, decimal totalAmount, string idVorcher, int orderStatus)
        {
            Order order = new Order()
            {
                Idorder = idOrder,
                Idaccount = idAccount,
                Idcustomer = idCustomer,
                EstablishedDate = establishedDate,
                TotalAmount = totalAmount,
                Idvoucher = idVorcher,
                OrderStatus = orderStatus
            };
            return orderDAL.AddNewOrder(order);
        }
        public bool UpdateOrder(string idOrder, string idAccount, string idCustomer, DateTime establishedDate, decimal totalAmount, string idVorcher, int orderStatus)
        {
            Order order = new Order()
            {
                Idorder = idOrder,
                Idaccount = idAccount,
                Idcustomer = idCustomer,
                EstablishedDate = establishedDate,
                TotalAmount = totalAmount,
                Idvoucher = idVorcher,
                OrderStatus = orderStatus
            };
            return orderDAL.UpdateOrder(order);
        }
        public Order GetOrderById(string id)
        {
            return GetAllOrder().FirstOrDefault(c => c.Idorder == id);
        }
        public List<Order> GetAllWaitingOrder()
        {
            return GetAllOrder().Where(c=>c.OrderStatus==0).ToList();
        }
        public List<string> GetAllIDWaitingOrder()
        {
            var list = GetAllOrder().Where(c => c.OrderStatus == 0).ToList();
            var listID = new List<String>();
            foreach (var order in list)
            {
                listID.Add(order.Idorder);
            }
            return listID;
        }
        public List<string> GetAllIDWaitingOrder(string idOrder)
        {
            var list = GetAllOrder().Where(c => c.OrderStatus == 0&&c.Idorder.Contains(idOrder)).ToList();
            var listID = new List<String>();
            foreach (var order in list)
            {
                listID.Add(order.Idorder);
            }
            return listID;
        }
    }
}
