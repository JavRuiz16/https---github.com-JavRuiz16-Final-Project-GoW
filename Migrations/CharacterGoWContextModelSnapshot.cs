﻿// <auto-generated />
using Final_Project_GoW.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProjectGoW.Migrations
{
    [DbContext(typeof(CharacterGoWContext))]
    partial class CharacterGoWContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Final_Project_GoW.Models.CharacterGoW", b =>
                {
                    b.Property<int>("CharacterGoWID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.HasKey("CharacterGoWID");

                    b.ToTable("CharacterGoW");
                });
#pragma warning restore 612, 618
        }
    }
}
