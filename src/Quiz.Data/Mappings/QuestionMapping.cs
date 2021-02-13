using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.Business.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Data.Mappings
{
    public class QuestionMapping : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnType("NVARCHAR(MAX)");

            builder.Property(p => p.QuestionLevel)
                .IsRequired()
                .HasConversion<string>();

            builder.HasMany(q => q.Alternatives)
                .WithOne(a => a.Question)
                .HasForeignKey(a => a.QuestionId);

            builder.ToTable("Questions");
        }
    }
}
