using invoice_backend_net6.domain.entities;
using Microsoft.EntityFrameworkCore;

namespace invoice_backend_net6.domain;

public class InvoiceDbContext: DbContext
{
    // Tables
    public DbSet<Country> Countries { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<City> Cities { get; set; }
}