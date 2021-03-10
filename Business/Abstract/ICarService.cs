using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
      List<Car> GetAll();
      Car GetById(int id);
      List<Car> GetByDailyPrice(decimal min, decimal max);
      List<Car> GetCarsByBrandId(int brandId);
      List<Car> GetCarsByColorId(int colorId);
      List<CarDetailDto> GetCarDetails();
      void Add(Car car);
      void Delete(Car car);
      void update(Car car);

    }

}
