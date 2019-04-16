using HospitalRegistry.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra
{
    public class RegistryDbContext : DbContext
    {
        public RegistryDbContext(DbContextOptions<RegistryDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Patient>().ToTable("Patients");
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
