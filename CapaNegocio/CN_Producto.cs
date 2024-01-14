using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto ocd_producto = new CD_Producto();

        public List<Producto> ObtenerProductos()
        {
            return ocd_producto.ObtenerProductos();
        }

        public bool AgregarProducto(Producto producto)
        {           
            return ocd_producto.AgregarProducto(producto);
        }

        public bool EditarProducto(Producto producto)
        {
            return ocd_producto.EditarProducto(producto);
        }

        public Producto ObtenerProductoPorCodigoProducto(string codigoProducto)
        {     
            return ocd_producto.ObtenerProductoPorCodigoProducto(codigoProducto);
        }

        public Producto ObtenerProductoPorId(int id)
        {
            return ocd_producto.ObtenerProductoPorId(id);
        }

        public bool ActualizarStockProducto(int productoId, int cantidad)
        {            
            return ocd_producto.ActualizarStockProducto(productoId, cantidad);
        }

        public bool ActualizarStockProductoVenta(int productoId, int cantidad)
        {
            return ocd_producto.ActualizarStockProductoVenta(productoId, cantidad);
        }

        public List<Producto> ObtenerProductoMasVendido(int topN, DateTime FechaDesde, DateTime FechaHasta)
        {
            return ocd_producto.ObtenerProductosMasVendidos(topN, FechaDesde, FechaHasta);
        }




    }
}
