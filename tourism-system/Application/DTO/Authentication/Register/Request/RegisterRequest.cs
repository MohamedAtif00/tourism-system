using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.DTO.Authentication.Register.Request
{
    public record RegisterRequest(string email, string username, string password,TourismType TourismType);


}
