using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ThongKeBLL
    {
        OrderBUS orderBUS = new OrderBUS();
        OrderDetailBUS orderDetailBUS = new OrderDetailBUS();
        ImeiBUS imeiBUS = new ImeiBUS();
        CustomerBUS customerBUS = new CustomerBUS();
        ProductDetailBUS productDetailBUS = new ProductDetailBUS();
        public Dictionary<string, int> GetBestSeller(DateTime from, DateTime to)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            var listOrder = orderBUS.GetOrderByTime(from, to);
            foreach (var order in listOrder)
            {
                var listOrderDetail = orderDetailBUS.GetOrderDetailsByOrderId(order.Idorder);
                foreach (var orderDetail in listOrderDetail)
                {
                    if (result.ContainsKey(orderDetail.IdproductDetails))
                    {
                        result[orderDetail.IdproductDetails] += orderDetail.Quantity;
                    }
                    else
                        result.Add(orderDetail.IdproductDetails, orderDetail.Quantity);
                }
            }
            return result.OrderByDescending(c => c.Value).ToDictionary();
        }
        public Dictionary<string, decimal> GetBestCustomer(DateTime from, DateTime to)
        {
            var result = new Dictionary<string, decimal>();
            var listOrder = orderBUS.GetOrderByTime(from, to);
            foreach (var order in listOrder)
            {
                if (result.ContainsKey(order.Idcustomer))
                {
                    result[order.Idcustomer] += order.TotalAmount;
                }
                else
                    result.Add(order.Idcustomer, order.TotalAmount);
            }
            return result.OrderByDescending(c => c.Value).ToDictionary();
        }
        public int NumberOrderOfCustomer(Customer customer, DateTime from, DateTime to)
        {
            return orderBUS.GetAllOrderByIdCustomer(customer.Idcustomer).Where(c=>c.OrderStatus==1&&c.EstablishedDate>=from&&c.EstablishedDate<=to).Count();
        }
        public int NumberOfOrder(DateTime from, DateTime to)
        {
            return orderBUS.GetOrderByTime(from, to).Count();
        }
        public int NumberOfNewProduct(DateTime from, DateTime to)
        {
            return imeiBUS.GetAmountNewProduct(from, to);
        }
        public Dictionary<string, int> GetNewProduct(DateTime from, DateTime to)
        {
            var result = new Dictionary<string, int>();
            var listImei = imeiBUS.GetImeiByTime(from, to);
            foreach(var imei in listImei)
            {
                if (result.ContainsKey(imei.IdproductDetails))
                {
                    result[imei.IdproductDetails]++;
                }
                else
                {
                    result.Add(imei.IdproductDetails, 1);
                }
            }
            return result;
        }
        public int ProductOnSale()
        {
            return productDetailBUS.GetAllProductDetail().Where(c => c.Inventory > 0).Count();
        }
        public int NumberOfCustomer()
        {
            return customerBUS.GetAllCustomer().Count();
        }
        public int NumberOfNewCustomer(DateTime from, DateTime to)
        {
            return customerBUS.GetAllCustomer().Where(c => c.DateAdded >= from && c.DateAdded <= to).Count();
        }
        public decimal GetGrossRevenue(DateTime from, DateTime to)
        {
            decimal result = 0;
            var listOrder = orderBUS.GetOrderByTime(from, to).Where(c=>c.OrderStatus==1).ToList();
            foreach (var order in listOrder)
            {
                result += order.TotalAmount;
            }
            return result;
        }
    }
}
