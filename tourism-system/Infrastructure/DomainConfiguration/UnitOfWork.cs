using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Repository;
using tourism_system.Infrastructure.Data;

namespace tourism_system.Infrastructure.DomainConfiguration
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public UnitOfWork(ApplicationDbContext applicationDbContext, IRefreshTokenRepository refreshTokenRepository, ITourismLocationRepository locationRepository, IUserLocationRepository userLocationRepository)
        {
            _applicationDbContext = applicationDbContext;
            RefreshTokenRepository = refreshTokenRepository;
            TourismLocation = locationRepository;
            UserLocationRepository = userLocationRepository;
        }

        public IRefreshTokenRepository RefreshTokenRepository { get; }
        public ITourismLocationRepository TourismLocation { get; }
        public IUserLocationRepository UserLocationRepository { get; }

        public async Task<int> save()
        {
            return await _applicationDbContext.SaveChangesAsync();
        }
    }
}
