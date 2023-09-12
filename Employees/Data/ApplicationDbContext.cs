using Employees.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Numerics;
using System.Reflection.Emit;

namespace Employees.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configure default schema
            modelBuilder.HasDefaultSchema("dbo");


            //  modelBuilder.Seed();
        }



        public DbSet<Employee> Employees { get; set; }

        public DbSet<Departments> Departments { get; set; }

    }
}
