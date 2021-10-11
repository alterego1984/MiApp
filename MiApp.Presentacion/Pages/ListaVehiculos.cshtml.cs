using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiApp.Persistencia;
using MiApp.Dominio;

namespace MiApp.Presentacion.Pages
{
    public class ListaVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculos;

        public IEnumerable<Vehiculo> Vehiculos { get; set; }
        public ListaVehiculosModel(IRepositorioVehiculo repositorioVehiculos)
        {
            this.repositorioVehiculos = repositorioVehiculos;
        }
        public IActionResult OnGet(int accidenteId)
        {
            Vehiculos=repositorioVehiculos.GetVehiculosxAccidente(accidenteId);
            if(Vehiculos==null){
                return RedirectToPage("./Error");
            }else{
                return Page();
            }
        }
    }
}
