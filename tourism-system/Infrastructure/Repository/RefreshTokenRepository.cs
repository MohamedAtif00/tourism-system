using Microsoft.EntityFrameworkCore;
using tourism_system.Domain.Entity.RefreshTokenDomain;
using tourism_system.Domain.Repository;
using tourism_system.Infrastructure.Data;
using tourism_system.Infrastructure.DomainConfiguration;

namespace tourism_system.Infrastructure.Repository
{
    public class RefreshTokenRepository : GenericRepository<RefreshToken, RefreshTokenId>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<RefreshToken> GetRefreshTokenByUserId(Guid userId)
        {
            return await _context.refreshTokens.FirstOrDefaultAsync(x => x.UserId == userId);
        }

        public async Task<RefreshToken> FindByToken(string token)
        {
            return await _context.refreshTokens.Where(x => x.Token == token).FirstOrDefaultAsync();
        }
    }

}
