﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TpAchatSqlite.Data;

#nullable disable

namespace TpAchatSqlite.Migrations
{
    [DbContext(typeof(TpAchatSqliteContext))]
    [Migration("20231006193912_ForthCreate")]
    partial class ForthCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("TpAchatSqlite.Models.Produit", b =>
                {
                    b.Property<int>("IDProduit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAjout")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomProduit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Prix")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("IDProduit");

                    b.ToTable("Produit");
                });
#pragma warning restore 612, 618
        }
    }
}
