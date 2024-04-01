using Business.Abstracts;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastaTakipProgram.Controllers
{
    public class MedicineController : Controller
    {
        private IMedicineService _medicineService;

        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        public IActionResult Index()
        {
            var result = _medicineService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            return View(result.Message);
       
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost("Medadd")]
        public IActionResult Add(Medicine medicine)
        {
            var result = _medicineService.Add(medicine);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(result);
        }
  
        public IActionResult Delete(Medicine medicine)
        {
            var result = _medicineService.Delete(medicine);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(result);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = _medicineService.GetById(id);
            if (result.Success)
            {
                return View(result.Data);
            }
            return View(result.Message);
        }
        [HttpPost("Medupdate")]
        public IActionResult Update(Medicine medicine)
        {
            var result = _medicineService.Update(medicine);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(result);
        }
    }
}
