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
using System.Windows.Forms.DataVisualization.Charting;
namespace CapaPresentacion
{
    public partial class frmResumenFinanciero : Form
    {
        decimal ingresosTotales = 0;
        decimal gastosTotales = 0;

        public frmResumenFinanciero()
        {
            InitializeComponent();
        }

        private void frmResumenFinanciero_Load(object sender, EventArgs e)
        {
            

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CN_Venta negocioVenta = new CN_Venta();
            CN_Compra negocioCompra = new CN_Compra();

            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual a la fecha 'Hasta'.");
                return;
            }

            decimal montoTotalVentas = negocioVenta.CalcularMontoTotalVentasPorFecha(fechaDesde, fechaHasta);
            decimal montoTotalCompras = negocioCompra.CalcularMontoTotalComprasPorFecha(fechaDesde, fechaHasta);

            if (montoTotalVentas == 0 && montoTotalCompras == 0)
            {
                MessageBox.Show("No hay datos disponibles para las fechas seleccionadas.");
                return;
            }

            decimal gananciasTotales = montoTotalVentas - montoTotalCompras;

            chart1.Series.Clear();
            chart1.Refresh();

            Series ingresosSeries = new Series("Ingresos");
            ingresosSeries.Points.AddXY("Ingresos", montoTotalVentas);
            ingresosSeries.ChartType = SeriesChartType.Bar;
            ingresosSeries.Color = Color.DeepSkyBlue;
            ingresosSeries.IsValueShownAsLabel = true;

            Series gastosSeries = new Series("Gastos");
            gastosSeries.Points.AddXY("Gastos", montoTotalCompras);
            gastosSeries.ChartType = SeriesChartType.Bar;
            gastosSeries.Color = Color.Firebrick;
            gastosSeries.IsValueShownAsLabel = true;

            Series gananciasSeries = new Series("Ganancias");
            gananciasSeries.Points.AddXY("Ganancias", gananciasTotales);
            gananciasSeries.ChartType = SeriesChartType.Bar;
            gananciasSeries.Color = Color.ForestGreen;
            gananciasSeries.IsValueShownAsLabel = true;

            chart1.Series.Add(ingresosSeries);
            chart1.Series.Add(gastosSeries);
            chart1.Series.Add(gananciasSeries);
        }


    }
}
