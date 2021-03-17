using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.IDTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c=> c.DailyPrice >= min && c.DailyPrice <=max);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Add(Car car)
        {
            
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            
        }

        public void Delete(int id)
        {
            var result = _carDal.Get(c=>c.Id == id);
            if (result != null)
            {

                _carDal.Delete(result);
                Console.WriteLine("The car is deleted from the list");
            }
            else
            {
                Console.WriteLine("The is not deleted because Id is not founded.");
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
                Console.WriteLine("The car information has been updated");
            
            
        }

    }
}
