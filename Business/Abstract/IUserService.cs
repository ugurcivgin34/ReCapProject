using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(int id);
        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetAll();
    }
}
