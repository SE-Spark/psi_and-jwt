using Authentication.DAL.Entities;
using Authentication.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.DAL.Repository
{
    public class LoginRepository:ILogin
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public LoginRepository(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        

        public async Task<Response> Register(Login lg)
        {
            var userExist = await _userManager.FindByNameAsync(lg.Username);
            if (userExist != null)
            {
                return new Response { Status = "Error", Message = "Username already exist" };
            }
            ApplicationUser user = new ApplicationUser
            {
                UserName = lg.Username,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var result = _userManager.CreateAsync(user, lg.Password);
            if(!result.IsCompletedSuccessfully)
                return new Response { Status = "Error", Message = "An error occured" };
            if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
            if (!await _roleManager.RoleExistsAsync(UserRoles.User))
                 await _roleManager.CreateAsync(new IdentityRole(UserRoles.User));
            if(await _roleManager.RoleExistsAsync(UserRoles.Admin))
            {
                await _userManager.AddToRoleAsync(user, UserRoles.Admin);
            }
            return new Response{Status="Success", Message="Registration succeded"};
        }

        public Task<Response> Update(Login lg)
        {
            throw new NotImplementedException();
        }
        public Task<Response> Delete(Login lg)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Login(Login lg)
        {
            throw new NotImplementedException();
        }
    }
}
