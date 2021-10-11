using System.Collections.Generic;
using System.Linq;
using MiApp.Dominio;

namespace MiApp.Persistencia
{
    public class RepositorioAccidentePersona:IRepositorioAccidentePersona
    {
        private readonly AppContext _appContext;
        public RepositorioAccidentePersona(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        public AccidentePersona AddAccidentePersona(AccidentePersona accidentepersona)
        {
            var accidentepersonaAdicionado = _appContext.AccidentesPersonas.Add(accidentepersona);
            _appContext.SaveChanges();
            return accidentepersonaAdicionado.Entity;
        }

        public void DeleteAccidentePersona(int idAccidentePersona)
        {
            var accidentepersonaEncontrado = _appContext.AccidentesPersonas.Find(idAccidentePersona);
            if (accidentepersonaEncontrado != null)
            {
                _appContext.Remove(accidentepersonaEncontrado);
                _appContext.SaveChanges();
            }
        }

        public AccidentePersona GetAccidentePersona(int idAccidentePersona)
        {
            var accidentepersonaEncontrado = _appContext.AccidentesPersonas.Where(p => p.Id == idAccidentePersona).FirstOrDefault();
            return accidentepersonaEncontrado;
        }

        public IEnumerable<AccidentePersona> GetAccidentePersonaxDocumento(string documento){
            var listaaccidentepersonaEncontrado = _appContext.AccidentesPersonas.Where(p => p.Persona.Documento == documento);
            return listaaccidentepersonaEncontrado;
        }

        public IEnumerable<AccidentePersona> GetAllAccidentePersona()
        {
            return _appContext.AccidentesPersonas;
        }

        public AccidentePersona UpdateAccidentePersona(AccidentePersona accidentepersona)
        {
            var accidentepersonaEncontrado = _appContext.AccidentesPersonas.Where(p => p.Id == accidentepersona.Id).FirstOrDefault();
            if (accidentepersonaEncontrado != null)
            {
                accidentepersonaEncontrado.Accidente=accidentepersona.Accidente;
                accidentepersonaEncontrado.Persona=accidentepersona.Persona;
                _appContext.SaveChanges();
            }
            return accidentepersonaEncontrado;
        }
        
    }
}