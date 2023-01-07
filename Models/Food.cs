

namespace fjorubordid_database.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public OrderItem? OrderItem { get; set; }

        public string? ImagePath { get; set; }
       
    }
}
