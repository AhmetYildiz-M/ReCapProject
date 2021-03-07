using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return null;
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            return null;
        }

        public void Add(Brand entity)
        {
        }

        public void Delete(Brand entity)
        {
        }

        public void Update(Brand entity)
        {
        }
    }
}
