﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WFA_SuFaturasi.DataAccess.Context;

#nullable disable

namespace SuFaturası.Entities.Migrations
{
    [DbContext(typeof(SuFaturasiEntities))]
    [Migration("20221211124538_v")]
    partial class v
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SuFaturası.Entities.Entities.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciID"), 1L, 1);

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("IlkIndex")
                        .HasColumnType("float");

                    b.Property<int>("KullanimYeri")
                        .HasColumnType("int");

                    b.Property<double>("SonIndex")
                        .HasColumnType("float");

                    b.HasKey("KullaniciID");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("SuFaturası.Entities.Entities.SuFaturasi", b =>
                {
                    b.Property<int>("SuFaturasiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SuFaturasiID"), 1L, 1);

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.HasKey("SuFaturasiID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("SuFaturasilar");
                });

            modelBuilder.Entity("SuFaturası.Entities.Entities.SuFaturasi", b =>
                {
                    b.HasOne("SuFaturası.Entities.Entities.Kullanici", "Kullanici")
                        .WithMany("SuFaturasilar")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("SuFaturası.Entities.Entities.Kullanici", b =>
                {
                    b.Navigation("SuFaturasilar");
                });
#pragma warning restore 612, 618
        }
    }
}
