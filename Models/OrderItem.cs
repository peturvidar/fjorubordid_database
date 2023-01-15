

namespace Fjorubordid_Api.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int FoodId { get; set; }
        public List<Food>? Food { get; set; }
        public int DrinkId { get; set; }
        public List<Drink>? Drink { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        
        public string? UserId { get; set; }
    }
}
