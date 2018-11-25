using Logatti.ByBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Data.Command.Mappings
{
    public class HorarioMap : IEntityTypeConfiguration<Horario>
    {
        public void Configure(EntityTypeBuilder<Horario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdSegmento).IsRequired();
            builder.Property(x => x.IdTipoDia).IsRequired();
            builder.Property(x => x.TabelaHoras).IsRequired();

            builder.HasOne(x => x.Segmento)
                .WithMany(x => x.Horarios)
                .HasForeignKey(x => x.IdSegmento);

            //builder.HasOne(x => x.TipoDia);

        }
    }
}
