using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TshepoSibiya.Models
{
    public class ExperienceModel
    {
        public int ID { get; set; }
        public string Technology { get; set; }
        public string Description { get; set; }
        public int SkillPercentage { get; set; }
        public int Years { get; set; }
    }
}