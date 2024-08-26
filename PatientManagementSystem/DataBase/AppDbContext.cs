using Microsoft.EntityFrameworkCore;
using PatientManagementSystem.Components.Model;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<AppointmentInformations> AppointmentsInformations { get; set; }
}
