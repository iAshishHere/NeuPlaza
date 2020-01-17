﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NeuPlaza.Data;

namespace NeuPlaza.Data.Migrations
{
    [DbContext(typeof(NeuPlazaDbContext))]
    partial class NeuPlazaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Schema_NeuPlaza")
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NeuPlaza.Data.Model.Answer", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("AcceptanceStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("AnswerContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("NeuPlaza.Data.Model.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("NeuPlaza.Data.Model.Point", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AcceptedAnswer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Downvote")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("Upvote")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("NeuPlaza.Data.Model.Question", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("AcceptanceStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuestionContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("NeuPlaza.Data.Model.Tag", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TagName")
                        .IsUnique()
                        .HasFilter("[TagName] IS NOT NULL");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("NeuPlaza.Data.Model.TagDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("TagDetails");
                });

            modelBuilder.Entity("NeuPlaza.Data.Model.User", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirstName")
                        .IsUnique();

                    b.HasIndex("UserEmail")
                        .IsUnique()
                        .HasFilter("[UserEmail] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NeuPlaza.Data.Model.Answer", b =>
                {
                    b.HasOne("NeuPlaza.Data.Model.Comment", null)
                        .WithOne("AnswerId")
                        .HasForeignKey("NeuPlaza.Data.Model.Answer", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NeuPlaza.Data.Model.Point", null)
                        .WithOne("AnswerId")
                        .HasForeignKey("NeuPlaza.Data.Model.Answer", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("NeuPlaza.Data.Model.Question", b =>
                {
                    b.HasOne("NeuPlaza.Data.Model.Comment", null)
                        .WithOne("QuestionId")
                        .HasForeignKey("NeuPlaza.Data.Model.Question", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NeuPlaza.Data.Model.Point", null)
                        .WithOne("QuestionId")
                        .HasForeignKey("NeuPlaza.Data.Model.Question", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NeuPlaza.Data.Model.TagDetail", null)
                        .WithOne("QuestionId")
                        .HasForeignKey("NeuPlaza.Data.Model.Question", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NeuPlaza.Data.Model.Tag", b =>
                {
                    b.HasOne("NeuPlaza.Data.Model.TagDetail", null)
                        .WithOne("TagId")
                        .HasForeignKey("NeuPlaza.Data.Model.Tag", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("NeuPlaza.Data.Model.User", b =>
                {
                    b.HasOne("NeuPlaza.Data.Model.Answer", null)
                        .WithOne("UserId")
                        .HasForeignKey("NeuPlaza.Data.Model.User", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NeuPlaza.Data.Model.Comment", null)
                        .WithOne("UserId")
                        .HasForeignKey("NeuPlaza.Data.Model.User", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NeuPlaza.Data.Model.Point", null)
                        .WithOne("UserId")
                        .HasForeignKey("NeuPlaza.Data.Model.User", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NeuPlaza.Data.Model.Question", null)
                        .WithOne("UserId")
                        .HasForeignKey("NeuPlaza.Data.Model.User", "Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}