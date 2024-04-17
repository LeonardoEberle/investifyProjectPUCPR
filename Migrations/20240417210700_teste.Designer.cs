﻿// <auto-generated />
using System;
using Investify.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Investify.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240417210700_teste")]
    partial class teste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Investify.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Usu_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Usu_id"));

                    b.Property<string>("Usu_cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Usu_dataInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Usu_dataNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usu_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usu_nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usu_senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Usu_status")
                        .HasColumnType("int");

                    b.Property<string>("Usu_telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Usu_id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
