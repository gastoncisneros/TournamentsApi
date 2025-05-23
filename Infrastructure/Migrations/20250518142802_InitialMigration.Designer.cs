﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250518142802_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficialId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorldRanking")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Prediction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Predictions");
                });

            modelBuilder.Entity("PredictionHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CalculatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("PointsEarned")
                        .HasColumnType("int");

                    b.Property<Guid>("PredictionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("PredictionHistory");
                });

            modelBuilder.Entity("PredictionPick", b =>
                {
                    b.Property<Guid>("PredictionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("PredictionId", "PlayerId");

                    b.ToTable("PredictionPicks");
                });

            modelBuilder.Entity("Round", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<Guid>("TournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId", "Number")
                        .IsUnique();

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoundId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ScoreToPar")
                        .HasColumnType("int");

                    b.Property<int>("Strokes")
                        .HasColumnType("int");

                    b.Property<Guid?>("TournamentPlayerPlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TournamentPlayerTournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoundId", "PlayerId")
                        .IsUnique();

                    b.HasIndex("TournamentPlayerTournamentId", "TournamentPlayerPlayerId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("TournamentPlayer", b =>
                {
                    b.Property<Guid>("TournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsAmateur")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCut")
                        .HasColumnType("bit");

                    b.Property<int?>("StartingHole")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly?>("TeeTime")
                        .HasColumnType("time");

                    b.HasKey("TournamentId", "PlayerId");

                    b.HasIndex("PlayerId");

                    b.ToTable("TournamentPlayers");
                });

            modelBuilder.Entity("TournamentsApi.Domain.Models.Tournament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CutRule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Par")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("PredictionPick", b =>
                {
                    b.HasOne("Prediction", null)
                        .WithMany("Picks")
                        .HasForeignKey("PredictionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Round", b =>
                {
                    b.HasOne("TournamentsApi.Domain.Models.Tournament", "Tournament")
                        .WithMany("Rounds")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("Score", b =>
                {
                    b.HasOne("Round", null)
                        .WithMany("Scores")
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TournamentPlayer", null)
                        .WithMany("Scores")
                        .HasForeignKey("TournamentPlayerTournamentId", "TournamentPlayerPlayerId");
                });

            modelBuilder.Entity("TournamentPlayer", b =>
                {
                    b.HasOne("Player", "Player")
                        .WithMany("TournamentPlayers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TournamentsApi.Domain.Models.Tournament", "Tournament")
                        .WithMany("TournamentPlayers")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("Player", b =>
                {
                    b.Navigation("TournamentPlayers");
                });

            modelBuilder.Entity("Prediction", b =>
                {
                    b.Navigation("Picks");
                });

            modelBuilder.Entity("Round", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("TournamentPlayer", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("TournamentsApi.Domain.Models.Tournament", b =>
                {
                    b.Navigation("Rounds");

                    b.Navigation("TournamentPlayers");
                });
#pragma warning restore 612, 618
        }
    }
}
