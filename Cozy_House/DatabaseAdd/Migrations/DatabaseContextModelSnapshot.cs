﻿using Cozy_House.DatabaseAdd;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cozy_House.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-rc.1.24451.1");

            modelBuilder.Entity("Cozy_House.models.Animal", b =>
            {
                b.Property<int>("AnimalID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<int>("Animal_Age")
                    .HasColumnType("INTEGER");

                b.Property<string>("Animal_Name")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Breed")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Infection")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Parasite")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Species")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Vaccine")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("AnimalID");

                b.ToTable("animals");
            });

            modelBuilder.Entity("Cozy_House.models.User", b =>
            {
                b.Property<int>("User_id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("FieldOfActivity")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Password")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Password_Check")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Prefer")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("User_Email")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("User_Location")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<int>("User_age")
                    .HasColumnType("INTEGER");

                b.Property<string>("User_name")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<int?>("UsersUser_id")
                    .HasColumnType("INTEGER");

                b.HasKey("User_id");

                b.HasIndex("UsersUser_id");

                b.ToTable("User");
            });

            modelBuilder.Entity("Cozy_House.models.Animal", b =>
            {
                b.HasOne("Cozy_House.models.User", "User")
                    .WithMany("Animals")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("User");
            });

            modelBuilder.Entity("Cozy_House.models.User", b =>
            {
                b.HasOne("Cozy_House.models.User", "Users")
                    .WithMany()
                    .HasForeignKey("UsersUser_id");

                b.Navigation("Users");
            });

            modelBuilder.Entity("Cozy_House.models.User", b =>
            {
                b.Navigation("Animals");
            });
#pragma warning restore 612, 618
        }
    }
}
