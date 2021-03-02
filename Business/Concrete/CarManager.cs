﻿using Business.Abstract;
using Business.BusinessAspects;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcers.Validation;
using Core.Utilities;
using Core.Utilities.Results;
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
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);

            _carDal.Add(car);
            return new ErrorResult(Messages.CarNameInvalid);
            
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Delete(Car car)
        {
            //_carDal.Delete(p => p.Id == id);
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
             return new SuccessDataResult <List<Car>>(_carDal.GetAll().ToList(),Messages.CarsListed);
        }

        public IDataResult <Car> GetCarById(int id)
        {
            return new SuccessDataResult <Car> (_carDal.Get(p => p.Id == id));
        }

        public IDataResult <List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult <List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult <List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult <List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
             _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
