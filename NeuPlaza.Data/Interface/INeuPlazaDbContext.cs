using Microsoft.EntityFrameworkCore;
using NeuPlaza.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Interface
{
    public interface INeuPlazaDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<Answer> Answers { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Point> Points { get; set; }
        DbSet<Tag> Tags { get; set; }
        DbSet<TagDetail> TagDetails { get; set; }
    }
}
