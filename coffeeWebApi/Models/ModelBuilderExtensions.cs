using Microsoft.EntityFrameworkCore;


namespace coffeeWebApi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                              new Category { Id = 1, Name = "Coffee" },
                              new Category { Id = 2, Name = "Tea" },
                              new Category { Id = 3, Name = "Juice" }
                                                                        );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Espresso", Sku = "ESP", Description = "Short and strong coffee without milk", Price = 2.5m, IsAvailable = true, CategoryId = 1 },
                new Product { Id = 2, Name = "Americano", Sku = "AM", Description = "Espresso with added hot water", Price = 3.5m, IsAvailable = true, CategoryId = 1 },
                new Product { Id = 3, Name = "Cappuccino", Sku = "CAP", Description = "Espresso with steamed milk foam", Price = 4.5m, IsAvailable = true, CategoryId = 1 },
                new Product { Id = 4, Name = "Latte", Sku = "LAT", Description = "Espresso with steamed milk", Price = 4.5m, IsAvailable = true, CategoryId = 1 },
                new Product { Id = 5, Name = "Tea with milk", Sku = "TM", Description = "Tea with milk", Price = 2.5m, IsAvailable = true, CategoryId = 2 },
                new Product { Id = 6, Name = "Tea with lemon", Sku = "TL", Description = "Tea with lemon", Price = 2.5m, IsAvailable = true, CategoryId = 2 },
                new Product { Id = 7, Name = "Orange juice", Sku = "OJ", Description = "Fresh orange juice", Price = 3.5m, IsAvailable = true, CategoryId = 3 },
                new Product { Id = 8, Name = "Apple juice", Sku = "AJ", Description = "Fresh apple juice", Price = 3.5m, IsAvailable = true, CategoryId = 3 });
        }
    }
}
