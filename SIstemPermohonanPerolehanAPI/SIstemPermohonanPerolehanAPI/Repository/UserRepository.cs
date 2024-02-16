using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using SIstemPermohonanPerolehanAPI.DTO;
using SIstemPermohonanPerolehanAPI.IRepository;
using SIstemPermohonanPerolehanAPI.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SIstemPermohonanPerolehanAPI.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly UserManager<ApplicationUser> _usermanager;

        public UserRepository(UserManager<ApplicationUser> userManager)
        {
           _usermanager = userManager;
        }

        public async Task<IdentityResult> RegisterUser(User user)
        {
            var applicationUser = new ApplicationUser()
            {
                UserName = user.Username,
                Email = user.Email,
            };
            var result = await _usermanager.CreateAsync(applicationUser, user.Password);
            return result;
        }

        public async Task<String> LoginUser(Login login)
        {
            var user = await _usermanager.FindByNameAsync(login.Username);
            if(user != null && await _usermanager.CheckPasswordAsync(user, login.Password))
            {
                IdentityOptions _options = new IdentityOptions();
                var tokenDesc = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("Username", login.Username.ToString()),
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890123456")), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDesc);
                var token = tokenHandler.WriteToken(securityToken);
                return token;
            }
            else
            {
                return null;
            }
        }

        public async Task<DTO_User> GetUserByUsername (string username)
        {
            var user = await _usermanager.FindByNameAsync(username);

            if(user != null)
            {
                var result = new DTO_User
                {
                    Id = user.Id,
                    Username = user.UserName
                };
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
    