using Manual.Testers.Api.Host.Models.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Manual.Testers.Api.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("Register")]
        public async Task Register(UserData model)
        {
            RegistrationStorage.AddUser(model);
        }

        [HttpPost]
        [Route("Login")]
        public async Task Login(UserData user)
        {
            await Authenticate(user); // аутентификация
        }

        [HttpPost]
        [Route("Logout")]
        public async Task Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        private async Task Authenticate(UserData user)
        {
            if (!RegistrationStorage.IsRegistrated(user))
                throw new InvalidOperationException("You don't have registration");

            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }


    }
}
