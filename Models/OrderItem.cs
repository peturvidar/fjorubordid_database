
using fjorubordid_database.Data;
using Microsoft.Identity.Client;

namespace fjorubordid_database.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int FoodId { get; set; }
        public int DrinkId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        
    }
}
