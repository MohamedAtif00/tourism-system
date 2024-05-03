using Ardalis.Result;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using tourism_system.Application.DTO.Authentication.JwtSettings;
using tourism_system.Domain.Entity.TourismLocationDomain;
using tourism_system.Domain.Entity.UserDomain;

namespace tourism_system.Application.Abstraction
{
    public interface IAuthenticationService
    {
        Task<Result<string>> CheckUsername(string username);
        Task<Result> ConfirmEmail(string userId, string code);
        Task<string> GenerateAccessToken(ClaimsIdentity claimsIdentity);
        Task<ClaimsIdentity> GenerateClaimsIdentity(UserApplication user, string role);
        Task<string> GenerateRefreshToken(UserApplication newUser, string Token);
        Task<Result<JwtTokenDto>> Login(string username, string password, string role);
        Task<Result<JwtTokenDto>> Register(string Username, string Email, string Password, string Role,TourismType tourismType);
    }
}
