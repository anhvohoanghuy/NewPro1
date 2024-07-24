using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ImeiService
    {
        ImeiRepos repos = new ImeiRepos();
        public ImeiService()
        {
            
        }
        public List<Imei> Show()
        {
            return repos.GetImei();
        }
        //Tìm theo IdProducDetail
        public List<Imei> CNTimTheoIdProducDetail(string idproducdetail)
        {
            return repos.GetByIdProducDetail(idproducdetail);
        }
        //Tìm theo ImeiNumber
        public List<Imei> CNTimTheoImeiNumber(string imeinumber)
        {
            return repos.GetByImeiNumber(imeinumber);
        }
        //Tìm theo IdAccount
        public List<Imei> CNTimTheoIdAccount(string idaccount)
        {
            return repos.GetByIdAccount(idaccount);
        }
        //Thêm Imei
        public string CNThemImei(string idproducdetail, string imeinumber, string idaccount)
        {
            Imei imei = new Imei()
            {
                IdproductDetails = idproducdetail,
                ImeiNumber = imeinumber,
                Idaccount = idaccount
            };
            if (repos.AddImei(imei))
            {
                return "Thêm Imei Thành Công";
            }
            else return "Thêm Imei Thất Bại";
        }
        //Sửa Imei
        public string CNSuaImei(string idproducdetail, string imeinumber, string idaccount)
        {
            Imei imei = new Imei()
            {
                IdproductDetails = idproducdetail,
                ImeiNumber = imeinumber,
                Idaccount = idaccount
            };
            if (repos.UpdateImei(imei))
            {
                return "Sửa Imei Thành Công";
            }
            else return "Sửa Imei Thất Bại";
        }
        //Xóa
        public string CNThemImei(string imeinumber)
        {
           
            if (repos.DeleteImei(imeinumber))
            {
                return "Xóa Imei Thành Công";
            }
            else return "Xóa Imei Thất Bại";
        }
    }
}
