﻿// <auto-generated />
using System;
using AgricultureWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgricultureWebApi.Migrations
{
    [DbContext(typeof(AgricultureDbContext))]
    partial class AgricultureDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgricultureWebApi.Models.AgricalturalDisease", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AgriculturalProductId")
                        .HasColumnType("int");

                    b.Property<int>("DiseaseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgriculturalProductId");

                    b.HasIndex("DiseaseId");

                    b.ToTable("AgricalturalDiseases");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgricalturalType", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AgricalturalTypes");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgriculturalProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("AgricalturalTypeId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AgricalturalTypeId");

                    b.ToTable("AgriculturalProduct");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("AgricalturalTypeId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.Error", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Errors");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgricalturalDisease", b =>
                {
                    b.HasOne("AgricultureWebApi.Models.AgriculturalProduct", "AgriculturalProduct")
                        .WithMany("AgricalturalDiseases")
                        .HasForeignKey("AgriculturalProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgricultureWebApi.Models.Disease", "Disease")
                        .WithMany("AgricalturalDisease")
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgriculturalProduct");

                    b.Navigation("Disease");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgriculturalProduct", b =>
                {
                    b.HasOne("AgricultureWebApi.Models.AgricalturalType", "AgricalturalType")
                        .WithMany("AgriculturalProduct")
                        .HasForeignKey("AgricalturalTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgricalturalType");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgricalturalType", b =>
                {
                    b.Navigation("AgriculturalProduct");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgriculturalProduct", b =>
                {
                    b.Navigation("AgricalturalDiseases");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.Disease", b =>
                {
                    b.Navigation("AgricalturalDisease");
                });
#pragma warning restore 612, 618
        }
    }
}
