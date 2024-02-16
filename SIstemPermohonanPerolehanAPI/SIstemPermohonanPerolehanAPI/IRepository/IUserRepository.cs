using Microsoft.AspNetCore.Identity;
using SIstemPermohonanPerolehanAPI.DTO;
using SIstemPermohonanPerolehanAPI.Model;

namespace SIstemPermohonanPerolehanAPI.IRepository
{
    public interface IUserRepository
    {
        Task<IdentityResult> RegisterUser(User user);
        Task<String> LoginUser(Login login);
        Task<DTO_User> GetUserByUsername(string username);
    }
}
