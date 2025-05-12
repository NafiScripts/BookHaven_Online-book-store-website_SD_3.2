using Microsoft.AspNetCore.Identity;
using BookShoppingCartMvcUI.Constants;
using System;

namespace BookShoppingCartMvcUI.Data
{
    public class DbSeeder
    {
        // This class provides a method for seeding default data into the database.

        // Method to seed default data, including roles and an admin user.
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            // Obtain instances of the UserManager and RoleManager services.
            var userMgr = service.GetService<UserManager<IdentityUser>>();
            var roleMgr = service.GetService<RoleManager<IdentityRole>>();

            // Adding roles to the database (Admin and User).
            await roleMgr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleMgr.CreateAsync(new IdentityRole(Roles.User.ToString()));

            // Creating an admin user with default credentials.

            // Define admin user details.
            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };

            // Check if admin user already exists in the database.
            var userInDb = await userMgr.FindByEmailAsync(admin.Email);
            if (userInDb is null)
            {
                // If the admin user doesn't exist, create the user with a password and assign the Admin role.
                await userMgr.CreateAsync(admin, "Admin@123");
                await userMgr.AddToRoleAsync(admin, Roles.Admin.ToString());
            }
        }
    }
}
