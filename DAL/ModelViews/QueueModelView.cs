namespace DAL.ModelViews
{
    public class QueueModelView
    {
        public OrderModelView Order { get; set; }
        public List<OrderDetailModelView> OrderDetails { get; set; }
    }
}
