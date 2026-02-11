using Microsoft.EntityFrameworkCore;
using HMSlite.Models;

namespace HMSlite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Patient> Patients { get; set; }
    }
}
