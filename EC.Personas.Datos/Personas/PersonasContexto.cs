using EC.Personas.Configuracion;
using EC.Personas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Personas
{
    public class PersonasContexto : DbContext
    {
        public PersonasContexto() : base("Conexion") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new MedicoConfig());
        }
        public DbSet<Medico> Medico { get; set; }
    }
}
