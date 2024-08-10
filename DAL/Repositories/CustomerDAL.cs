using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class CustomerDAL
    {
        Pro1QuanLiDienThoaiFinalContext db= new Pro1QuanLiDienThoaiFinalContext();
        public List<Customer> GetAllCustomer()
        {
            return db.Customers.ToList();
        }
        public bool AddNewCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                var current = GetAllCustomer().FirstOrDefault(c => c.Idcustomer == customer.Idcustomer);
                if (current != null)
                {
                    current.Idcustomer = customer.Idcustomer;
                    current.CustomerName= customer.CustomerName;
                    current.PhoneNumber = customer.PhoneNumber;
                    current.CustomerAddress= customer.CustomerAddress;
                    current.Idaccount = customer.Idaccount;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
