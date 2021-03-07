﻿using System;
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
          
            foreach (var car in carManager.GetByBrandId(3))
            {
                Console.WriteLine(car.Description);
            }
           
        }
        

        
    }
}
