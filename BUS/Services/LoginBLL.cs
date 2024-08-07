using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL;
using DAL.Models;
namespace BUS.Services
{
    public class LoginBLL
    {
        LoginDAL account = new LoginDAL();
        
       
        public Account TimkiemTK(string tentk)
        {
            return account.TimkiemTK(tentk);
        }
    }
}
