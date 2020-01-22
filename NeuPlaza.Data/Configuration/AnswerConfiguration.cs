using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeuPlaza.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.AnswerContent).IsRequired();
            builder.Property(b => b.AcceptanceStatus).HasDefaultValue("False");
            builder.Property(b => b.CreatedAt).IsRequired();


            builder.HasOne(p => p.User)
                  .WithMany(p => p.Answers)
                  .HasForeignKey(p => p.UserId)
                  .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
