using tourism_system.Domain.Abstraction;

namespace tourism_system.Domain.Entity.LocationDomain
{
    public class Location : Entity<LocationId>
    {
        public Location(LocationId id) : base(id)
        {
        }

        public string Name { get; private set; }
        public string Address { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public static Location Create()
        {
            return new(LocationId.CreateUnique());
        }


    }
}
