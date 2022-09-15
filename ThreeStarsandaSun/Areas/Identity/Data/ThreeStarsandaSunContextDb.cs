using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThreeStarsandaSun.Areas.Identity.Data;
using ThreeStarsandaSun.Models;

namespace ThreeStarsandaSun.Areas.Identity.Data;

public class ThreeStarsandaSunContextDb : IdentityDbContext<ThreeStarsandaSunUser>
{
    public ThreeStarsandaSunContextDb(DbContextOptions<ThreeStarsandaSunContextDb> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<ThreeStarsandaSun.Models.City>? City { get; set; }

    public DbSet<ThreeStarsandaSun.Models.Restaurant>? Restaurant { get; set; }

    public DbSet<ThreeStarsandaSun.Models.Event>? Event { get; set; }

    public DbSet<ThreeStarsandaSun.Models.Store>? Store { get; set; }
}
