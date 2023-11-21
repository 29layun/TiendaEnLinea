using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CARRITO
    {
        public int IdCarrito { get; set; }
        public CLIENTES oCliente { get; set; }
        public PRODUCTOS oProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
