using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetCarById(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByBrandId(int id);
        void Add(Car car);
        void Delete(int id);
        void Update(Car car);
        List<CarDetailDto> GetCarDetail();
    }
}
