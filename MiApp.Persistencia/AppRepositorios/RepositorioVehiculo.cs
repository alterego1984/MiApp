using System.Collections.Generic;
using MiApp.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MiApp.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        private readonly AppContext _appContext;
        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Vehiculo> GetVehiculosxAccidente(int idAccidente)
        {
            // var vehiculosEncontrados=_appContext.Vehiculos.Where(m=>m.AccidenteId==idAccidente);
            // return vehiculosEncontrados;
            var accidenteEncontrado = _appContext.Accidentes.Where(m => m.Id == idAccidente).Include(m => m.Vehiculos).FirstOrDefault();
            return accidenteEncontrado.Vehiculos;
        }
        public Vehiculo AddVehiculo(Vehiculo vehiculo)
        {
            var vehiculoAdicionado = _appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return vehiculoAdicionado.Entity;
        }
        public Vehiculo UpdateVehiculo(Vehiculo vehiculo)
        {
            var vehiculoEncontrado = _appContext.Vehiculos.Where(p => p.Id == vehiculo.Id).FirstOrDefault();
            if (vehiculoEncontrado != null)
            {
                vehiculoEncontrado.Placa = vehiculo.Placa;
                vehiculoEncontrado.Modelo = vehiculo.Modelo;
                vehiculoEncontrado.Marca = vehiculo.Marca;

                _appContext.SaveChanges();
            }
            return vehiculoEncontrado;
        }
        public void DeleteVehiculo(int idVehiculo)
        {
            var vehiculoEncontrado = _appContext.Vehiculos.Find(idVehiculo);
            if (vehiculoEncontrado != null)
            {
                _appContext.Remove(vehiculoEncontrado);
                _appContext.SaveChanges();
            }
        }
        public Vehiculo GetVehiculo(int idVehiculo)
        {
            var vehiculoEncontrado = _appContext.Vehiculos.Where(p => p.Id == idVehiculo).FirstOrDefault();
            return vehiculoEncontrado;
        }

        public int GetCantVehiculosxAccidente(string placa)
        {
            var vehiculosEncontrados = _appContext.Vehiculos.Where(m => m.Placa == placa).ToList();
            return vehiculosEncontrados.Count();
        }

        public IEnumerable<Vehiculo> GetVehiculosxAccidentexPlaca(string placa)
        {
            var vehiculosEncontrados = _appContext.Vehiculos.Where(m => m.Placa == placa).Include(m=>m.Accidente);
            return vehiculosEncontrados;
        }
    }
}