using DataAccess;
using Entity.Concrete;
using IoTechBackend.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Entity.DTOs;

namespace IoTechBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        //private IConfiguration _config;

        //public HomeController(IConfiguration config)
        //{
        //    _config = config;
        //}

        AppDbContext context = new AppDbContext();


        [HttpPost("action")]
        public IActionResult Login(User user)
        {
            IActionResult response = Unauthorized();
            var data = context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            if (data != null)
            {
                var tokenString = new BuildToken().CreateToken(data);
                response = Ok(new { token = tokenString });

            }
            return response;

        }

    }
}
