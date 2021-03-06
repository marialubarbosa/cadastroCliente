﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cadastroCliente.Data;

namespace cadastroCliente.Migrations
{
    [DbContext(typeof(cadastroClienteContext))]
    [Migration("20201206225214_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("cadastroCliente.Models.cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("nomeCliente")
                        .HasColumnType("TEXT");

                    b.Property<string>("rg")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
