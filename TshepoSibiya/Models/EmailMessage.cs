using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TshepoSibiya.Models
{
    public class EmailMessage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
       
        public EmailMessage()
        {
            this.DateSent = DateTime.Now;
        }
        
    }
}