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
    public class MedicineManager : IMedicineService
    {
        IMedicineDal _medicineDal;

        public MedicineManager(IMedicineDal medicineDal)
        {
            _medicineDal = medicineDal;
        }

        public IResult Add(Medicine medicine)
        {
            _medicineDal.Add(medicine);
            return new SuccessResult(Messages.MedicineAdded);
        }

        public IResult Delete(Medicine medicine)
        {
            _medicineDal.Delete(medicine);
            return new SuccessResult(Messages.MedicineDeleted);
        }

        public IDataResult<List<Medicine>> GetAll()
        {
            return new SuccessDataResult<List<Medicine>>(_medicineDal.GetAll(), Messages.MedicinesListed);
        }

        public IDataResult<Medicine> GetById(int id)
        {
            return new SuccessDataResult<Medicine>(_medicineDal.Get(m => m.Id == id));
        }

        public IResult Update(Medicine medicine)
        {
            _medicineDal.Update(medicine);
            return new SuccessResult(Messages.MedicineUpdated);
        }
    }
}
