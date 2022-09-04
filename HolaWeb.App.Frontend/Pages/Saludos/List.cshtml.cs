using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HolaWeb.App.Persistencia.AppRepositorios;
using HolaWeb.App.Dominio;


namespace HolaWeb.App.Fronetend.pages
{
    public class ListModel : PageModel
    {
        //private string[] saludos = {"Buenos dias", "Buenas tardes", "Buenas noches", "Hasta mañana"};

        //public List<string> ListaSaludos { get; set; }

        private readonly IRepositorioSaludos repositorioSaludos;
        public IEnumerable<Saludo> Saludos {get;set;}

        public ListModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos=repositorioSaludos;
        }

        public void OnGet()
        {

            //ListaSaludos = new List<string>();
            //ListaSaludos.AddRange(saludos);
            Saludos=repositorioSaludos.GetAll();

        }
    }
}
