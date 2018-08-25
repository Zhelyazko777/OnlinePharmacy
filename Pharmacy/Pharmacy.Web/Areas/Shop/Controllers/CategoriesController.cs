namespace Pharmacy.Web.Areas.Shop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Pharmacy.Services.Shop;
    using Pharmacy.Services.Shop.Models;
    using System.Collections.Generic;

    [Area("Shop")]
    public class CategoriesController
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        //public IEnumerable<CategoriesServiceModel> Chiled(int id)
        //    => this.categoriesService.Children(id);
    }
}
