﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReAl.Template.Lumino.Dal.Entidades;
using ReAl.Template.Lumino.Helpers;

namespace ReAl.Template.Lumino.Controllers
{
    public class BaseController : Controller
    {
        public string getLogin()
        {
            if (User.Identity.IsAuthenticated)
                return User.Identity.Name;
            return null;
        }

        public string getUserName()
        {
            if (User.Identity.IsAuthenticated)
                return User.Identity.GetGivenName();
            return null;
        }

        public EntSegUsuario getUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                return new EntSegUsuario();
            }
            else
                return null;
        }

        protected List<EntSegAplicaciones> GetAplicaciones()
        {
            return CMenus.GetAplicaciones();
        }

        protected List<EntSegPaginas> GetPages()
        {
            return CMenus.GetPages(this.HttpContext);
        }
    }
}