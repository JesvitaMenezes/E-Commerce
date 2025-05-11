using Ecom.Repository;
using Ecom.Repository.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Ecom.Business.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _dbContext; // Inject AppDbContext

        public UserService(UserManager<User> userManager,
                                           SignInManager<User> signInManager,
                                           RoleManager<IdentityRole> roleManager,
                                           AppDbContext dbContext) // Update constructor
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        public async Task<IdentityResult> RegisterUserAsync(RegisterViewModel model)
        {
            var user = new User { UserName = model.Username, Email = model.Email, Role = "CUSTOMER" }; // Set Role to CUSTOMER
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                // Assign the user to the CUSTOMER role
                await _userManager.AddToRoleAsync(user, "CUSTOMER");
            }

            return result;
        }

        public async Task<SignInResult> LoginUserAsync(LoginViewModel model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> GetUserProfileAsync(string userId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IdentityResult> UpdateUserProfileAsync(User updatedUser)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<User>> GetCustomersAsync()
        {
            return await _dbContext.Users.Where(u => u.Role == "CUSTOMER").ToListAsync();
        }
    }
}