﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiFinalEngelstajnSebastian.Data;

namespace WebApiFinalEngelstajnSebastian.Migrations
{
    [DbContext(typeof(DBHospitalAPIContext))]
    [Migration("20221118182032_CreandoDB")]
    partial class CreandoDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiFinalEngelstajnSebastian.Model.Doctor", b =>
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

                    b.Property<int>("idHospital")
                        .HasColumnType("int");

                    b.HasKey("DoctorId");

                    b.HasIndex("HospitalId");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("WebApiFinalEngelstajnSebastian.Model.Hospital", b =>
                {
                    b.Property<int>("HospitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Num_Cama")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("varchar(50)");

                    b.HasKey("HospitalId");

                    b.ToTable("Hospital");
                });

            modelBuilder.Entity("WebApiFinalEngelstajnSebastian.Model.Doctor", b =>
                {
                    b.HasOne("WebApiFinalEngelstajnSebastian.Model.Hospital", "hospital")
                        .WithMany("Doctors")
                        .HasForeignKey("HospitalId");
                });
#pragma warning restore 612, 618
        }
    }
}
