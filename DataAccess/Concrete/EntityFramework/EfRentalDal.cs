using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalDemoDbContext>, IRentalDal
    {
        //public List<RentalDetailDto> GetRentalDetails()
        //{
        //    //using (CarRentalDemoDbContext context = new CarRentalDemoDbContext())
        //    //{
        //    //    var result = from r in context.Rentals
        //    //                 join cu in context.Customers
        //    //                     on cu.CustomerId equals r.CustomerId
        //    //                 join c in context.Cars
        //    //                     on c.CarId equals c.CarId
                        
                                   

        //    //                 select new RentalDetailDto
        //    //                 {
        //    //                     CustomerName = u.FirstName

        //    //                 };
        //    //    return result.ToList();
        //    }
        //}
    }
}
