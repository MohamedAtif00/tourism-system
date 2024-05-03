using Microsoft.AspNetCore.Identity;
using tourism_system.Domain.Entity.TourismLocationDomain;
using tourism_system.Domain.Entity.UserTourismLocationDomain;

namespace tourism_system.Domain.Entity.UserDomain
{
    public class UserApplication : IdentityUser<Guid>
    {
        public TourismType FavoritType { get; set; }

    }
}
