using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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

       public List<Color> GetAll()
        {
            return null;
        }

        public Color GetById(int colorId)
        {
            return null;
        }

        public void Add(Color color)
        {
        }

        public void Delete(Color color)
        {
        }

        public void Update(Color color)
        {
        }
        
    }
}
