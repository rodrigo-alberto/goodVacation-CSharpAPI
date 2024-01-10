﻿// <auto-generated />
using CSharpAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSharpAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240110030424_updateDestiny")]
    partial class updateDestiny
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CSharpAPI.Models.Destiny", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrls")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("imageUrls");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("state");

                    b.HasKey("Id");

                    b.ToTable("destiny");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Lençois",
                            Description = "Com uma bela queda d’água em meio a grandiosos paredões rochosos, a Cachoeira do Mosquito impressiona pela sua beleza e graciosidade natural.",
                            ImageUrls = "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/1b6270da-85f9-452d-8f11-9e486522397a\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7da3cc7f-75cd-41aa-a2fb-a133e90d1b21\"]",
                            Name = "Cachoeira do Mosquito",
                            State = "Bahia"
                        },
                        new
                        {
                            Id = 2,
                            City = "Angra dos Reis",
                            Description = "Um sítio histórico e natural com mais de 100 praias, além de cachoeiras, rios, trilhas, construções históricas e uma rica flora e fauna.",
                            ImageUrls = "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d1f4942a-4d4e-417a-9445-7117b1648cfa\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7b90c8d5-e3bf-4132-a281-615db90e23b4\"]",
                            Name = "Ilha Grande",
                            State = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 3,
                            City = "Aracaju",
                            Description = "Aracaju é um destino que reúne um extenso litoral, praias de rio, centro histórico repleto de museus e mercados públicos, além de uma culinária deliciosa.",
                            ImageUrls = "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7b90c8d5-e3bf-4132-a281-615db90e23b4\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d1f4942a-4d4e-417a-9445-7117b1648cfa\"]",
                            Name = "Praia de Atalaia",
                            State = "Sergipe"
                        },
                        new
                        {
                            Id = 4,
                            City = "Iraquara",
                            Description = "As águas cristalinas do rio Pratinha são um convite para uma pedalada em família, um teste de equilíbrio ou remo em meio à natureza.",
                            ImageUrls = "[\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d1f4942a-4d4e-417a-9445-7117b1648cfa\",\"https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7b90c8d5-e3bf-4132-a281-615db90e23b4\"]",
                            Name = "Pratinha",
                            State = "Bahia"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}