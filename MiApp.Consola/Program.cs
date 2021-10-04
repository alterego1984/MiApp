using System;
using MiApp.Dominio;
using MiApp.Persistencia;

namespace MiApp.Consola
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddPersona();
        }

        private static void AddPersona()
        {
            var nuevaPersona = new Persona
            {
                Nombres = "Daniel",
                Apellidos = "Aguilar",
                Edad = 25,
                Genero = Genero.Masculino
            };
            _repoPersona.AddPersona(nuevaPersona);
        }
    }
}
