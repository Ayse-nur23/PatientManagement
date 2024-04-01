using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPatientDal : EfEntityRepositoryBase<Patient, HastaTakipContext>, IPatientDal
    {
        public List<PatientDetailDto> GetPatientDetails()
        {
            using (HastaTakipContext context=new HastaTakipContext())
            {
                var result = from p in context.Patients
                             join m in context.Medicines
                             on p.MedicineId equals m.Id
                             select new PatientDetailDto
                             {
                                 Id = p.Id,
                                 NationalityId = p.NationalityId,
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 Email = p.Email,
                                 DateOfBirth = p.DateOfBirth,
                                 PhoneNumber = p.PhoneNumber,
                                 Address = p.Address,
                                 Gender = p.Gender,
                                 BloodGroup = p.BloodGroup,
                                 ConnectionName = p.ConnectionName,
                                 ConnectionPhone = p.ConnectionPhone,
                                 MedicineName = m.MedicineName
                             };
                return result.ToList();
            }
        }
    }
}
