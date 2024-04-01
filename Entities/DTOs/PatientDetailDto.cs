using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PatientDetailDto:IDto
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string ConnectionName { get; set; }
        public string ConnectionPhone { get; set; }
        public string MedicineName { get; set; }
    }
}
