using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ThanhToan
    {
        OrderDetailBUS detailBUS=new OrderDetailBUS();
        ImeiBUS meiBUS=new ImeiBUS();
        public string CheckThanhToan(string idOrder)
        {
            string result = "Thanh toán thành công";
            var orderDetails = detailBUS.GetOrderDetailsByOrderId(idOrder);
            if (orderDetails != null)
            {
                foreach (var item in orderDetails)
                {
                    var productDetail = item.IdproductDetailsNavigation;
                    for (var i = 0; i < item.Quantity; i++)
                    {
                        var imei = productDetail.Imeis.FirstOrDefault(c => c.Selled == false);
                        if (imei != null)
                        {
                            if (meiBUS.UpdateImei(imei.IdproductDetails, imei.ImeiNumber, imei.Idaccount, true))
                            {
                                continue;
                            }
                            else
                                return "Thanh toán không thành công";
                        }
                        else
                            return "Không có imei nào trong product detail này";
                    }
                }
            }
            else
                return "Không có sản phẩm nào trong order";
            return result;
        }
    }
}
