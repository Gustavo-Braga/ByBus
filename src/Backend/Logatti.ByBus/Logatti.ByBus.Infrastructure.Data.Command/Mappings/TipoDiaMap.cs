using Logatti.ByBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Infrastructure.Data.Command.Mappings
{
    public class TipoDiaMap : IEntityTypeConfiguration<TipoDia>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TipoDia> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Tipo).IsRequired();
        }
    }
}
