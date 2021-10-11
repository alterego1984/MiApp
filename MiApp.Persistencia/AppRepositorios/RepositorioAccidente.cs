using System.Collections.Generic;
using System.Linq;
using MiApp.Dominio;

namespace MiApp.Persistencia
{
    public class RepositorioAccidente : IRepositorioAccidente
    {
        private readonly AppContext _appContext;
        public RepositorioAccidente(AppContext appContext)
        {
            _appContext = appContext;
        }
        public Accidente AddAccidente(Accidente accidente)
        {
            var accidenteAdicionado = _appContext.Accidentes.Add(accidente);
            _appContext.SaveChanges();
            return accidenteAdicionado.Entity;
        }

        public void DeleteAccidente(int idAccidente)
        {
            var accidenteEncontrado = _appContext.Accidentes.Find(idAccidente);
            if (accidenteEncontrado != null)
            {
                _appContext.Remove(accidenteEncontrado);
                _appContext.SaveChanges();
            }
        }

        public Accidente GetAccidente(int idAccidente)
        {
            var accidenteEncontrado = _appContext.Accidentes.Where(p => p.Id == idAccidente).FirstOrDefault();
            return accidenteEncontrado;
        }

        public IEnumerable<Accidente> GetAllAccidentes()
        {
            return _appContext.Accidentes;
        }

        public Accidente UpdateAccidente(Accidente accidente)
        {
            var accidenteEncontrado = _appContext.Accidentes.Where(p => p.Id == accidente.Id).FirstOrDefault();
            if (accidenteEncontrado != null)
            {
                accidenteEncontrado.Observacion = accidente.Observacion;
                // accidenteEncontrado.Persona = accidente.Persona;
                accidenteEncontrado.Vehiculos = accidente.Vehiculos;
                _appContext.SaveChanges();
            }
            return accidenteEncontrado;
        }
    }
}