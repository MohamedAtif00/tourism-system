using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tourism_system.Domain.Entity.TourismLocationDomain;
using tourism_system.Domain.Entity.UserDomain;

namespace tourism_system.Infrastructure.DomainConfiguration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<UserApplication>
    {
        public void Configure(EntityTypeBuilder<UserApplication> builder)
        {

            builder.Property(t => t.FavoritType)
            .IsRequired()
            .HasConversion(
                v => v.ToString(),
                v => (TourismType)Enum.Parse(typeof(TourismType), v));
        }
    }
}
