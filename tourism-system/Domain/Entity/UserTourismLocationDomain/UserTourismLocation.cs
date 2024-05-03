using Microsoft.AspNetCore.Identity;
using tourism_system.Domain.Abstraction;
using tourism_system.Domain.Entity.TourismLocationDomain;
using tourism_system.Domain.Entity.UserDomain;

namespace tourism_system.Domain.Entity.UserTourismLocationDomain
{
    public class UserTourismLocation : Entity<UserTourismLocationId>
    {
        public UserTourismLocation(UserTourismLocationId id, Guid userId, TourismLocationId tourismLocationId) : base(id)
        {
            this.userId = userId;
            TourismLocationId = tourismLocationId;
        }

        public Guid userId { get;private set; }

        public TourismLocation TourismLocation { get; private set; }
        public TourismLocationId TourismLocationId { get; private set; }

        public int? VisitingNumber { get; private set; } = 1;


        public static UserTourismLocation Create(Guid userId, TourismLocationId tourismLocationId)
        {
            return new(UserTourismLocationId.CreateUnique(),userId,tourismLocationId);
        }

        public void AddVisite()
        {
            VisitingNumber++;
        }
    }
}
