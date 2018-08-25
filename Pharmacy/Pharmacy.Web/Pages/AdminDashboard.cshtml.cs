namespace Pharmacy.Web.Pages
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Pharmacy.Common;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin;
    using System.Linq;
    
    [Authorize(Roles = GlobalConstants.RoleAdmin + ", " +  GlobalConstants.RoleEditor)]
    public class AdminDashboardModel : PageModel
    {
        private readonly IOrdersAdminService ordersAdminService;
        private readonly UserManager<User> userManager;

        public AdminDashboardModel(IOrdersAdminService ordersAdminService, UserManager<User> userManager)
        {
            this.ordersAdminService = ordersAdminService;
            this.userManager = userManager;
        }

        public DashboardInfoModel DashboardInfo { get; set; }

        public class DashboardInfoModel
        {
            public int NumOfAllOrders { get; set; }

            public int NumOfUsers { get; set; }
        }

        public IActionResult OnGet()
        {
            this.DashboardInfo = new DashboardInfoModel
            {
                NumOfAllOrders = this.ordersAdminService.NumOfAll(),
                NumOfUsers = this.userManager.Users.Count()
            };

            return Page();
        }
    }
}