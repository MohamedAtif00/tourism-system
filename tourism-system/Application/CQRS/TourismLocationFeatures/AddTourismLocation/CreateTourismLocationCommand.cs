using MediatR;
using tourism_system.Application.Abstraction;
using tourism_system.Application.DTO.TourismLocation;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.AddTourismLocation
{
    public record CreateTourismLocationCommand(string name, string description, TourismType tourismType, double latitude, double longitude, LocationDto nearestHotel,LocationDto nearestRestourant, LocationDto nearestMall, LocationDto nearestHospital, LocationDto nearestPharmacy,IFormFile file, BudgetDto a, BudgetDto b, BudgetDto c) : ICommand<TourismLocation>;


}
