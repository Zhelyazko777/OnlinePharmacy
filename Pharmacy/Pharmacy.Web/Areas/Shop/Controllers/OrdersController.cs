namespace Pharmacy.Web.Areas.Shop.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Pharmacy.Common;
    using Pharmacy.Models;
    using Pharmacy.Services.Shop;
    using Pharmacy.Services.Shop.Models;
    using Pharmacy.Web.Areas.Shop.Models;
    using System;

    [Area("Shop")]
    public class OrdersController: Controller
    {
        private readonly IOrdersService ordersService;
        private readonly UserManager<User> userManager;

        public OrdersController(IOrdersService ordersService, UserManager<User> userManager)
        {
            this.userManager = userManager;
            this.ordersService = ordersService;
        }

        public IActionResult ByUser(int page = 1)
            => View(new OrdersHistoryViewModel
            {
                Orders = this.ordersService.ByUser(this.userManager.GetUserId(this.User), page < 1 ? 1 : page),
                AllPages = (int) Math.Ceiling((this.ordersService.Count(this.userManager.GetUserId(this.User)) / (double) GlobalConstants.PageItems)),
                CurrentPage = page < 1 ? 1 : page
            });

        public IActionResult WithDetails(int id)
        {
            var userId = this.userManager.GetUserId(this.User);
            var order = this.ordersService.OrderById(id);

            if (order.UserId != userId)
            {
                return BadRequest();
            }

            return Ok(order);
        }
    }
}
