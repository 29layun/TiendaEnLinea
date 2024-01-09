using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CapaEntidad;
using CapaNegocio;
using Newtonsoft.Json;

namespace CapaPresentacionAdmin.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor
        public ActionResult Categorias()
        {
            return View();
        }
        public ActionResult Marcas()
        {
            return View();
        }
        public ActionResult Productos()
        {
            return View();
        }

        // ++++++++++++++++ CATEGORIAS ++++++++++++++++++++

        #region CATEGORIA

        [HttpGet]
        public JsonResult ListarCategorias()
        {

            List<CATEGORIAS> oLista = new List<CATEGORIAS>();
            oLista = new CN_Categorias().Listar();
            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public JsonResult GuardarCategoria(CATEGORIAS objeto)
        {
            object resultado;
            string mensaje = string.Empty;

            if (objeto.IdCategoria == 0)
            {

                resultado = new CN_Categorias().Registrar(objeto, out mensaje);
            }
            else
            {
                resultado = new CN_Categorias().Editar(objeto, out mensaje);

            }

            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        public JsonResult EliminarCategoria(int id)
        {
            bool respuesta = false;
            string mensaje = string.Empty;

            respuesta = new CN_Categorias().Eliminar(id, out mensaje);

            return Json(new { resultado = respuesta, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        #endregion


        // ++++++++++++++++ MARCAS ++++++++++++++++++++
        /*
        #region MARCAS

        [HttpGet]
        public JsonResult ListarMarcas()
        {

            List<MARCAS> oLista = new List<MARCAS>();
            oLista = new CN_Marcas().Listar();
            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public JsonResult GuardarMarcas(MARCAS objeto)
        {
            object resultado;
            string mensaje = string.Empty;

            if (objeto.IdMarca == 0)
            {

                resultado = new CN_Marcas().Registrar(objeto, out mensaje);
            }
            else
            {
                resultado = new CN_Marcas().Editar(objeto, out mensaje);

            }

            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        public JsonResult EliminarMarcas(int id)
        {
            bool respuesta = false;
            string mensaje = string.Empty;

            respuesta = new CN_Marcas().Eliminar(id, out mensaje);

            return Json(new { resultado = respuesta, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        #endregion
        */
    }
}