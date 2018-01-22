using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Players
    {
        public string RegistrationID {get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}