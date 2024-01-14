using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdProveedor, Nombre, Documento, Telefono, Estado FROM Proveedor");

                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(reader["IdProveedor"]),
                                Nombre = reader["Nombre"].ToString(),
                                Documento = reader["Documento"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    lista = new List<Proveedor>();
                }
            }
            return lista;
        }

        public bool AgregarProveedor(Proveedor proveedor)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Proveedor (Nombre, Documento, Telefono, Estado) VALUES (@Nombre, @Documento, @Telefono, @Estado)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                    cmd.Parameters.AddWithValue("@Documento", proveedor.Documento);
                    cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", proveedor.Estado);
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

        public bool EditarProveedor(Proveedor proveedor)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Proveedor SET Nombre = @Nombre, Documento = @Documento, Telefono = @Telefono, Estado = @Estado WHERE IdProveedor = @IdProveedor";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                    cmd.Parameters.AddWithValue("@Documento", proveedor.Documento);
                    cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                    cmd.Parameters.AddWithValue("@Estado", proveedor.Estado);
                    cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
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
    }
}

