using EC.Personas.Entidades;
using EC.Personas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Personas
{
    public class PersonasNegocio : IPersona
    {
        readonly IPersonaServicio Servicio;
        public PersonasNegocio(IPersonaServicio _servicio)
        {
            Servicio = _servicio;
        }

        public List<Medico> MedicoBuscar()
        {
            return Servicio.MedicoBuscar(s => true).ToList();
        }

        public List<Medico> MedicoBuscarPorEstado(bool _estatus)
        {
            return Servicio.MedicoBuscar(s => s.EsActivo == _estatus).ToList();
        }

        public Medico MedicoBuscarPorId(long _id)
        {
            return Servicio.MedicoBuscarPorId(_id);
        }

        public void MedicoGuardar(Medico _medico)
        {
            if (_medico == null)
                throw new Exception("La variable médico es requerida.");

            Servicio.MedicoGuardar(_medico);
        }
    }
}
