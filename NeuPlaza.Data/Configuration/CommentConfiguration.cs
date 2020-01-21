using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeuPlaza.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.CommentContent).IsRequired();
            builder.Property(b => b.CreatedAt).IsRequired();

            builder.HasOne(p => p.User)
                  .WithMany(p => p.Comments)
                  .HasForeignKey(p => p.UserId);

            builder.HasOne(p => p.Question)
                  .WithMany(p => p.Comments)
                  .HasForeignKey(p => p.QuestionId);

            builder.HasOne(p => p.Answer)
                  .WithMany(p => p.Comments)
                  .HasForeignKey(p => p.AnswerId);

           /* builder.HasOne(u => u.UserId)
            .WithOne()
            .HasForeignKey<User>(u => u.Id)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.QuestionId)
            .WithOne()
            .HasForeignKey<Question>(u => u.Id).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.AnswerId)
            .WithOne()
            .HasForeignKey<Answer>(u => u.Id).OnDelete(DeleteBehavior.Restrict);*/

        }
    }
}
