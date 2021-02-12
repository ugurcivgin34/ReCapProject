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
        IDataResult <List<Car>> GetCarsByColorId(int id);
        IDataResult <List<Car>> GetCarsByBrandId(int id);
        IResult Add(Car car);
        IResult Delete(int id);
        IResult Update(Car car);
        IDataResult <List<CarDetailDto>> GetCarDetail();
    }
}
