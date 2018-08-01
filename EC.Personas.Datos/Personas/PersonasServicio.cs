using EC.Personas.Entidades;
using EC.Personas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EC.Personas
{
    public class PersonasServicio : IPersonaServicio
    {
        readonly PersonasContexto db;
        public PersonasServicio()
        {
            db = new PersonasContexto();
        }

        public IQueryable<Medico> MedicoBuscar(Expression<Func<Medico, bool>> _donde)
        {
            return db.Medico.Where(_donde);
        }

        public Medico MedicoBuscarPorId(long _id)
        {
            return db.Medico.Find(_id);
        }

        public void MedicoGuardar(Medico _medico)
        {
            db.Entry(_medico).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
    }
}
