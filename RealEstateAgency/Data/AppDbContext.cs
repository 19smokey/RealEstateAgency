using Microsoft.EntityFrameworkCore;
using RealEstateAgency.Models;

namespace RealEstateAgency.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Owner> Owners => Set<Owner>();
        public DbSet<Agent> Agents => Set<Agent>();
        public DbSet<City> Cities => Set<City>();
        public DbSet<PropertyType> PropertyTypes => Set<PropertyType>();
        public DbSet<Property> Properties => Set<Property>();
        public DbSet<Deal> Deals => Set<Deal>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=agency.db");
    }
}