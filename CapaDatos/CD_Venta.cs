using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Venta
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

        public List<Venta> ObtenerVentas(int? IdUsuario = null)
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    
                    using (SqlCommand cmd = new SqlCommand("SELECT v.IdVenta, u.IdUsuario, u.Nombre AS NombreUsuario, c.Nombre AS NombreCliente,v.MontoPago, v.MontoCambio, v.MontoTotal, v.FechaRegistro " +
                                                  "FROM Venta v " +
                                                  "INNER JOIN USUARIO u ON v.IdUsuario = u.IdUsuario " +
                                                  "INNER JOIN Cliente c ON v.IdCliente = c.IdCliente" +
                                                  (IdUsuario.HasValue ? " WHERE v.IdUsuario = @IdUsuario" : ""), con))
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
                                lista.Add(new Venta
                                {
                                    IdVenta = Convert.ToInt32(reader["IdVenta"]),
                                    oUsuario = new Usuario
                                    {
                                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                        Nombre = reader["NombreUsuario"].ToString()
                                    },
                                    oCliente = new Cliente
                                    {
                                        Nombre = reader["NombreCliente"].ToString()
                                    },
                                   
                                    MontoPago = Convert.ToDecimal(reader["MontoPago"]),
                                    MontoCambio = Convert.ToDecimal(reader["MontoCambio"]),
                                    MontoTotal = Convert.ToDecimal(reader["MontoTotal"]),
                                    FechaRegistro = (DateTime)(reader["FechaRegistro"] as DateTime?)
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    lista = new List<Venta>();
                    MessageBox.Show("Se produjo un error: " + ex.Message);
                }
            }

            return lista;
        }

        public bool AgregarVenta(Venta venta)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Venta(IdUsuario, IdCliente, MontoPago, MontoCambio, MontoTotal, FechaRegistro) " +
                        "VALUES(@IdUsuario, @IdCliente, @MontoPago, @MontoCambio, @MontoTotal, @FechaRegistro)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdUsuario", venta.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@IdCliente", venta.oCliente.IdCliente);
                    
                   
                    cmd.Parameters.AddWithValue("@MontoPago", venta.MontoPago);
                    cmd.Parameters.AddWithValue("@MontoCambio", venta.MontoCambio);
                    cmd.Parameters.AddWithValue("@MontoTotal", venta.MontoTotal);
                    cmd.Parameters.AddWithValue("@FechaRegistro", venta.FechaRegistro);
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

        public int ObtenerUltimoIDVenta()
        {
            int ultimoID = -1;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 IdVenta FROM Venta ORDER BY IdVenta DESC", con))
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

        public List<Venta> ObtenerVentasPorIdUsuario(int idUsuario)
        {
            List<Venta> ventasUsuario = new List<Venta>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT v.IdVenta, u.IdUsuario, u.Nombre AS NombreUsuario, c.Nombre AS NombreCliente, v.MontoPago, v.MontoCambio, v.MontoTotal, v.FechaRegistro " +
                                                          "FROM Venta v " +
                                                          "INNER JOIN Usuario u ON v.IdUsuario = u.IdUsuario " +
                                                          "INNER JOIN Cliente c ON v.IdCliente = c.IdCliente " +
                                                          "WHERE u.IdUsuario = @IdUsuario", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ventasUsuario.Add(new Venta
                                {
                                    IdVenta = Convert.ToInt32(reader["IdVenta"]),
                                    oUsuario = new Usuario
                                    {
                                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                        Nombre = reader["NombreUsuario"].ToString()
                                    },
                                    oCliente = new Cliente
                                    {
                                        Nombre = reader["NombreCliente"].ToString()
                                    },
                                    MontoPago = Convert.ToDecimal(reader["MontoPago"]),
                                    MontoCambio = Convert.ToDecimal(reader["MontoCambio"]),
                                    MontoTotal = Convert.ToDecimal(reader["MontoTotal"]),
                                    FechaRegistro = (DateTime)(reader["FechaRegistro"] as DateTime?)
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Se produjo un error: " + ex.Message);
                }
            }

            return ventasUsuario;
        }

        public List<Venta> ObtenerVentasPorIntervaloDeTiempo(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> ventasFiltradas = new List<Venta>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT v.IdVenta, u.IdUsuario, u.Nombre AS NombreUsuario, c.Nombre AS NombreCliente, v.MontoPago, v.MontoCambio, v.MontoTotal, v.FechaRegistro " +
                                                          "FROM Venta v " +
                                                          "INNER JOIN Usuario u ON v.IdUsuario = u.IdUsuario " +
                                                          "INNER JOIN Cliente c ON v.IdCliente = c.IdCliente " +
                                                          "WHERE v.FechaRegistro >= @FechaDesde AND v.FechaRegistro <= @FechaHasta", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ventasFiltradas.Add(new Venta
                                {
                                    IdVenta = Convert.ToInt32(reader["IdVenta"]),
                                    oUsuario = new Usuario
                                    {
                                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                        Nombre = reader["NombreUsuario"].ToString()
                                    },
                                    oCliente = new Cliente
                                    {
                                        Nombre = reader["NombreCliente"].ToString()
                                    },
                                    MontoPago = Convert.ToDecimal(reader["MontoPago"]),
                                    MontoCambio = Convert.ToDecimal(reader["MontoCambio"]),
                                    MontoTotal = Convert.ToDecimal(reader["MontoTotal"]),
                                    FechaRegistro = (DateTime)(reader["FechaRegistro"] as DateTime?)
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Se produjo un error: " + ex.Message);
                }
            }

            return ventasFiltradas;
        }

        public decimal CalcularMontoTotalVentasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            decimal montoTotal = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT SUM(MontoTotal) AS MontoTotal FROM Venta " +
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
