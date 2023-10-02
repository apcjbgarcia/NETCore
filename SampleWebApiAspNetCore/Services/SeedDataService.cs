using SampleWebApiAspNetCore.Entities;
using SampleWebApiAspNetCore.Repositories;

namespace SampleWebApiAspNetCore.Services
{
    public class SeedDataService : ISeedDataService
    {
        public void Initialize(DrinkDbContext context)
        {
            context.DrinkItems.Add(new DrinkEntity() { Calories = 101, Type = "Juice", Name = "Juice", Created = DateTime.Now });
            context.DrinkItems.Add(new DrinkEntity() { Calories = 102, Type = "Coffee", Name = "Cafe Latte", Created = DateTime.Now });
            context.DrinkItems.Add(new DrinkEntity() { Calories = 103, Type = "Tea", Name = "Iced Tea", Created = DateTime.Now });
            context.DrinkItems.Add(new DrinkEntity() { Calories = 104, Type = "Alcohol", Name = "Beer", Created = DateTime.Now });

            context.SaveChanges();
        }
    }
}
