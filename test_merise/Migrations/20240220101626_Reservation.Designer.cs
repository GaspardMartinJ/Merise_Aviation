﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test_merise.data;

#nullable disable

namespace test_merise.Migrations
{
    [DbContext(typeof(VoyageDbContext))]
    [Migration("20240220101626_Reservation")]
    partial class Reservation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EquipageVol", b =>
                {
                    b.Property<int>("PersonnelId")
                        .HasColumnType("int");

                    b.Property<int>("VolsId")
                        .HasColumnType("int");

                    b.HasKey("PersonnelId", "VolsId");

                    b.HasIndex("VolsId");

                    b.ToTable("EquipageVol");
                });

            modelBuilder.Entity("test_merise.models.Aeroport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom_aero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aeroports");
                });

            modelBuilder.Entity("test_merise.models.Avion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacite")
                        .HasColumnType("int");

                    b.Property<string>("Compagnie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Avions");
                });

            modelBuilder.Entity("test_merise.models.Equipage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Nom_emp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom_emp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipages");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Equipage");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("test_merise.models.Passager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Num_place")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Passagers");
                });

            modelBuilder.Entity("test_merise.models.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personnes");
                });

            modelBuilder.Entity("test_merise.models.Reservation", b =>
                {
                    b.Property<int>("PassagerId")
                        .HasColumnType("int");

                    b.Property<int>("VolId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateReservation")
                        .HasColumnType("datetime2");

                    b.HasKey("PassagerId", "VolId");

                    b.HasIndex("VolId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("test_merise.models.Vol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AeroportId")
                        .HasColumnType("int");

                    b.Property<int?>("AeroportId1")
                        .HasColumnType("int");

                    b.Property<int>("AvionId")
                        .HasColumnType("int");

                    b.Property<int>("Code_aero_arr")
                        .HasColumnType("int");

                    b.Property<int>("Code_aero_dep")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("Heure_depart")
                        .HasColumnType("time");

                    b.Property<DateOnly>("Jour_depart")
                        .HasColumnType("date");

                    b.Property<int>("Nb_places_vendues")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AeroportId");

                    b.HasIndex("AeroportId1");

                    b.HasIndex("AvionId");

                    b.ToTable("Vols");
                });

            modelBuilder.Entity("test_merise.models.Agent_de_Bord", b =>
                {
                    b.HasBaseType("test_merise.models.Equipage");

                    b.Property<bool>("Est_chef_cabine")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Agent_de_Bord");
                });

            modelBuilder.Entity("test_merise.models.Pilote", b =>
                {
                    b.HasBaseType("test_merise.models.Equipage");

                    b.Property<bool>("Est_commandant")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Pilote");
                });

            modelBuilder.Entity("EquipageVol", b =>
                {
                    b.HasOne("test_merise.models.Equipage", null)
                        .WithMany()
                        .HasForeignKey("PersonnelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("test_merise.models.Vol", null)
                        .WithMany()
                        .HasForeignKey("VolsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("test_merise.models.Reservation", b =>
                {
                    b.HasOne("test_merise.models.Passager", null)
                        .WithMany("Reservations")
                        .HasForeignKey("PassagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("test_merise.models.Vol", null)
                        .WithMany("Reservations")
                        .HasForeignKey("VolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("test_merise.models.Vol", b =>
                {
                    b.HasOne("test_merise.models.Aeroport", null)
                        .WithMany("Vols_arr")
                        .HasForeignKey("AeroportId");

                    b.HasOne("test_merise.models.Aeroport", null)
                        .WithMany("Vols_dep")
                        .HasForeignKey("AeroportId1");

                    b.HasOne("test_merise.models.Avion", null)
                        .WithMany("Vols")
                        .HasForeignKey("AvionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("test_merise.models.Aeroport", b =>
                {
                    b.Navigation("Vols_arr");

                    b.Navigation("Vols_dep");
                });

            modelBuilder.Entity("test_merise.models.Avion", b =>
                {
                    b.Navigation("Vols");
                });

            modelBuilder.Entity("test_merise.models.Passager", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("test_merise.models.Vol", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
