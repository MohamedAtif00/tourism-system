using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using tourism_system.Application.Abstraction;
using tourism_system.Application.DTO.Authentication.AllowAccess;
using tourism_system.Application.DTO.Authentication.Login.Request;
using tourism_system.Application.DTO.Authentication.Register.Request;
using tourism_system.Domain.Entity.TourismLocationDomain;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tourism_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly UserManager<IdentityUser<Guid>> _userManager;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        // GET: api/<AuthenticationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AuthenticationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuthenticationController>
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromForm] RegisterRequest request )
        {
            var result = await _authenticationService.Register(request.username, request.email, request.password, "User",request.TourismType);

            return Ok(result);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await _authenticationService.Login(request.username, request.password, "User");

            return Ok(result);
        }

        [HttpPost("LoginAdmin")]
        public async Task<IActionResult> LoginAdmin([FromBody] LoginRequest request)
        {
            var result = await _authenticationService.Login(request.username, request.password, "Admin");

            return Ok(result);
        }
        // PUT api/<AuthenticationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthenticationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("AllowAccess/{token}")]
        public async Task<IActionResult> AllowAccess(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

            var claims = jsonToken.Claims;

            var claimIdenity = new ClaimsIdentity(jsonToken.Claims);
            var principle = new ClaimsPrincipal(claimIdenity);
            string userid = claims.FirstOrDefault(x => x.Type == "userid").Value;
            string username = claims.FirstOrDefault(x => x.Type == "username").Value;
            string email = claims.FirstOrDefault(x => x.Type == "email").Value;
            string role = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role).Value;
            int stringType = Convert.ToUInt16(claims.FirstOrDefault(x => x.Type == "Type").Value);

            var response = new AllowAccessResponse(userid, username, role, email, token, stringType);

            return Ok(response);
        }

        [HttpGet("CheckUsername/{username}")]
        public async Task<IActionResult> CheckUsername(string username)
        {
            var result = _userManager.FindByNameAsync(username).Result;

            return Ok(result != null ? true : false);
        }

    }
}

