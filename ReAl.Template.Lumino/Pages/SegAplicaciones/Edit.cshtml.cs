using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReAl.Template.Lumino.Dal.Entidades;
using ReAl.Template.Lumino.Helpers;
using ReAl.Template.Lumino.Models;

namespace ReAl.Template.Lumino.Pages.SegAplicaciones
{
    [Authorize]
    public class EditModel: BasePageModel
    {
        public List<EntSegAplicaciones> ListApp { get; private set; }
        public List<EntSegPaginas> ListPages { get; private set; }
        public string Usuario { get; private set; }

        [BindProperty]
        public EntSegAplicaciones MiAplicacion { get; set; }
        
        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult OnGetAsync(string id)
        {
            ListApp = this.GetAplicaciones();
            ListPages = this.GetPages();
            Usuario = this.getUserName();
            
            //Obtenemos el objeto
            MiAplicacion = DataExample.AppListado.SingleOrDefault(x => x.aplicacionsap == id);
            
            if (MiAplicacion == null)
            {
                return RedirectToPage("./Index");
            }

            return Page();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                //Guardamos el registro
            
                //Redireccionamos
                return RedirectToPage("./Index");
            }
            else
            {
                ListApp = this.GetAplicaciones();
                ListPages = this.GetPages();
                Usuario = this.getUserName();
                ModelState.AddModelError("", string.Join("; ", ModelState.Values
                    .SelectMany(x => x.Errors)
                    .Select(x => x.ErrorMessage)));
            }
            return Page();
        }
    }
}