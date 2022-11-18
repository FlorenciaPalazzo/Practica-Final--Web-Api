﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiFinalPalazzoFlorencia.Data;

namespace WebApiFinalPalazzoFlorencia.Migrations
{
    [DbContext(typeof(DBHospitalContext))]
    [Migration("20221118214210_CambioDetallePropiedades")]
    partial class CambioDetallePropiedades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiFinalPalazzoFlorencia.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("HospitalId")
                        .HasColumnType("int");

                    b.Property<int>("IdHospital")
                        .HasColumnType("int");

                    b.HasKey("DoctorId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Doctores");
                });

            modelBuilder.Entity("WebApiFinalPalazzoFlorencia.Models.Hospital", b =>
                {
                    b.Property<int>("HospitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("NumCama")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("varchar(50)");

                    b.HasKey("HospitalId");

                    b.ToTable("Hospitales");
                });

            modelBuilder.Entity("WebApiFinalPalazzoFlorencia.Models.Doctor", b =>
                {
                    b.HasOne("WebApiFinalPalazzoFlorencia.Models.Hospital", "Hospital")
                        .WithMany("Doctores")
                        .HasForeignKey("HospitalId");
                });
#pragma warning restore 612, 618
        }
    }
}
