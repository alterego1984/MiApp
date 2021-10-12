using System;
using MiApp.Dominio;
using MiApp.Persistencia;
using System.Collections.Generic;

namespace MiApp.Consola
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        private static IRepositorioAccidente _repoAccidente = new RepositorioAccidente(new Persistencia.AppContext());
        private static IRepositorioAccidentePersona _repoAccidentePersona = new RepositorioAccidentePersona(new Persistencia.AppContext());
        private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");

            // string documento = "1234";

            // Persona personaencontrada = _repoPersona.GetPersonaXDocumento(documento);

            // if (personaencontrada != null)
            // {
            //     Console.WriteLine("Persona encontrada:" + personaencontrada.Nombres + " " + personaencontrada.Apellidos);
            // }
            // else
            // {
            //     Console.WriteLine("No se encontró la persona");
            // }

            // IEnumerable<AccidentePersona> accidentespersonas = _repoAccidentePersona.GetAccidentePersonaxDocumento("5");

            // foreach (AccidentePersona item in accidentespersonas)
            // {
            //     Console.WriteLine(item.Id);
            // }
            // Accidente accidenteNuevo = AddAccidente();
            // Persona personaNueva1 = Crear_Actualizar_Persona();

            // AddAccidentePersona(accidenteNuevo, personaNueva1);
            IEnumerable<Vehiculo> vehiculos=_repoVehiculo.GetVehiculosxAccidentexPlaca("RWE123");
            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo.Modelo + " - " + vehiculo.Accidente.Id.ToString() +" - "+ vehiculo.Accidente.Observacion);
            }
            
        }

        private static void AddAccidentePersona(Accidente accidenteNuevo, Persona personaNueva)
        {
            // Accidente nuevoAccidente=new Accidente();
            // Persona nuevaPersona=new Persona();

            // AccidentePersona accidentepersonaNuevo= new AccidentePersona(){
            //     Accidente=accidenteNuevo,
            //     Persona=personaNueva
            // };
            AccidentePersona accidentepersonaNuevo = new AccidentePersona();



            AccidentePersona accidentePersonaadicionado = _repoAccidentePersona.AddAccidentePersona(accidentepersonaNuevo);
            accidentePersonaadicionado.Accidente = accidenteNuevo;
            accidentePersonaadicionado.Persona = personaNueva;

            _repoAccidentePersona.UpdateAccidentePersona(accidentePersonaadicionado);

        }

        private static Persona Crear_Actualizar_Persona()
        {
            var nuevaPersona = new Persona
            {
                Nombres = "Daniel",
                Apellidos = "Aguilar",
                Edad = 25,
                Genero = Genero.Masculino,
                Documento = "123463"
            };

            Persona personaencontrada = _repoPersona.GetPersonaXDocumento(nuevaPersona.Documento);

            if (personaencontrada != null)
            {
                return personaencontrada;
            }
            else
            {
                Persona personanueva = _repoPersona.AddPersona(nuevaPersona);
                return personanueva;
            }

        }

        private static Accidente AddAccidente()
        {
            // List<Persona> listaPersonas=new List<Persona>{
            //     new Persona{Nombres="Ramiro", Apellidos="Garzía", Edad=32, Genero=Genero.Masculino,Documento="10"},
            //     new Persona{Nombres="Carmenza", Apellidos="Duque", Edad=56, Genero=Genero.Femenino,Documento="20"},
            //     new Persona{Nombres="Camilo Andrés", Apellidos="Lopez", Edad=12, Genero=Genero.Masculino,Documento="30"}
            // };   

            List<Vehiculo> listaVehiculos = new List<Vehiculo>{
                new Vehiculo{Placa= "RWE123", Modelo="2007" , Marca= 1},
                new Vehiculo{Placa= "TRQ563", Modelo="2020" , Marca= 12}
            };


            var nuevoAccidente = new Accidente
            {
                Observacion = "Vehiculo atropella a peatones",
                Vehiculos = listaVehiculos
            };
            Accidente accidenteNuevo = _repoAccidente.AddAccidente(nuevoAccidente);
            Console.WriteLine(accidenteNuevo.Id);
            return accidenteNuevo;
        }
    }
}
