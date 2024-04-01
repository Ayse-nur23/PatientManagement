using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PatientManager : IPatientService
    {
        IPatientDal _patientDal;

        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }

        public IResult Add(Patient patient)
        {
            _patientDal.Add(patient);
            return new SuccessResult(Messages.PatientAdded);
        }

        public IResult Delete(Patient patient)
        {
            _patientDal.Delete(patient);
            return new SuccessResult(Messages.PatientDeleted);
        }

        public IDataResult<List<Patient>> GetAll()
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetAll(),Messages.PatientsListed);
        }

        public IDataResult<Patient> GetById(int id)
        {
            return new SuccessDataResult<Patient>(_patientDal.Get(p => p.Id == id));
        }

        public IDataResult<List<PatientDetailDto>> GetPatientDetails()
        {
            return new SuccessDataResult<List<PatientDetailDto>>(_patientDal.GetPatientDetails(), Messages.MedicinesListed);
        }

        public IResult Update(Patient patient)
        {
            _patientDal.Update(patient);
            return new SuccessResult(Messages.PatientUpdated);
        }
    }
}
