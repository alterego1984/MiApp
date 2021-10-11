using System.Collections.Generic;
using MiApp.Dominio;
using System.Linq;

namespace MiApp.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext;
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Persona AddPersona(Persona persona)
        {
            var personaAdicionado = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;
        }

        public void DeletePersona(int idPersona)
        {
            var personaEncontrado = _appContext.Personas.Find(idPersona);
            if (personaEncontrado != null)
            {
                _appContext.Remove(personaEncontrado);
                _appContext.SaveChanges();
            }
        }

        public IEnumerable<Persona> GetAllPersonas()
        {
            return _appContext.Personas;
        }

        public Persona GetPersona(int idPersona)
        {
            var personaEncontrado = _appContext.Personas.Where(p => p.Id == idPersona).FirstOrDefault();
            return personaEncontrado;
        }

        public Persona GetPersonaXDocumento(string idDocumento)
        {
            var personaEncontrado = _appContext.Personas.Where(p => p.Documento == idDocumento).FirstOrDefault();
            return personaEncontrado;
        }

        public IEnumerable<Persona> GetPersonasXAccidente(int idAccidente)
        {
            var accidenteEncontrado=_appContext.Accidentes.Where(m=>m.Id==idAccidente).FirstOrDefault();
            var personaEncontrado = _appContext.AccidentesPersonas.Where(p => p.Accidente == accidenteEncontrado).Select(m=> m.Persona);
            return personaEncontrado;
        }

        public Persona UpdatePersona(Persona persona)
        {
            var personaEncontrado = _appContext.Personas.Where(p => p.Id == persona.Id).FirstOrDefault();
            if (personaEncontrado != null)
            {
                personaEncontrado.Nombres = persona.Nombres;
                personaEncontrado.Apellidos = persona.Apellidos;
                personaEncontrado.Edad = persona.Edad;
                personaEncontrado.Genero = persona.Genero;

                _appContext.SaveChanges();
            }
            return personaEncontrado;

        }
    }

}