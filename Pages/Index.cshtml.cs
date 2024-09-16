using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureDeploy.Pages;

public class IndexModel : PageModel
{
    private readonly IConfiguration _configuration;

    public IndexModel(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string? Message { get; private set; }

    public void OnGet()
    {
        Message = _configuration["MESSAGE"] ?? "TestLocal";
    }
}
