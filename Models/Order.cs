namespace fjorubordid_database.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderItemId { get; set; }
        public int TotalPrice { get; set; }
        public int Quantity { get; set; }


    }
}
