using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Medicine: IEntity
    {
        public int Id { get; set; }
        public string MedicineName { get; set; }
    }
}
