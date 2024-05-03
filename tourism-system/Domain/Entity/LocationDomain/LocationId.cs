using tourism_system.Domain.Abstraction;

namespace tourism_system.Domain.Entity.LocationDomain
{
    public class LocationId : ValueObjectId
    {
        protected LocationId(Guid id) : base(id)
        {
        }

        public static LocationId Create(Guid id)
        {
            return new(id);
        }

        public static LocationId CreateUnique()
        {
            return new(Guid.NewGuid());
        }
    }
}