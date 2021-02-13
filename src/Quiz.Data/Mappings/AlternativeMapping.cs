using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.Business.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Data.Mappings
{
    public class AlternativeMapping : IEntityTypeConfiguration<Alternative>
    {
        public void Configure(EntityTypeBuilder<Alternative> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnType("NVARCHAR(MAX)");

            builder.Property(p => p.IsCorrect)
                .IsRequired()
                .HasColumnType("BIT");

            builder.ToTable("Alternatives");
        }
    }
}
