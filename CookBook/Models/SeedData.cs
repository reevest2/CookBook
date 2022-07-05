using CookBook.Data;
using Microsoft.EntityFrameworkCore;

namespace CookBook.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CookBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CookBookContext>>()))
            {
                if (context.Recipe.Any())
                {
                    return;
                }

                context.Recipe.AddRange(
                    new Recipe
                    {
                        Name="Cooked Rice",
                        Instructions="Cook Rice till its done"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
