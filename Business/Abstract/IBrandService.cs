using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetById(int brandId);
        void Add(Brand brand);
        void Delete(int brandId);
        void Update(Brand brand);

    }
}
