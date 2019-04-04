using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalRegistry.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalRegistry.Data
{
    public class RegistryContext : DbContext
    {
        public RegistryContext(DbContextOptions<RegistryContext> o) : base(o) { }

        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            b.Entity<Patient>().ToTable("Patient");
        }
    }
}
