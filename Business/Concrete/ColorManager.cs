﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
       IColorDal _colorDal;

       public ColorManager(IColorDal colorDal)
       {
           _colorDal = colorDal;
       }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.BrandListed);
            }
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(co => co.ColorId == colorId));
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.ColorIdInvalid);
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorIsAdded);
        }


        public IResult Delete(Color color)
        {            
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorIsDeleted);
        }

        public IResult Update(Color color)
        {            
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorIsUpdated);
        }
    }
}
