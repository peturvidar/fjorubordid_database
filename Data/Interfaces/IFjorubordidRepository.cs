using fjorubordid_database.Models;

namespace fjorubordid_database.Data.Interfaces
{
    public interface IFjorubordidRepository
    {

        List<Food> GetAllFoods();
        public Food GetFoodById(int id);
        public Food DeleteFood(int id);
        void CreateFood(Food food);
        List<Drink> GetAllDrinks();
        public Drink GetDrinkById(int id);
        void AddItem(OrderItem orderItem);
        void UpdateItemFood(OrderItem orderItem);
        void UpdateItemDrink(OrderItem orderItem);
        List<OrderItem> GetAllOrderItems();
        public OrderItem GetOrderItemById(int id);
        public OrderItem GetOrderItemByUserId(string id);
        public List<OrderItem> GetAllOrderItemsByUserId(string id);
        public OrderItem GetOrderItemByFoodId(int id);
        public OrderItem GetOrderItemByDrinkId(int id);
        public OrderItem DeleteOrderItemById(int id);
        OrderItem DeleteAllOrderItems(OrderItem item);


    }
}
