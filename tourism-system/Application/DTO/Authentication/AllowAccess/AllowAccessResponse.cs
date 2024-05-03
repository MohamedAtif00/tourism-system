using tourism_system.Domain.Entity.TourismLocationDomain;

namespace tourism_system.Application.DTO.Authentication.AllowAccess
{
    public record AllowAccessResponse(string userId, string username, string role, string emai, string token,int TourismType);
}
