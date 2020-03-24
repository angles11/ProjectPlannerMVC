﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectPlanner.Data;

namespace ProjectPlanner.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("ProjectPlanner.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<DateTime>("EstimatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<decimal>("PercentageOfCompletion")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            CreatedDate = new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Herramienta para calcular los viaticos de vuelo",
                            EstimatedDate = new DateTime(2020, 3, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Calculadora de Viaticos",
                            PercentageOfCompletion = 0.00m
                        },
                        new
                        {
                            ProjectId = 2,
                            CreatedDate = new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Herramienta para calcular los tiempos limites de vuelo",
                            EstimatedDate = new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Calculadora de Vencimiento",
                            PercentageOfCompletion = 0.00m
                        },
                        new
                        {
                            ProjectId = 3,
                            CreatedDate = new DateTime(2020, 3, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Herramienta para llevar el control de los proyectos",
                            EstimatedDate = new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Todo List",
                            PercentageOfCompletion = 0.00m
                        });
                });

            modelBuilder.Entity("ProjectPlanner.Models.Todo", b =>
                {
                    b.Property<int>("TodoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.Property<DateTime>("EstimatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<int?>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.HasKey("TodoId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("ProjectPlanner.Models.Todo", b =>
                {
                    b.HasOne("ProjectPlanner.Models.Project", "Project")
                        .WithMany("Todos")
                        .HasForeignKey("ProjectId");
                });
#pragma warning restore 612, 618
        }
    }
}
