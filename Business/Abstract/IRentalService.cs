using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(int id);
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetAll();
        IResult Deliver(int rentalId);
        IDataResult<List<Rental>> GetAvailableCars();
        IDataResult<List<Rental>> GetUnAvailableCars();

    }
}
