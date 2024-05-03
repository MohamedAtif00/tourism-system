using tourism_system.Domain.Repository;

namespace tourism_system.Domain.Abstraction
{
    public interface IUnitOfWork
    {

        IRefreshTokenRepository RefreshTokenRepository { get; }
        ITourismLocationRepository TourismLocation { get; }
        IUserLocationRepository UserLocationRepository { get; }

        Task<int> save();
    }
}
