using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VideoGamesApi.Modules.Achievements.entities;
using VideoGamesApi.Modules.Characters.entities;
using VideoGamesApi.Modules.Comments_Reviews.entities;
using VideoGamesApi.Modules.Games.entities;
using VideoGamesApi.Modules.Guides.entities;

namespace VideoGamesApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<CommentReview> CommentsReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Characters)
                .WithOne(c => c.Game)
                .HasForeignKey(c => c.GameId);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Achievements)
                .WithOne(a => a.Game)
                .HasForeignKey(a => a.GameId);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Guides)
                .WithOne(gu => gu.Game)
                .HasForeignKey(gu => gu.GameId);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.CommentsReviews)
                .WithOne(cr => cr.Game)
                .HasForeignKey(cr => cr.GameId);
        }
    }
}