using Logatti.ByBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Data.Command.Mappings
{
    public class LinhaMap : IEntityTypeConfiguration<Linha>
    {
        public void Configure(EntityTypeBuilder<Linha> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.CNPJ).IsRequired();

            builder.HasMany(x => x.Onibus)
                .WithOne(x=>x.Linha)
                .HasForeignKey(x=>x.IdLinha);

            builder.HasMany(x => x.Segmentos);


        }
    }
}
