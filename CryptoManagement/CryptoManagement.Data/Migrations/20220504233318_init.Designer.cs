﻿// <auto-generated />
using System;
using CryptoManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoManagement.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220504233318_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CryptoManagement.Data.Model.Coin", b =>
                {
                    b.Property<int>("CoinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.HasKey("CoinId");

                    b.ToTable("Coins");
                });
#pragma warning restore 612, 618
        }
    }
}
