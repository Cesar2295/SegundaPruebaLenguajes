using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificador.AccesoAdatos
{
    public class Context : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Persona>().ToTable("Persona");
            modelBuilder.Entity<Model.ConfiguracionDeNotificacion>().ToTable("ConfiguracionDeNotificacion");

        }
        public DbSet<Model.Persona> Persona { get; set; }
        public DbSet<Model.ConfiguracionDeNotificacion> ConfiguracionDeNotificacion { get; set; }
    }
}
