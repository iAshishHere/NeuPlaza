using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeuPlaza.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuPlaza.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.FirstName).IsRequired();
            builder.HasIndex(b => b.UserName).IsUnique();
            builder.Property(b => b.UserName).IsRequired();
            builder.HasIndex(b => b.UserEmail).IsUnique();
            builder.Property(b => b.UserEmail).IsRequired();
            builder.Property(b => b.CreatedAt).IsRequired();
            builder.Property(b => b.Password).IsRequired();

        }
    }
}
