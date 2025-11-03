using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DisasterAlleviationFoundation.Models;

namespace DisasterAlleviationFoundation.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Disaster> Disasters { get; set; }
        public DbSet<GoodsDonation> GoodsDonations { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
    }
}
