using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id = 1, BrandId = 2, ColorId = 2, DailyPrice = 20000, ModelYear = 1986, Description = "Ferrari"},
                new Car{Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 15000, ModelYear = 1954, Description = "Mercedes"},
                new Car{Id = 3, BrandId = 1, ColorId = 3, DailyPrice = 10000, ModelYear = 1881, Description = "Mercedes"},
                new Car{Id = 4, BrandId = 3, ColorId = 4, DailyPrice = 12000, ModelYear = 1950, Description = "Mustang"},
                new Car{Id = 5, BrandId = 4, ColorId = 3, DailyPrice = 20300, ModelYear = 2021, Description = "HaciMurat"}
                
            };
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return null;
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
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
