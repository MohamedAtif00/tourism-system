using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.RefreshTokenDomain;

namespace tourism_system.Domain.Repository
{
    public interface IRefreshTokenRepository : IGenericRepository<RefreshToken, RefreshTokenId>
    {
        Task<RefreshToken> FindByToken(string token);
        Task<RefreshToken> GetRefreshTokenByUserId(Guid userId);
    }
}
