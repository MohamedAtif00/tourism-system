using tourism_system.Domain.Abstraction;

namespace tourism_system.Domain.Entity.UserTourismLocationDomain
{
    public class UserTourismLocationId : ValueObjectId
    {
        protected UserTourismLocationId(Guid id) : base(id)
        {
        }

        public static UserTourismLocationId Create(Guid id)
        {
            return new(id);
        }

        public static UserTourismLocationId CreateUnique()
        {
            return new(Guid.NewGuid());
        }
    }
}