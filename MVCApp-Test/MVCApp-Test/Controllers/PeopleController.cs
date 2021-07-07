using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp_Test.Models;

namespace MVCApp_Test.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel p = new PersonModel();
            int i = 5 / p.Age;

            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel {FirstName = "Flo", LastName = "Gabriel", Age = 31});
            people.Add(new PersonModel { FirstName = "Timmi", LastName = "Stocker", Age = 29 });
            people.Add(new PersonModel { FirstName = "Jan", LastName = "Gabriel", Age = 14 });

            return View(people);
        }
    }
}