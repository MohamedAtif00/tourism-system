using tourism_system.Application.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.GetSingleTourismLocation
{
    public record GetSingleTourismLocationQuery(Guid id):IQuery<TourismLocation>;
    
    
}
