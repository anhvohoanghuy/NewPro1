using DAL.Models;
using DAL.Respositories;

namespace BUS.Services
{
    public class ProductColorBUS
    {
        ProductColorDAL productColorDAL = new ProductColorDAL();
        public List<ProductColor> GetAllColor()
        {
            return productColorDAL.GetAllColor();
        }
        public List<string> GetAllIdColor()
        {
            var listIdColor = new List<string>();
            var listColor = GetAllColor();
            foreach (ProductColor color in listColor)
            {
                listIdColor.Add(color.Idcolor);
            }
            return listIdColor;
        }
        public bool AddNewColor(string idColor, string colorName, string idAccount)
        {
            ProductColor productColor = new ProductColor()
            {
                Idcolor = idColor,
                ColorName = colorName,
                Idaccount = idAccount
            };
            if (productColorDAL.AddNewColor(productColor))
                return true;
            else
                return false;
        }
        public bool UpdateProductColor(string idColor, string colorName, string idAccount)
        {
            ProductColor productColor = new ProductColor()
            {
                Idcolor = idColor,
                ColorName = colorName,
                Idaccount = idAccount
            };
            if (productColorDAL.UpdateColor(productColor))
                return true;
            else
                return false;
        }
        public ProductColor GetProductColorById(string id)
        {
            return GetAllColor().FirstOrDefault(c => c.Idcolor == id);
        }

        public ProductColor GetProductColorByProdutId(string id)
        {
            return GetAllColor().FirstOrDefault(c => c.Idcolor == id);
        }
    }
}
