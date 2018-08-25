namespace Pharmacy.Web.Areas.Admin.Controllers
{
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Pharmacy.Common;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin;
    using Pharmacy.Web.Areas.Admin.Models;
    using System.Linq;
    using System.Threading.Tasks;

    using static Pharmacy.Common.GlobalConstants;

    [Area("Admin")]
    [Authorize(Roles = RoleAdmin)]
    public class UsersController: Controller
    {
        private readonly IUserManagmentService userManagmentService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;

        public UsersController(UserManager<User> userManager, IUserManagmentService userManagmentService, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.userManagmentService = userManagmentService;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var users = await this.userManager
                          .Users
                          .ProjectTo<UsersViewModel>()
                          .OrderBy(u => u.DateOfRegistration)
                          .ToListAsync();

            return View(new UsersWithPagesViewModel
            {
                Users = users,
                AllPages = (int)(this.userManager.Users.Count() / (double)PageItems),
                CurrentPage = page
            });
        }

        public UserDetailsViewModel ById(string id)
            => this
                .userManager
                .Users
                .Where(u => u.Id == id)
                .ProjectTo<UserDetailsViewModel>()
                .FirstOrDefault();

        public async Task<IActionResult> Delete(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);

            await this.userManager.DeleteAsync(user);

            return RedirectToAction(nameof(Index));
        }
    }
}
