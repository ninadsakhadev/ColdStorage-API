using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;


namespace ColdStorage_API.Models
{
    public class ColdStorageDBContext : DbContext
    {
        public ColdStorageDBContext(DbContextOptions<ColdStorageDBContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Package> Packages { get; set; }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<HallLocation> HallLocations { get; set; }
    }
    public class ColdStorageContextFactory : IDesignTimeDbContextFactory<ColdStorageDBContext>
    {
        public ColdStorageDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ColdStorageDBContext>();
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("SqlConnectionString"));

            return new ColdStorageDBContext(optionsBuilder.Options);
        }
    }
}
