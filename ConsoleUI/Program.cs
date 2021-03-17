using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Channels;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDeleteTest();

            //CarGetBrandIdTest(carManager);

            //CarGetColorIdTest(carManager);

            //CarGetDailyPriceTest(carManager);

            //CarAddTest(carManager);

            //CarUpdateTest();



            //ColotGetAllTest();

            //ColorGetByIdTest();

            //ColorAddTest();

            //ColorDeleteTest();

            //ColorUpdateTest();




            //BrandGetAllTest();

            //BrandGetByIdTest();

            //BrandAddTest();

            //BrandDeleteTest();

            //BrandUpdateTest();
        }

        private static void BrandUpdateTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand() {BrandId = 6, BrandName = "Volvo"});
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " / " + brand.BrandName);
            }
        }

        private static void BrandDeleteTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(5);
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " / " + brand.BrandName);
            }
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand() {BrandName = "Suzuki"});
            Console.WriteLine($"The new brand is added.");
        }

        private static void BrandGetByIdTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine($"This ID is given for {brandManager.GetById(4).BrandName}.");
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " / " + brand.BrandName);
            }
        }

        private static void ColorUpdateTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color() {ColorId = 5, ColorName = "Purple"});
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " / " + color.ColorName);
            }
        }

        private static void ColorDeleteTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(6);
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " / " + color.ColorName);
            }
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color() {ColorName = "Dark Brown"});
            Console.WriteLine($"The new color is added.");
        }

        private static void ColorGetByIdTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine($"This ID is given for {colorManager.GetById(2).ColorName}.");
        }

        private static void ColotGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " / " + color.ColorName);
            }
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car()
            {
                Id = 5,
                CarName = "Ferrari",
                ColorId = 4,
                DailyPrice = 14200,
                BrandId = 2,
                Description = "Sports",
                ModelYear = 2001
            });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " - " + car.Description);
            }
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(7);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " - " + car.Description);
            }
        }

        private static void CarGetBrandIdTest(CarManager carManager)
        {
            CarManager carManagerCarBrandId = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description + " BrandId: " + car.BrandId);
            }
        }

        private static void CarGetColorIdTest(CarManager carManager)
        {
            CarManager carManagerGetColorId = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description + " ColorId: " + car.ColorId);
            }
        }

        private static void CarGetDailyPriceTest(CarManager carManager)
        {
            CarManager carManagerDailyPrice = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByDailyPrice(5000, 15000))
            {
                Console.WriteLine(car.Description + " DailyPrice: " + car.DailyPrice);
            }
        }

        private static void CarAddTest(CarManager carManager)
        {
            CarManager carManagerAdd = new CarManager(new EfCarDal());
            carManager.Add(new Car()
            {
                CarName = "Maseratti", ColorId = 3, DailyPrice = 13200,
                BrandId = 2, Description = "Maseratti", Id = 6, ModelYear = 1987
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Name : {0}", car.CarName);
            }
        }
    }



}
