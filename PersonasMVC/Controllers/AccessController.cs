using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonasMVC.Models;


namespace PersonasMVC.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(string user, string password)
        {
            try
            {

                using (PersonasEntities db = new PersonasEntities())
                {

                    var lst = from consulta in db.Usuario
                              where consulta.Usuario1 == user && consulta.Pass == password
                              select consulta;

                    if (lst.Count() > 0)
                    {
                        Usuario oUsuario = lst.First();
                        Session["User"] = oUsuario;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario o contraseña incorrecto");
                    }

                }

            }
            catch (Exception ex)
            {
                return Content("Error" + ex.Message);
            }


        }



    }
}