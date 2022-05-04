using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebSitePortifolio.Pages
{
    public class CurriculumModel : PageModel
    {
        private readonly ILogger<CurriculumModel> _logger;

        public CurriculumModel(ILogger<CurriculumModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}