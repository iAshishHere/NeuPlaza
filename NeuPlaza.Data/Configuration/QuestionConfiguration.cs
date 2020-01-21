using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeuPlaza.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.QuestionTitle).IsRequired();
            builder.Property(b => b.QuestionContent).IsRequired();
            builder.Property(b => b.CreatedDate).IsRequired();
            builder.Property(b => b.AcceptanceStatus).HasDefaultValue("False");

/*            builder.HasOne(u => u.UserId)
            .WithOne()
            .HasForeignKey<User>(u => u.Id).OnDelete(DeleteBehavior.Restrict);*/

            builder.HasOne(p => p.User)
                  .WithMany(p => p.Questions)
                  .HasForeignKey(p => p.UserId);


        }
    }
}
