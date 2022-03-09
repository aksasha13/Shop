using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        
        public IEnumerable<Category> getAllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {
                        categoryName = "Electric cars",
                        desc = "Modern cars" },
                    new Category {
                        categoryName = "Classic cars",
                        desc = "Fuel cars" }
                };

            }

        }
    }
}
