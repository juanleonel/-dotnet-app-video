using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity; 

namespace CodeFirstAppVideo.Domain.Models
{
    public class VideoContext : DbContext
    {
        public VideoContext(DbContextOptions<VideoContext> options) : base(options) { }

        public DbSet<Video> Video { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserClaim> UserClaim { get; set; }
        public DbSet<UserToken> UserToken { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=videoDB;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
