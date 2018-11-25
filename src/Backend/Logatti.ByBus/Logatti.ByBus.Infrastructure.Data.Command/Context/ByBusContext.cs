using Logatti.ByBus.Infrastructure.Data.Command.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Logatti.ByBus.Infrastructure.Data.Command.Context
{
    public class ByBusContext : DbContext
    {
        private bool useConfigurationFile = true;

        public ByBusContext(DbContextOptions<ByBusContext> options)
            : base(options)
        {
            useConfigurationFile = false;
        }

        public ByBusContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new HorarioMap());
            modelBuilder.ApplyConfiguration(new LinhaMap());
            modelBuilder.ApplyConfiguration(new OnibusMap());
            modelBuilder.ApplyConfiguration(new SegmentoMap());
            modelBuilder.ApplyConfiguration(new TipoDiaMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (useConfigurationFile)
            //{
            //    var config = new ConfigurationBuilder()
            //        .SetBasePath(Directory.GetCurrentDirectory())
            //        .AddJsonFile("appsettings.json")
            //        .Build();

            //    optionsBuilder.UseSqlServer(config.GetConnectionString("ByBusConn"));
            //}
        }
    }
}
