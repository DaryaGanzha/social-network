﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using simple_social_network.Data;

namespace simple_social_network.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221220220050_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("simple_social_network.Models.CommunityModels.Communities", b =>
                {
                    b.Property<Guid>("CommunityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommunityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommunityId");

                    b.ToTable("Communities");
                });

            modelBuilder.Entity("simple_social_network.Models.CommunityModels.CommunityPostComments", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostCommentDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.HasIndex("PostId");

                    b.ToTable("CommunityPostComments");
                });

            modelBuilder.Entity("simple_social_network.Models.CommunityModels.CommunityPostLikes", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostId", "UserId");

                    b.ToTable("CommunityPostLikes");
                });

            modelBuilder.Entity("simple_social_network.Models.CommunityModels.CommunityPosts", b =>
                {
                    b.Property<Guid>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommunityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PostId");

                    b.HasIndex("CommunityId");

                    b.ToTable("CommunityPosts");
                });

            modelBuilder.Entity("simple_social_network.Models.CommunityModels.CommunitySubscriptions", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommunityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CommunityPostsPostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SubscribeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "CommunityId");

                    b.HasIndex("CommunityId");

                    b.HasIndex("CommunityPostsPostId");

                    b.ToTable("CommunitySubscriptions");
                });

            modelBuilder.Entity("simple_social_network.Models.Friendship", b =>
                {
                    b.Property<Guid>("FriendshipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FirstFriendId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FriendshipStartTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SecondFriendId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FriendshipId");

                    b.HasIndex("UserId");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("simple_social_network.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CurrentCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("simple_social_network.Models.UserPostComments", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CommentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId", "UserId");

                    b.ToTable("UserPostComments");
                });

            modelBuilder.Entity("simple_social_network.Models.UserPostLikes", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostId", "UserId");

                    b.ToTable("UserPostLikes");
                });

            modelBuilder.Entity("simple_social_network.Models.UserPosts", b =>
                {
                    b.Property<Guid>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPosts");
                });

            modelBuilder.Entity("simple_social_network.Models.CommunityModels.CommunityPostComments", b =>
                {
                    b.HasOne("simple_social_network.Models.CommunityModels.CommunityPosts", "CommunityPost")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("simple_social_network.Models.CommunityModels.CommunityPostLikes", b =>
                {
                    b.HasOne("simple_social_network.Models.CommunityModels.CommunityPosts", "CommunityPost")
                        .WithMany("CommunityPostLikes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("simple_social_network.Models.CommunityModels.CommunityPosts", b =>
                {
                    b.HasOne("simple_social_network.Models.CommunityModels.Communities", "Community")
                        .WithMany("CommunityPosts")
                        .HasForeignKey("CommunityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("simple_social_network.Models.CommunityModels.CommunitySubscriptions", b =>
                {
                    b.HasOne("simple_social_network.Models.CommunityModels.Communities", "Community")
                        .WithMany("CommunitySubscriptions")
                        .HasForeignKey("CommunityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("simple_social_network.Models.CommunityModels.CommunityPosts", null)
                        .WithMany("CommunitySubscriptions")
                        .HasForeignKey("CommunityPostsPostId");

                    b.HasOne("simple_social_network.Models.User", "User")
                        .WithMany("CommunitySubscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("simple_social_network.Models.Friendship", b =>
                {
                    b.HasOne("simple_social_network.Models.User", "User")
                        .WithMany("Friendships")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("simple_social_network.Models.UserPostComments", b =>
                {
                    b.HasOne("simple_social_network.Models.UserPosts", "UserPost")
                        .WithMany("UserPostComments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("simple_social_network.Models.UserPostLikes", b =>
                {
                    b.HasOne("simple_social_network.Models.UserPosts", "UserPost")
                        .WithMany("UserPostLikes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("simple_social_network.Models.UserPosts", b =>
                {
                    b.HasOne("simple_social_network.Models.User", "User")
                        .WithMany("UserPosts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
