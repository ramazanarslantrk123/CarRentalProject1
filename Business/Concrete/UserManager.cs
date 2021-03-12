﻿using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        /*private readonly*/ IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
        //public IResult Add(User user)
        //{
        //    _userDal.Add(user);
        //    return new SuccessResult();
        //}

        //public IResult Delete(User user)
        //{
        //    _userDal.Delete(user);
        //    return new SuccessResult();
        //}

        //public IDataResult<List<User>> GetAll()
        //{
        //    return new SuccessDataResult<List<User>>(_userDal.GetAll());
        //}

        //public IDataResult<User> GetById(int userId)
        //{
        //    return new SuccessDataResult<User>(_userDal.Get(p=>p.Id==userId));
        //}

        //public IResult Update(User user)
        //{
        //    _userDal.Update(user);
        //    return new SuccessResult();
        //}
    }
}
