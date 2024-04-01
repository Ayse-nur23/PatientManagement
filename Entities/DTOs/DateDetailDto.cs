using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class DateDetailDto:IDto
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string Name { get; set; }
        public DateTime DateTim { get; set; }  
    }
}
