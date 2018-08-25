namespace Pharmacy.Services
{
    using Microsoft.AspNetCore.Http;
    using System.Threading.Tasks;

    public interface IFileService: IService
    {
        Task<string> SaveFileAsync(string name, IFormFile file, string path);

        void Delete(string path);
    }
}
