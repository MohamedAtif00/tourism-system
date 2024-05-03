using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Domain.Repository
{
    public interface ITourismLocationRepository : IGenericRepository<TourismLocation, TourismLocationId>
    {
        Task<List<TourismLocation>> GetAll(TourismType tourismType);
        Task<List<TourismLocation>> GetAllwithout();
    }
}
