using tourism_system.Domain.Abstraction;

namespace tourism_system.Domain.Entity.RefreshTokenDomain
{
    public class RefreshTokenId : ValueObjectId
    {
        protected RefreshTokenId(Guid id) : base(id)
        {
        }

        public static RefreshTokenId Create(Guid id)
        {
            return new(id);
        }

        public static RefreshTokenId CreateUnique()
        {
            return new(Guid.NewGuid());
        }
    }
}