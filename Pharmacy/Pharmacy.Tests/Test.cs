namespace Pharmacy.Tests
{
    using AutoMapper;
    using Pharmacy.Web.Infrastructure.Mapping;

    public class Test
    {
        private static bool IsInitialaized = false;

        public static void Initialize()
        {
            if (!IsInitialaized)
            {
                Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());
                IsInitialaized = true;
            }
        }
    }
}
