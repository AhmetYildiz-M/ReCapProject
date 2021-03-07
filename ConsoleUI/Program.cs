using System;
using System.Collections.Generic;
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
          


            CarManager carManager = new CarManager(new EfCarDal());

            foreach(var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description + " BrandId: " + car.BrandId);
            }

            foreach(var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description + " ColorId: " + car.ColorId);
            }

            foreach(var car in carManager.GetByDailyPrice(5000, 15000))
            {
                Console.WriteLine(car.Description + " DailyPrice: " + car.DailyPrice);
            }

            /*carManager.Add(new Car(){CarName = "Maseratti", ColorId = 3, DailyPrice = 13200, 
                BrandId = 2, Description = "Maseratti", Id = 6, ModelYear = 1987});


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Name : {0}", car.CarName);
            }*/
          
            
           
        }
        

        
    }
}
