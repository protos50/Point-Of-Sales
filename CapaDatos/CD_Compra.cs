using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Compra
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
        public List<Compra> ObtenerCompras(int? IdUsuario = null)
        {
            List<Compra> lista = new List<Compra>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT c.IdCompra, u.Nombre AS NombreUsuario, p.Nombre AS NombreProveedor, c.MontoTotal, c.FechaRegistro FROM COMPRA c " +
                                                           "INNER JOIN USUARIO u ON c.IdUsuario = u.IdUsuario " +
                                                           "INNER JOIN PROVEEDOR p ON c.IdProveedor = p.IdProveedor" +
                                                           (IdUsuario.HasValue ? " WHERE c.IdUsuario = @IdUsuario" : ""), con))

                    {
                        cmd.CommandType = CommandType.Text;

                        if (IdUsuario.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario.Value);
                        }

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Compra
                                {
                                    IdCompra = Convert.ToInt32(reader["IdCompra"]),
                                    oUsuario = new Usuario
                                    {
                                        Nombre = reader["NombreUsuario"].ToString()
                                    },
                                    oProveedor = new Proveedor
                                    {
                                        Nombre = reader["NombreProveedor"].ToString()
                                    },
                                    MontoTotal = Convert.ToDecimal(reader["MontoTotal"]),
                                    FechaRegistro = (DateTime)(reader["FechaRegistro"] as DateTime?)
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    lista = new List<Compra>();
                }
            }

            return lista;
        }

        public bool AgregarCompra(Compra compra)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO compra(IdUsuario,IdProveedor,MontoTotal,FechaRegistro)" +
                        "VALUES(@IdUsuario,@IdProveedor,@MontoTotal,@FechaRegistro)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdUsuario", compra.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@IdProveedor", compra.oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("@MontoTotal", compra.MontoTotal);
                    cmd.Parameters.AddWithValue("@FechaRegistro", compra.FechaRegistro);
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

        public int ObtenerUltimoIDCompra()
        {
            int ultimoID = -1;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdCompra FROM COMPRA ORDER BY IdCompra DESC", con))
                    {
                        cmd.CommandType = CommandType.Text;

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            ultimoID = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }

            return ultimoID;
        }

        public decimal CalcularMontoTotalComprasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            decimal montoTotal = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT SUM(MontoTotal) AS MontoTotal FROM COMPRA " +
                                                          "WHERE FechaRegistro >= @FechaDesde AND FechaRegistro <= @FechaHasta", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            montoTotal = Convert.ToDecimal(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Se produjo un error: " + ex.Message);
                }
            }

            return montoTotal;
        }
    }
}
