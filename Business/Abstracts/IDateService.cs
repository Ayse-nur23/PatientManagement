using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;


namespace Business.Abstracts
{
    public interface IDateService
    {
        IResult Add(Date date);
        IResult Delete(Date date);
        IResult Update(Date date);
        IDataResult<List<DateDetailDto>> GetDateDetails();
        IDataResult<List<Date>> GetAll();
    }
}
