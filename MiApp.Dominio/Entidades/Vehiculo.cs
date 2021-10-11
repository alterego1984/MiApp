namespace MiApp.Dominio
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int Marca { get; set; }
        public int AccidenteId { get; set; }
        public Accidente Accidente { get; set; }
    }
}