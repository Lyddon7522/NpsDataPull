namespace NpsDataPull.Infrastructure;
using Microsoft.EntityFrameworkCore;
using NpsDataPull.Domain.Models;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<NationalPark> NationalParks { get; set; }
}