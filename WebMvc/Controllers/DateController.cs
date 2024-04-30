using Business.Abstracts;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HastaTakipProgram.Controllers
{
    public class DateController : Controller
    {
        private IDateService _dateService;
        private IPatientService _patientService;
        public DateController(IDateService dateService, IPatientService patientService)
        {
            _dateService = dateService;
            _patientService = patientService;
        }

        public IActionResult Index()
        {
            var result = _dateService.GetDateDetails();
            if (result.Success)
            {
                return View(Tuple.Create(new Date() , result.Data));

                //return View(Tuple.Create<Date, List<DateDetailDto>>(new Date(), new List<DateDetailDto>()));
           
              // return View(result.Data);

            }
            return View(result.Message);
        }

        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> patientList = (from p in _patientService.GetAll().Data
                                                select new SelectListItem
                                                {
                                                    Text = p.NationalityId + "-" + p.FirstName + p.LastName,
                                                    Value = p.Id.ToString()
                                                }).ToList();
            ViewBag.PatientList = patientList;

            return View();
        }

        [HttpPost("Add")]
        public IActionResult Add(Date date)
        {
            var result = _dateService.Add(date);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(result.Message);
        }
        public IActionResult Delete(Date date )
        {
            var result = _dateService.Delete(date);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(result.Message);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            List<SelectListItem> patientList = (from p in _patientService.GetAll().Data
                                                select new SelectListItem
                                                {
                                                    Text = p.NationalityId,
                                                    Value = p.Id.ToString()
                                                }).ToList();
            ViewBag.PatientList = patientList;


            var result = _patientService.GetById(id);
            if (result.Success)
            {
                return View(result.Data);
            }
            return View(result.Message);
        }

        [HttpPost("Datupdate")]
        public IActionResult Update(Date date)
        {
            var result = _dateService.Update(date);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(result.Message);
        }

    }
}
