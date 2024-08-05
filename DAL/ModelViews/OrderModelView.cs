namespace DAL.ModelViews
{
    public class OrderModelView
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }

        public string? Idvoucher { get; set; }

        public bool? Paid { get; set; }
        public string? Idaccount { get; set; }

    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
