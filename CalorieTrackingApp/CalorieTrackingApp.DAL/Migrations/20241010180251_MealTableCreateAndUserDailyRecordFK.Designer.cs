﻿// <auto-generated />
using System;
using CalorieTrackingApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    [DbContext(typeof(CalorieDbContext))]
    [Migration("20241010180251_MealTableCreateAndUserDailyRecordFK")]
    partial class MealTableCreateAndUserDailyRecordFK
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminName = "admin",
                            CreatedDate = new DateTime(2024, 10, 10, 21, 2, 50, 878, DateTimeKind.Local).AddTicks(7822),
                            DataStatus = 0,
                            Name = "Admin_Name",
                            Password = "admin123",
                            Surname = "admin@example.com"
                        });
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.Beverage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("BeverageCalorie")
                        .HasColumnType("real");

                    b.Property<int>("BeverageCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("BeverageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Portion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BeverageCategoryId");

                    b.ToTable("Beverages");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.BeverageCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BeverageCategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BeverageCategories");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.DailyUserRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BeverageId")
                        .HasColumnType("int");

                    b.Property<int>("BeveragesPortions")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("FoodPortions")
                        .HasColumnType("int");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("RecordDate")
                        .HasColumnType("date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BeverageId");

                    b.HasIndex("FoodId");

                    b.HasIndex("MealId");

                    b.HasIndex("UserId");

                    b.ToTable("DailyUserRecord");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("FoodCalorie")
                        .HasColumnType("real");

                    b.Property<int>("FoodCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Portion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoryId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.FoodCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FoodCategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UserAgeGap")
                        .HasColumnType("int");

                    b.Property<int>("UserGoal")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.Beverage", b =>
                {
                    b.HasOne("CalorieTrackingApp.DAL.Entities.Concrete.BeverageCategory", "BeverageCategory")
                        .WithMany("Beverages")
                        .HasForeignKey("BeverageCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BeverageCategory");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.DailyUserRecord", b =>
                {
                    b.HasOne("CalorieTrackingApp.DAL.Entities.Concrete.Beverage", "Beverages")
                        .WithMany("BeverageRecords")
                        .HasForeignKey("BeverageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalorieTrackingApp.DAL.Entities.Concrete.Food", "Foods")
                        .WithMany("FoodRecords")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalorieTrackingApp.DAL.Entities.Concrete.Meal", "Meals")
                        .WithMany("MealsRecords")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalorieTrackingApp.DAL.Entities.Concrete.User", "Users")
                        .WithMany("UserRecords")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beverages");

                    b.Navigation("Foods");

                    b.Navigation("Meals");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.Food", b =>
                {
                    b.HasOne("CalorieTrackingApp.DAL.Entities.Concrete.FoodCategory", "FoodCategory")
                        .WithMany("Foods")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategory");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.Beverage", b =>
                {
                    b.Navigation("BeverageRecords");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.BeverageCategory", b =>
                {
                    b.Navigation("Beverages");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.Food", b =>
                {
                    b.Navigation("FoodRecords");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.FoodCategory", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.Meal", b =>
                {
                    b.Navigation("MealsRecords");
                });

            modelBuilder.Entity("CalorieTrackingApp.DAL.Entities.Concrete.User", b =>
                {
                    b.Navigation("UserRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
