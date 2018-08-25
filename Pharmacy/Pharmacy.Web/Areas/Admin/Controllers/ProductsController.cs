namespace Pharmacy.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Pharmacy.Services;
    using Pharmacy.Services.Admin;
    using Pharmacy.Services.Shop;
    using Pharmacy.Web.Areas.Admin.Models;
    using Pharmacy.Web.Controllers;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    
    public class ProductsController: BaseAdminController
    {
        private readonly ISanitizerService sanitizerService;
        private readonly IProductsAdminService productsAdminService;
        private readonly ICategoriesAdminService categoriesService;
        private readonly IFileService fileService;
        private readonly IProductsService productsService;

        public ProductsController(ICategoriesAdminService categoriesService,
                                IProductsAdminService productsAdminService,
                                ISanitizerService sanitizerService,
                                IFileService fileService,
                                IProductsService productsService)
        {
            this.productsService = productsService;
            this.fileService = fileService;
            this.sanitizerService = sanitizerService;
            this.categoriesService = categoriesService;
            this.productsAdminService = productsAdminService;
        }

        [HttpGet]
        public IActionResult Add()
            => View(new ProductFormModel
            {
                Categories = this.categoriesService.GetCategoriesDropDown().Select(c => new SelectListItem
                {
                    Text = c.Text,
                    Value = c.Value.ToString()
                }),
                DrugTypes = this.productsAdminService.GetDrugTypeDropDown().Select(dt => new SelectListItem
                {
                    Text = dt.Text,
                    Value = dt.Value.ToString()
                })
            });

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var sanitizedDescription = this.sanitizerService.Sanitize(model.Description);
            
            var path = Path.Combine("\\..\\", Directory.GetCurrentDirectory(), "wwwroot\\ProductsImages\\");
            var imageName = await this.fileService.SaveFileAsync(model.Name, model.Image, path);

            var result = await this
                .productsAdminService
                .AddAsync(model.Name, model.CategoryId, sanitizedDescription, model.Price, model.Barcode, model.DrugTypeId, model.Image, imageName);

            if (!result)
            {
                return View(model);
            }

            return RedirectToAction(nameof(HomeController.Index), "Home", new { Area = "" });
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = this.productsAdminService.GetProduct(id);

            return View(new ProductFormModel
            {
                Name = product.Name,
                Barcode = product.Barcode,
                Price = product.Price,
                Description = product.Description,
                Categories = this.categoriesService
                    .GetCategoriesDropDown()
                    .Select(c => new SelectListItem
                    {
                        Text = c.Text,
                        Value = c.Value.ToString(),
                        Selected = true
                    }),
                CategoryId = product.Categories.Select(c => c.CategoryId).FirstOrDefault(),
                DrugTypes = this.productsAdminService.GetDrugTypeDropDown().Select(dt => new SelectListItem
                {
                    Text = dt.Text,
                    Value = dt.Value.ToString(),
                    Selected = true
                }),
                DrugTypeId = product.DrugTypeId
            });
        }

        [HttpPost]
        public IActionResult Update(int id, ProductFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            
            var sanitizedDescription = this.sanitizerService.Sanitize(model.Description);
            
            
            var updatedProductName = this.productsAdminService.Update(id, model.Name, model.CategoryId, sanitizedDescription, model.Price, model.Barcode, model.DrugTypeId);
            
            return RedirectToAction("All", "Products", new { Area = "Shop" });
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var deletedProductName = this.productsAdminService.DeleteProduct(id);
            if (deletedProductName == "")
            {
                return NotFound();
            }
            var path = Path.Combine("\\..\\", Directory.GetCurrentDirectory(), "wwwroot\\ProductsImages\\", deletedProductName + ".jpg");
            this.fileService.Delete(path);

            return RedirectToAction("All", "Products", new { Area = "Shop" });
        }

        //public IActionResult All(int page = 1)
        //    => View(this.productsService.All(page));
        
    }
}
