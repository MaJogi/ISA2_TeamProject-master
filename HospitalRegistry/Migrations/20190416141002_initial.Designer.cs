﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalRegistry.Migrations
{
    [DbContext(typeof(RegistryDbContext))]
    [Migration("20190416141002_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview.19074.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalRegistry.Core.Patient", b =>
                {
                    b.Property<string>("PatientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("IdCode");

                    b.Property<string>("LastName");

                    b.Property<string>("Problem");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<DateTime>("ValidTo");

                    b.HasKey("PatientID");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
