using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.UserTourismLocationDomain;

namespace tourism_system.Domain.Repository
{
    public interface IUserLocationRepository : IGenericRepository<UserTourismLocation,UserTourismLocationId>
    {
    }
}
