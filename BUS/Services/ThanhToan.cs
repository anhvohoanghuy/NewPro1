using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ThanhToan
    {
        ImeiBUS meiBUS=new ImeiBUS();
        OrderDetailBUS orderDetailBUS = new OrderDetailBUS();
        
        public bool ComfirmThanhToan(string idOrder)
        {
            var result = false;
            var orderDetails = orderDetailBUS.GetOrderDetailsByOrderId(idOrder);
            if (orderDetails != null)
            {
                foreach(var item in orderDetails)
                {
                    var listImei= item.ImeiNumbers;
                    foreach(var imei in listImei)
                    {
                        if (imei.Selled ==true)
                        {
                            if (meiBUS.UpdateImei(imei.IdproductDetails, imei.ImeiNumber, imei.Idaccount, true))
                                result = true;
                            else
                                return false;
                        }
                        else
                            return false;
                    }
                }
            }
            else
                return false;
            return result;
        }
    }
}
