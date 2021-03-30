using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
            }
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(u => u.RentalId == rentalId));
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate < DateTime.Now && rental.ReturnDate==null)
            {
                return new ErrorResult(Messages.RentalIdInvalid);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalIsAdded);
        }


        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalIsDeleted);
        }

        public IResult Update(Rental rental)
        {
            if (rental.RentalId != rental.RentalId)
            {
                return new ErrorResult(Messages.RentalIdInvalid);
            }
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalIsUpdated);
        }
    }
}
