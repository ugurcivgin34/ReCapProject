using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;

namespace Business.Concrete
{
    


    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rental)
        {
            _rentalDal = rental;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetAll(p => p.CarId == rental.CarId && rental.ReturnDate == null);
            if (result.Count>0)
            {
                return new ErrorResult(Messages.RentalBusy);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
           
  
        }

        public IResult Delete(int id)
        {
            var result = _rentalDal.Get(p => p.CarId == id);
            if(result == null)
            {
                return new SuccessResult(Messages.NoRecording);

            }
            if (result.ReturnDate==null)
            {
                return new SuccessResult(Messages.RentalBusy);
            }
            _rentalDal.Delete(p => p.CarId == id);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IResult Deliver(int rentalId)
        {
            var result = _rentalDal.Get(p => p.CarId == rentalId);
            result.ReturnDate = DateTime.Now.Date;
            Update(result);
            return new SuccessResult(Messages.RentalDelivered);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetAvailableCars()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.ReturnDate == null));
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.CarId == id));
        }

        public IDataResult<List<Rental>> GetUnAvailableCars()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.ReturnDate != null));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
