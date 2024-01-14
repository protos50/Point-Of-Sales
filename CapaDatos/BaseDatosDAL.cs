using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class BaseDatosDAL
    {
        public static DataTable ObtenerBasesDeDatos()
        {
            try
            {
                string connectionString = Conexion.cadena;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para obtener la lista de bases de datos
                    string query = "SELECT name FROM sys.databases WHERE database_id > 4"; // Excluye bases de sistema

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
               
                throw ex;
            }
        }

    }
}
