namespace Pharmacy.Tests.Services
{
    using Microsoft.EntityFrameworkCore;
    using Pharmacy.Data;
    using System;

    public class BaseTest
    {
        public PharmacyDbContext InitializeDb()
        {
            var dbOptions = new DbContextOptionsBuilder<PharmacyDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new PharmacyDbContext(dbOptions);
        }
    }
}
