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
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(co => co.BrandId == brandId);
        }

        public void Add(Brand brand)
        {
            
            _brandDal.Add(brand);
        }

        public void Delete(int brandId)
        {
            var result = _brandDal.Get(b => b.BrandId == brandId);
            if (result != null)
            {
                _brandDal.Delete(result);
                Console.WriteLine("Brand details has been deleted.");
            }
            else
            {
                Console.WriteLine("There is no brand with this ID.");
            }
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
