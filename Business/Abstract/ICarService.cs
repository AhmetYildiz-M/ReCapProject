﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
      List<Car> GetAll();

      List<Car> GetById(int id, int brandId, int colorId);
    }

}
