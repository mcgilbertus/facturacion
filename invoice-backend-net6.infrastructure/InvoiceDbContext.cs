using invoice_backend_net6.domain.entities;
using Microsoft.EntityFrameworkCore;

namespace invoice_backend_net6.infrastructure;

public class InvoiceDbContext: DbContext
{
    public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        //seed data for countries
        var argentina = new Country { Id = 1, CountryName = "Argentina" };
        modelBuilder.Entity<Country>().HasData(argentina);
        //seed data for provinces
        var entreRios = new Province { Id = 1, ProvinceName = "Entre Rios", CountryId = argentina.Id };
        var santaFe = new Province { Id = 2, ProvinceName = "Santa Fe", CountryId = argentina.Id };
        modelBuilder.Entity<Province>().HasData(entreRios, santaFe);
        //seed data for cities
        modelBuilder.Entity<City>().HasData(
            new City { Id = 1, CityName = "Parana", ProvinceId = entreRios.Id },
            new City { Id = 2, CityName = "Victoria", ProvinceId = entreRios.Id },
            new City { Id = 3, CityName = "Santa Fe", ProvinceId = santaFe.Id });
    }

    // Tables
    public DbSet<Country> Countries { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<City> Cities { get; set; }
}