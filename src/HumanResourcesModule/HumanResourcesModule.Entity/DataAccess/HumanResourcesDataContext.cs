using HumanResourcesModule.Entity.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HumanResourcesModule.Entity.DataAccess;

public class HumanResourcesDataContext : DbContext
{

    private readonly IConfiguration _configuration;

    public HumanResourcesDataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Default"));
    }

    public DbSet<Personal> Personal { get; set; }

    public DbSet<Adress> Adress { get; set; }

    public DbSet<City> City { get; set; }

    public DbSet<Country> Country { get; set; }



}