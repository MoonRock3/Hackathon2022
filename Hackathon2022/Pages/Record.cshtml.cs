using Hackathon2022.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hackathon2022.Pages
{
    public class RecordModel : PageModel
    {
		readonly ApplicationContext context;
        public List<Specialty> Specialties { get; private set; } = new();
		public RecordModel(ApplicationContext context)
		{
            this.context = context;
		}
        public void OnGet()
        {
            Specialties = context.Specialties.ToList();
        }
    }
}
