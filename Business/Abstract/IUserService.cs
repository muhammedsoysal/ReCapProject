﻿using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<List<User>> GetAll(); 
        IDataResult<User> GetById(int id);
        IDataResult<User> GetByMail(string email);
    }
}