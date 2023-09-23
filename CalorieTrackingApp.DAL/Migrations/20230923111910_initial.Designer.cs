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
    [DbContext(typeof(ProjectContext))]
    [Migration("20230923111910_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfEntry")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionAnswer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SecurityQuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SecurityQuestionId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.ConsumedFood", b =>
                {
                    b.Property<int>("ConsumedFoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsumedFoodId"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<int>("ConsumedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("ConsumedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodID")
                        .HasColumnType("int");

                    b.Property<int>("MealCategory")
                        .HasColumnType("int");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("Portion")
                        .HasColumnType("float");

                    b.HasKey("ConsumedFoodId");

                    b.HasIndex("AccountID");

                    b.HasIndex("FoodID");

                    b.ToTable("ConsumedFoods");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.ConsumedWater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Portion")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AccountID");

                    b.ToTable("ConsumedWaters");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("PortionCalorie")
                        .HasColumnType("float");

                    b.Property<double>("PortionCarb")
                        .HasColumnType("float");

                    b.Property<double>("PortionFat")
                        .HasColumnType("float");

                    b.Property<double>("PortionProtein")
                        .HasColumnType("float");

                    b.Property<double>("StandartPortion")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.LikedAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("SocialMediaPostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SocialMediaPostId");

                    b.ToTable("LikedAccounts");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.SecurityQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("QestionText")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("SecurityQuestions");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.SocialMediaPost", b =>
                {
                    b.Property<int>("SocialMediaPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocialMediaPostId"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostDescription")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<byte[]>("PostPicture")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("SocialMediaPostId");

                    b.HasIndex("AccountId");

                    b.ToTable("SocialMediaPosts");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.UserDetail", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<double>("BMI")
                        .HasColumnType("float");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ExerciseLevel")
                        .HasColumnType("float");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("LastWeight")
                        .HasColumnType("float");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("TargetCalorieIntake")
                        .HasColumnType("float");

                    b.Property<double>("TargetWaterIntake")
                        .HasColumnType("float");

                    b.Property<double>("TargetWeight")
                        .HasColumnType("float");

                    b.HasKey("AccountId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.WeightHistory", b =>
                {
                    b.Property<int>("WeightHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeightHistoryId"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<DateTime>("WeightDate")
                        .HasColumnType("datetime2");

                    b.HasKey("WeightHistoryId");

                    b.HasIndex("AccountID");

                    b.ToTable("WeightHistories");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.Account", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.SecurityQuestion", "SecurityQuestion")
                        .WithMany("Accounts")
                        .HasForeignKey("SecurityQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SecurityQuestion");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.ConsumedFood", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.Account", "Account")
                        .WithMany("ConsumedFoods")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalorieTrackingApp.DATA.Entities.Food", "Food")
                        .WithMany("ConsumedFoods")
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.ConsumedWater", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.Account", "Account")
                        .WithMany("ConsumedWaters")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.LikedAccount", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.SocialMediaPost", "SocialMediaPost")
                        .WithMany("LikedAccounts")
                        .HasForeignKey("SocialMediaPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SocialMediaPost");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.SocialMediaPost", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.Account", "Account")
                        .WithMany("SocialMediaPosts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.UserDetail", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.Account", "Account")
                        .WithOne("UserDetail")
                        .HasForeignKey("CalorieTrackingApp.DATA.Entities.UserDetail", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.WeightHistory", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.Account", "Account")
                        .WithMany("WeightHistories")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.Account", b =>
                {
                    b.Navigation("ConsumedFoods");

                    b.Navigation("ConsumedWaters");

                    b.Navigation("SocialMediaPosts");

                    b.Navigation("UserDetail")
                        .IsRequired();

                    b.Navigation("WeightHistories");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.Food", b =>
                {
                    b.Navigation("ConsumedFoods");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.SecurityQuestion", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.SocialMediaPost", b =>
                {
                    b.Navigation("LikedAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
