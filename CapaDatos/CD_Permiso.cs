using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {


                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select PERMISO.IdRol,PERMISO.NombreMenu from  PERMISO");
                    query.AppendLine(" inner join ROL r on r.IdRol = PERMISO.IdRol");
                    query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    query.AppendLine("WHERE u.IdUsuario = @IdUsuario");
                    
   
                    
                    SqlCommand cmd = new SqlCommand(query.ToString() , con);
                    cmd.Parameters.AddWithValue("@IdUsuario", idusuario);
                    cmd.CommandType = CommandType.Text;
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() {IdRol = Convert.ToInt32(reader["IdRol"])},
                                NombreMenu = reader["NombreMenu"].ToString(),
                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
