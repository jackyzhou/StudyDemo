using StudyDemo.KnockoutJs.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StudyDemo.KnockoutJs.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            // NOTE: We should have a wrapper ViewModel instead of ViewBag or ViewData. 
            // This is used here to keep the demonstration simple.
            ViewBag.Countries = new List<Country>(){
                new Country()
                {
                    Id = 1,
                    Name = "India"
                },
                new Country()
                {
                    Id = 2,
                    Name = "USA"
                },
                new Country()
                {
                    Id = 3,
                    Name = "France"
                }
            };

            var viewModel = new PersonViewModel()
            {
                Id = 1,
                Name = "Naveen",
                DateOfBirth = new DateTime(1990, 11, 21)
            };

            return View(viewModel);
        }

        [HttpPost]
        public JsonResult SavePersonDetails(PersonViewModel viewModel)
        {
            // TODO: Save logic goes here.
            return Json(new { });
        }
    }
}