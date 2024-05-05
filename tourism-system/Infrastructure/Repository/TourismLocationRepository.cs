using Microsoft.EntityFrameworkCore;
using tourism_system.Domain.Entity.TourismLocationDomain;
using tourism_system.Domain.Repository;
using tourism_system.Infrastructure.Data;
using tourism_system.Infrastructure.DomainConfiguration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace tourism_system.Infrastructure.Repository
{
    public class TourismLocationRepository : GenericRepository<TourismLocation, TourismLocationId>,ITourismLocationRepository
    {
        public TourismLocationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public  async Task<List<TourismLocation>> GetAll(TourismType tourismType)
        {
            return await _context.tourismLocations.Where(x =>x.TourismType == tourismType).Take(3).ToListAsync();
            //return await _context.tourismLocations
            //.OrderBy(x => x.TourismType != tourismType)
            //.ThenBy(x => x.Name).ToListAsync();
        }
        public async Task<List<TourismLocation>> GetAllwithout()
        {
            return await _context.tourismLocations.ToListAsync();
            //return await _context.tourismLocations
            //.OrderBy(x => x.TourismType != tourismType)
            //.ThenBy(x => x.Name).ToListAsync();
        }
    }
}
