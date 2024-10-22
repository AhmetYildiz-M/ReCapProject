﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
      IDataResult<List<Car>> GetAll();
      IDataResult<Car> GetById(int carId);
      IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
      IDataResult<List<Car>> GetCarsByBrandId(int id);
      IDataResult<List<Car>> GetCarsByColorId(int id);
      IDataResult<List<CarDetailDto>> GetCarDetails();
      IResult Add(Car car);
      IResult Delete(Car car);
      IResult Update(Car car);

    }

}
