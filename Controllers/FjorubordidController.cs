using fjorubordid_database.Data;
using fjorubordid_database.Data.Interfaces;
using fjorubordid_database.Models;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace fjorubordid_database.Controllers
{

    [Route("api")]
    [ApiController]
    public class FjorubordidController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;

        public IFjorubordidRepository _repo;

        public FjorubordidController(UserManager<ApiUser> userManager)
        {

            _repo = new FjorubordidRepository();
        }

        [HttpGet]
        [Route("food")]
        public List<Food> GetAllFoods()
        {
            return _repo.GetAllFoods();

        }

        [HttpGet]
        [Route("food/{id}")]
        public ActionResult<Food> GetFoodById(int id)
        {
            Food? food = _repo.GetFoodById(id);

            if (food == null)
            {
                return NotFound();
            }
            return food;
        }

        [HttpPost]
        [Route("food")]
        public ActionResult<Food> CreateFood(Food food)
        {

            _repo.CreateFood(food);

            return CreatedAtAction(nameof(GetFoodById), new { id = food.FoodId }, food);
        }

        [HttpDelete]
        [Route("food/{id}")]
        public ActionResult<Food> DeleteFood(int id)
        {
            try
            {
                var foodToDelete = _repo.GetFoodById(id);

                if (foodToDelete == null)
                {
                    return NotFound($"Food with Id = {id} not found");
                }
                return _repo.DeleteFood(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

        [HttpGet]
        [Route("drink")]
        public List<Drink> GetAllDrinks()
        {
            return _repo.GetAllDrinks();

        }

        [HttpGet]
        [Route("drink/{id}")]
        public ActionResult<Drink> GetDrinkById(int id)
        {
            Drink? drink = _repo.GetDrinkById(id);

            if (drink == null)
            {
                return NotFound();
            }
            return drink;
        }

        [HttpGet]
        [Route("orderItem")]
        public List<OrderItem> GetAllOrderItems()
        {
            return _repo.GetAllOrderItems();
        }

        [HttpGet]
        [Route("orderItem/{id}")]
        public ActionResult<OrderItem> GetOrderItemById(int id)
        {
            OrderItem orderItem = _repo.GetOrderItemById(id);

            if (orderItem == null)
            {
                return NotFound();
            }
            return orderItem;
        }

        [HttpDelete]
        [Route("orderItem/{id}")]
        public ActionResult<OrderItem> DeleteOrderItem(int id)
        {

            try
            {
                var orderItemToDelete = _repo.GetOrderItemById(id);

                if (orderItemToDelete == null)
                {
                    return NotFound($"OrderItem with Id = {id} not found");
                }
                return _repo.DeleteOrderItem(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

        [HttpDelete]
        [Route("orderItem")]
        public void DeleteAllOrderItems()
        {
            List<OrderItem> orderItems = _repo.GetAllOrderItems();

            foreach (var item in orderItems)
            {
                _repo.DeleteAllOrderItems(item);
            }

        }


        [HttpPost]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> AddDrinkItem(Drink drink) //input frá postman
        {
            
            var orderItem = _repo.GetOrderItemByDrinkId(drink.DrinkId);

            if (orderItem == null)
            {
                OrderItem temp = new OrderItem()
                {

                    DrinkId = drink.DrinkId,
                    UnitPrice = drink.UnitPrice,
                    Quantity = drink.Quantity,
                    Name = drink.Name,
                    Description = drink.Description,

                };
                _repo.AddItem(temp);
                return CreatedAtAction(nameof(AddDrinkItem), new { Id = temp.OrderItemId }, temp);
            }
            else if (orderItem.DrinkId != drink.DrinkId)
            {
                OrderItem temp = new OrderItem()
                {

                    DrinkId = drink.DrinkId,
                    UnitPrice = drink.UnitPrice,
                    Quantity = drink.Quantity,
                    Name = drink.Name,
                    Description = drink.Description,

                };
                _repo.AddItem(temp);
                return CreatedAtAction(nameof(AddDrinkItem), new { Id = temp.OrderItemId }, temp);
            }
            else if (orderItem.DrinkId == drink.DrinkId)
            {
                OrderItem temp = new OrderItem()
                {
                    DrinkId = drink.DrinkId,
                    UnitPrice = drink.UnitPrice + orderItem.UnitPrice,
                    Quantity = drink.Quantity + orderItem.Quantity,
                    Name = drink.Name,
                    Description = drink.Description,
                };
                _repo.UpdateItemDrink(temp);
                return null; 

            }
            else
            {
                return null;
            }
        }

        [HttpPost]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> AddFoodItem(Food food) //input frá postman
        {
            string token = Request.Headers["Authorization"].ToString().Replace("Bearer ", ""); 
            // Decode the token and get the claims
            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;
            var claims = tokenS.Claims; 
            // Get the user id from the "sub" claim
            var userId = claims.FirstOrDefault(c => c.Type == "sub")?.Value;

            // var currentUserId = User.Identity.
            var orderItem = _repo.GetOrderItemByFoodId(food.FoodId);
            
            if (orderItem == null)
            {
                OrderItem temp = new OrderItem()
                {
                    
                    FoodId = food.FoodId,
                    UnitPrice = food.UnitPrice,
                    Quantity = food.Quantity,
                    Name = food.Name,
                    Description = food.Description,

                };
                _repo.AddItem(temp);
                return CreatedAtAction(nameof(AddFoodItem), new { Id = temp.OrderItemId }, temp);
            }
            else if (orderItem.FoodId != food.FoodId)
            {
                OrderItem temp = new OrderItem()
                {

                    FoodId = food.FoodId,
                    UnitPrice = food.UnitPrice,
                    Quantity = food.Quantity,
                    Name = food.Name,
                    Description = food.Description,

                };
                _repo.AddItem(temp);
                return CreatedAtAction(nameof(AddFoodItem), new { Id = temp.OrderItemId }, temp);
            }
            else if (orderItem.FoodId == food.FoodId)
            {
                OrderItem temp = new OrderItem()
                {
                    FoodId = food.FoodId,
                    UnitPrice = food.UnitPrice + orderItem.UnitPrice,
                    Quantity = food.Quantity + orderItem.Quantity,
                    Name = food.Name,
                    Description = food.Description,
                };
                _repo.UpdateItemFood(temp);
                return null; //CreatedAtAction(nameof(AddFoodItem), new { Id = temp.OrderItemId }, temp);

            }
            else
            {
                return null;
            }
        }

       /* [HttpPost]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> AddFoodItemUserTest(Food food) //input frá postman
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity!;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var orderItem = _repo.GetOrderItemByFoodId(food.FoodId);

            if (orderItem == null)
            {
                OrderItem temp = new OrderItem()
                {

                    FoodId = food.FoodId,
                    UnitPrice = food.UnitPrice,
                    Quantity = food.Quantity,
                    Name = food.Name,
                    Description = food.Description,

                };
                _repo.AddItem(temp);
                return CreatedAtAction(nameof(AddFoodItem), new { Id = temp.OrderItemId }, temp);
            }
            else if (orderItem.FoodId != food.FoodId)
            {
                OrderItem temp = new OrderItem()
                {

                    FoodId = food.FoodId,
                    UnitPrice = food.UnitPrice,
                    Quantity = food.Quantity,
                    Name = food.Name,
                    Description = food.Description,

                };
                _repo.AddItem(temp);
                return CreatedAtAction(nameof(AddFoodItem), new { Id = temp.OrderItemId }, temp);
            }
            else if (orderItem.FoodId == food.FoodId)
            {
                OrderItem temp = new OrderItem()
                {
                    FoodId = food.FoodId,
                    UnitPrice = food.UnitPrice + orderItem.UnitPrice,
                    Quantity = food.Quantity + orderItem.Quantity,
                    Name = food.Name,
                    Description = food.Description,
                };
                _repo.UpdateItemFood(temp);
                return null; //CreatedAtAction(nameof(AddFoodItem), new { Id = temp.OrderItemId }, temp);

            }
            else
            {
                return null;
            }
        }
       */
        [HttpPost]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> IncreaseQuantityOrderItemFood(OrderItem orderItem)
        {
            var food = _repo.GetFoodById(orderItem.FoodId);

            if (food.FoodId == orderItem.FoodId)
            {
                OrderItem temp = new OrderItem()
                {
                    OrderItemId = orderItem.OrderItemId,
                    FoodId = food.FoodId,
                    UnitPrice = food.UnitPrice + orderItem.UnitPrice,
                    Quantity = food.Quantity + orderItem.Quantity,
                    Name = food.Name,
                    Description = food.Description,
                };
                _repo.UpdateItemFood(temp);
                return null;
            }
            else
            {
                return null;
            }
        }
        [HttpPost]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> DecreaseQuantityOrderItemFood(OrderItem orderItem)
        {
            var food = _repo.GetFoodById(orderItem.FoodId);
            if (orderItem.Quantity > 1)
            {
                if (food.FoodId == orderItem.FoodId)
                {
                    OrderItem temp = new OrderItem()
                    {
                        OrderItemId = orderItem.OrderItemId,
                        FoodId = food.FoodId,
                        UnitPrice = orderItem.UnitPrice - food.UnitPrice,
                        Quantity = orderItem.Quantity - food.Quantity,
                        Name = food.Name,
                        Description = food.Description,
                    };
                    _repo.UpdateItemFood(temp);
                    return null;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        [HttpPost]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> IncreaseQuantityOrderItemDrink(OrderItem orderItem)
        {
            var drink = _repo.GetDrinkById(orderItem.DrinkId);

            if (drink.DrinkId == orderItem.DrinkId)
            {
                OrderItem temp = new OrderItem()
                {
                    OrderItemId = orderItem.OrderItemId,
                    DrinkId = drink.DrinkId,
                    UnitPrice = drink.UnitPrice + orderItem.UnitPrice,
                    Quantity = drink.Quantity + orderItem.Quantity,
                    Name = drink.Name,
                    Description = drink.Description,
                };
                _repo.UpdateItemDrink(temp);
                return null;
            }
            else
            {
                return null;
            }
        }
        [HttpPost]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> DecreaseQuantityOrderItemDrink(OrderItem orderItem)
        {
            var drink = _repo.GetDrinkById(orderItem.DrinkId);
            if (orderItem.Quantity > 1)
            {
                if (drink.DrinkId == orderItem.DrinkId)
                {
                    OrderItem temp = new OrderItem()
                    {
                        OrderItemId = orderItem.OrderItemId,
                        DrinkId = drink.DrinkId,
                        UnitPrice = orderItem.UnitPrice - drink.UnitPrice,
                        Quantity = orderItem.Quantity - drink.Quantity,
                        Name = drink.Name,
                        Description = drink.Description,
                    };
                    _repo.UpdateItemDrink(temp);
                    return null;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
