using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Blazor_app_v3.Components.Classes;

namespace Blazor_app_v3.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Blazor_app_v3.Components.Classes.Movie> Movie { get; set; } = default!;
    }
}
