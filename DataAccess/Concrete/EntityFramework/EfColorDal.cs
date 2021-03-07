using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return null;
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            return null;
        }

        public void Add(Color entity)
        {
        }

        public void Delete(Color entity)
        {
        }

        public void Update(Color entity)
        {
        }
    }
}
