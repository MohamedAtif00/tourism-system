using tourism_system.Domain.Abstraction;

namespace tourism_system.Domain.Entity.TourismLocationDomain
{
    public class TourismLocationId : ValueObjectId
    {
        protected TourismLocationId(Guid id) : base(id)
        {
        }

        public static TourismLocationId Create(Guid id)
        {
            return new(id);
        }

        public static TourismLocationId CreateUnique()
        {
            return new(Guid.NewGuid());
        }
    }
}