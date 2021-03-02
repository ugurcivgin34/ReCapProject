using Core.Entities.Concorete;
using Core.Entities.Concrete;
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
        //IResult Delete(int id);
        IResult Delete(User user);
        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetAll();

        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
    }
}
