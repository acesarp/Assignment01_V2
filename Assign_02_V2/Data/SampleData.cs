using Assign_02_V2.Controllers;
using Assign_02_V2.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign_02_V2.Data {
    public class SampleData {

        public static async Task Init(ApplicationDbContext context, UserManager<User> userManager,
                                        RoleManager<AppRole> roleManager) {
            //UserController.userManager = userManager;
            context.Database.EnsureCreated();

            string adminID1 = "";
            string adminID2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administration role";

            string role2 = "Member";
            string desc2 = "Regular user";

            string password = "P@$$w0rd";

            var y = await roleManager.RoleExistsAsync(role1);
            var x = await  roleManager.FindByNameAsync(role1);

            if(await roleManager.FindByNameAsync(role1) == null) {
                await roleManager.CreateAsync(new AppRole(role1, desc1, DateTime.Now));
            }

            if(await roleManager.FindByNameAsync(role2) == null) {
                await roleManager.CreateAsync(new AppRole(role2, desc2, DateTime.Now));
            }

            if(await userManager.FindByNameAsync("a") == null) {
                var user = new User("a", "a@a.a", 7782125454, "P@$$W0Rd", "Alonzo", "Britt", "1st", "Burnaby", "BC", "K4D8J6", "Canada") { IsAdmin = true };
                var result = await userManager.CreateAsync(user);

                if(result.Succeeded) {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminID1 = user.Id;
            }

            if(await userManager.FindByNameAsync("m") == null) {
                var user = new User("m", "m@m.m", 7782125454, "P@$$W0Rd", "Melozo", "Britt", "5st", "Victoria", "BC", "F5H1D4", "Canada") { IsAdmin = true };
                var result = await userManager.CreateAsync(user);

                if(result.Succeeded) {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                    GC.KeepAlive(userManager);
                    GC.SuppressFinalize(userManager);
                }
                adminID2 = user.Id;
            }
            GC.KeepAlive(userManager);
            GC.SuppressFinalize(userManager);
        }
    }
}