namespace Pharmacy.Services.Admin.Implementations
{
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Pharmacy.Models;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Pharmacy.Data;
    using System;

    public class UserManagmentService : IUserManagmentService, IService
    {
        private readonly PharmacyDbContext db;

        private readonly RoleManager<IdentityRole> roleManager;

        public UserManagmentService(PharmacyDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            this.db = db;
        }
    }
}
