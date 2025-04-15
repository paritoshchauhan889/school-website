using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using School_website.Models;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
}
