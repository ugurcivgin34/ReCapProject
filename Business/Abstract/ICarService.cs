using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult <List<Car>> GetAll();
        IDataResult <Car> GetCarById(int id);
       
        IResult Add(Car car);
        //IResult Delete(int id);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult <List<CarDetailDto>> GetCarDetail();
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int ColorId);
        IDataResult<List<CarDetailDto>> GetCarsDetailByBrandId(int BrandId);
        IDataResult<List<CarDetailDto>> GetCarDetailById(int carId);
        IResult AddTransactionalTest(Car car);
    }
}
