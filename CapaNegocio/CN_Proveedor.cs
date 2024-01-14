using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;



namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor ocd_proveedor = new CD_Proveedor();

        public List<Proveedor> ObtenerProveedores()
        {
            return ocd_proveedor.ObtenerProveedores();
        }

        public bool AgregarProveedor(Proveedor proveedor)
        {
           
            return ocd_proveedor.AgregarProveedor(proveedor);
        }

        public bool EditarProveedor(Proveedor proveedor)
        {
            
            return ocd_proveedor.EditarProveedor(proveedor);
        }
    }
}
