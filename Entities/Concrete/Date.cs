using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Date:IEntity
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime DateTim { get; set; }
    }
}
