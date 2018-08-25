namespace Pharmacy.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Pharmacy.Common;
    using Pharmacy.Services.Admin;
    using Pharmacy.Services.Admin.Models;
    using Pharmacy.Web.Areas.Admin.Models;
    using System;

    public class OrdersController: BaseAdminController
    {
        private readonly IOrdersAdminService ordersService;

        public OrdersController(IOrdersAdminService ordersService)
        {
            this.ordersService = ordersService;
        }

        public IActionResult All(int page = 1)
            => View(new OrdersViewModel
            {
                Orders = this.ordersService.All(page),
                AllPages = (int)Math.Ceiling(this.ordersService.NumOfAll() / (double)GlobalConstants.PageItems),
                CurrentPage = page < 1 ? 1 : page
            });

        public IActionResult AllUnreaded(int page = 1)
            => View(new OrdersViewModel
            {
                Orders = this.ordersService.AllUreaded(page),
                AllPages = (int) Math.Ceiling(this.ordersService.NumOfUnread() / (double)GlobalConstants.PageItems),
                CurrentPage = page
            });
        
        public OrderWithDetailsServiceModel ById(int id)
            => this.ordersService.OrderById(id);

        [HttpPost]
        public IActionResult MarkAsRead(int id)
        {
            var result = this.ordersService.MarkAsRead(id);

            if (!result)
            {
                return BadRequest();
            }

            return RedirectToAction("AllUnreaded", "Orders", new { area = "Admin" });
        }

        public int NumOfUnread()
            => this.ordersService.NumOfUnread();
    }
}
