using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmVerVentasVendedor : Form
    {
        private Usuario usuarioActual;
        public frmVerVentasVendedor(Usuario oUsuario = null)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmVerVentasVendedor_Load(object sender, EventArgs e)
        {
            int idUsuario = usuarioActual.IdUsuario;
            CN_Venta negocioVenta = new CN_Venta();

            // Obtener la lista de compras desde la capa de negocio
            List<Venta> ventas = negocioVenta.ObtenerVentasPorIdUsuario(idUsuario);

            // Calcula la suma total de las compras
            decimal totalVentas = ventas.Sum(v => v.MontoTotal);

            // Asigna la suma total al label
            lblTotalVentas2.Text = totalVentas.ToString("C");


            // Establecer el texto de lblTotalVentas para mostrar la cantidad de registros total de ventas
            lblTotalVentas.Text = ventas.Count.ToString();

            dgvDataVenta.Rows.Clear();

            foreach (Venta venta in ventas)
            {
                // Accede a las propiedades Nombre de Usuario y Proveedor
                string Vendedor = usuarioActual.Nombre;

                dgvDataVenta.Rows.Add(
                    venta.IdVenta,
                    Vendedor,
                    venta.MontoPago,
                    venta.MontoCambio,
                    venta.MontoTotal,
                    venta.FechaRegistro
                );
            }


        }

        private void dgvDataVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtén el índice de la fila seleccionada
            int index = e.RowIndex;

            // Si el índice es válido (es decir, el usuario hizo clic en una fila, no en el encabezado de la columna)
            if (index != -1)
            {
                // Obtén el IdCompra de la fila seleccionada
                int idVenta = Convert.ToInt32(dgvDataVenta.Rows[index].Cells[0].Value);

                // Crea una instancia de CN_DetalleCompra
                CN_DetalleVenta negocioDetalleVenta = new CN_DetalleVenta();

                // Obtén los detalles de la compra desde la capa de negocio
                List<DetalleVenta> detallesVenta = negocioDetalleVenta.ObtenerDetallesVenta(idVenta);

                // Calcula la suma total de los detalles de la compra
                decimal subtotal = detallesVenta.Sum(dc => dc.Subtotal);

                // Asigna la suma total al label
                lblSubtotalVenta.Text = subtotal.ToString("C");

                // Limpia las filas existentes en dgvDetalleCompra
                dgvDetalleVenta.Rows.Clear();

                // Agrega los detalles de la compra a dgvDetalleCompra
                foreach (DetalleVenta detalleVenta in detallesVenta)
                {
                    dgvDetalleVenta.Rows.Add(
                        detalleVenta.oProducto.IdProducto,
                        detalleVenta.oProducto.Nombre,
                        detalleVenta.PrecioVenta,
                        detalleVenta.Cantidad,
                        detalleVenta.Subtotal
                    );
                }

                // Establecer el texto de lblTotalDetalleVentas para mostrar el total de registros en detalle de venta
                lblTotalDetalleVentas.Text = detallesVenta.Count.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView dgvDetalleVenta
            dgvDetalleVenta.Rows.Clear();

            // Limpiar las etiquetas lblTotalDetalleVentas y lblSubtotalVenta
            lblTotalDetalleVentas.Text = "0";
            lblSubtotalVenta.Text = "0";

            CN_Venta negocioVenta = new CN_Venta();

            // Obtén las fechas seleccionadas en los DateTimePickers
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            // Obtener la lista de ventas en el intervalo de tiempo desde hasta
            List<Venta> ventasEnIntervalo = negocioVenta.ObtenerVentasPorIntervaloDeTiempo(fechaDesde, fechaHasta);

            // Calcula la suma total de las ventas en el intervalo
            decimal totalVentasEnIntervalo = ventasEnIntervalo.Sum(v => v.MontoTotal);

            // Asigna la suma total al label
            lblTotalVentas2.Text = totalVentasEnIntervalo.ToString("C");

            // Establecer el texto de lblTotalVentas para mostrar la cantidad de registros total de ventas
            lblTotalVentas.Text = ventasEnIntervalo.Count.ToString();

            // Limpia el DataGridView
            dgvDataVenta.Rows.Clear();

            foreach (Venta venta in ventasEnIntervalo)
            {
                string Vendedor = usuarioActual.Nombre;

                dgvDataVenta.Rows.Add(
                    venta.IdVenta,
                    Vendedor,
                    venta.MontoPago,
                    venta.MontoCambio,
                    venta.MontoTotal,
                    venta.FechaRegistro
                );
            }
        }
    }
}
