using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tourism_system.Domain.Entity.TourismLocationDomain;
using tourism_system.Domain.Entity.UserTourismLocationDomain;

namespace tourism_system.Infrastructure.DomainConfiguration
{
    public class UserTourismEntityTypeConfiguration : IEntityTypeConfiguration<UserTourismLocation>
    {
        public void Configure(EntityTypeBuilder<UserTourismLocation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasConversion(x =>x.value,x =>UserTourismLocationId.Create(x));

            builder.Property(x => x.TourismLocationId).HasConversion(x => x.value, x => TourismLocationId.Create(x));

            builder.HasOne(x => x.TourismLocation).WithMany(x =>x.userTourismLocations);
            //builder.HasOne(x => x.IdentityUser).WithMany(x =>x.tourismLocations);
        }
    }
}
