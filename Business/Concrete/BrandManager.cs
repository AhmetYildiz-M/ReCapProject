using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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

        public List<Brand> GetAll()
        {
            return null;
        }

        public Brand GetById(int id)
        {
            return null;
        }

        public void Add(Brand brand)
        {
        }

        public void Delete(Brand brand)
        {
        }

        public void Update(Brand brand)
        {
        }
    }
}
