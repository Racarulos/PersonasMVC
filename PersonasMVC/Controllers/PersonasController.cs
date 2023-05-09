using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonasMVC.Models.TableViewModels;
using PersonasMVC.Models;
using PersonasMVC.Models.TableModels;

namespace PersonasMVC.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
            List<PersonasModel> lst = null;
            using (PersonasEntities db = new PersonasEntities())
            {

                lst = (
                        from d in db.InfoPersonas
                        orderby d.idPersona
                        select new PersonasModel
                        {
                            Id = d.idPersona
                            ,Nombres = d.Nombres
                            ,Apellidos = d.Apellidos
                            ,FechaNacimiento = d.FechaNacimiento
                            ,idEstadoCivil = d.idEstadoCivil
                            ,idGradoAcademico = d.idGradoAcademico
                            ,Direccion = d.Direccion

                        }).ToList();

            }

                return View(lst);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(IngresoPersonasModel modelo)
        {

            if (!ModelState.IsValid)
            {
                return View(modelo);
            }
            using (var db = new PersonasEntities())
            {

                InfoPersonas Ingreso = new InfoPersonas();

                Ingreso.idPersona = 1;
                Ingreso.Nombres = modelo.Nombres;
                Ingreso.Apellidos = modelo.Apellidos;
                Ingreso.FechaNacimiento = modelo.FechaNacimiento;
                Ingreso.idEstadoCivil = modelo.idEstadoCivil;
                Ingreso.idGradoAcademico = modelo.idGradoAcademico;
                Ingreso.Direccion = modelo.Direccion;

                db.InfoPersonas.Add(Ingreso);
                db.SaveChanges();

            }

            return Redirect(Url.Content("~/Personas/Index"));

        }

        public ActionResult Edit(int id)
        {

            EditarPersonasModel model = new EditarPersonasModel();

            using (var db =new PersonasEntities())
            {
                var Persona = db.InfoPersonas.Find(id);
                model.Nombres = Persona.Nombres;
                model.Apellidos = Persona.Apellidos;
                model.FechaNacimiento = Persona.FechaNacimiento;
                model.idEstadoCivil = Persona.idEstadoCivil;
                model.idGradoAcademico = Persona.idGradoAcademico;
                model.Direccion = Persona.Direccion;
                model.id = Persona.idPersona;

            }

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(EditarPersonasModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            using (var db = new PersonasEntities())
            {
                var Persona = db.InfoPersonas.Find(model.id);
                Persona.Nombres = model.Nombres;
                Persona.Apellidos = model.Apellidos;
                Persona.FechaNacimiento = model.FechaNacimiento;
                Persona.idEstadoCivil = model.idEstadoCivil;
                Persona.idGradoAcademico = model.idGradoAcademico;
                Persona.Direccion = model.Direccion;

                db.Entry(Persona).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return Redirect(Url.Content("~/Personas/Index"));




        }


    }
}