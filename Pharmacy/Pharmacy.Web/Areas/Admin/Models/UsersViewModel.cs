namespace Pharmacy.Web.Areas.Admin.Models
{
    using Pharmacy.Common.Mapping;
    using Pharmacy.Models;
    using System;

    public class UsersViewModel: IMapFrom<User>
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public DateTime DateOfRegistration { get; set; }
    }
}
