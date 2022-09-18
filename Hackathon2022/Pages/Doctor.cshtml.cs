using Hackathon2022.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hackathon2022.Pages
{
    public class DoctorModel : PageModel
    {
        readonly ApplicationContext context;
        public List<Doctor> Doctors { get; private set; } = new();
		public DoctorModel(ApplicationContext context)
		{
            this.context = context;
		}
		public void OnGet(int id)
        {
            Doctors = context.Doctors.ToList().FindAll(x => x.Specialty_Id == id);
        }
    }
}
