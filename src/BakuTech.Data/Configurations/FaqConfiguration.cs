using BakuTech.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakuTech.Data.Configurations;

public class FaqConfiguration : IEntityTypeConfiguration<Faq>
{
    public void Configure(EntityTypeBuilder<Faq> builder)
    {
        builder.ToTable("Faqs");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.QuestionAz)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.QuestionEn)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.QuestionRu)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.AnswerAz)
            .IsRequired();

        builder.Property(x => x.AnswerEn)
            .IsRequired();

        builder.Property(x => x.AnswerRu)
            .IsRequired();

        builder.Property(x => x.DisplayOrder)
            .HasDefaultValue(0);
    }
}
