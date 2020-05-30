﻿// <auto-generated />
using System;
using MastersClinic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MastersClinic.Migrations
{
    [DbContext(typeof(MastersClinicDb))]
    [Migration("20200530222217_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MastersClinic.Models.Doctor_specialization", b =>
                {
                    b.Property<int>("IdDoctor_specialization")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Doctor_id")
                        .HasColumnType("int");

                    b.Property<int>("Specialization_id")
                        .HasColumnType("int");

                    b.HasKey("IdDoctor_specialization");

                    b.HasIndex("Doctor_id");

                    b.HasIndex("Specialization_id");

                    b.ToTable("Doctor_specializations");
                });

            modelBuilder.Entity("MastersClinic.Models.Doctors_referal", b =>
                {
                    b.Property<int>("IdReferal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_of_issue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Expiration_day")
                        .HasColumnType("datetime2");

                    b.Property<int>("Visit_id")
                        .HasColumnType("int");

                    b.HasKey("IdReferal");

                    b.HasIndex("Visit_id");

                    b.ToTable("Doctors_referals");
                });

            modelBuilder.Entity("MastersClinic.Models.Medical_specialization", b =>
                {
                    b.Property<int>("IdSpecialization")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Specialization_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSpecialization");

                    b.ToTable("Medical_specializations");
                });

            modelBuilder.Entity("MastersClinic.Models.Medicine", b =>
                {
                    b.Property<int>("IdMedicine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_of_issue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dosage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Expiration_day")
                        .HasColumnType("datetime2");

                    b.Property<string>("Medicine_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Visit_id")
                        .HasColumnType("int");

                    b.HasKey("IdMedicine");

                    b.HasIndex("Visit_id");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("MastersClinic.Models.Patient", b =>
                {
                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Building_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City_of_birth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_of_birth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_of_death")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flat_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Forename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maiden_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Second_forename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pesel");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("MastersClinic.Models.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MastersClinic.Models.Visit", b =>
                {
                    b.Property<int>("IdVisit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Compleated")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Doctor_id")
                        .HasColumnType("int");

                    b.Property<string>("Patient_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Visits_description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVisit");

                    b.HasIndex("Doctor_id");

                    b.HasIndex("Patient_id");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("MastersClinic.Models.Worker", b =>
                {
                    b.Property<int>("IdWorker")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Forename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role_id")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdWorker");

                    b.HasIndex("Role_id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("MastersClinic.Models.Working_day", b =>
                {
                    b.Property<int>("IdWorkingDay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Time_end")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Time_start")
                        .HasColumnType("datetime2");

                    b.Property<int>("Worker_id")
                        .HasColumnType("int");

                    b.HasKey("IdWorkingDay");

                    b.HasIndex("Worker_id");

                    b.ToTable("Working_days");
                });

            modelBuilder.Entity("MastersClinic.Models.Doctor_specialization", b =>
                {
                    b.HasOne("MastersClinic.Models.Worker", "worker")
                        .WithMany()
                        .HasForeignKey("Doctor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MastersClinic.Models.Medical_specialization", "Medical_Specialization")
                        .WithMany()
                        .HasForeignKey("Specialization_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MastersClinic.Models.Doctors_referal", b =>
                {
                    b.HasOne("MastersClinic.Models.Visit", "Visit")
                        .WithMany()
                        .HasForeignKey("Visit_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MastersClinic.Models.Medicine", b =>
                {
                    b.HasOne("MastersClinic.Models.Visit", "Visit")
                        .WithMany()
                        .HasForeignKey("Visit_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MastersClinic.Models.Visit", b =>
                {
                    b.HasOne("MastersClinic.Models.Worker", "Doctor")
                        .WithMany()
                        .HasForeignKey("Doctor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MastersClinic.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("Patient_id");
                });

            modelBuilder.Entity("MastersClinic.Models.Worker", b =>
                {
                    b.HasOne("MastersClinic.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("Role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MastersClinic.Models.Working_day", b =>
                {
                    b.HasOne("MastersClinic.Models.Worker", "Worker")
                        .WithMany()
                        .HasForeignKey("Worker_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
