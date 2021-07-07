using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor_FirstWebApp.Shared
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AccountBalance { get; set; }
        public string FullName => $"{ FirstName } { LastName }";

    }
}
