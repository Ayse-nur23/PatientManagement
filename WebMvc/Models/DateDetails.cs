using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Models
{
    public class DateDetails
    {
        public List<DateDetailDto> DateDetailModel { get; set; }
        public Date DateModel { get; set; }
    }
}
