﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alunos1.Migrations
{
    [DbContext(typeof(DbContext))]
    [Migration("20231021003527_Alunos1")]
    partial class Alunos1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Alunos1.Alunos1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NotaPrimeiroSemestre")
                        .HasColumnType("float");

                    b.Property<double>("NotaSegundoSemestre")
                        .HasColumnType("float");

                    b.Property<int>("NumeroSala")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Alunos1");
                });
#pragma warning restore 612, 618
        }
    }
}
