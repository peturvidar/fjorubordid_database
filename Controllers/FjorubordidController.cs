using Fjorubordid_Api.Data;
using Fjorubordid_Api.Data.Interfaces;
using Fjorubordid_Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;


namespace Fjorubordid_Api.Controllers
{
    [Authorize]
    [Route("api")]
    [ApiController]
    public class FjorubordidController : ControllerBase
    {
       
        private string GetUserIdFromToken()
        {
            string token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;
            var claims = tokenS!.Claims;
            var userId = claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            return userId!;
        }
        public IFjorubordidRepository _repo;

        public FjorubordidController()
        {

            _repo = new FjorubordidRepository();
 
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("food")]
        public List<Food> GetAllFoods()
        {
            return _repo.GetAllFoods();

        }
        [AllowAnonymous]
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
        //[Authorize]
        [Route("food")]
        public ActionResult<Food> CreateFood(Food food)
        {

            _repo.CreateFood(food);

            return CreatedAtAction(nameof(GetFoodById), new { id = food.FoodId }, food);
        }

        [HttpDelete]
        //[Authorize]
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

        [AllowAnonymous]
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
       // [Authorize]
        [HttpGet]
        [Route("orderItem")]
        public List<OrderItem> GetAllOrderItemsByUserId()
        {
            string userId = GetUserIdFromToken();
            return _repo.GetAllOrderItemsByUserId(userId);
        }

        //[HttpGet]
        [Authorize]
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

       // [Authorize]
        [HttpGet]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> GetOrderItemByUserId()
        {
            string userId = GetUserIdFromToken();

            var orderItem = _repo.GetOrderItemByUserId(userId);

            if (orderItem == null)
            {
                return null!;
            }
            return orderItem;
        }

       // [Authorize]
        [HttpDelete]        
        [Route("orderItem/[action]/{id}")]
        public ActionResult<OrderItem> DeleteOrderItemsById(int id)
        {
            string userId = GetUserIdFromToken();
            var userOrderItems = _repo.GetAllOrderItemsByUserId(userId);

            foreach(var item in userOrderItems)
            {
                if(item.FoodId == id)
                {
                    _repo.DeleteAllOrderItems(item);
                }
                
                if(item.DrinkId == id)
                {
                    _repo.DeleteAllOrderItems(item);
                }
               
            }
            return null!;

        }

       // [Authorize]
        [HttpDelete]
        [Route("orderItem")]
        public void DeleteAllOrderItemsByUserId()
        {
            string userId = GetUserIdFromToken();
            List<OrderItem> orderItems = _repo.GetAllOrderItemsByUserId(userId);

            foreach (var item in orderItems)
            {
                _repo.DeleteAllOrderItems(item);
            }

        }

       // [Authorize]
        [HttpPost]       
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> AddDrinkItemToOrder(Drink drink) //input frá postman
        {
            string userId = GetUserIdFromToken();

            OrderItem temp = new OrderItem()
            {
                UserId = userId,
                DrinkId = drink.DrinkId,
                UnitPrice = drink.UnitPrice,
                Quantity = drink.Quantity,
                Name = drink.Name,
                Description = drink.Description,
            };
            _repo.AddItem(temp);
            return CreatedAtAction(nameof(AddDrinkItemToOrder), new { Id = temp.OrderItemId }, temp);
        }

        //[Authorize]
        [HttpPost]      
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> AddFoodItemToOrder(Food food)
        {
            string userId = GetUserIdFromToken();

            // List<OrderItem> orderItem = _repo.GetAllOrderItemsByUserId(userId);

            OrderItem temp = new OrderItem()
            {
                UserId = userId,
                FoodId = food.FoodId,
                UnitPrice = food.UnitPrice,
                Quantity = food.Quantity,
                Name = food.Name,
                Description = food.Description,
            };
            _repo.AddItem(temp);
            return CreatedAtAction(nameof(AddFoodItemToOrder), new { Id = temp.OrderItemId }, temp);
        }

       // [Authorize]
        [HttpPost]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> IncreaseQuantityOrderItemFood(OrderItem orderItem)
        {
            string userId = GetUserIdFromToken();

            var food = _repo.GetFoodById(orderItem.FoodId);

            OrderItem temp = new OrderItem()
            {
                UserId = userId,
                FoodId = food.FoodId,
                UnitPrice = food.UnitPrice,
                Quantity = food.Quantity,
                Name = food.Name,
                Description = food.Description,
            };
            _repo.AddItem(temp);
            return CreatedAtAction(nameof(IncreaseQuantityOrderItemFood), new { Id = temp.OrderItemId }, temp);
        }

        //[Authorize]
        [HttpPost]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> DecreaseQuantityOrderItem(OrderItem orderItem)
        {
            string userId = GetUserIdFromToken();
            var userOrderItems = _repo.GetAllOrderItemsByUserId(userId);

            int elementToRemove = orderItem.OrderItemId;

            OrderItem item = userOrderItems.Find(x => x.OrderItemId == elementToRemove);
            _repo.DeleteOrderItemById(item!.OrderItemId);
            return null!;
        }

        //[Authorize]
        [HttpPost]
        [Route("orderItem/[action]")]
        public ActionResult<OrderItem> IncreaseQuantityOrderItemDrink(OrderItem orderItem)
        {
            string userId = GetUserIdFromToken();

            var drink = _repo.GetDrinkById(orderItem.DrinkId);

            OrderItem temp = new OrderItem()
            {
                UserId = userId,
                DrinkId = drink.DrinkId,
                UnitPrice = drink.UnitPrice,
                Quantity = drink.Quantity,
                Name = drink.Name,
                Description = drink.Description,
            };
            _repo.AddItem(temp);
            return CreatedAtAction(nameof(IncreaseQuantityOrderItemDrink), new { Id = temp.OrderItemId }, temp);
        }

    }
}
