using Jewelry_ShoppingCart_.Constants;
using Microsoft.AspNetCore.Identity;

namespace Jewelry_ShoppingCart_.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAdminAsync(IServiceProvider service)
        {
            // Seed Roles
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Manager.ToString()));

            // Creating Admin
            var user = new ApplicationUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                Name = "Clark2666",
                EmailConfirmed = true
            };
            var userInDb = await userManager.FindByEmailAsync(user.Email);
            if (userInDb == null)
            {
                await userManager.CreateAsync(user, "Admin@123");
                await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
            }

            // Creating Manager
            var manager = new ApplicationUser
            {
                UserName = "manager@gmail.com",
                Email = "manager@gmail.com",
                Name = "Mark",
                EmailConfirmed = true
            };
            var managerInDb = await userManager.FindByEmailAsync(manager.Email);
            if (managerInDb == null)
            {
                /* var passwordHasher = new PasswordHasher<ApplicationUser>();
                 var hashedPassword = passwordHasher.HashPassword(manager, "Manager@123");
                 manager.PasswordHash = hashedPassword;

                 await userManager.CreateAsync(manager);
                 await userManager.AddToRoleAsync(manager, Roles.Manager.ToString());*/
                await userManager.CreateAsync(manager, "Manager@123");
                await userManager.AddToRoleAsync(manager, Roles.Manager.ToString());
            }
        }
    }
}
