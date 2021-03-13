using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        //IResult Delete(int id);
        IResult Delete(Rental rental);
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<DtoRentalDetail>> GetRentalDto();
        IResult Deliver(int rentalId);
        IDataResult<List<Rental>> GetAvailableCars();
        IDataResult<List<Rental>> GetUnAvailableCars();


    }
}
