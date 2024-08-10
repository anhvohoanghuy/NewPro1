using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class listOrderDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();

        public List<Order> GetDataO()
        {
            return db.Orders.ToList<Order>();
        }

        public List<OrderDetail> GetDataOD()
        {
            return db.OrderDetails.ToList<OrderDetail>();
        }

        public dynamic GetAllDonHang(string searchCriteria = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            var query = from order in db.Orders
                        join orderDetail in db.OrderDetails
                        on order.Idorder equals orderDetail.Idorder
                        select new
                        {
                            IdOrder = order.Idorder,
                            IdAccount = order.Idaccount,
                            IdCustomer = order.Idcustomer,
                            EstablishedDate = order.EstablishedDate,
                            TotalAmount = order.TotalAmount,
                            IdVoucher = order.Idvoucher,
                            OrderStatus = order.OrderStatus,
                            IdProductDetail = orderDetail.IdproductDetails,
                            Quantity = orderDetail.Quantity,
                            Amount = orderDetail.Amount,
                            ReducedAmount = orderDetail.ReducedAmount
                        };

            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(x => x.EstablishedDate >= startDate.Value && x.EstablishedDate <= endDate.Value);
            }

            if (!string.IsNullOrEmpty(searchCriteria))
            {
                query = query.Where(x => x.IdOrder.ToString().Contains(searchCriteria) ||
                                         x.IdAccount.ToString().Contains(searchCriteria) ||
                                         x.IdCustomer.ToString().Contains(searchCriteria) ||
                                         x.EstablishedDate.ToString().Contains(searchCriteria) ||
                                         x.TotalAmount.ToString().Contains(searchCriteria) ||
                                         x.IdVoucher.ToString().Contains(searchCriteria) ||
                                         x.OrderStatus.ToString().Contains(searchCriteria) ||
                                         x.IdProductDetail.ToString().Contains(searchCriteria) ||
                                         x.Quantity.ToString().Contains(searchCriteria) ||
                                         x.Amount.ToString().Contains(searchCriteria) ||
                                         x.ReducedAmount.ToString().Contains(searchCriteria));
            }

            return query.ToList();
        }
    }
}
