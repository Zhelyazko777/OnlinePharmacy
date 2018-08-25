namespace Pharmacy.Web.Infrastructure.Extentions
{
    using Microsoft.Extensions.DependencyInjection;
    using Pharmacy.Services;
    using System.Reflection;
    using System.Linq;

    public static class IServiceCollectionExtentions
    {
        public static void AutoloadServices(this IServiceCollection services)
        {
            Assembly
                .GetAssembly(typeof(IService))
                .GetTypes()
                .Where(t => t.IsClass && t.GetInterfaces().Any(i => i.Name == $"I{t.Name}"))
                .Select(t => new
                {
                    Interface = t.GetInterface($"I{t.Name}"),
                    Implementation = t
                })
                .ToList()
                .ForEach(s => services.AddTransient(s.Interface, s.Implementation));
        
        }
    }
}
