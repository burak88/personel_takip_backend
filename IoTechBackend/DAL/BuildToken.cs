using Entity.Concrete;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IoTechBackend.DAL
{
    public class BuildToken
    {
        public string CreateToken(User user)
        {
            var bytes = Encoding.UTF8.GetBytes("personeltakipuygulaması");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("Name", user.Name ),
                new Claim("Surname", user.Surname ),
                new Claim("Id", user.UserId.ToString())
    };

            var token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost",
               claims,
               expires: DateTime.Now.AddMinutes(120),
               signingCredentials: credentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(token);








        }
    }
}
