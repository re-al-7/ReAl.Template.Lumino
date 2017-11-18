// // <copyright file="Dashboard.cshtml.cs" company="INTEGRATE - Soluciones Informaticas">
// // Copyright (c) 2016 Todos los derechos reservados
// // </copyright>
// // <author>re-al </author>
// // <date>2017-11-16 21:42</date>

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReAl.Template.Lumino.Dal.Entidades;
using ReAl.Template.Lumino.Models;

namespace ReAl.Template.Lumino.Pages
{
    public class DashboardModel : BasePageModel
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