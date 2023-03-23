using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LABasicAppDocker.Pages
{
    //test
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string text = "hello world!";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var number = 0;
            var list = new List<string>();
            
        }
    }
}