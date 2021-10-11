using System.Collections.Generic;
using MiApp.Dominio;

namespace MiApp.Persistencia
{
    public interface IRepositorioVehiculo
    {
        IEnumerable<Vehiculo> GetVehiculosxAccidente(int idAccidente);
        Vehiculo AddVehiculo(Vehiculo vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(int idVehiculo);
        Vehiculo GetVehiculo(int idVehiculo);
    }
}