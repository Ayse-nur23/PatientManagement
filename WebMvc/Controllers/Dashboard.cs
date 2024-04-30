using Business.Abstracts;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Controllers
{
    public class Dashboard : Controller
    {
        private IDateService _dateService;

        public Dashboard(IDateService dateService)
        {
            _dateService = dateService;
        }

        public IActionResult Index()
        {
            var result = _dateService.GetDateDetails();
            if (result.Success)
            {
                return View(Tuple.Create(new Date(), result.Data));
            }
            return View(result.Message);
        }
    }
}
