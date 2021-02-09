using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.Descriptions.Length >2)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("İstenilen özelliklere uymadığınız için ekleme yapılamıyor");
            }
            
        }

        public void Delete(int id)
        {
            _carDal.Delete(p => p.Id == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll().ToList();
        }

        public Car GetCarById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
