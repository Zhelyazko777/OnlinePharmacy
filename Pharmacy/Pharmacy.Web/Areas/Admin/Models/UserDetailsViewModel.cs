namespace Pharmacy.Web.Areas.Admin.Models
{
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;

    public class UserDetailsViewModel: IMapFrom<User>
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
