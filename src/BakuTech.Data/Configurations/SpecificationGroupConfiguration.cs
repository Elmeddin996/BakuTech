using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BakuTech.Core.Entities;

namespace BakuTech.Data.Configurations;

public class SpecificationGroupConfiguration : IEntityTypeConfiguration<SpecificationGroup>
{
    public void Configure(EntityTypeBuilder<SpecificationGroup> builder)
    {
        builder.ToTable("SpecificationGroups");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.NameAz)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.NameEn)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.NameRu)
            .IsRequired()
            .HasMaxLength(200);

        builder.HasIndex(x => x.NameAz);

        builder.HasIndex(x => x.DisplayOrder);
    }
}
