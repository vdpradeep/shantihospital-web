using Microsoft.EntityFrameworkCore;

namespace ShantiHospitalWeb.Models
{
    public class ShantiDbContext : DbContext
    {
        public ShantiDbContext(DbContextOptions<ShantiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
