namespace Pharmacy.Web.Areas.Shop.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Pharmacy.Models;
    using Pharmacy.Services.Shop;
    using Pharmacy.Web.Areas.Shop.Models;
    using Pharmacy.Web.Controllers;
    using Pharmacy.Web.Infrastructure.Extentions;

    [Area("Shop")]
    public class ShoppingCartController: Controller
    {
        private readonly IShoppingCartManager shoppingCartManager;
        private readonly UserManager<User> userManager;
        private readonly IProductsService productsService;
        private readonly IFinishOrderService finishOrderService;

        public ShoppingCartController(IShoppingCartManager shoppingCartManager, IProductsService productsService, UserManager<User> userManager, IFinishOrderService finishOrderService)
        {
            this.finishOrderService = finishOrderService;
            this.userManager = userManager;
            this.productsService = productsService;
            this.shoppingCartManager = shoppingCartManager;
        }

        public IActionResult Items()
        {
            var shoppingCartId = this.HttpContext.Session.GetShoppingCartId();

            return View(new CartItemsViewModel
            {
                CartItems = this.shoppingCartManager.GetItems(shoppingCartId)
            });
        }

        [HttpPost]
        public void Add([FromRoute] int id, [FromBody] int quantity)
        {
            var shoppingCartId = this.HttpContext.Session.GetShoppingCartId();

            var product = this.productsService.GetProductInfoForCartById(id);
            product.Quantity = quantity;

            this.shoppingCartManager.AddToCart(shoppingCartId, product);
            
        }

        public IActionResult Remove([FromRoute] int id)
        {
            var shoppingCartId = this.HttpContext.Session.GetShoppingCartId();
            
            this.shoppingCartManager.RemoveFromCart(shoppingCartId, id);

            return Redirect("/Shop/ShoppingCart/Items");
        }

        [HttpPost]
        [Authorize]
        public IActionResult FinishOrder()
        {
            var shoppingCardId = this.HttpContext.Session.GetShoppingCartId();

            this
                .finishOrderService
                .FinishOrder(this.shoppingCartManager.GetItems(shoppingCardId),
                this.userManager.GetUserId(this.User));

            this
                .shoppingCartManager
                .DeleteCart(shoppingCardId);

            TempData.Add("FinishOrderMessage", "Вие успешно завършихте вашата поръчка! Може да следите нейния статус в секция история на поръчките.");

            return RedirectToAction(nameof(HomeController.Index), "Home", new { area = "" });
        }
    }
}
