﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalDocs.Data;

namespace PortalDocs.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("PortalDocs.Models.Parceiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CpfFuncionario")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentosEmpresa")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentosFuncionario")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeFuncionario")
                        .HasColumnType("TEXT");

                    b.Property<string>("RgFuncionario")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Parceiros");
                });

            modelBuilder.Entity("PortalDocs.Models.Solicitacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentoRequerido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ObservacaoSolicitacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParceiroCnpj")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParceiroEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ParceiroNome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Solicitante")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Solicitacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
