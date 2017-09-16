using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TshepoSibiya.Models;

namespace TshepoSibiya.Context
{
    public class ProfileContext : DbContext
    {
        public DbSet<EmailMessage> Messages { get; set; }

        public DbSet<ProfileModel> ProfileModels { get; set; }
        public DbSet<ExperienceModel> Contents { get; set; }
    }
}