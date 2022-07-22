﻿// <auto-generated />
using System;
using CTFServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CTFServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CTFServer.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AcceptedUserCount")
                        .HasColumnType("integer");

                    b.Property<int?>("CPUCount")
                        .HasColumnType("integer");

                    b.Property<int?>("ContainerExposePort")
                        .HasColumnType("integer");

                    b.Property<string>("ContainerImage")
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Difficulty")
                        .HasColumnType("integer");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<string>("Hints")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("boolean");

                    b.Property<int?>("MemoryLimit")
                        .HasColumnType("integer");

                    b.Property<double>("MinScoreRate")
                        .HasColumnType("double precision");

                    b.Property<int>("OriginalScore")
                        .HasColumnType("integer");

                    b.Property<int>("SubmissionCount")
                        .HasColumnType("integer");

                    b.Property<byte>("Tag")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("CTFServer.Models.Container", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ContainerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("ExpectStopAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("InstanceId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsProxy")
                        .HasColumnType("boolean");

                    b.Property<int>("Port")
                        .HasColumnType("integer");

                    b.Property<string>("PublicIP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PublicPort")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("StartedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte>("Status")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("InstanceId");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("CTFServer.Models.FlagContext", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte>("AttachmentType")
                        .HasColumnType("smallint");

                    b.Property<int>("ChallengeId")
                        .HasColumnType("integer");

                    b.Property<string>("Flag")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("boolean");

                    b.Property<int?>("LocalFileId")
                        .HasColumnType("integer");

                    b.Property<string>("RemoteUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("LocalFileId");

                    b.ToTable("FlagContexts");
                });

            modelBuilder.Entity("CTFServer.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("EndTimeUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PosterHash")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("StartTimeUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TeamMemberCountLimit")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("CTFServer.Models.GameEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("PublishTimeUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("GameEvents");
                });

            modelBuilder.Entity("CTFServer.Models.GameNotice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("PublishTimeUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("GameNotices");
                });

            modelBuilder.Entity("CTFServer.Models.Instance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ChallengeId")
                        .HasColumnType("integer");

                    b.Property<string>("ContainerId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("FlagId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsSolved")
                        .HasColumnType("boolean");

                    b.Property<int>("ParticipationId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("ContainerId")
                        .IsUnique();

                    b.HasIndex("FlagId");

                    b.HasIndex("GameId");

                    b.HasIndex("ParticipationId", "ChallengeId", "GameId");

                    b.ToTable("Instances");
                });

            modelBuilder.Entity("CTFServer.Models.LocalFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("ReferenceCount")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Hash");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("CTFServer.Models.LogModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Exception")
                        .HasColumnType("text");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Logger")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RemoteIP")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTimeOffset>("TimeUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("CTFServer.Models.Notice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsPinned")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset>("PublishTimeUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("CTFServer.Models.Participation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<int>("Score")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("TeamId", "GameId");

                    b.ToTable("Participations");
                });

            modelBuilder.Entity("CTFServer.Models.Submission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("ChallengeId")
                        .HasColumnType("integer");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<int>("ParticipationId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("SubmitTimeUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.HasIndex("ParticipationId", "ChallengeId", "GameId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("CTFServer.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AvatarHash")
                        .HasColumnType("text");

                    b.Property<string>("Bio")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("CaptainId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InviteToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Locked")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.HasIndex("CaptainId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("CTFServer.Models.UserInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<int?>("ActiveTeamId")
                        .HasColumnType("integer");

                    b.Property<string>("AvatarHash")
                        .HasColumnType("text");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("LastSignedInUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("LastVisitedUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int?>("OwnTeamId")
                        .HasColumnType("integer");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("RealName")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)");

                    b.Property<DateTimeOffset>("RegisterTimeUTC")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("StdNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("ActiveTeamId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("OwnTeamId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TeamUserInfo", b =>
                {
                    b.Property<string>("MembersId")
                        .HasColumnType("text");

                    b.Property<int>("TeamsId")
                        .HasColumnType("integer");

                    b.HasKey("MembersId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("TeamUserInfo");
                });

            modelBuilder.Entity("CTFServer.Models.Challenge", b =>
                {
                    b.HasOne("CTFServer.Models.Game", "Game")
                        .WithMany("Challenges")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("CTFServer.Models.FlagContext", b =>
                {
                    b.HasOne("CTFServer.Models.Challenge", "Challenge")
                        .WithMany("Flags")
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.LocalFile", "LocalFile")
                        .WithMany()
                        .HasForeignKey("LocalFileId");

                    b.Navigation("Challenge");

                    b.Navigation("LocalFile");
                });

            modelBuilder.Entity("CTFServer.Models.GameEvent", b =>
                {
                    b.HasOne("CTFServer.Models.Game", "Game")
                        .WithMany("GameEvents")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.UserInfo", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Game");

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CTFServer.Models.GameNotice", b =>
                {
                    b.HasOne("CTFServer.Models.Game", "Game")
                        .WithMany("GameNotices")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("CTFServer.Models.Instance", b =>
                {
                    b.HasOne("CTFServer.Models.Challenge", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.Container", "Container")
                        .WithOne("Instance")
                        .HasForeignKey("CTFServer.Models.Instance", "ContainerId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("CTFServer.Models.FlagContext", "FlagContext")
                        .WithMany()
                        .HasForeignKey("FlagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.Game", "Game")
                        .WithMany("Instances")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.Participation", "Participation")
                        .WithMany("Instances")
                        .HasForeignKey("ParticipationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Challenge");

                    b.Navigation("Container");

                    b.Navigation("FlagContext");

                    b.Navigation("Game");

                    b.Navigation("Participation");
                });

            modelBuilder.Entity("CTFServer.Models.Participation", b =>
                {
                    b.HasOne("CTFServer.Models.Game", "Game")
                        .WithMany("Teams")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.Team", "Team")
                        .WithMany("Games")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("CTFServer.Models.Submission", b =>
                {
                    b.HasOne("CTFServer.Models.Challenge", "Challenge")
                        .WithMany("Submissions")
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.Game", "Game")
                        .WithMany("Submissions")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.Participation", "Participation")
                        .WithMany("Submissions")
                        .HasForeignKey("ParticipationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.UserInfo", "User")
                        .WithMany("Submissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Challenge");

                    b.Navigation("Game");

                    b.Navigation("Participation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CTFServer.Models.Team", b =>
                {
                    b.HasOne("CTFServer.Models.UserInfo", "Captain")
                        .WithMany()
                        .HasForeignKey("CaptainId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Captain");
                });

            modelBuilder.Entity("CTFServer.Models.UserInfo", b =>
                {
                    b.HasOne("CTFServer.Models.Team", "ActiveTeam")
                        .WithMany()
                        .HasForeignKey("ActiveTeamId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("CTFServer.Models.Team", "OwnTeam")
                        .WithMany()
                        .HasForeignKey("OwnTeamId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("ActiveTeam");

                    b.Navigation("OwnTeam");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CTFServer.Models.UserInfo", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CTFServer.Models.UserInfo", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.UserInfo", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CTFServer.Models.UserInfo", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamUserInfo", b =>
                {
                    b.HasOne("CTFServer.Models.UserInfo", null)
                        .WithMany()
                        .HasForeignKey("MembersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CTFServer.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CTFServer.Models.Challenge", b =>
                {
                    b.Navigation("Flags");

                    b.Navigation("Submissions");
                });

            modelBuilder.Entity("CTFServer.Models.Container", b =>
                {
                    b.Navigation("Instance");
                });

            modelBuilder.Entity("CTFServer.Models.Game", b =>
                {
                    b.Navigation("Challenges");

                    b.Navigation("GameEvents");

                    b.Navigation("GameNotices");

                    b.Navigation("Instances");

                    b.Navigation("Submissions");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("CTFServer.Models.Participation", b =>
                {
                    b.Navigation("Instances");

                    b.Navigation("Submissions");
                });

            modelBuilder.Entity("CTFServer.Models.Team", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("CTFServer.Models.UserInfo", b =>
                {
                    b.Navigation("Submissions");
                });
#pragma warning restore 612, 618
        }
    }
}
