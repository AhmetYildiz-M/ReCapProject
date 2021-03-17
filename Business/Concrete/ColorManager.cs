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
           return _colorDal.GetAll();
       }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(co => co.ColorId == colorId);
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(int id)
        {
            var result = _colorDal.Get(co => co.ColorId == id);
            if (result != null)
            {
                _colorDal.Delete(result);
                Console.WriteLine("Color details has been deleted.");
            }
            else
            {
                Console.WriteLine("There is no color with this ID.");
            }
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
        
    }
}
