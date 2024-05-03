using tourism_system.Domain.Abstraction;

namespace tourism_system.Domain.Entity.TourismLocationDomain
{
    public class Location : ValueObject
    {
        private Location(string description, double latitude, double longitude)
        {
            Description = description;
            Latitude = latitude;
            Longitude = longitude;
        }


        public string Description { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public static Location Create(string description,double latitude,double longitude)
        {
            return new(description,latitude,longitude);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Description;
            yield return Latitude;
            yield return Longitude;
        }
    }
}
