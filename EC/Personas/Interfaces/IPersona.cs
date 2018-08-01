using EC.Personas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Personas.Interfaces
{
    public interface IPersona
    {
        void MedicoGuardar(Medico _medico);
        Medico MedicoBuscarPorId(long _id);
        List<Medico> MedicoBuscar();
        List<Medico> MedicoBuscarPorEstado(bool _estatus);

    }
}
