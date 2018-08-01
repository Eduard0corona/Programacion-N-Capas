using EC.Personas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EC.Personas.Interfaces
{
    public interface IPersonaServicio
    {
        void MedicoGuardar(Medico _medico);
        IQueryable<Medico> MedicoBuscar(Expression<Func<Medico, bool>> _donde);
        Medico MedicoBuscarPorId(long _id);
    }
}
