using Fjorubordid_Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Fjorubordid_Api.Data
{
    public class FjorubordidDbContext : IdentityDbContext
    {
        public FjorubordidDbContext()
        {

        }

        public FjorubordidDbContext(DbContextOptions<FjorubordidDbContext> options)
            : base(options) { }

        public DbSet<Food> Foods { get; set; }  //stofna töflur í gagnagrunninn
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FjorubordidApi");
            //optionsBuilder.EnableSensitiveDataLogging();
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            #region FoodSeed
            Food f1 = new Food { FoodId = 1, Name = "3ja rétta 400g", UnitPrice = 14175, Description = "3ja rétta 400g", Quantity = 1, ImagePath = "humar.jpg" };
            Food f3 = new Food { FoodId = 3, Name = "Humar 400g", UnitPrice = 10750, Description = "Leturhumar 400g", Quantity = 1, ImagePath = "humar.jpg" };
            Food f2 = new Food { FoodId = 2, Name = "3ja rétta 300g", UnitPrice = 12250, Description = "3ja rétta 300g", Quantity = 1, ImagePath = "humar.jpg" };
            Food f4 = new Food { FoodId = 4, Name = "Humar 300g", UnitPrice = 8650, Description = "Leturhumar 300g", Quantity = 1, ImagePath = "humar.jpg" };
            Food f5 = new Food { FoodId = 5, Name = "Humar 250g", UnitPrice = 8050, Description = "Leturhumar 250g", Quantity = 1, ImagePath = "humar.jpg" };
            Food f6 = new Food { FoodId = 6, Name = "Humarsúpa", UnitPrice = 4190, Description = "Aðalréttur", Quantity = 1, ImagePath = "supa.jpg" };
            Food f7 = new Food { FoodId = 7, Name = "Humarsúpa", UnitPrice = 3250, Description = "Forréttur", Quantity = 1, ImagePath = "supa.jpg" };
            Food f8 = new Food { FoodId = 8, Name = "Grænmetisréttur", UnitPrice = 4190, Description = "Grænmetisréttur", Quantity = 1, ImagePath = "green.jpg" };
            Food f9 = new Food { FoodId = 9, Name = "Lambahryggvöðvi", UnitPrice = 6250, Description = "Lambahryggvöðvi", Quantity = 1, ImagePath = "lamb.jpg" };
            Food f10 = new Food { FoodId = 10, Name = "Kjúklinganaggar", UnitPrice = 990, Description = "Barnamatseðill", Quantity = 1, ImagePath = "naggar.jpg" };
            Food f11 = new Food { FoodId = 11, Name = "Samloka", UnitPrice = 990, Description = "Barnamatseðill", Quantity = 1, ImagePath = "samloka.jpg" };
            Food f12 = new Food { FoodId = 12, Name = "Eftirréttur", UnitPrice = 1650, Description = "Eftirréttur tertusneið", Quantity = 1, ImagePath = "dessert.jpg" };
           
            modelBuilder.Entity<Food>().HasData(f1);
            modelBuilder.Entity<Food>().HasData(f2);
            modelBuilder.Entity<Food>().HasData(f3);
            modelBuilder.Entity<Food>().HasData(f4);
            modelBuilder.Entity<Food>().HasData(f5);
            modelBuilder.Entity<Food>().HasData(f6);
            modelBuilder.Entity<Food>().HasData(f7);
            modelBuilder.Entity<Food>().HasData(f8);
            modelBuilder.Entity<Food>().HasData(f9);
            modelBuilder.Entity<Food>().HasData(f10);
            modelBuilder.Entity<Food>().HasData(f11);
            modelBuilder.Entity<Food>().HasData(f12);
            #endregion

            #region DrinkSeed
            Drink d1 = new Drink { DrinkId = 1, Name = "Egils Gull 0.5l", UnitPrice = 1400, Description = "Egils Gull 0.5l", Quantity = 1, ImagePath = "gull.png" };
            Drink d2 = new Drink { DrinkId = 2, Name = "Egils Gull 0.3l", UnitPrice = 1200, Description = "Egils Gull 0.3l", Quantity = 1, ImagePath = "gull.png" };
            Drink d3 = new Drink { DrinkId = 3, Name = "Hvítvín hússins", UnitPrice = 7200, Description = "Flaska af hvítvíni hússins", Quantity = 1, ImagePath = "white.jpg" };
            Drink d4 = new Drink { DrinkId = 4, Name = "Rauðvín hússins", UnitPrice = 7200, Description = "Flaska af rauðvíni hússins", Quantity = 1, ImagePath = "red.png" };
            Drink d5 = new Drink { DrinkId = 5, Name = "Pepsi", UnitPrice = 500, Description = "Pepsi í gleri 330ml", Quantity = 1, ImagePath = "pepsi.jpg" };
            Drink d6 = new Drink { DrinkId = 6, Name = "Pepsi Max", UnitPrice = 500, Description = "Pepsi í gleri 330ml", Quantity = 1, ImagePath = "pepsimax.jpg" };
            Drink d7 = new Drink { DrinkId = 7, Name = "7up", UnitPrice = 500, Description = "7up í gleri 330ml", Quantity = 1, ImagePath = "7up.jpg" };
            Drink d8 = new Drink { DrinkId = 8, Name = "Appelsín", UnitPrice = 500, Description = "Appelsín í gleri 330ml", Quantity = 1, ImagePath = "appelsin.png" };
            Drink d9 = new Drink { DrinkId = 9, Name = "Kristall", UnitPrice = 500, Description = "Kristall í gleri 330ml án bragðefna", Quantity = 1, ImagePath = "kristall.jpg" };
            Drink d10 = new Drink { DrinkId = 10, Name = "Sleipnir Pale Ale", UnitPrice = 1600, Description = "Sleipnir Pale Ale frá Ölvisholt Brugghús 330ml", Quantity = 1, ImagePath = "sleipnir.jpg" };

            modelBuilder.Entity<Drink>().HasData(d1);
            modelBuilder.Entity<Drink>().HasData(d2);
            modelBuilder.Entity<Drink>().HasData(d3);
            modelBuilder.Entity<Drink>().HasData(d4);
            modelBuilder.Entity<Drink>().HasData(d5);
            modelBuilder.Entity<Drink>().HasData(d6);
            modelBuilder.Entity<Drink>().HasData(d7);
            modelBuilder.Entity<Drink>().HasData(d8);
            modelBuilder.Entity<Drink>().HasData(d9);
            modelBuilder.Entity<Drink>().HasData(d10);
            #endregion
        }

    }
}
