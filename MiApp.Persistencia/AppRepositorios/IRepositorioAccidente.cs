using System.Collections.Generic;
using MiApp.Dominio;

namespace MiApp.Persistencia
{
    public interface IRepositorioAccidente
    {
        IEnumerable<Accidente> GetAllAccidentes();
        Accidente AddAccidente(Accidente accidente);
        Accidente UpdateAccidente(Accidente accidente);
        void DeleteAccidente(int idAccidente);
        Accidente GetAccidente(int idAccidente);
    }
}