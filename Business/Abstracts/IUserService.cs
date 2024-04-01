using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IResult Add(User user);
        User GetByUser(string userName);
        bool GetByPassword(string userName, string password);
        IDataResult<User> Login(User user);


    }
}
