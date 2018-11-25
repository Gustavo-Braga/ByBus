using Logatti.ByBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Data.Command.Mappings
{
    public class SegmentoMap : IEntityTypeConfiguration<Segmento>
    {
        public void Configure(EntityTypeBuilder<Segmento> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Logradouro).IsRequired();
            builder.Property(x => x.IdLinha).IsRequired();

            builder.HasOne(x => x.Linha)
                .WithMany(x => x.Segmentos)
                .HasForeignKey(x => x.IdLinha);

            builder.HasMany(x => x.Horarios);
        }
    }
}
