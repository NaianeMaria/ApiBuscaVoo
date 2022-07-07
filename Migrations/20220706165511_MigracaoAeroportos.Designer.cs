﻿// <auto-generated />
using ApiBuscaVoos.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiBuscaVoos.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20220706165511_MigracaoAeroportos")]
    partial class MigracaoAeroportos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiBuscaVoos.Models.Aeroporto", b =>
                {
                    b.Property<int>("AeroportoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AeroportoId");

                    b.ToTable("Aeroportos");
                });
#pragma warning restore 612, 618
        }
    }
}
