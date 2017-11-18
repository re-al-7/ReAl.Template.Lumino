using System.Collections.Generic;
using ReAl.Template.Lumino.Dal.Entidades;
using ReAl.Template.Lumino.Models;

namespace ReAl.Template.Lumino.Pages.Template
{
    public class TablesModel: BasePageModel
    {
        public List<EntSegAplicaciones> ListApp { get; private set; }
        public List<EntSegPaginas> ListPages { get; private set; }
        public string Usuario { get; private set; }

        public void OnGet()
        {
            ListApp = this.GetAplicaciones();
            ListPages = this.GetPages();
            Usuario = this.getUserName();
        }
    }
}