using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IMedicineService
    {
        IResult Add(Medicine  medicine);
        IResult Delete(Medicine medicine);
        IResult Update(Medicine medicine);
        IDataResult<List<Medicine>> GetAll();
        IDataResult<Medicine> GetById(int id);
    }
}
