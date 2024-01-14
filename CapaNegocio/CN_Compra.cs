using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private CD_Compra ocd_compra = new CD_Compra();
        public List<Compra> ObtenerCompras(int? IdUsuario = null)
        {
            return ocd_compra.ObtenerCompras(IdUsuario);
        }

        public bool AgregarCompra(Compra compra)
        {          
            return ocd_compra.AgregarCompra(compra);
        }

        public int obtenerUltimoIdCompra()
        {
            return ocd_compra.ObtenerUltimoIDCompra();
        }

        public decimal CalcularMontoTotalComprasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            return ocd_compra.CalcularMontoTotalComprasPorFecha(fechaDesde, fechaHasta);
        }
    }
}
