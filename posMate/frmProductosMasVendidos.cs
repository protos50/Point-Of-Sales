using CapaNegocio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProductosMasVendidos : Form
    {
        private Usuario usuarioActual;
        private CN_Producto negocioProducto;

        public frmProductosMasVendidos(Usuario oUsuario = null)
        {
            usuarioActual = oUsuario;
            negocioProducto = new CN_Producto(); // Instancia de la capa de negocio
            InitializeComponent();
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.Text = "1";
            CargarProductosMasVendidos(1); // Cargar con cantidad predeterminada (1)
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                List<Producto> productosMasVendidos = negocioProducto.ObtenerProductoMasVendido(cantidad,dtpFechaDesde.Value, dtpFechaHasta.Value);

                dgvData.Rows.Clear();

                foreach (Producto producto in productosMasVendidos)
                {
                    dgvData.Rows.Add(producto.codigoProducto, producto.Nombre);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida en el campo de texto.");
            }
        }

        private void CargarProductosMasVendidos(int cantidad)
        {
            List<Producto> productosMasVendidos = negocioProducto.ObtenerProductoMasVendido(cantidad, dtpFechaDesde.Value, dtpFechaHasta.Value);

            dgvData.Rows.Clear();

            foreach (Producto producto in productosMasVendidos)
            {
                dgvData.Rows.Add(producto.codigoProducto, producto.Nombre);
            }
        }

        // Botón de filtrar
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha 'Desde' debe ser menor o igual a la fecha 'Hasta'.");
                return;
            }
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                CargarProductosMasVendidos(cantidad);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida en el campo de texto.");
            }
        }

        private void frmProductosMasVendidos_Load(object sender, EventArgs e)
        {

            
        }
    }
}
