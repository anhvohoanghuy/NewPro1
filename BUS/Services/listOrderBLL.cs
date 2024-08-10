using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class listOrderBLL
    {
        listOrderDAL kho = new listOrderDAL();
        List<Order> listO;
        List<OrderDetail> listOD;

        public List<Order> GetAllO()
        {
            listO = kho.GetDataO();
            return listO;
        }

        public List<OrderDetail> GetAllOD()
        {
            listOD = kho.GetDataOD();
            return listOD;
        }

        public dynamic GetAllDonHang(string searchCriteria = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            return kho.GetAllDonHang(searchCriteria, startDate, endDate);
        }
    }
}
