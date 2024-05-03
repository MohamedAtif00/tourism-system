using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.DTO.TourismLocation.request
{
    public class CreateTourismLocationRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TourismType TourismType { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public IFormFile image { get; set; }
        public BudgetDto a { get; set; }
        public BudgetDto b { get; set; }
        public BudgetDto c { get; set; }
        public LocationDto nearestHotel { get; set; }   
        public LocationDto NearestRestourant { get; set; }
        public LocationDto NearestMall { get; set; }
        public LocationDto NearestHospital { get; set; }
        public LocationDto NearestPharmacy { get; set; }
    }
}
