using Microsoft.AspNetCore.Mvc;
using Project_03.Data;
using Project_03.Models;
using System;
using System.Diagnostics;


namespace Project_03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult PartialForm()
        {
            return PartialView("_AddPerson");
        }

        [HttpPost]
        [HttpPost]
        public IActionResult SubmitPerson(PersonModel person)
        {
            if (ModelState.IsValid)
            {
                _context.person.Add(person);
                _context.SaveChanges();
                TempData["Message"] = "Person Details Saved Successfully!";
                return RedirectToAction("Index");
            }

            return PartialView("PartialForm", person);
        }

        [HttpPost]
        public IActionResult SubmitAddress(AddressModel address)
        {
            if (ModelState.IsValid)
            {
                _context.address.Add(address);
                _context.SaveChanges();
                TempData["Message"] = "Address Details Saved Successfully!";
                return RedirectToAction("Index");
            }

            return PartialView("PartialForm", address);
        }

    }

}