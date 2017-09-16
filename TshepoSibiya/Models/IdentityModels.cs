using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TshepoSibiya.Models;

namespace TshepoSibiya.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("ProfileContext")
        {
        }
        public DbSet<ProfileModel> profile { get; set; }
        public DbSet<ExperienceModel> Contents { get; set; }
        public DbSet<EmailMessage> Messages { get; set; }
    }
}