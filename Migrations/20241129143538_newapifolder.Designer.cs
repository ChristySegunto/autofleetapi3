﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace autofleetapi3.Migrations
{
    [DbContext(typeof(AutoFleetDbContext))]
    [Migration("20241129143538_newapifolder")]
    partial class newapifolder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Admin", b =>
                {
                    b.Property<int>("admin_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("admin_id"));

                    b.Property<DateTime?>("admin_birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("admin_fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_mname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("admin_id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("admin", (string)null);
                });

            modelBuilder.Entity("CarUpdate", b =>
                {
                    b.Property<int>("carupdate_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("carupdate_id"));

                    b.Property<string>("carupdate_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("location_latitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("location_longitude")
                        .HasColumnType("decimal(18,6)");

                    b.Property<string>("renter_fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("renter_id")
                        .HasColumnType("int");

                    b.Property<string>("renter_lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("speed")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("total_distance_travelled")
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal>("total_fuel_consumption")
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("vehicle_id")
                        .HasColumnType("int");

                    b.HasKey("carupdate_id");

                    b.HasIndex("renter_id");

                    b.ToTable("realtime_carupdate", (string)null);
                });

            modelBuilder.Entity("Maintenance", b =>
                {
                    b.Property<int>("maintenance_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("maintenance_id"));

                    b.Property<string>("car_model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("maintenance_due_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("maintenance_next_due_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintenance_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maintenance_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plate_num")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("vehicle_id")
                        .HasColumnType("int");

                    b.HasKey("maintenance_id");

                    b.ToTable("maintenance");
                });

            modelBuilder.Entity("RentedVehicle", b =>
                {
                    b.Property<int>("rented_vehicle_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("rented_vehicle_id"));

                    b.Property<string>("car_manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("car_model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dropoff_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("dropoff_loc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("dropoff_time")
                        .HasColumnType("time");

                    b.Property<DateTime>("pickup_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("pickup_loc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("pickup_time")
                        .HasColumnType("time");

                    b.Property<string>("plate_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rent_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("renter_fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("renter_id")
                        .HasColumnType("int");

                    b.Property<string>("renter_lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vehicle_id")
                        .HasColumnType("int");

                    b.HasKey("rented_vehicle_id");

                    b.HasIndex("renter_id");

                    b.HasIndex("vehicle_id");

                    b.ToTable("rented_vehicle", (string)null);
                });

            modelBuilder.Entity("Renter", b =>
                {
                    b.Property<int>("renter_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("renter_id"));

                    b.Property<string>("renter_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("renter_birthday")
                        .HasColumnType("date");

                    b.Property<string>("renter_contact_num")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("renter_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("renter_emergency_contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("renter_fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("renter_id_photo_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("renter_id_photo_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("renter_lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("renter_mname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("renter_id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("renter", (string)null);
                });

            modelBuilder.Entity("Report", b =>
                {
                    b.Property<int>("report_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("report_id"));

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("emergency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nature_of_issue")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("renter_id")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("time")
                        .HasColumnType("time");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("report_id");

                    b.ToTable("report");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("user_id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Vehicle", b =>
                {
                    b.Property<int>("vehicle_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("vehicle_id"));

                    b.Property<string>("car_manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("car_model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("distance_traveled")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("fuel_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("manufacture_year")
                        .HasColumnType("int");

                    b.Property<string>("plate_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("seating_capacity")
                        .HasColumnType("int");

                    b.Property<decimal>("total_fuel_consumption")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("total_mileage")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("transmission_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("vehicle_category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicle_color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicle_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("vehicle_id");

                    b.ToTable("vehicle");
                });

            modelBuilder.Entity("Admin", b =>
                {
                    b.HasOne("User", "User")
                        .WithOne()
                        .HasForeignKey("Admin", "user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CarUpdate", b =>
                {
                    b.HasOne("Renter", "Renter")
                        .WithMany("CarUpdates")
                        .HasForeignKey("renter_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Renter");
                });

            modelBuilder.Entity("RentedVehicle", b =>
                {
                    b.HasOne("Renter", "Renter")
                        .WithMany("RentedVehicles")
                        .HasForeignKey("renter_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("vehicle_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Renter");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Renter", b =>
                {
                    b.HasOne("User", "User")
                        .WithOne()
                        .HasForeignKey("Renter", "user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Renter", b =>
                {
                    b.Navigation("CarUpdates");

                    b.Navigation("RentedVehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
