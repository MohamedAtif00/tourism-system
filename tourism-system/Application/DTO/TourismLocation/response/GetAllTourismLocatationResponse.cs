using System.Buffers.Text;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.DTO.TourismLocation.response
{
    public record GetAllTourismLocatationResponse(string id,string name, string description, TourismType tourismType, double latitude, double longitude,LocationDto nearestHotel, LocationDto nearestRestourant, LocationDto nearestMall, LocationDto nearestHospital, LocationDto nearestPharmacy, string file,BudgetDto a,BudgetDto b,BudgetDto c);
    
}
