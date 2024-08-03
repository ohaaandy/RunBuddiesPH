﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RunBuddies.DataModel;

#nullable disable

namespace RunBuddies.DataModel.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RunBuddies.DataModel.BuddyPartner", b =>
                {
                    b.Property<int>("BuddyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuddyID"));

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("BuddyID");

                    b.HasIndex("UserID");

                    b.ToTable("BuddyPartners");
                });

            modelBuilder.Entity("RunBuddies.DataModel.BuddySession", b =>
                {
                    b.Property<int>("BuddySessionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuddySessionID"));

                    b.Property<int>("BuddyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VerificationID")
                        .HasColumnType("int");

                    b.HasKey("BuddySessionID");

                    b.HasIndex("BuddyID");

                    b.HasIndex("VerificationID")
                        .IsUnique();

                    b.ToTable("BuddySessions");
                });

            modelBuilder.Entity("RunBuddies.DataModel.Club", b =>
                {
                    b.Property<int>("ClubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClubID"));

                    b.Property<int>("ClubMemberID")
                        .HasColumnType("int");

                    b.Property<int>("ClubModeratorID")
                        .HasColumnType("int");

                    b.Property<string>("ClubName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClubID");

                    b.HasIndex("ClubMemberID");

                    b.HasIndex("ClubModeratorID");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("RunBuddies.DataModel.ClubMember", b =>
                {
                    b.Property<int>("ClubMemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClubMemberID"));

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ClubMemberID");

                    b.HasIndex("UserID");

                    b.ToTable("ClubMembers");
                });

            modelBuilder.Entity("RunBuddies.DataModel.ClubModerator", b =>
                {
                    b.Property<int>("ClubModeratorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClubModeratorID"));

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ClubModeratorID");

                    b.HasIndex("UserID");

                    b.ToTable("ClubModerators");
                });

            modelBuilder.Entity("RunBuddies.DataModel.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventID"));

                    b.Property<int>("ClubID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeaderboardID")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("EventID");

                    b.HasIndex("ClubID");

                    b.HasIndex("UserID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("RunBuddies.DataModel.Leaderboard", b =>
                {
                    b.Property<int>("LeaderboardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaderboardID"));

                    b.Property<int>("EventID")
                        .HasColumnType("int");

                    b.Property<int>("Ranking")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time");

                    b.HasKey("LeaderboardID");

                    b.HasIndex("EventID")
                        .IsUnique();

                    b.ToTable("Leaderboards");
                });

            modelBuilder.Entity("RunBuddies.DataModel.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunnerLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Schedule")
                        .HasColumnType("date");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RunBuddies.DataModel.Verification", b =>
                {
                    b.Property<int>("VerificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VerificationID"));

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.HasKey("VerificationID");

                    b.ToTable("Verifications");
                });

            modelBuilder.Entity("RunBuddies.DataModel.BuddyPartner", b =>
                {
                    b.HasOne("RunBuddies.DataModel.User", "User")
                        .WithMany("BuddyPartners")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RunBuddies.DataModel.BuddySession", b =>
                {
                    b.HasOne("RunBuddies.DataModel.BuddyPartner", "BuddyPartner")
                        .WithMany("BuddySessions")
                        .HasForeignKey("BuddyID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RunBuddies.DataModel.Verification", "Verification")
                        .WithOne("BuddySessions")
                        .HasForeignKey("RunBuddies.DataModel.BuddySession", "VerificationID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BuddyPartner");

                    b.Navigation("Verification");
                });

            modelBuilder.Entity("RunBuddies.DataModel.Club", b =>
                {
                    b.HasOne("RunBuddies.DataModel.ClubMember", "ClubMember")
                        .WithMany("Clubs")
                        .HasForeignKey("ClubMemberID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RunBuddies.DataModel.ClubModerator", "ClubModerator")
                        .WithMany("Clubs")
                        .HasForeignKey("ClubModeratorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ClubMember");

                    b.Navigation("ClubModerator");
                });

            modelBuilder.Entity("RunBuddies.DataModel.ClubMember", b =>
                {
                    b.HasOne("RunBuddies.DataModel.User", "User")
                        .WithMany("ClubMembers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RunBuddies.DataModel.ClubModerator", b =>
                {
                    b.HasOne("RunBuddies.DataModel.User", "User")
                        .WithMany("ClubModerators")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RunBuddies.DataModel.Event", b =>
                {
                    b.HasOne("RunBuddies.DataModel.Club", "Club")
                        .WithMany("Events")
                        .HasForeignKey("ClubID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RunBuddies.DataModel.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Club");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RunBuddies.DataModel.Leaderboard", b =>
                {
                    b.HasOne("RunBuddies.DataModel.Event", "Events")
                        .WithOne("Leaderboards")
                        .HasForeignKey("RunBuddies.DataModel.Leaderboard", "EventID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Events");
                });

            modelBuilder.Entity("RunBuddies.DataModel.BuddyPartner", b =>
                {
                    b.Navigation("BuddySessions");
                });

            modelBuilder.Entity("RunBuddies.DataModel.Club", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("RunBuddies.DataModel.ClubMember", b =>
                {
                    b.Navigation("Clubs");
                });

            modelBuilder.Entity("RunBuddies.DataModel.ClubModerator", b =>
                {
                    b.Navigation("Clubs");
                });

            modelBuilder.Entity("RunBuddies.DataModel.Event", b =>
                {
                    b.Navigation("Leaderboards")
                        .IsRequired();
                });

            modelBuilder.Entity("RunBuddies.DataModel.User", b =>
                {
                    b.Navigation("BuddyPartners");

                    b.Navigation("ClubMembers");

                    b.Navigation("ClubModerators");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("RunBuddies.DataModel.Verification", b =>
                {
                    b.Navigation("BuddySessions")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
