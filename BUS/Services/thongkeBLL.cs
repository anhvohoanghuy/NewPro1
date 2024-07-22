using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class thongkeBLL
    {
        thongkeDAL tkDAL = new thongkeDAL();
        List<Order> listsO;
        public List<Order> GetListO()
        {
            listsO = tkDAL.GetListO();
            return listsO;
        }
        List<OrderDetail> listsOD;
        public List<OrderDetail> GetListOD()
        {
            listsOD = tkDAL.GetListOD();
            return listsOD;
        }
    }
}
