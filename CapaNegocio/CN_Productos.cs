using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objCapaDato = new CD_Productos();

        public List<PRODUCTOS> Listar()
        {
            return objCapaDato.Listar();
        }

        //Registrar
        public int Registrar(PRODUCTOS obj, out string Mensaje)
        {

            Mensaje = string.Empty;



            if (string.IsNullOrEmpty(obj.Nombre) || string.IsNullOrWhiteSpace(obj.Nombre))
            {
                Mensaje = "El nombre del producto no puede ser vacio";
            }
            else if (string.IsNullOrEmpty(obj.Descripcion) || string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje = "La descripcion del producto no puede ser vacio";
            }
            else if (obj.oMarca.IdMarca == 0)
            {
                Mensaje = "Debe seleccionar una marca";
            }
            else if (obj.oCategoria.IdCategoria == 0)
            {
                Mensaje = "Debe seleccionar una categoria";
            }
            else if (obj.oCategoria.IdCategoria == 0)
            {
                Mensaje = "Debe seleccionar una categoria";
            }
            else if (obj.Precio == 0)
            {

                Mensaje = "Debe ingrear el precio del producto";
            }
            else if (obj.Stock == 0)
            {

                Mensaje = "Debe ingrear el stock del producto";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {

                return objCapaDato.Registrar(obj, out Mensaje);

            }
            else
            {

                return 0;
            }
        }

        public bool Editar(PRODUCTOS obj, out string Mensaje)
        {

            Mensaje = string.Empty;


            if (string.IsNullOrEmpty(obj.Nombre) || string.IsNullOrWhiteSpace(obj.Nombre))
            {
                Mensaje = "El nombre del producto no puede ser vacio";
            }
            else if (string.IsNullOrEmpty(obj.Descripcion) || string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje = "La descripcion del producto no puede ser vacio";
            }
            else if (obj.oMarca.IdMarca == 0)
            {
                Mensaje = "Debe seleccionar una marca";
            }
            else if (obj.oCategoria.IdCategoria == 0)
            {
                Mensaje = "Debe seleccionar una categoria";
            }
            else if (obj.oCategoria.IdCategoria == 0)
            {
                Mensaje = "Debe seleccionar una categoria";
            }
            else if (obj.Precio == 0)
            {

                Mensaje = "Debe ingrear el precio del producto";
            }
            else if (obj.Stock == 0)
            {

                Mensaje = "Debe ingrear el stock del producto";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {

                return objCapaDato.Editar(obj, out Mensaje);
            }
            else
            {
                return false;
            }
        }

        public bool GuardarDatosImagen(PRODUCTOS obj, out string Mensaje)
        {

            return objCapaDato.GuardarDatosImagen(obj, out Mensaje);
        }

        public bool Eliminar(int id, out string Mensaje)
        {
            return objCapaDato.Eliminar(id, out Mensaje);
        }
    }
}
