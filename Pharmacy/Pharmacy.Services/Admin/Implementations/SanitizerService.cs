namespace Pharmacy.Services.Admin.Implementations
{
    using Ganss.XSS;

    public class SanitizerService : ISanitizerService, IService
    {
        private readonly HtmlSanitizer sanitizer;

        public SanitizerService()
        {
            this.sanitizer = new HtmlSanitizer();
        }

        public string Sanitize(string html)
            => this.sanitizer.Sanitize(html);
    }
}
