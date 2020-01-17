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

            builder.HasOne(u => u.QuestionId)
            .WithOne()
            .HasForeignKey<Question>(u => u.Id);

            builder.HasOne(u => u.TagId)
            .WithOne()
            .HasForeignKey<Tag>(u => u.Id).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
