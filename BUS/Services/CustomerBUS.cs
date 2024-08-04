using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class CustomerBUS
    {
        CustomerDAL customerDAL= new CustomerDAL();
        public List<Customer> GetAllCustomer()
        {
            return customerDAL.GetAllCustomer();
        }
        public Customer GetCustomerByID(string idCustomer)
        {
            return GetAllCustomer().FirstOrDefault(c => c.Idcustomer == idCustomer);
        }
        public bool CheckCustomerExsit(string idCustomer)
        {
            var check = GetCustomerByID(idCustomer);
            return check != null ? true : false;
        }
        public bool AddNewCustomer(string idCustomer, string customerName, string phoneNumber, string customerAddress, string idAccount)
        {
            Customer customer = new Customer()
            {
                Idcustomer=idCustomer,
                CustomerName=customerName,
                PhoneNumber=phoneNumber,
                CustomerAddress=customerAddress,
                Idaccount=idAccount,
                DateAdded=DateTime.Now
            };
            return customerDAL.AddNewCustomer(customer);
        }
        public bool UpdateCustomer(string idCustomer, string customerName, string phoneNumber, string customerAddress, string idAccount)
        {
            Customer customer = new Customer()
            {
                Idcustomer = idCustomer,
                CustomerName = customerName,
                PhoneNumber = phoneNumber,
                CustomerAddress = customerAddress,
                Idaccount = idAccount
            };
            return customerDAL.UpdateCustomer(customer);
        }
        public List<Customer> SearchCustomerByIdCustomer(string idCustomer)
        {
            return GetAllCustomer().Where(c=>c.Idcustomer.Contains(idCustomer)).ToList();
        }
        public List<Customer> SearchCustomerByName(string name)
        {
            return GetAllCustomer().Where(c => c.CustomerName.Contains(name)).ToList();
        }
        public List<Customer> SearchCustomerByPhoneNumber(string phoneNumber)
        {
            return GetAllCustomer().Where(c => c.PhoneNumber.Contains(phoneNumber)).ToList();
        }
        public List<Customer> SearchCustomerByAddress(string address)
        {
            return GetAllCustomer().Where(c => c.CustomerAddress.Contains(address)).ToList();
        }
        public List<Customer> SearchCustomerByIdAccount(string idAccount)
        {
            return GetAllCustomer().Where(c => c.Idaccount.Contains(idAccount)).ToList();
        }
        public List<Customer> Search(int sw, string key)
        {
            switch (sw)
            {
                case 0:
                    return SearchCustomerByIdCustomer(key);
                case 1:
                    return SearchCustomerByName(key);
                case 2:
                    return SearchCustomerByPhoneNumber(key);
                case 3:
                    return SearchCustomerByAddress(key);
                case 4:
                    return SearchCustomerByIdAccount(key);
                default:
                    return null;
            }
        }
    }   
}
