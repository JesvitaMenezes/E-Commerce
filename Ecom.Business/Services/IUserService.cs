using Ecom.Repository.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Ecom.Business.Services
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUserAsync(RegisterViewModel model); // Role is no longer passed here
        Task<SignInResult> LoginUserAsync(LoginViewModel model);
        Task<User> GetUserProfileAsync(string userId);
        Task<IdentityResult> UpdateUserProfileAsync(User updatedUser);
        Task<List<User>> GetCustomersAsync();
    }
}