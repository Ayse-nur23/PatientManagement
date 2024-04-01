using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDateDal : EfEntityRepositoryBase<Date, HastaTakipContext>, IDateDal
    {

        public List<DateDetailDto> GetDateDetails()
        {
            using (HastaTakipContext context = new HastaTakipContext())
            {
                var result = from p in context.Patients
                             join d in context.Dates
                             on p.Id equals d.PatientId
                             select new DateDetailDto {Id=d.Id, Name = p.FirstName + " " + p.LastName, NationalityId = p.NationalityId ,DateTim=d.DateTim};

              return result.ToList();
            }
        }
    }
}
