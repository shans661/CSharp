using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DatingApp.Interfaces;
using DatingDatingApp.API.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;


namespace DatingApp.Services
{
    
    public class TokenService : ITokenService
    {
        //Jwt is the symmetric encryption service
        //Uses one key for encoding and decoding
        //Token key is private
        private readonly SymmetricSecurityKey m_Key;
        public TokenService(IConfiguration config)
        {
            //Gets the token key from appsettings.development.json
            m_Key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(config["TokenKey"]));
        }

        public string CreateToken(User appUser)
        {
            //Jwt has 3 sections
            //1. Header holds alg, type
            //2. Payload - nameid , role, expiry etc
            //3. Signature - encoded data

            //Payload creation
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.NameId, appUser.UserName)
            };

            var creds = new SigningCredentials(m_Key, SecurityAlgorithms.HmacSha512Signature);

            //Token descriptor
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            //Token handler
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
           
        }
    }
}