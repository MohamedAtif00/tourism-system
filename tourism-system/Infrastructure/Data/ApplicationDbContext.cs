using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using tourism_system.Domain.Entity.RefreshTokenDomain;
using tourism_system.Domain.Entity.TourismLocationDomain;
using tourism_system.Domain.Entity.UserDomain;
using tourism_system.Domain.Entity.UserTourismLocationDomain;

namespace tourism_system.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserApplication,IdentityRole<Guid>,Guid>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<TourismLocation> tourismLocations { get; set; }
        public DbSet<UserTourismLocation> userTourismLocations { get; set; }
        public DbSet<RefreshToken> refreshTokens { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

                



            base.OnModelCreating(builder);
        }

    }
}
