﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalDocs.Data;

namespace PortalDocs.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220427140354_RemoveDocuments")]
    partial class RemoveDocuments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("PortalDocs.Models.Parceiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
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

                    b.Property<int?>("ParceiroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Solicitante")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ParceiroId");

                    b.ToTable("Solicitacoes");
                });

            modelBuilder.Entity("PortalDocs.Models.Solicitacao", b =>
                {
                    b.HasOne("PortalDocs.Models.Parceiro", "Parceiro")
                        .WithMany()
                        .HasForeignKey("ParceiroId");

                    b.Navigation("Parceiro");
                });
#pragma warning restore 612, 618
        }
    }
}
