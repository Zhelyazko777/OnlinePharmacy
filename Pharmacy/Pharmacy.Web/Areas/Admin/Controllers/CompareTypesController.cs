namespace Pharmacy.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Pharmacy.Common;
    using Pharmacy.Models;
    using Pharmacy.Services.Admin;
    using Pharmacy.Services.Admin.Models;
    using Pharmacy.Web.Areas.Admin.Models;
    using Pharmacy.Web.Areas.DrugComperator.Models;
    using System.Collections.Generic;
    using System;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;

    public class CompareTypesController: BaseAdminController
    {
        private readonly ICompareTypesAdminService compareTypesAdminService;

        public CompareTypesController(ICompareTypesAdminService compareTypesAdminService)
        {   
            this.compareTypesAdminService = compareTypesAdminService;
        }

        public IActionResult All(int page = 1)
            => View(new DrugIngredientsViemModel
            {
                DrugIngredients = this.compareTypesAdminService.All(page < 1 ? 1 : page),
                AllPages = (int)Math.Ceiling(this.compareTypesAdminService.NumOfIngredients() / (double)GlobalConstants.PageItems),
                CurrentPage = page
            });

        public IEnumerable<TypesServiceModel> AllForAjax()
            => this.compareTypesAdminService.AllWithoutPages();

        [HttpPost]
        public IActionResult Add([FromBody][Required] string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            this.compareTypesAdminService.Add(name);
            return Ok();
        }

        //[HttpGet]
        //public IActionResult AddCross([FromRoute] int id)
        //    => View(new ComparableDrugFormModel
        //    {
        //        BaseDrugId = id,
        //        DrugTypes = this
        //        .compareTypesAdminService
        //        .All()
        //        .Select(dt => new SelectListItem
        //        {
        //            Text = dt.Name,
        //            Value = dt.Id.ToString()
        //        })
        //    });

        [HttpPost]
        public IActionResult AddCross(ComparableDrugFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = this
                .compareTypesAdminService
                .AddCross(model.Id, model.ComparableDrugId);

            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpPost]
        public void Delete(int id)
            => this.compareTypesAdminService.Delete(id);
            

        [HttpGet]
        public DrugIngredient Update(int id)
            => this.compareTypesAdminService.GetIngridient(id);

        [HttpPost]
        public IActionResult Update(int id, [FromBody][Required] string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = this.compareTypesAdminService.Update(id, name);

            if (result)
            {
                return Ok();
            }

            return BadRequest();
        } 

        public IEnumerable<string> CrossIngredients(int id)
            => this.compareTypesAdminService.CrossIngredientsById(id);
    }
}
