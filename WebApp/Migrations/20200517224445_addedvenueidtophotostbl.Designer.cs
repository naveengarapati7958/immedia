﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.DataLayer;

namespace WebApp.Migrations
{
    [DbContext(typeof(IMMEDIADbContext))]
    [Migration("20200517224445_addedvenueidtophotostbl")]
    partial class addedvenueidtophotostbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Models.PhotoModel", b =>
                {
                    b.Property<Guid>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("venueid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("width")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("uid");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("WebApp.Models.VenueModel", b =>
                {
                    b.Property<Guid>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("uid");

                    b.ToTable("Venue");
                });
#pragma warning restore 612, 618
        }
    }
}
