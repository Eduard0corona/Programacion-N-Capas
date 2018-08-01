using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using EC.Personas.Interfaces;
using EC.Personas;
using EC.Personas.Entidades;
using SimpleInjector.Lifestyles;

namespace CL.Personas.Pruebas
{
    [TestClass]
    public class PersonasPruebas
    {
        static Container container;
        public PersonasPruebas()
        {
            container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IPersona, PersonasNegocio>(Lifestyle.Singleton);
            container.Register<IPersonaServicio, PersonasServicio>(Lifestyle.Singleton);

            container.Verify();
        }

        [TestMethod]
        public void AgregarMedico()
        {

            var Servicio = container.GetInstance<IPersona>();

            Medico obj = new Medico()
            {
                Nombre = "Eduardo",
                ApellidoPaterno = "Corona",
                ApellidoMaterno = "",
                EsActivo = true
            };

            Servicio.MedicoGuardar(obj);
            Assert.IsTrue(obj.Id > 0);
        }

        [TestMethod]
        public void BuscarMedicoPorId()
        {
            var container = new Container();
            container = new SimpleInjector.Container();
            container.Register<IPersona, PersonasNegocio>(ScopedLifestyle.Singleton);
            container.Register<IPersonaServicio, PersonasServicio>(ScopedLifestyle.Singleton);

            Medico obj = container.GetInstance<IPersona>().MedicoBuscarPorId(1);
            Assert.IsNotNull(obj);
        }
    }
}
