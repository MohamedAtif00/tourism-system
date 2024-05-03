using tourism_system.Domain.Abstraction;

namespace tourism_system.Domain.Entity.RefreshTokenDomain
{
    public class RefreshToken : Entity<RefreshTokenId>
    {
        public Guid UserId { get; private set; }
        public DateTime IssuedUtc { get; private set; }
        public DateTime ExpiresUtc { get; private set; }
        public string Token { get; private set; }
        public string Role { get; private set; }

        public RefreshToken(RefreshTokenId id) : base(id)
        {

        }
        protected RefreshToken(RefreshTokenId id, Guid userId, DateTime IssuedUtc, DateTime ExpiresUtc, string token, string Role) : base(id)
        {
            UserId = userId;
            this.IssuedUtc = IssuedUtc;
            this.ExpiresUtc = ExpiresUtc;
            Token = token;
            this.Role = Role;
        }

        public static RefreshToken Create(Guid userId, DateTime IssuedUtc, DateTime ExpiresUtc, string Token, string Role)
        {
            return new(RefreshTokenId.CreateUnique(), userId, IssuedUtc, ExpiresUtc, Token, Role);
        }

        public void Update(Guid userId, DateTime IssuedUtc, DateTime ExpiresUtc, string Token, string Role)
        {
            this.UserId = userId;
            this.IssuedUtc = IssuedUtc;
            this.ExpiresUtc = ExpiresUtc;
            this.Token = Token;
            this.Role = Role;
        }
    }
}
