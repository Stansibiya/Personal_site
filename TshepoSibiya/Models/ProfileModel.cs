using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TshepoSibiya.Models
{
    public class ProfileModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public int Expereince { get; set; }
        public int Contact { get; set; }
        public int Contact_alt { get; set; }
        

    }
}