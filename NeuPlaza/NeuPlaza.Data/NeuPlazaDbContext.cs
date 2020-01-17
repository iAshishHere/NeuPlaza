using Microsoft.EntityFrameworkCore;
using NeuPlaza.Data.Configuration;
using NeuPlaza.Data.Interface;
using NeuPlaza.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NeuPlaza.Data
{
    public class NeuPlazaDbContext : DbContext, INeuPlazaDbContext
    {
        public NeuPlazaDbContext()
           //: base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagDetail> TagDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DB_NeuPlaza;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Schema_NeuPlaza");
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new TagDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PointConfiguration());
        }

    //public async Task<int> SaveChangesAsync()
    //{
    //    return await base.SaveChangesAsync();
    //}


}
}