using tourism_system.Domain.Entity.UserTourismLocationDomain;
using tourism_system.Domain.Repository;
using tourism_system.Infrastructure.Data;
using tourism_system.Infrastructure.DomainConfiguration;

namespace tourism_system.Infrastructure.Repository
{
    public class UserLocationRepository : GenericRepository<UserTourismLocation, UserTourismLocationId>,IUserLocationRepository
    {
        public UserLocationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
