using System;
namespace MiApp.Dominio
{
    public class AgenteTransito:Persona
    {
        public int Id {get;set;}
        public string CodigoAgente {get;set;}
        public DateTime FechaRegistro {get;set;}
    }
}