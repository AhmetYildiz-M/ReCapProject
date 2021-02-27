using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 2, ColorId = 2, DailyPrice = 20, ModelYear = 1986, Description = "Ferrari"},
                new Car{Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 20, ModelYear = 1986, Description = "Mercedes"},
                new Car{Id = 3, BrandId = 1, ColorId = 2, DailyPrice = 20, ModelYear = 1986, Description = "Mercedes"},
                new Car{Id = 4, BrandId = 3, ColorId = 2, DailyPrice = 20, ModelYear = 1986, Description = "Mustang"},
                new Car{Id = 5, BrandId = 4, ColorId = 2, DailyPrice = 20, ModelYear = 1986, Description = "HaciMurat"}
                
            };
        }

        public List<Car> GetById(int Id,int BrandId, int ColorId )
        {
            return _cars.Where(c=>c.Id == Id && c.BrandId == BrandId && c.ColorId == ColorId).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        { 
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;


        }
    }
}
