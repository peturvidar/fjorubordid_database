namespace Fjorubordid_Api.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

        public string? ImagePath { get; set; }
    }
}
