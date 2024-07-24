using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class OrderService
    {
        OrderRepos repos = new OrderRepos();
        public OrderService()
        {
            
        }
        public List<Order> Show()
        {
            return repos.GetOrders();
        }
        //Chuc nang tim theo idorder
        public List<Order> CNTimTheoIdOrder(string idorder)
        {
            return repos.GetByIdOrder(idorder);
        }
        //Chuc nang tim theo idaccount
        public List<Order> CNTimTheoIdAccount(string accountid)
        {
            return repos.GetByIdAccount(accountid);
        }
        //Chuc nang tim theo IDCustom
        public List<Order> CNTimTheoIdCustom(string customid)
        {
            return repos.GetByIdCustom(customid);
        }
        //Chuc nang tim theo EstablishedDate
        public List<Order> CNTimTheoEstablishedDate(DateTime fromdate, DateTime todate)
        {
            return repos.GetByEstablishedDate(fromdate, todate);
        }
        //Chuc nang them Order
        public string CNAddOrder(string idorder, string idaccount, string idcustomer, DateTime establishedDate, decimal totalamount, string idvoucher, bool paid)
        {
            Order order = new Order()
            {
                Idorder = idorder,
                Idaccount = idaccount,
                Idcustomer = idcustomer,
                EstablishedDate = establishedDate,
                TotalAmount = totalamount,
                Idvoucher = idvoucher,
                Paid = paid
            };
            if (repos.AddOrder(order))
            {
                return "Thêm hóa đơn thành công";
            }
            else return "Thêm hóa đơn thất bại";
            
        }
        public string CNUpdateOrder(string idorder, string idaccount, string idcustomer, DateTime establishedDate, decimal totalamount, string idvoucher, bool paid)
        {
            Order order = new Order()
            {
                Idorder = idorder,
                Idaccount = idaccount,
                Idcustomer = idcustomer,
                EstablishedDate = establishedDate,
                TotalAmount = totalamount,
                Idvoucher = idvoucher,
                Paid = paid
            };
            if (repos.UpdateOrder(order))
            {
                return "Sửa hóa đơn thành công";
            }
            else return "Sửa hóa đơn thất bại";

        }
        public string CNDeleteOrder(string idorder)
        {
            
            if (repos.DeleteOrder(idorder))
            {
                return "Xóa hóa đơn thành công";
            }
            else return "Xóa hóa đơn thất bại";

        }



    }
}
