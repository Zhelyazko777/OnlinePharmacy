namespace Pharmacy.Web.Areas.Shop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Pharmacy.Common;
    using Pharmacy.Services.Shop;
    using Pharmacy.Web.Areas.Shop.Models;
    using System;

    [Area("Shop")]
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;
        private readonly ICategoriesService categoriesService;

        public ProductsController(ICategoriesService categoriesService, IProductsService productsService)
        {
            this.categoriesService = categoriesService;
            this.productsService = productsService;
        }

        public IActionResult All(int page = 1)
            => View(new ProductsViewModel
            {
                Products = this
                .productsService
                .All(page < 1 ? 1 : page),
                Categories = this
                .categoriesService
                .All(),
                CurrentPage = page,
                AllPages = (int)Math.Ceiling(this.productsService.NumOfProducts() / (double)GlobalConstants.PageItems)
            });

        public IActionResult ByCategory(int id, int page = 1)
        {
            if (!this.categoriesService.IsCatgoryExists(id))
            {
                return NotFound();
            }

            return View(new ProductsViewModel
            {
                Categories = this
                   .categoriesService
                   .All(),
                Products = this
                   .productsService
                   .ByCategory(id, page < 1 ? 1 : page),
                AllPages = (int)Math.Ceiling(this.productsService.NumOfProductsInCategory(id) / (double)GlobalConstants.PageItems),
                CurrentPage = page
            });
        } 

        public IActionResult ById(int id)
        {
            var product = this.productsService.ById(id);
            if (CustomValidator.CheckIfObjectNull(product))
            {
                return NotFound();
            }

           return View(new ProductsWithDetailsViewModel
            {
                Categories = this.categoriesService.All(),
                Product = product
            });
        }
    }
}
