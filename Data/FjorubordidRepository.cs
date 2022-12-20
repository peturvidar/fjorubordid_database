using fjorubordid_database.Data.Interfaces;
using fjorubordid_database.Models;

namespace fjorubordid_database.Data
{    ///þ gagnagrunnsaðgerðir, klasi til að stýra gagnagrunninum
    public class FjorubordidRepository : IFjorubordidRepository
    {
        private readonly FjorubordidDbContext _dbContext;

        public FjorubordidRepository()
        {
            _dbContext = new FjorubordidDbContext();
        }

        public Food GetFoodById(int id)
        {
            return _dbContext.Foods.Where(t => t.FoodId == id).FirstOrDefault();
        }
        public void CreateFood(Food food)
        {
            _dbContext.Add(food);
            _dbContext.SaveChanges();
        }
        public Food DeleteFood(int FoodId)
        {
            var result = _dbContext.Foods.FirstOrDefault(e => e.FoodId == FoodId);
            if (result != null)
            {
                _dbContext.Foods.Remove(result);
                _dbContext.SaveChanges();
                return result;
            }
            return null;
        }
        public List<Food> GetAllFoods()
        {
            return _dbContext.Foods.ToList();
        }

        public List<Drink> GetAllDrinks()
        {
            return _dbContext.Drinks.ToList();

        }
        public Drink GetDrinkById(int id)
        {
            return _dbContext.Drinks.Where(t => t.DrinkId == id).FirstOrDefault();
        }

        public void AddItem(OrderItem orderItem)
        {
            _dbContext.Add(orderItem);
            _dbContext.SaveChanges();
        }
        public void UpdateItemFood(OrderItem orderItem)
        {

            var result = _dbContext.OrderItems.Where(t => t.FoodId == orderItem.FoodId).FirstOrDefault();
            if (result!.FoodId == orderItem.FoodId)
            {

                _dbContext.OrderItems.Attach(result);

                result.UnitPrice = orderItem.UnitPrice;
                result.Quantity = orderItem.Quantity;
                _dbContext.SaveChanges();

            }

        }
        public void UpdateItemDrink(OrderItem orderItem)
        {

            var result = _dbContext.OrderItems.Where(t => t.DrinkId == orderItem.DrinkId).FirstOrDefault();
            if (result!.DrinkId == orderItem.DrinkId)
            {

                _dbContext.OrderItems.Attach(result);

                result.UnitPrice = orderItem.UnitPrice;
                result.Quantity = orderItem.Quantity;
                _dbContext.SaveChanges();

            }

        }

        public List<OrderItem> GetAllOrderItems()
        {
            return _dbContext.OrderItems.ToList();
        }
        public OrderItem GetOrderItemById(int id)
        {
            return _dbContext.OrderItems.Where(t => t.OrderItemId == id).FirstOrDefault();
        }

        public OrderItem GetOrderItemByFoodId(int id)
        {
            return _dbContext.OrderItems.Where(t => t.FoodId == id).FirstOrDefault();
        }

        public OrderItem GetOrderItemByDrinkId(int id)
        {
            return _dbContext.OrderItems.Where(t => t.DrinkId == id).FirstOrDefault();
        }

        public OrderItem DeleteOrderItem(int OrderItemId)
        {
            var result = _dbContext.OrderItems.FirstOrDefault(e => e.OrderItemId == OrderItemId);
            if (result != null)
            {
                _dbContext.OrderItems.Remove(result);
                _dbContext.SaveChanges();
                return result;
            }
            return null;
        }

        public OrderItem DeleteAllOrderItems(OrderItem item)
        {
            // var deleteAll = _dbContext.OrderItems.Select(x => new OrderItem { OrderItemId = x.OrderItemId }).ToList();
            _dbContext.OrderItems.RemoveRange(item);
            _dbContext.SaveChanges();
            return null!;
        }

    }
}
