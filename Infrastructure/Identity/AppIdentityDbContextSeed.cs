using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Mihai",
                    Email = "runcan.mihai@gmail.com",
                    UserName = "mihai",
                    Address = new Address
                    {
                        FirstName = "Mihai",
                        LastName = "Runcan",
                        Street = "10 The street",
                        City = "New York",
                        State = "NY",
                        Zipcode = "651123"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
