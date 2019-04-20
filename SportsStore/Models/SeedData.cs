using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models{

    public class SeedData{
        public static void EnsurePopulated(IApplicationBuilder app) {
            MyDbContext ctx = app.ApplicationServices.GetRequiredService<MyDbContext>();
            ctx.Database.Migrate();
                if (!ctx.Products.Any()) {
                    ctx.Products.AddRange(
                        new Product
                        {
                            //ProductID = 1,
                            Name = "Kayak",
                            Description = "A boat for one person",
                            Category = "Watersports",
                            Price = 275
                        },
                    new Product
                    {
                        //ProductID = 2,
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    {
                        //ProductID = 3,
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product
                    {
                        //ProductID = 4,
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.95m
                    },
                    new Product
                    {
                        //ProductID = 5,
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product
                    {
                        //ProductID = 6,
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product
                    {
                        //ProductID = 7,
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess",
                        Price = 29.95m
                    }
                    );
                ctx.SaveChanges();
                }
        }
    }
}
