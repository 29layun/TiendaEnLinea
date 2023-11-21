using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DETALLE_VENTAS
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public PRODUCTOS oProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string IdTransaccion { get; set; }
    }
}
