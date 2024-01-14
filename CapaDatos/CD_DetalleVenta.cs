using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_DetalleVenta
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
        public List<DetalleVenta> ObtenerDetallesVenta(int idVenta)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT dv.IdDetalleVenta, dv.IdProducto, dv.PrecioVenta, dv.Cantidad, dv.Subtotal, dv.FechaRegistro, p.Nombre AS NombreProducto " +
                                                           "FROM DETALLE_VENTA dv " +
                                                           "INNER JOIN PRODUCTO p ON dv.IdProducto = p.IdProducto " +
                                                           "WHERE dv.IdVenta = @IdVenta", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@IdVenta", idVenta);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new DetalleVenta
                                {
                                    IdDetalleVenta = Convert.ToInt32(reader["IdDetalleVenta"]),
                                    oProducto = new Producto
                                    {
                                        IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                        Nombre = reader["NombreProducto"].ToString()
                                    },
                                    PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),
                                    Cantidad = Convert.ToInt32(reader["Cantidad"]),
                                    Subtotal = Convert.ToDecimal(reader["Subtotal"]),
                                    FechaRegistro = (DateTime)(reader["FechaRegistro"] as DateTime?)
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    lista = new List<DetalleVenta>();
                }
            }

            return lista;
        }
        
        public bool AgregarDetalleVenta(DetalleVenta detalleVenta)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO DETALLE_VENTA(IdVenta, IdProducto, PrecioVenta, Cantidad, Subtotal, FechaRegistro) " +
                        "VALUES(@IdVenta, @IdProducto, @PrecioVenta, @Cantidad, @Subtotal, @FechaRegistro)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdVenta", detalleVenta.IdVenta);
                    cmd.Parameters.AddWithValue("@IdProducto", detalleVenta.oProducto.IdProducto);
                    cmd.Parameters.AddWithValue("@PrecioVenta", detalleVenta.PrecioVenta);
                    cmd.Parameters.AddWithValue("@Cantidad", detalleVenta.Cantidad);
                    cmd.Parameters.AddWithValue("@Subtotal", detalleVenta.Subtotal);
                    cmd.Parameters.AddWithValue("@FechaRegistro", detalleVenta.FechaRegistro);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    
                    return false;
                }
            }
        }
        

        public Dictionary<string, decimal> ObtenerGananciasPorCategoria(FranjaHoraria franjaHoraria)
        {
            Dictionary<string, decimal> gananciasPorCategoria = new Dictionary<string, decimal>();

            // Define las horas de inicio y fin de cada franja horaria
            TimeSpan inicio;
            TimeSpan fin;

            switch (franjaHoraria)
            {
                case FranjaHoraria.Mañana:
                    inicio = new TimeSpan(6, 0, 0); // 6:00 AM
                    fin = new TimeSpan(12, 0, 0); // 12:00 PM
                    break;
                case FranjaHoraria.Tarde:
                    inicio = new TimeSpan(12, 0, 0); // 12:00 PM
                    fin = new TimeSpan(18, 0, 0); // 6:00 PM
                    break;
                case FranjaHoraria.Noche:
                    inicio = new TimeSpan(18, 0, 0); // 6:00 PM
                    fin = new TimeSpan(23, 59, 59); // 11:59 PM
                    break;
                default: // FranjaHoraria.Total
                    inicio = new TimeSpan(0, 0, 0); // 12:00 AM
                    fin = new TimeSpan(23, 59, 59); // 11:59 PM
                    break;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT c.Descripcion, SUM(dv.Subtotal) as Ganancias " +
                                                           "FROM DETALLE_VENTA dv " +
                                                           "INNER JOIN PRODUCTO p ON dv.IdProducto = p.IdProducto " +
                                                           "INNER JOIN CATEGORIA c ON p.IdCategoria = c.IdCategoria " +
                                                           "WHERE (CAST(dv.FechaRegistro AS TIME) BETWEEN @Inicio AND @Fin) " +
                                                           "GROUP BY c.Descripcion", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Inicio", inicio);
                        cmd.Parameters.AddWithValue("@Fin", fin);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                gananciasPorCategoria.Add(reader["Descripcion"].ToString(), Convert.ToDecimal(reader["Ganancias"]));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    gananciasPorCategoria = new Dictionary<string, decimal>();
                }
            }

            return gananciasPorCategoria;
        }

    }
}
