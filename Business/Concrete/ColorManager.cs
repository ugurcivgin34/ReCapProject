using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(int id)
        {
            _colorDal.Delete(p => p.ColorId == id);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult <List<Color>> GetAll()
        {
            return new SuccessDataResult <List<Color>>(_colorDal.GetAll().ToList());
        }

        public IDataResult <Color> GetById(int id)
        {
            return new SuccessDataResult <Color> (_colorDal.Get(p => p.ColorId == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
