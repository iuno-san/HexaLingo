﻿// <auto-generated />
using HexaLingo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HexaLingo.Migrations
{
    [DbContext(typeof(HexaLingoDbContext))]
    partial class HexaLingoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HexaLingo.Models.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("EnglishLang")
                        .HasColumnType("longtext");

                    b.Property<string>("FrenchLang")
                        .HasColumnType("longtext");

                    b.Property<string>("GermanishLang")
                        .HasColumnType("longtext");

                    b.Property<string>("IconPath")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ItalianishLang")
                        .HasColumnType("longtext");

                    b.Property<string>("Language")
                        .HasColumnType("longtext");

                    b.Property<string>("PolishLang")
                        .HasColumnType("longtext");

                    b.Property<string>("SentenceEnglishLang")
                        .HasColumnType("longtext");

                    b.Property<string>("SentenceFrenchLang")
                        .HasColumnType("longtext");

                    b.Property<string>("SentenceGermanishLang")
                        .HasColumnType("longtext");

                    b.Property<string>("SentenceItalianishLang")
                        .HasColumnType("longtext");

                    b.Property<string>("SentencePolishLang")
                        .HasColumnType("longtext");

                    b.Property<string>("SentenceSpanishLang")
                        .HasColumnType("longtext");

                    b.Property<string>("SpanishLang")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Words");
                });
#pragma warning restore 612, 618
        }
    }
}