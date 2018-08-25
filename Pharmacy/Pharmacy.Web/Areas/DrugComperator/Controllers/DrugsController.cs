namespace Pharmacy.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Pharmacy.Common;
    using Pharmacy.Services.Admin;
    using Pharmacy.Services.DrugComperator;
    using Pharmacy.Services.DrugComperator.Models;
    using Pharmacy.Services.Shop;
    using Pharmacy.Web.Areas.DrugComperator.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [Area("DrugComperator")]
    public class DrugsController : Controller
    {
        private readonly IDrugService drugService;
        private readonly IProductsService productsService;

        public DrugsController(IProductsService productsService, IDrugService drugService)
        {
            this.productsService = productsService;
            this.drugService = drugService;
        }

        //public IActionResult Generics(SearchDrugIngredientsFormModel model)
        //    => View(new SearchDrugIngredientsFormModel
        //    {
        //        Products = this
        //                .productsService
        //                .GetProductsDropDown()
        //                .Select(p => new SelectListItem
        //                {
        //                    Value = p.Id.ToString(),
        //                    Text = p.Name
        //                })
        //    });

        //public IActionResult Cross(SearchDrugIngredientsFormModel model)
        //    => View(new SearchDrugIngredientsFormModel
        //    {
        //        Products = this
        //                .productsService
        //                .GetProductsDropDown()
        //                .Select(p => new SelectListItem
        //                {
        //                    Value = p.Id.ToString(),
        //                    Text = p.Name
        //                })
        //    });

        public IActionResult GetGenericDrugs(int id, int page = 1)
            => View(new GenericProductsViewModel
            {
                Generics = this.drugService.GenericDrugsById(id, page < 1 ? 1 : page),
                AllPages = (int) Math.Ceiling(this.drugService.NumOfGenerics(id) / (double) GlobalConstants.PageItems),
                CurrentPage = page < 1 ? 1 : page
            });

        public IActionResult GetCrossDrugs(int id, int page = 1)
            => View(new CrossDrugsViewModel
            {
                CrossDrugs = this.drugService.CrossDrugsById(id, page < 1 ? 1 : page),
                CurrentPage = page < 1 ? 1 : page,
                AllPages = this.drugService.NumOfCross(id)
            });



    }
}
