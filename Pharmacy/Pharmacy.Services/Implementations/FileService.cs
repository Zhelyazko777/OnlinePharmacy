namespace Pharmacy.Services.Implementations
{
    using Microsoft.AspNetCore.Http;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    public class FileService : IFileService
    {
        public async Task<string> SaveFileAsync(string name, IFormFile file, string path)
        {
            var extention = file.FileName.Split('.').ToArray()[1];
            var fileName = name + "." + extention;

            var finalPath = Path.Combine(path, fileName);

            using (var fileStream = new FileStream(finalPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            };

            return fileName;
        }

        public void Delete(string path)
        {
            File.Delete(path);
        }
    }
}
