namespace DAL.ModelViews
{
    public class ProductModelView
    {
        public string Idproduct { get; set; }
        public string ProductImage { get; set; }
        public string ProductName { get; set; }
        public int Ram { get; set; }
        public string Idcompany { get; set; }
        public string CompanyName { get; set; }
        public string Idcpu { get; set; }
        public string NameCpu { get; set; }
        public string Manufacturer { get; set; }
        public string IdproductDetails { get; set; }
        public string Idcolor { get; set; }
        public string ColorName { get; set; }
        public int Storage { get; set; }
        public decimal Price { get; set; }
        public string? Idpromotion { get; set; }
        public string? PromotionName { get; set; }
        public decimal? Discount { get; set; }
    }
}
