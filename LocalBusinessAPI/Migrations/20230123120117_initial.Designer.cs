﻿// <auto-generated />
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocalBusinessAPI.Migrations
{
    [DbContext(typeof(LocalBusinessContext))]
    [Migration("20230123120117_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusiness.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BusinessType")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            BusinessType = "Restaurant",
                            Name = "Viva",
                            Phone = "111-1111"
                        },
                        new
                        {
                            BusinessId = 2,
                            BusinessType = "Coffee/Tea",
                            Name = "Panda Tea House",
                            Phone = "222-2222"
                        },
                        new
                        {
                            BusinessId = 3,
                            BusinessType = "Restaurant",
                            Name = "Saigon",
                            Phone = "333-3333"
                        },
                        new
                        {
                            BusinessId = 4,
                            BusinessType = "Clothing",
                            Name = "Fontanas",
                            Phone = "444-4444"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
