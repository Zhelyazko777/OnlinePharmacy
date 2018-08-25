namespace Pharmacy.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static Pharmacy.Common.GlobalConstants;

    [Area("Admin")]
    [Authorize(Roles = RoleAdmin + ", " + RoleEditor)]
    public class BaseAdminController: Controller
    {
    }
}
