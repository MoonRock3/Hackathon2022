using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hackathon2022.Pages
{
    public class QuestionModel : PageModel
    {
        public static uint Counter { get; private set; } = 0;
		public void OnGet()
        {
            Counter++;
        }
    }
}
