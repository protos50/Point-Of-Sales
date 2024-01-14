using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario ocd_usuario = new CD_Usuario();
        public List<Usuario> Listar()
        {
            return ocd_usuario.Listar();
        }


        public int Registrar(Usuario obj, out string Mensaje)
        {
            return ocd_usuario.Registrar(obj, out Mensaje);
        }

     


        public bool Editar(Usuario obj, out string Mensaje)
        {
                return ocd_usuario.Editar(obj, out Mensaje);
        }

        public Usuario ObtenerUsuarioPorNombre(string nombre)
        {
            return ocd_usuario.ObtenerUsuarioPorNombre(nombre);
        }

    }
}
    

