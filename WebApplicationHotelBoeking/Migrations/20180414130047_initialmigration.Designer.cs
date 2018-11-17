﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplicationHotelBoeking.Models;

namespace WebApplicationHotelBoeking.Migrations
{
    [DbContext(typeof(HotelBoekingContext))]
    [Migration("20180414130047_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplicationHotelBoeking.Models.HotelBoeking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("Booking_id");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("Guest_No");

                    b.Property<string>("HotelName");

                    b.Property<int>("Room_No");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("hotelBoeking");
                });
#pragma warning restore 612, 618
        }
    }
}
