namespace PrsWebApi.Models
{
    public class LineItem
    {
        public int ID { get; set; }
        public int RequestID { get; set; }
        public virtual Request request { get; set; }
        public int ProductID { get; set; }
        public virtual Product product { get; set; }
        public int Quantity { get; set; }
    }
}
