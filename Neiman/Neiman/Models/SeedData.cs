using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
namespace Neiman.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<StoreContext>();
            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.Products.Any())
            {
                return; // Database has been seeded
            }

            var pine_boards = context.Categories.Add(new Category { Name = "Pine Boards" }).Entity;
            var pine_pattern = context.Categories.Add(new Category { Name = "Pine Patterns" }).Entity;

            context.Products.AddRange(
                new Product
                {
                    Name = "1x4 Grade 2 Board",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat convallis convallis. " + 
                    "Mauris consequat ipsum velit, eu laoreet quam fermentum maximus. Mauris elementum urna non mi posuere dictum. " + 
                    "Suspendisse vitae quam interdum, fringilla purus sed, scelerisque mauris. Phasellus accumsan diam eget tortor fringilla, quis dictum sem volutpat. " + 
                    "Aenean eget ornare mi, non porttitor eros. Vestibulum rutrum libero eget felis sollicitudin euismod.",
                    Price = 59.99M,
                    Category = pine_boards
                },
                new Product
                {
                    Name = "WP 2 Pattern",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed feugiat convallis convallis. " +
                    "Mauris consequat ipsum velit, eu laoreet quam fermentum maximus. Mauris elementum urna non mi posuere dictum. " +
                    "Suspendisse vitae quam interdum, fringilla purus sed, scelerisque mauris. Phasellus accumsan diam eget tortor fringilla, quis dictum sem volutpat. " +
                    "Aenean eget ornare mi, non porttitor eros. Vestibulum rutrum libero eget felis sollicitudin euismod.",
                    Price = 19.99M,
                    Category = pine_pattern
                }
            );

            context.SaveChanges();
        }
    }
}
