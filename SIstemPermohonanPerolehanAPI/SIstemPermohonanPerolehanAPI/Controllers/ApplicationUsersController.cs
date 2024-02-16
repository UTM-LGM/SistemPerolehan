using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIstemPermohonanPerolehanAPI.IRepository;
using SIstemPermohonanPerolehanAPI.Model;

namespace SIstemPermohonanPerolehanAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApplicationUsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public ApplicationUsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("{username}")]
        public async Task<IActionResult> GetUser(string username)
        {
            var user = await _userRepository.GetUserByUsername(username);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IdentityResult> Register(User user)
        {
            var registerUser = await _userRepository.RegisterUser(user);
            return registerUser;
        }

        [HttpPost]
        public async Task<IActionResult> Login (Login login)
        {
            var token = await _userRepository.LoginUser(login);
            if (token != null)
            {
                return Ok(new { token });
            }
            else
            {
                return BadRequest(new { message = "Email or Password is incorrect" });
            }
        }

    }
}
