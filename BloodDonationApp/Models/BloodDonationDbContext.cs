using Microsoft.EntityFrameworkCore;

namespace BloodDonationApp.Models
{
    public class BloodDonationDbContext : DbContext
    {
        public BloodDonationDbContext(DbContextOptions<BloodDonationDbContext> options): base(options) { }
        public DbSet<DonationCandidate> DonationCandidate { get; set; }
    }
}
