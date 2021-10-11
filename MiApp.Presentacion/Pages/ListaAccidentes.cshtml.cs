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
    public class ListaAccidentesModel : PageModel
    {
        private readonly IRepositorioAccidente repositorioAccidentes;

        public IEnumerable<Accidente> Accidentes { get; set; }
        public ListaAccidentesModel(IRepositorioAccidente repositorioAccidentes)
        {
            this.repositorioAccidentes = repositorioAccidentes;
        }
        public void OnGet()
        {
            Accidentes=repositorioAccidentes.GetAllAccidentes();
        }
    }
}
