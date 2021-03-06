﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLDocker.Data;

namespace SQLDocker.Data.Migrations
{
    [DbContext(typeof(OMGContext))]
    partial class OMGContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SQLDocker.Data.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<Guid>("ClientId");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("PostalCode");

                    b.Property<string>("StreetAddress");

                    b.HasKey("Id")
                        .HasName("PK_Addresses");

                    b.HasIndex("ClientId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SQLDocker.Data.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id")
                        .HasName("PK_Clients");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SQLDocker.Data.Entities.Address", b =>
                {
                    b.HasOne("SQLDocker.Data.Entities.Client", "Client")
                        .WithMany("Addresses")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("FK_Client_Addresses")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
