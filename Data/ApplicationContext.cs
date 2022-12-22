using Microsoft.EntityFrameworkCore;
using simple_social_network.Models;
using simple_social_network.Models.CommunityModels;

namespace simple_social_network.Data
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<UserPosts> UserPosts { get; set; }
        public DbSet<UserPostLikes> UserPostLikes { get; set; }
        public DbSet<UserPostComments> UserPostComments { get; set; }
        public DbSet<Communities> Communities { get; set; }
        public DbSet<CommunitySubscriptions> CommunitySubscriptions { get; set; }
        public DbSet<CommunityPosts> CommunityPosts { get; set; }
        public DbSet<CommunityPostLikes> CommunityPostLikes { get; set; }
        public DbSet<CommunityPostComments> CommunityPostComments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=socialnetworkdb;Username=postgres;Password=Dd_14.04.2014_");
            optionsBuilder.UseSqlServer(@"Connection String Here");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommunityPostComments>()
                .HasKey(o => new { o.PostId, o.UserId });
            modelBuilder.Entity<CommunityPostComments>()
                .HasKey(o => o.UserId);
            modelBuilder.Entity<CommunityPostLikes>()
                .HasKey(o => new { o.PostId, o.UserId });
            modelBuilder.Entity<CommunitySubscriptions>()
                .HasKey(o => new { o.UserId, o.CommunityId });
            modelBuilder.Entity<UserPostComments>()
                .HasKey(o => new { o.PostId, o.UserId });
            modelBuilder.Entity<UserPostLikes>()
                .HasKey(o => new { o.PostId, o.UserId });
        }
    }
}