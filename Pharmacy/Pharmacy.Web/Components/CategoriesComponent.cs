namespace Pharmacy.Web.Components
{
    using Pharmacy.Services.Shop;
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesComponent: ViewComponent
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesComponent(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IViewComponentResult Invoke()
            => View(this.categoriesService.All());
        
    }
}
