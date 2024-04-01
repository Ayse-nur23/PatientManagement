using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IPatientService
    {
        IDataResult<List<Patient>> GetAll();
        IDataResult<List<PatientDetailDto>> GetPatientDetails();
        IResult Add(Patient patient );
        IResult Delete(Patient patient );
        IResult Update(Patient patient );
        IDataResult<Patient> GetById(int id);
    }
}
