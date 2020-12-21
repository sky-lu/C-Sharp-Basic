using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using SchoolManagement.Models;

[assembly: OwinStartupAttribute(typeof(SchoolManagement.Startup))]
namespace SchoolManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        public void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                var user = new ApplicationUser
                {
                    UserName = "admin",
                    Email = "admin@schmng.com"
                };

                var password = "password";

                var usr = userManager.Create(user, password);
                if (usr.Succeeded)
                {
                    var result = userManager.AddToRole(user.Id, "Admin");
                }

            }
        }
    }
}
