namespace Pharmacy.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Pharmacy.Services.Admin;
    using Pharmacy.Services.Admin.Models;
    using Pharmacy.Web.Areas.Admin.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class CategoriesController: BaseAdminController
    {
        private readonly ICategoriesAdminService categoriesService;

        public CategoriesController(ICategoriesAdminService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Top()
            => View(this.categoriesService.Top());

        public IEnumerable<CategoriesAdminServiceModel> Children(int id)
            => this.categoriesService.Children(id);

        public IActionResult AddChiled(int id, [FromBody][Required] int chiledId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var success = this.categoriesService.AddChiled(id, chiledId);

            if (!success)
            {
                return BadRequest();
            }

            return Ok();
        }

        //Returns only categories without children 
        public IEnumerable<CategoriesDropDownModel> CategoriesDropDown()
            => this.categoriesService.GetCategoriesDropDown();

        [HttpPost]
        public IActionResult Add([FromBody][Required] string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var succsess = this.categoriesService.Add(name);

            if (!succsess)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
