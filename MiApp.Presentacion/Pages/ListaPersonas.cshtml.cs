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
    public class ListaPersonasModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;

        public IEnumerable<Persona> Personas { get; set; }
        public ListaPersonasModel(IRepositorioPersona repositorioPersona)
        {
            this.repositorioPersona = repositorioPersona;
        }
        public IActionResult OnGet(int accidenteId)
        {
            Personas=repositorioPersona.GetPersonasXAccidente(accidenteId);
            if(Personas==null){
                return RedirectToPage("./Error");
            }else{
                return Page();
            }
        }
    }
}
