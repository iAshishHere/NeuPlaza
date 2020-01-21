using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeuPlaza.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Configuration
{
    public class PointConfiguration : IEntityTypeConfiguration<Point>
    {
        public void Configure(EntityTypeBuilder<Point> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.CreatedAt).IsRequired();
            builder.Property(b => b.Upvote).HasDefaultValue("False");
            builder.Property(b => b.Downvote).HasDefaultValue("False");
            builder.Property(b => b.AcceptedAnswer).HasDefaultValue("False");

            builder.HasOne(p => p.User)
                  .WithMany(p => p.Points)
                  .HasForeignKey(p => p.UserId);

            builder.HasOne(p => p.Question)
                  .WithMany(p => p.Points)
                  .HasForeignKey(p => p.QuestionId);

            builder.HasOne(p => p.Answer)
                  .WithMany(p => p.Points)
                  .HasForeignKey(p => p.AnswerId);




            /*builder.HasOne(u => u.UserId)
            .WithOne()
            .HasForeignKey<User>(u => u.Id).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.QuestionId)
            .WithOne()
            .HasForeignKey<Question>(u => u.Id).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.AnswerId)
            .WithOne()
            .HasForeignKey<Answer>(u => u.Id).OnDelete(DeleteBehavior.Restrict);*/
        }
    }
}
