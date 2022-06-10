using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebSitePortifolio.Pages
{
    public class ProjetosModel : PageModel
    {
        private readonly ILogger<ProjetosModel> _logger;

        public ProjetosModel(ILogger<ProjetosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}