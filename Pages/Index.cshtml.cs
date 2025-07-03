using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_pages.Pages;

public class IndexModel : PageModel
{
    public bool showMessage = true;
    public string[] OtherProjectTypes = ["MVC", "Blazor", "Web Apis"];

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
