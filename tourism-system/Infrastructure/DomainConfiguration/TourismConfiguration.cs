using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Infrastructure.DomainConfiguration
{
    
    public class TourismConfiguration : IEntityTypeConfiguration<TourismLocation>
    {
        public void Configure(EntityTypeBuilder<TourismLocation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasConversion(x => x.value, x => TourismLocationId.Create(x));

            builder.Property(t => t.TourismType)
            .IsRequired()
            .HasConversion(
                v => v.ToString(),
                v => (TourismType)Enum.Parse(typeof(TourismType), v));

            builder.HasMany(x => x.userTourismLocations).WithOne(x => x.TourismLocation);

            //builder.Property(x => x.NearestRestourant)
            //    .HasConversion(
            //        v => new { Description = v.Description, Longitude = v.Longitude, Latitude = v.Latitude },
            //        v => Location.Create(v.Description, v.Latitude, v.Longitude))
            //    .HasColumnName("NearestRestourant");

            //builder.Property(x => x.NearestMall)
            //    .HasConversion(
            //        v => new { Description = v.Description, Longitude = v.Longitude, Latitude = v.Latitude },
            //        v => Location.Create(v.Description, v.Latitude, v.Longitude))
            //    .HasColumnName("NearestMall");

            //builder.Property(x => x.NearestHospital)
            //    .HasConversion(
            //        v => new { Description = v.Description, Longitude = v.Longitude, Latitude = v.Latitude },
            //        v => Location.Create(v.Description, v.Latitude, v.Longitude))
            //    .HasColumnName("NearestHospital");

            //builder.Property(x => x.NearestPharmacy)
            //    .HasConversion(
            //        v => new { Description = v.Description, Longitude = v.Longitude, Latitude = v.Latitude },
            //        v => Location.Create(v.Description, v.Latitude, v.Longitude))
            //    .HasColumnName("NearestPharmacy");


            //builder.Property(x => x.NearestRestourant)
            //    .HasConversion(
            //        v => ConvertLocationToString(v),
            //        v => ConvertStringToLocation(v))
            //    .HasColumnName("NearestRestourant"); 

            //builder.Property(x => x.NearestMall)
            //    .HasConversion(
            //        v => ConvertLocationToString(v),
            //        v => ConvertStringToLocation(v));

            //builder.Property(x => x.NearestHospital)
            //    .HasConversion(
            //        v => ConvertLocationToString(v),
            //        v => ConvertStringToLocation(v));

            //builder.Property(x => x.NearestPharmacy)
            //    .HasConversion(
            //        v => ConvertLocationToString(v),
            //        v => ConvertStringToLocation(v));

            builder.ComplexProperty(x => x.NearestHotel);
            builder.ComplexProperty(x => x.NearestRestourant);
            builder.ComplexProperty(x => x.NearestMall);
            builder.ComplexProperty(x => x.NearestHospital);
            builder.ComplexProperty(x => x.NearestPharmacy);
            builder.ComplexProperty(x =>x.A);
            builder.ComplexProperty(x =>x.B);
            builder.ComplexProperty(x =>x.C);

            //builder.OwnsOne<Location>(
            //        x => x.NearestMall,
            //        opt =>
            //        {
            //            opt.Property(x => x.Description).HasColumnName("NearestMallDescription");
            //            opt.Property(x => x.Latitude).HasColumnName("NearestMallLatitude");
            //            opt.Property(x => x.Longitude).HasColumnName("NearestMallLongitude");
            //        }
            //    );

            //builder.OwnsOne<Location>(
            //    x => x.NearestHospital,
            //    opt =>
            //    {
            //        opt.Property(x => x.Description).HasColumnName("NearestHospitalDescription");
            //        opt.Property(x => x.Latitude).HasColumnName("NearestHospitalLatitude");
            //        opt.Property(x => x.Longitude).HasColumnName("NearestHospitalLongitude");
            //    }
            //);


            //builder.OwnsOne<Location>(
            //    x => x.NearestPharmacy,
            //    opt =>
            //    {
            //        opt.Property(x => x.Description).HasColumnName("NearestPharmacyDescription");
            //        opt.Property(x => x.Latitude).HasColumnName("NearestPharmacyLatitude");
            //        opt.Property(x => x.Longitude).HasColumnName("NearestPharmacyLongitude");
            //    }
            //);



            //builder.OwnsOne<Location>("_nearestMall", opt =>
            //{

            //});
            //builder.OwnsOne<Location>("_nearestHospital", opt =>
            //{

            //});
            //builder.OwnsOne<Location>("_nearestPharmacy", opt =>
            //{

            //});

        }

        private static string ConvertLocationToString(Location location)
        {
            return $"{location.Description},{location.Latitude},{location.Longitude}";
        }

        private static Location ConvertStringToLocation(string value)
        {
            var values = value.Split(',', 3);
            return Location.Create(values[0], double.Parse(values[1]), double.Parse(values[2]));
        }
    }
}
