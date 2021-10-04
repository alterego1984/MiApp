using System.Collections.Generic;
namespace MiApp.Dominio
{
    public class Accidente
    {
        public int Id {get;set;}
        public List<Persona> Persona {get;set;}
        public List<Vehiculo> Vehiculo {get;set;}
        public string Observacion {get;set;}
    }
}