using DAL.Models;

namespace DAL.Repositories
{
    public class VoucherDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public VoucherDAL()
        {

        }

        public List<Voucher> GetAll()
        {
            return db.Vouchers.ToList();
        }

        public Voucher GetDataById(string id)
        {
            return db.Vouchers.Find(id);
        }

        public Voucher Insert(Voucher voucher)
        {
            db.Vouchers.Add(voucher);
            db.SaveChanges();
            return voucher;
        }
    }
}
