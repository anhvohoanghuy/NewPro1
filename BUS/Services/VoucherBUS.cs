using DAL.Models;
using DAL.Repositories;

namespace BUS.Services
{
    public class VoucherBUS
    {
        private readonly CustomerBUS customerBUS;
        private readonly VoucherDAL voucherDAL;
        public VoucherBUS()
        {
            voucherDAL = new VoucherDAL();
            customerBUS = new CustomerBUS();
        }

        public List<Voucher> GetAll()
        {
            return voucherDAL.GetAll().Where(x => x.StartTime <= DateTime.Now && x.EndTime >= DateTime.Now).ToList();
        }

        public Voucher GetById(string id)
        {
            return voucherDAL.GetDataById(id);
        }
    }
}
