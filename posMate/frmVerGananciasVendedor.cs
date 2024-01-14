using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class frmVerGananciasVendedor : Form
    {
        private CN_Venta cnVenta = new CN_Venta();
        private CN_Usuario cnUsuario = new CN_Usuario();
        public frmVerGananciasVendedor()
        {
            InitializeComponent();
        }

        private void frmVerGananciasVendedor_Load(object sender, EventArgs e)
        {



            // Llena el ComboBox del mes
            dropdownMeses.Items.Add("Todo el año");
            dropdownMeses.Items.AddRange(new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            dropdownMeses.SelectedIndex = 0;  // Selecciona 'Todo el año' por defecto

            // Llena el ComboBox del año con los años en los que se realizaron ventas
            var años = cnVenta.ObtenerVentas().Select(v => v.FechaRegistro.Year).Distinct().OrderByDescending(a => a);
            foreach (var año in años)
            {
                dropdownAños.Items.Add(año);
            }
            dropdownAños.SelectedIndex = 0;  // Selecciona el año más reciente por defecto

            ActualizarReporte();
        }

        private void ActualizarReporte()
        {
            // Obtiene las ventas y los usuarios
            var ventas = cnVenta.ObtenerVentas();
            var usuarios = cnUsuario.Listar();

            // Obtiene el año y el mes seleccionados
            int añoSeleccionado;
            if (dropdownAños.SelectedItem != null)
            {
                añoSeleccionado = (int)dropdownAños.SelectedItem;
            }
            else
            {
                // Maneja el caso en que no hay ningún elemento seleccionado
                añoSeleccionado = DateTime.Now.Year; // Año actual por defecto
                return;
            }
            int mesSeleccionado = dropdownMeses.SelectedIndex;


            // Si se seleccionó un mes específico, filtra las ventas para incluir solo las ventas de ese mes
            if (mesSeleccionado > 0)
            {
                ventas = ventas.Where(v => v.FechaRegistro.Year == añoSeleccionado && v.FechaRegistro.Month == mesSeleccionado).ToList();
            }
            // Si se seleccionó 'Todo el año', filtra las ventas para incluir solo las ventas de ese año
            else
            {
                ventas = ventas.Where(v => v.FechaRegistro.Year == añoSeleccionado).ToList();
            }


            // Agrupa las ventas por IdUsuario y suma los totales de ventas
            var ventasPorUsuario = ventas
                .GroupBy(v => v.oUsuario.IdUsuario)
                .Select(g => new { IdUsuario = g.Key, NombreUsuario = g.First().oUsuario.Nombre, TotalVentas = g.Sum(v => v.MontoTotal) })
                .ToList();


            // Actualiza el gráfico con los datos procesados
            // Actualiza el gráfico con los datos procesados
            chartGananciasMeses.Series.Clear();
            var series = new Series("Ganancias");
            series.ChartType = SeriesChartType.Column;

            foreach (var ventaPorUsuario in ventasPorUsuario)
            {
                // Agrega una barra al gráfico para cada usuario
                series.Points.AddXY($"{ventaPorUsuario.NombreUsuario}", ventaPorUsuario.TotalVentas);
            }
            chartGananciasMeses.Series.Add(series);

            // Actualiza la tabla con los datos procesados
            dataGridGananciasMeses.DataSource = ventasPorUsuario;
        }





        private void dropdownMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarReporte();
        }

        private void dropdownAños_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarReporte();
        }

        private void dataGridGananciasMeses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
