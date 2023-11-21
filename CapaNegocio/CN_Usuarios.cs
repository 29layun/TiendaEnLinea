using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CN_Usuarios objCapaDato = new CN_Usuarios();

        public List<USUARIOS> Listar()
        {
            return objCapaDato.Listar();
        }

    }
}
