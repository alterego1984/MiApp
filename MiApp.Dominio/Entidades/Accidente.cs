using System.Collections.Generic;
namespace MiApp.Dominio
{
    public class Accidente
    {
        public int Id {get;set;}
        public IEnumerable<Vehiculo> Vehiculos {get;set;}
        public string Observacion {get;set;}
    }
}