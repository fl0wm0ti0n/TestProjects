using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Blazor_FirstWebApp.Shared;

namespace Blazor_FirstWebApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public IEnumerable<PersonModel> GetPeople()
        {
            return new List<PersonModel>
            {
                new PersonModel {FirstName = "Flo", LastName = "Gabriel", AccountBalance = 12.44M},
                new PersonModel {FirstName = "Tim", LastName = "Stocker", AccountBalance = -19.01M},
                new PersonModel {FirstName = "Anna", LastName = "Sexy", AccountBalance = 100.11M}
            };
        }

        [HttpPost]
        public void Post(PersonModel person)
        {
            
        }
    }
}