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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour==20)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.BrandListed);
            }
        }

        public IDataResult<Brand> GetById(int brandId)
        {            
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId));            
        }
            
        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
                return new ErrorResult(Messages.BrandIdInvalid);
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandIsAdded);
        }


        public IResult Delete(Brand brand)
        {
            
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandIsDeleted);
        }

        public IResult Update(Brand brand)
        {                        
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandIsUpdated);          
            
        }

    }
}
