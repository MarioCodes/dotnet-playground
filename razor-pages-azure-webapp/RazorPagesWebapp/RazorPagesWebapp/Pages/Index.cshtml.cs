using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesWebapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _config;
        private readonly ILogger<IndexModel> _logger;

        public string Message { get; set; }

        public IndexModel(IConfiguration config, 
            ILogger<IndexModel> logger)
        {
            _config = config;
            _logger = logger;
        }

        public void OnGet()
        {
            Message = _config["MyCustomConfig:IndexText"] ?? "";
            _logger.LogInformation($"message is: {Message}");
        }
    }
}
