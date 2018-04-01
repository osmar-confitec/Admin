﻿// <auto-generated />
using Back_end.Context_entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Backend.Migrations
{
    [DbContext(typeof(ContextBco))]
    [Migration("20180401173246_tabela_usuario")]
    partial class tabela_usuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Back_end.Models_entity.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Sobrenome")
                        .HasColumnName("Sobrenome")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("tbPessoa");
                });

            modelBuilder.Entity("Back_end.Models_entity.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login")
                        .HasColumnName("Login")
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("PessoaId");

                    b.Property<string>("Senha")
                        .HasColumnName("Senha")
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("tbUsuario");
                });

            modelBuilder.Entity("Back_end.Models_entity.Usuario", b =>
                {
                    b.HasOne("Back_end.Models_entity.Pessoa", "Pessoa")
                        .WithOne("Usuario")
                        .HasForeignKey("Back_end.Models_entity.Usuario", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
