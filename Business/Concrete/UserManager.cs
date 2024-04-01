using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }


        public User GetByUser(string userName)
        {
            return _userDal.Get(u => u.UserName == userName);
        }


        public bool GetByPassword(string userName, string password)
        {
            var userCheck = _userDal.Get(u => u.UserName == userName);
            if (userCheck.Password == password)
            {
                return true;
            }
            return false;
        }

        public IDataResult<User> Login(User user)
        {
            var userToCheck = GetByUser(user.UserName);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            var passwordToCheck = GetByPassword(user.UserName, user.Password);
            if (!passwordToCheck)
            {
                return new ErrorDataResult<User>(Messages.PasswordError);

            }

            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

    }
}
