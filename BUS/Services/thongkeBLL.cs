using DAL.Models;
using DAL.Repositories;
using DevExpress.Security.Resources;
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
        List<Order> listO;
        List<OrderDetail> listOD;
        List<Customer> listC;
        List<Product> listP;
        List<ProductDetail> listPD;
        public List<Order> GetListO()
        {
            listO = tkDAL.listO();
            return listO;
        }
        
        public List<OrderDetail> GetListOD()
        {
            listOD = tkDAL.GetListOD();
            return listOD;
        }
        public List<Customer> GetListC()
        {
            listC = tkDAL.GetListC();
            return listC;
        }
        public List<Product> GetListP()
        {
            listP = tkDAL.GetListP();
            return listP;
        }
        public List<ProductDetail> GetListPD()
        {
            listPD = tkDAL.GetListPD();
            return listPD;
        }
    }
}
