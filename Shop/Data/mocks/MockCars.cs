using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars:IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla",
                        shortDesc="Model S",
                        longDesc="Horsepower 1,020 hp <br>0-60mph 2.8 seconds",
                        img="/img/tesla.jpg",
                        price=60000,
                        isFavorite=true,
                        available=true,
                        Category = _categoryCars.getAllCategories.First()
                    },
                     new Car
                    {
                        name = "Porsche",
                        shortDesc="Macan GTS",
                        longDesc="Horsepower 434 <br> 0-60mph 4.3 seconds",
                        img="/img/macan.jpg",
                        price=65000,
                        isFavorite=true,
                        available=true,
                        Category = _categoryCars.getAllCategories.Last()
                    },
                      new Car
                    {
                        name = "BMW",
                        shortDesc="530i",
                        longDesc="Horsepower 248 <br> 0-60mph 5.7 seconds",
                        img="/img/530i.jpg",
                        price=45000,
                        isFavorite=true,
                        available=true,
                        Category = _categoryCars.getAllCategories.Last()
                    },
                       new Car
                    {
                        name = "Ford",
                        shortDesc="Fiesta",
                        longDesc="Horsepower 120 <br> 0-60mph 11.9 seconds",
                        img="/img/fiesta.jpg",
                        price=31420,
                        isFavorite=false,
                        available=true,
                        Category = _categoryCars.getAllCategories.Last()
                    },
                       new Car
                    {
                        name = "Mercedes-Benz",
                        shortDesc="Cls",
                        longDesc="Horsepower 362 <br> 0-60mph 4.9 seconds",
                        img="/img/cls.jpg",
                        price=48000,
                        isFavorite=true,
                        available=false,
                        Category = _categoryCars.getAllCategories.Last()
                    },
                       new Car
                    {
                        name = "Hyndai",
                        shortDesc="Kona",
                        longDesc="Horsepower 201 <br> 0-60mph 6.4 seconds",
                        img="/img/kona.jpg",
                        price=31420,
                        isFavorite=false,
                        available=true,
                        Category = _categoryCars.getAllCategories.First()
                    },
                };

            }
        }
        public IEnumerable<Car> getFavCars { get; set;}

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
