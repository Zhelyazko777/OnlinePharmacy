namespace Pharmacy.Web.Areas.Admin.Models
{
    using Pharmacy.Common;
    using System.Collections.Generic;

    public class UsersWithPagesViewModel: ViewModelWithPages
    {
        public IEnumerable<UsersViewModel> Users { get; set; }
    }
}
