using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace RazorPagesWebapp.Pages
{
    public class IndexModel(
        IFeatureManager _featureManager,
        IConfiguration _config,
        ILogger<IndexModel> _logger) : PageModel
    {

        public string Message { get; set; }

        public async Task OnGet()
        {
            bool customGreetingEnabled = await _featureManager.IsEnabledAsync("CustomGreeting");
            if (customGreetingEnabled)
            {
                Message = _config["MyCustomConfig:IndexText"] ?? "";
                _logger.LogInformation($"message is: {Message}");
            }
        }
    }
}
