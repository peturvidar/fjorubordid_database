using fjorubordid_database.Data;
using fjorubordid_database.Data.Interfaces;
using fjorubordid_database.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;


namespace fjorubordid_database.Controllers
{
    
    [Route("api")]
    [ApiController]
    public class FjorubordidController : ControllerBase
    {
        private readonly UserManager<ApiUser>? _userManager;
        private string GetUserIdFromToken()
        {
            string token = Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;
            var claims = tokenS!.Claims;
            var userId = claims.FirstOrDefault(c => c.Type == "uid")?.Value;
            return userId!;
        }
        public IFjorubordidRepository _repo;

        public FjorubordidController(UserManager<ApiUser> userManager)
        {

            _repo = new FjorubordidRepository();
        }
        [Authorize]
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
       // [Authorize(Roles = "Administrator")]
        [Route("food")]
        public ActionResult<Food> CreateFood(Food food)
        {

            _repo.CreateFood(food);

            return CreatedAtAction(nameof(GetFoodById), new { id = food.FoodId }, food);
        }

        [HttpDelete]
        //[Authorize(Roles = "Administrator")]
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

        [HttpGet]
       // [Authorize(Roles = "User")]
        [Route("orderItem")]
        public List<OrderItem> GetAllOrderItemsByUserId()
        {
            string userId = GetUserIdFromToken();
            return _repo.GetAllOrderItemsByUserId(userId);
        }

        [HttpGet]
       // [Authorize(Roles = "User")]
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

        [HttpGet]
       // [Authorize(Roles = "User")]
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

        [HttpDelete]
        //[Authorize(Roles = "User")]
        [Route("orderItem/{id}")]
        public ActionResult<OrderItem> DeleteOrderItemByUserId(int id)
        {
            string userId = GetUserIdFromToken();

            try
            {
                var orderItemToDelete = _repo.GetOrderItemByUserId(userId);

                if (orderItemToDelete == null)
                {
                    return NotFound($"OrderItem with Id = {id} not found");
                }
                return _repo.DeleteOrderItemById(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

        [HttpDelete]
       // [Authorize(Roles = "User")]
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


        /* [HttpPost]
         //[Authorize(Roles = "User")]
         [Route("orderItem/[action]")]
         public ActionResult<OrderItem> AddDrinkItemToOrder(Drink drink) //input frá postman
         {
             string userId = GetUserIdFromToken();

             List<OrderItem> orderItem = _repo.GetAllOrderItemsByUserId(userId);

             bool found = false;
             for (int i = 0; i < orderItem.Count; i++)
             {
                 if (orderItem[i].DrinkId == drink.DrinkId)
                 {
                     OrderItem temp = new OrderItem()
                     {
                         DrinkId = drink.DrinkId,
                         UnitPrice = drink.UnitPrice + orderItem[i].UnitPrice,
                         Quantity = drink.Quantity + orderItem[i].Quantity,
                         Name = drink.Name,
                         Description = drink.Description,
                     };
                     _repo.UpdateItemDrink(temp);
                     found = true;
                     break;
                 }
             }
             if (!found)
             {
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
             return null!;
         }*/


        [HttpPost]
        [Authorize]
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

        /* [HttpPost]
         //[Authorize(Roles = "User")]
         [Route("orderItem/[action]")]
         public ActionResult<OrderItem> AddFoodItemToOrder(Food food)
         {
             string userId = GetUserIdFromToken();

             List<OrderItem> orderItem = _repo.GetAllOrderItemsByUserId(userId);

             bool found = false;
             for (int i = 0; i < orderItem.Count; i++)
             {
                 if (orderItem[i].FoodId == food.FoodId)
                 {
                     OrderItem temp = new OrderItem()
                     {
                         FoodId = food.FoodId,
                         UnitPrice = food.UnitPrice + orderItem[i].UnitPrice,
                         Quantity = food.Quantity + orderItem[i].Quantity,
                         Name = food.Name,
                         Description = food.Description,
                     };
                     _repo.UpdateItemFood(temp);
                     found = true;
                     break;
                 }
             }
             if (!found)
             {
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
             }return null!;
         }*/

        [HttpPost]
        [Authorize]
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

        /* [HttpPost]
        // [Authorize(Roles = "User")]
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
                  return null!;
              }
              else
              {
                  return null!;
              }
          }*/


       [HttpPost]
      // [Authorize(Roles = "User")]
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
                Name = food .Name,
                Description = food.Description,
            };
            _repo.AddItem(temp);
            return CreatedAtAction(nameof(IncreaseQuantityOrderItemFood), new { Id = temp.OrderItemId }, temp);
        }

        [HttpPost]
       // [Authorize(Roles = "User")]
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
                     return null!;
                 }
                 else
                 {
                     return null!;
                 }
             }
             else
             {
                 return null!;
             }
         }

        /*[HttpPost]
       // [Authorize(Roles = "User")]
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
                return null!;
            }
            else
            {
                return null!;
            }
        }*/

        [HttpPost]
        // [Authorize(Roles = "User")]
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


        [HttpPost]
       // [Authorize(Roles = "User")]
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
                    _repo.UpdateItemFood(temp);
                    return null!;
                }
                else
                {
                    return null!;
                }
            }
            else
            {
                return null!;
            }
        }



    }
}
