using Business.Abstracts;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaTakipProgram.Controllers
{
    public class PatientController : Controller
    {
        private IPatientService _patientService;
       private IMedicineService _medicineService;

        public PatientController(IMedicineService medicineService, IPatientService patientService)
        {
            _medicineService = medicineService;
            _patientService = patientService;
        }

        
        public IActionResult Index()
        {
            var result = _patientService.GetPatientDetails();
            if (result.Success)
            {
                return View(result.Data);
            }
            return View(result.Message);
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> medicineList = (from x in _medicineService.GetAll().Data
                                                  select new SelectListItem
                                                  {
                                                      Text = x.MedicineName,
                                                      Value = x.Id.ToString()
                                                  }).ToList();

            ViewBag.MedicineList = medicineList;

            return View();
        }
        [HttpPost("Patadd")]
        public IActionResult Add(Patient patient)
        {
            var result = _patientService.Add(patient);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(result);
        }
       
        public IActionResult Delete(Patient patient)
        {
            var result = _patientService.Delete(patient);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(result.Message);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            List<SelectListItem> medicineList = (from x in _medicineService.GetAll().Data
                                                 select new SelectListItem
                                                 {
                                                     Text = x.MedicineName,
                                                     Value = x.Id.ToString()
                                                 }).ToList();

            ViewBag.MedicineList = medicineList;

            var result = _patientService.GetById(id);
            if (result.Success)
            {
                return View(result.Data);
            }
            return View(result.Message);
        }

        [HttpPost("Patupdate")]
        public IActionResult Update(Patient patient)
        {
           var result= _patientService.Update(patient);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(result.Message);
        }

    }
}
