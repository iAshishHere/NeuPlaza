using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeuPlaza.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Configuration
{
    public class TagDetailConfiguration : IEntityTypeConfiguration<TagDetail>
    {
        public void Configure(EntityTypeBuilder<TagDetail> builder)
        {
            builder.HasKey(b => b.Id);

            builder.HasOne(p => p.Question)
                  .WithMany(p => p.TagDetails)
                  .HasForeignKey(p => p.QuestionId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Tag)
                  .WithMany(p => p.TagDetails)
                  .HasForeignKey(p => p.TagId)
                  .OnDelete(DeleteBehavior.Restrict);

            /*builder.HasOne(u => u.QuestionId)
            .WithOne()
            .HasForeignKey<Question>(u => u.Id).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.TagId)
            .WithOne()
            .HasForeignKey<Tag>(u => u.Id).OnDelete(DeleteBehavior.Restrict);*/
        }
    }
}
