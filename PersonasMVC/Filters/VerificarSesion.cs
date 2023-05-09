using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonasMVC.Models;
using PersonasMVC.Controllers;
using System.Web.Mvc;

namespace PersonasMVC.Filters
{
    public class VerificarSesion : ActionFilterAttribute
    {

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var oUsuario = (Usuario)HttpContext.Current.Session["User"];

            if (oUsuario == null)
            {
                if (filterContext.Controller is AccessController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Access/Index");
                }

            }

            base.OnActionExecuted(filterContext);
        }

    }
}