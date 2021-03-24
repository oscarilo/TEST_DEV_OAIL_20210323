using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST_DEV.Models;
using TEST_DEV.Models.ViewModel;

namespace TEST_DEV.Controllers
{
    public class PersonaFisicaController : Controller
    {
        // GET: PersonaFisica
        public ActionResult Inicio()
        {
            List<GetPersonaFisicaViewModel> list;
            // context
            using (TEST_DEVEntities1 db = new TEST_DEVEntities1())
            {
                list = (from data in db.Tb_PersonasFisicas
                        select new GetPersonaFisicaViewModel
                        {
                            Nombre = data.Nombre,
                            ApellidoPaterno = data.ApellidoPaterno,
                            ApellidoMaterno = data.ApellidoMaterno,
                            RFC = data.RFC,
                            FechaNacimiento = (DateTime)data.FechaNacimiento,
                            Activo = (bool)data.Activo
                        }).ToList();

            }

            return View(list);

        }// Inicio


        public ActionResult AgregarPersona()
        {

            return View();
        }

        // POST: AgregarPersona
        [HttpPost]
        public ActionResult AgregarPersona(PostPersonaFisicaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    using (var db = new TEST_DEVEntities1())
                    {

                        
                        //var data = new Tb_PersonasFisicas();
                        //data.FechaRegistro = model.FechaRegistro;
                        //data.FechaActualizacion = model.FechaActualizacion;
                        //data.Nombre = model.Nombre;
                        //data.ApellidoPaterno = model.ApellidoPaterno;
                        //data.ApellidoMaterno = model.ApellidoMaterno;
                        //data.RFC = model.RFC;
                        //data.FechaNacimiento = model.FechaNacimiento;
                        //data.UsuarioAgrega = model.UsuarioAgrega;
                        //data.Activo = model.Activo;

                        //db.Tb_PersonasFisicas.Add(data);
                        //db.SaveChanges();

                    }

                    return Redirect("~/PersonaFisica/Inicio");
                }

                return View(model);



            }// try
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }// catch

        }// AgregarPersona


    }// class

}// namespace