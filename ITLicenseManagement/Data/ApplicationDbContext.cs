using ITLicenseManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ITLicenseManagement.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<LicenseIT> licenseITs { get; set; }

       


    }
    
}
