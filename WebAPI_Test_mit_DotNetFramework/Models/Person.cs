using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Test_mit_DotNetFramework.Models
{
    /// <summary>
    /// Represents one specific Person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID froM SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// The users first name
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// Couldn't you guess?
        /// </summary>
        public string LastName { get; set; } = "";

    }
}