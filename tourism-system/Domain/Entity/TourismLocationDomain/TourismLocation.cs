using System.ComponentModel.DataAnnotations.Schema;
using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.UserTourismLocationDomain;

namespace tourism_system.Domain.Entity.TourismLocationDomain
{
    public class TourismLocation : Entity<TourismLocationId>
    {
        private readonly List<UserTourismLocation> _userTourismLocation= new();

        public TourismLocation() :base(TourismLocationId.CreateUnique())
        {
            
        }
        public TourismLocation(TourismLocationId id, string name, string description, TourismType tourismType, double latitude, double longitude,Location nearestHotel, Location nearestRestourant, Location nearestMall, Location nearestHospital, Location nearestPharmacy, byte[] image,budget a,budget b,budget c) : base(id)
        {
            Name = name;
            Description = description;
            TourismType = tourismType;
            Latitude = latitude;
            Longitude = longitude;
            NearestHotel = nearestHotel;
            NearestRestourant = nearestRestourant;
            NearestMall = nearestMall;
            NearestHospital = nearestHospital;
            NearestPharmacy = nearestPharmacy;
            A = a;
            B = b;
            C = c;
            this.image = image;
        }

        public string Name { get;private set; }
        public string Description { get; private set; }
        public TourismType TourismType { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public byte[] image { get; private set; }
        public budget A { get; private set;  }
        public budget B { get; private set;  }
        public budget C { get; private set; }
        public Location NearestHotel { get; private set; }
        public Location NearestRestourant { get; private set; }
        public Location NearestMall { get; private set; }
        public Location NearestHospital { get; private set; }
        public Location NearestPharmacy { get; private set; }


        [NotMapped]
        public IReadOnlyCollection<UserTourismLocation> userTourismLocations => _userTourismLocation;

        public static TourismLocation Create(string name, string description,TourismType tourismType, double latitude, double longitude, byte[] image,Location nearestHotel,Location nearestRestourant, Location nearestMall, Location nearestHospital, Location nearestPharmacy,budget A,budget B,budget C)
        {
            return new(TourismLocationId.CreateUnique(),name,description,tourismType,latitude,longitude,nearestHotel,nearestRestourant,nearestMall,nearestHospital,nearestPharmacy,image,A,B,C);
        }

        public void Update(string name, string description, TourismType tourismType, double latitude, double longitude)
        {
            this.Name = name;
            Description = description ?? Description;
            TourismType = tourismType;
            Latitude = latitude;
            Longitude = longitude;
        }

        public void UpdateImage(byte[] bytes)
        {
            image = bytes;
        }


    }

    public enum TourismType
    {
        Natural,
        Cultural,
        Historical,
        Adventure,
        Religious,
        Urban,
        Rural,
        Beach,
        Mountain
    }


}
