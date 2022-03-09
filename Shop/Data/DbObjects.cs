using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content )
        {
           
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Model S",
                        longDesc = "Horsepower 1,020 hp <br>0-60mph 2.8 seconds",
                        img = "/img/tesla.jpg",
                        price = 81190,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Electric cars"]
                    },
                     new Car
                     {
                         name = "Porsche",
                         shortDesc = "Macan GTS",
                         longDesc = "Horsepower 434 <br> 0-60mph 4.3 seconds",
                         img = "/img/macan.jpg",
                         price = 82700,
                         isFavorite = true,
                         available = true,
                         Category = Categories["Classic cars"]
                     },
                      new Car
                      {
                          name = "BMW",
                          shortDesc = "530i",
                          longDesc = "Horsepower 248 <br> 0-60mph 5.7 seconds",
                          img = "/img/530i.jpg",
                          price = 54200,
                          isFavorite = true,
                          available = true,
                          Category = Categories["Classic cars"]
                      },
                       new Car
                       {
                           name = "Ford",
                           shortDesc = "Fiesta",
                           longDesc = "Horsepower 120 <br> 0-60mph 11.9 seconds",
                           img = "/img/fiesta.jpg",
                           price = 31420,
                           isFavorite = false,
                           available = true,
                           Category = Categories["Classic cars"]
                       },
                       new Car
                       {
                           name = "Mercedes-Benz",
                           shortDesc = "Cls",
                           longDesc = "Horsepower 362 <br> 0-60mph 4.9 seconds",
                           img = "/img/cls.jpg",
                           price = 98442,
                           isFavorite = true,
                           available = false,
                           Category = Categories["Classic cars"]
                       },
                       new Car
                       {
                           name = "Hyndai",
                           shortDesc = "Kona",
                           longDesc = "Horsepower 201 <br> 0-60mph 6.4 seconds",
                           img = "/img/kona.jpg",
                           price = 31420,
                           isFavorite = false,
                           available = true,
                           Category = Categories["Electric cars"]
                       }
                    );
            }
            content.SaveChanges();
        }



        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {
                        categoryName = "Electric cars",
                        desc = "Modern cars" },
                        new Category {
                        categoryName = "Classic cars",
                        desc = "Gasoline cars" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }

                }
                return category;
            }
        }
    }
}
