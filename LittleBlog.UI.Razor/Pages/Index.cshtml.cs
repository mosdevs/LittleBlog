using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LittleBlog.UI.Razor.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "Hello World";
        }

        public IActionResult Load()
        {
            return Page();
        }
    }
}