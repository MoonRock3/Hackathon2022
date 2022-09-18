using Microsoft.EntityFrameworkCore;

namespace Hackathon2022.Models
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Specialty> Specialties { get; set; } = null!;
		public DbSet<Doctor> Doctors { get; set; } = null!;
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
	}
}
