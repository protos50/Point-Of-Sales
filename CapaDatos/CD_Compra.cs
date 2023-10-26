﻿using System;
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
    public class CD_Compra
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
        public List<Compra> ObtenerCompras()
        {
            List<Compra> lista = new List<Compra>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT c.IdCompra, c.IdUsuario, c.IdProveedor, c.MontoTotal, c.FechaRegistro, u.Nombre AS NombreUsuario, p.Nombre AS NombreProveedor FROM COMPRA c " +
                                                           "INNER JOIN USUARIO u ON c.IdUsuario = u.IdUsuario " +
                                                           "INNER JOIN PROVEEDOR p ON c.IdProveedor = p.IdProveedor", con))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Compra
                                {
                                    IdCompra = Convert.ToInt32(reader["IdCompra"]),
                                    oUsuario = new Usuario
                                    {
                                        IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                        Nombre = reader["Nombre"].ToString()
                                        
                                    },
                                    oProveedor = new Proveedor
                                    {
                                        IdProveedor = Convert.ToInt32(reader["IdProveedor"]),
                                        Nombre = reader["Nombre"].ToString()
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
                    // Manejo de errores aquí
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
                    // Manejo de errores aquí
                    return false;
                }

            }
        }
    }
}
