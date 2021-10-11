using System.Collections.Generic;
using MiApp.Dominio;

namespace MiApp.Persistencia
{
    public interface IRepositorioAccidentePersona
    {
        IEnumerable<AccidentePersona> GetAllAccidentePersona();
        AccidentePersona AddAccidentePersona(AccidentePersona accidentepersona);
        AccidentePersona UpdateAccidentePersona(AccidentePersona accidentepersona);
        void DeleteAccidentePersona(int idAccidentePersona);
        AccidentePersona GetAccidentePersona(int idAccidentePersona);
        IEnumerable<AccidentePersona> GetAccidentePersonaxDocumento(string documento);
    }
}