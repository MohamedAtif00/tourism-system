using tourism_system.Application.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.CQRS.TourismLocationFeatures.GetAllTourismLocation
{
    public record GetAllTourismLocationQuery(TourismType TourismType ):IQuery<List<TourismLocation>>;

    public record GetAllTourismLocationWithoutQuery() : IQuery<List<TourismLocation>>;
}
