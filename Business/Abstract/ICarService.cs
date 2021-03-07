using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
      List<Car> GetAll();
      List<Car> GetById(int id);
      List<Car> GetByDailyPrice(decimal min, decimal max);
      List<Car> GetByBrandId(int brandId);
      List<Car> GetByColorId(int colorId);

    }

}
