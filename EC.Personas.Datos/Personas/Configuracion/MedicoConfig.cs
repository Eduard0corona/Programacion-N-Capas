using EC.Personas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Personas.Configuracion
{
    public class MedicoConfig : EntityTypeConfiguration<Medico>
    {
        public MedicoConfig()
        {
            ToTable("Medicos");
            HasKey(s=> s.Id);
        }
    }
}
