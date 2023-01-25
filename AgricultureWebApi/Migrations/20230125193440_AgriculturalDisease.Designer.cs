﻿// <auto-generated />
using System;
using AgricultureWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgricultureWebApi.Migrations
{
    [DbContext(typeof(AgricultureDbContext))]
    [Migration("20230125193440_AgriculturalDisease")]
    partial class AgriculturalDisease
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("AgciculturalProductId")
                        .HasColumnType("int");

                    b.Property<int>("AgcicultureProductId")
                        .HasColumnType("int");

                    b.Property<int>("DiseaseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgciculturalProductId");

                    b.HasIndex("DiseaseId");

                    b.ToTable("AgricalturalDiseases");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgricalturalType", b =>
                {
                    b.Property<byte>("AgricalturalTypeId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AgricalturalTypeId");

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
                    b.Property<int>("DiseaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiseaseId"));

                    b.Property<byte>("AgricalturalTypeId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DiseaseId");

                    b.HasIndex("AgricalturalTypeId");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgricalturalDisease", b =>
                {
                    b.HasOne("AgricultureWebApi.Models.AgriculturalProduct", "AgciculturalProduct")
                        .WithMany("AgricalturalDiseases")
                        .HasForeignKey("AgciculturalProductId");

                    b.HasOne("AgricultureWebApi.Models.Disease", "Disease")
                        .WithMany("AgriCulturalDiseases")
                        .HasForeignKey("DiseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgciculturalProduct");

                    b.Navigation("Disease");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgriculturalProduct", b =>
                {
                    b.HasOne("AgricultureWebApi.Models.AgricalturalType", "AgricalturalType")
                        .WithMany()
                        .HasForeignKey("AgricalturalTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgricalturalType");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.Disease", b =>
                {
                    b.HasOne("AgricultureWebApi.Models.AgricalturalType", "AgricalturalType")
                        .WithMany("Diseases")
                        .HasForeignKey("AgricalturalTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgricalturalType");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgricalturalType", b =>
                {
                    b.Navigation("Diseases");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.AgriculturalProduct", b =>
                {
                    b.Navigation("AgricalturalDiseases");
                });

            modelBuilder.Entity("AgricultureWebApi.Models.Disease", b =>
                {
                    b.Navigation("AgriCulturalDiseases");
                });
#pragma warning restore 612, 618
        }
    }
}