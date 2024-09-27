namespace NpsDataPull.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

public class ApplicationDbContext : DbContext
{
    public DbSet<NationalParks> NationalParks { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=NationalParks;Trusted_Connection=True;");
    }
}