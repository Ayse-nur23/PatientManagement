using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DateManager : IDateService
    {
        IDateDal _dateDal;

        public DateManager(IDateDal dateDal)
        {
            _dateDal = dateDal;
        }

        public IResult Add(Date date)
        {
            _dateDal.Add(date);
            return new SuccessResult();
        }

        public IResult Delete(Date date)
        {
            _dateDal.Delete(date);
            return new SuccessResult();
        }

        public IDataResult<List<Date>> GetAll()
        {
            return new SuccessDataResult<List<Date>>(_dateDal.GetAll());
        }

        public IDataResult<List<DateDetailDto>> GetDateDetails()
        {
            return new SuccessDataResult<List<DateDetailDto>>(_dateDal.GetDateDetails());
        }

        public IResult Update(Date date)
        {
            _dateDal.Update(date);
            return new SuccessResult();
        }
    }
}
