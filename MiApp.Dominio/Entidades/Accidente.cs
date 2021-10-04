namespace MiApp.Dominio
{
    public class Accidente
    {
        public int Id {get;set;}
        public Persona Persona {get;set;}
        public Vehiculo Vehiculo {get;set;}
        public string Observacion {get;set;}
    }
}