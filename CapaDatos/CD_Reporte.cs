using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;

using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace CapaDatos
{
    public class CD_Reporte
    {
        public List<Reporte> Ventas(string Fechainicio, string Fechafin, string Idtransaccion)
        {
            List<Reporte> lista = new List<Reporte>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", oconexion);
                    cmd.Parameters.AddWithValue("Fechainicio", Fechainicio);
                    cmd.Parameters.AddWithValue("Fechafin", Fechafin);
                    cmd.Parameters.AddWithValue("Idtransaccion", Idtransaccion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(
                                new Reporte()
                                {
                                    FechaVenta = dr["FechaVenta"].ToString(),
                                    Cliente = dr["Cliente"].ToString(),
                                    Producto = dr["Producto"].ToString(),
                                    Precio = Convert.ToDecimal(dr["Precio"],new CultureInfo("es-MX")),
                                    Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                    Total = Convert.ToDecimal(dr["Total"],new CultureInfo("es-MX")),
                                    IdTransaccion = dr["IdTransaccion"].ToString()
                                });
                        }
                    }
                    oconexion.Close();
                }
            }
            catch
            {
                lista = new List<Reporte>();
            }
            return lista;

        }
        public DashBoard VerDashBoard()
        {

            DashBoard objeto = new DashBoard();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {

                    SqlCommand cmd = new SqlCommand("sp_ReporteDashboard", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            objeto = new DashBoard()
                            {
                                TotalClientes = Convert.ToInt32(dr["TotalClientes"]),
                                TotalVenta = Convert.ToInt32(dr["TotalVenta"]),
                                TotalProductos = Convert.ToInt32(dr["TotalProductos"]),

                            };
                        }
                    }
                    oconexion.Close();
                }

            }
            catch
            {
                objeto = new DashBoard();

            }


            return objeto;


        }

    }
}
