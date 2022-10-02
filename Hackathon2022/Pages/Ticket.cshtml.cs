using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hackathon2022.Pages
{
    public class TicketModel : PageModel
    {
        public string Date_Time { get; set; }
        public void OnGet(string dateTime)
        {
            Date_Time = dateTime;
        }
    }
}
