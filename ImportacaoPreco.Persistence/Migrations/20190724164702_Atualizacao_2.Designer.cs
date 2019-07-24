﻿// <auto-generated />
using System;
using ImportacaoPreco.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImportacaoPreco.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190724164702_Atualizacao_2")]
    partial class Atualizacao_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImportacaoPreco.Dominio.Entities.Cor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Cores");
                });

            modelBuilder.Entity("ImportacaoPreco.Dominio.Entities.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("ImportacaoPreco.Dominio.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ImportacaoPreco.Dominio.Entities.Subgrupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GrupoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.ToTable("Subgrupos");
                });

            modelBuilder.Entity("ImportacaoPreco.Dominio.Entities.Tamanho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Tamanhos");
                });

            modelBuilder.Entity("ImportacaoPreco.Dominio.Entities.Subgrupo", b =>
                {
                    b.HasOne("ImportacaoPreco.Dominio.Entities.Grupo", "Grupo")
                        .WithMany("Subgrupo")
                        .HasForeignKey("GrupoId");
                });
#pragma warning restore 612, 618
        }
    }
}
