﻿// <auto-generated />
using System;
using ChatAppDatabaseLibraryy.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseLibrary.Migrations
{
    [DbContext(typeof(ChatAppDb))]
    partial class ChatAppDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Concrets.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Concrets.GroupAndUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupAndUser");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Concrets.GroupMessages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FromId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupMessages");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Concrets.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("VideoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 2,
                            VideoPath = "\\Database\\Statues\\video1.mp4"
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2,
                            VideoPath = "\\Database\\Statues\\video2.mp4"
                        },
                        new
                        {
                            Id = 3,
                            UserId = 2,
                            VideoPath = "\\Database\\Statues\\video3.mp4"
                        },
                        new
                        {
                            Id = 4,
                            UserId = 2,
                            VideoPath = "\\Database\\Statues\\video4.mp4"
                        },
                        new
                        {
                            Id = 5,
                            UserId = 2,
                            VideoPath = "\\Database\\Statues\\video5.mp4"
                        });
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Concrets.UserConnection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("FromConnectedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FromId")
                        .HasColumnType("int");

                    b.Property<bool>("SofDeleteFrom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("SoftDeleteTo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("ToConnectedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ToId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("ConnectionsTb");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<int>("FromId")
                        .HasColumnType("int");

                    b.Property<int>("ToId")
                        .HasColumnType("int");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bio")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasAnnotation("RegularExpression", "^[a-zA-Z0-9._%+-]+@gmail\\.com$");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsUsing")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("RegularExpression", "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()-_+=])[A-Za-z\\d!@#$%^&*()-_+=]{8,}$");

                    b.HasKey("Id");

                    b.HasIndex("Gmail")
                        .IsUnique();

                    b.ToTable("UsersTbs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "I am John",
                            Gmail = "John",
                            ImagePath = "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png",
                            IsUsing = false,
                            Password = "1234"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "I am BlackBoy",
                            Gmail = "BlackBoy",
                            ImagePath = "\\Images\\3135715.png",
                            IsUsing = false,
                            Password = "1234"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "I am Cavanshir",
                            Gmail = "Cavanshir",
                            ImagePath = "\\Images\\download (1).jpeg",
                            IsUsing = false,
                            Password = "1234"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "I am Qudret",
                            Gmail = "Qudret",
                            ImagePath = "\\Images\\photo-little-brunet-boy-wear-260nw-2030792027.webp",
                            IsUsing = false,
                            Password = "1234"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "I am Michail",
                            Gmail = "Michail",
                            ImagePath = "\\Images\\3135715.png",
                            IsUsing = false,
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Concrets.GroupAndUser", b =>
                {
                    b.HasOne("ChatAppModelsLibrary.Models.Concrets.Group", "Group")
                        .WithMany("GroupAndUsers")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatAppModelsLibrary.Models.User", "User")
                        .WithMany("GroupAndUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Concrets.GroupMessages", b =>
                {
                    b.HasOne("ChatAppModelsLibrary.Models.User", "From")
                        .WithMany("GroupMessages")
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ChatAppModelsLibrary.Models.Concrets.Group", "Group")
                        .WithMany("Messages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("From");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Concrets.Status", b =>
                {
                    b.HasOne("ChatAppModelsLibrary.Models.User", "User")
                        .WithMany("Status")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Concrets.UserConnection", b =>
                {
                    b.HasOne("ChatAppModelsLibrary.Models.User", "From")
                        .WithMany("ConnectionFroms")
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ChatAppModelsLibrary.Models.User", "To")
                        .WithMany("ConnectionTos")
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("From");

                    b.Navigation("To");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Message", b =>
                {
                    b.HasOne("ChatAppModelsLibrary.Models.User", "From")
                        .WithMany("MessagesFroms")
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ChatAppModelsLibrary.Models.User", "To")
                        .WithMany("MessagesTo")
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("From");

                    b.Navigation("To");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.Concrets.Group", b =>
                {
                    b.Navigation("GroupAndUsers");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("ChatAppModelsLibrary.Models.User", b =>
                {
                    b.Navigation("ConnectionFroms");

                    b.Navigation("ConnectionTos");

                    b.Navigation("GroupAndUsers");

                    b.Navigation("GroupMessages");

                    b.Navigation("MessagesFroms");

                    b.Navigation("MessagesTo");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
