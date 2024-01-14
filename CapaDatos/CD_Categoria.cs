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
    public class CD_Categoria
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCategoria, Descripcion, estado FROM Categoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    lista = new List<Categoria>();
                }
            }
            return lista;
        }

        public bool AgregarCategoria(Categoria categoria)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Categoria (Descripcion, estado) VALUES (@Descripcion, @Estado)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", categoria.estado);
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

        public bool EditarCategoria(Categoria categoria)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Categoria SET Descripcion = @Descripcion, estado = @Estado WHERE IdCategoria = @IdCategoria";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    cmd.Parameters.AddWithValue("@Estado", categoria.estado);
                    cmd.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
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

        public Categoria ObtenerCategoriaPorId(int idCategoria)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT IdCategoria, Descripcion, Estado " +
                                   "FROM CATEGORIA " +
                                   "WHERE IdCategoria = @IdCategoria";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Categoria categoria = new Categoria
                            {
                                IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                estado = Convert.ToBoolean(reader["Estado"])
                            };
                            return categoria;
                        }
                        else
                        {
                            
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    return null;
                }
            }
        }

        public List<Categoria> ObtenerCategoriasMasVendidas(int topN, DateTime fechaDesde, DateTime fechaHasta)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT TOP (@TopN) c.IdCategoria, SUM(dv.Cantidad) AS TotalVendido " +
                                   "FROM CATEGORIA c " +
                                   "INNER JOIN PRODUCTO p ON c.IdCategoria = p.IdCategoria " +
                                   "INNER JOIN DETALLE_VENTA dv ON p.IdProducto = dv.IdProducto " +
                                   "WHERE dv.FechaRegistro BETWEEN @FechaDesde AND @FechaHasta " +
                                   "GROUP BY c.IdCategoria " +
                                   "ORDER BY TotalVendido DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TopN", topN);
                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    List<Categoria> categoriasMasVendidas = new List<Categoria>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idCategoria = Convert.ToInt32(reader["IdCategoria"]);
                            Categoria categoria = ObtenerCategoriaPorId(idCategoria);
                            if (categoria != null)
                            {
                                categoriasMasVendidas.Add(categoria);
                            }
                        }
                    }

                    return categoriasMasVendidas;
                }
                catch (Exception ex)
                {
                    
                    return new List<Categoria>();
                }
            }
        }
    }
}
