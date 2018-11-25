using Logatti.ByBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Data.Command.Mappings
{
    public class OnibusMap : IEntityTypeConfiguration<Onibus>
    {
        public void Configure(EntityTypeBuilder<Onibus> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdLinha).IsRequired();
            builder.Property(x => x.CNPJ).IsRequired();

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.Onibus)
                .HasForeignKey(x => x.CNPJ);
                
        }
    }
}
