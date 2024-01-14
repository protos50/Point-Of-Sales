using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta ocd_venta = new CD_Venta();

        public List<Venta> ObtenerVentas(int? IdUsuario = null)
        {
            return ocd_venta.ObtenerVentas(IdUsuario);
        }


        public bool AgregarVenta(Venta venta)
        {
            
            return ocd_venta.AgregarVenta(venta);
        }

        public int ObtenerUltimoIDVenta()
        {
            return ocd_venta.ObtenerUltimoIDVenta();
        }

        public List<Venta> ObtenerVentasPorIdUsuario(int usuario)
        {
            return ocd_venta.ObtenerVentasPorIdUsuario(usuario);
        }

        public List<Venta> ObtenerVentasPorIntervaloDeTiempo(DateTime fechaDesde, DateTime fechaHasta)
        {
            return ocd_venta.ObtenerVentasPorIntervaloDeTiempo(fechaDesde, fechaHasta);
        }

        public decimal CalcularMontoTotalVentasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            return ocd_venta.CalcularMontoTotalVentasPorFecha(fechaDesde,fechaHasta);
        }
    }
}
