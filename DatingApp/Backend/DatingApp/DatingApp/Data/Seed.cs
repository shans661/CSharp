using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DatingApp.API;
using DatingDatingApp.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Data
{
    public class Seed
    {
        public static async Task SeedUsers(DataBaseContext context)
        {
            if(await context.User.AnyAsync())
            {
                return;
            }

            var userDataJson = await File.ReadAllTextAsync("Data/UserSeedData.json");
            var users = JsonSerializer.Deserialize<List<AppUser>>(userDataJson);

            foreach(var user in users)
            {
                using var hmac = new HMACSHA512();
                user.UserName = user.UserName.ToLower();
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF32.GetBytes("shiva123"));
                user.PasswordSalt = hmac.Key;

                context.User.Add(user);
            }

            await context.SaveChangesAsync();
        }
    }
}