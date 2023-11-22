using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Usuarios()
        {
            return View();
        }

        public JsonResult ListarUsuarios()
        {
            List<USUARIOS> oLista = new List<USUARIOS>();
            oLista = new CN_Usuarios().Listar();

            return Json(oLista, JsonRequestBehavior.AllowGet);
        }
    }
}