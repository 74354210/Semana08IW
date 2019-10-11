using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo02.Controllers
{
    public class ProfesionController : Controller
    {
        public object elemento { get; private set; }

        // GET: Profesion
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult listarTodo()
        {
            List<WebDemo02.Models.Profesion> elListado = new List<Models.Profesion>();

            //WebDemo02.Models.Profesion objeto01 = new Models.Profesion();
            //objeto01.Codigo = 100;
            //objeto01.Nombre = "Cheff";
            //objeto01.Descripcion = "Artes culinarios";
            //elListado.Add(objeto01);

            //WebDemo02.Models.Profesion objeto02 = new Models.Profesion();
            //objeto02.Codigo = 101;
            //objeto02.Nombre = "Arquitecto";
            //objeto02.Descripcion = "Hace diseños";
            //elListado.Add(objeto02);
            Demo03Entities misdatos = new Demo03Entities();

            foreach (tblProfesion tblProfesion elemento in misdatos.tblCalificacion) ;


            WebDemo02.Models.Calificacion objeto02 = new Models.Calificacion();
            objeto02.Codigo = elemento.codigo;
            objeto02.Nombre = elemneto.Nombre;
           
            elListado.Add(objeto02);
            return Json(elListado,JsonRequestBehavior.AllowGet);
        }

    }
}