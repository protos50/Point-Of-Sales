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
    public partial class verCategoriaMasVendidas : Form
    {
        private CN_Categoria negocioCategoria;
        public verCategoriaMasVendidas()
        {
            InitializeComponent();
            negocioCategoria = new CN_Categoria(); 
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.Text = "1";
            CargarCategoriasMasVendidas(1);
        }

        private void verCategoriaMasVendidas_Load(object sender, EventArgs e)
        {
           
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                List<Categoria> categoriasMasVendidas = negocioCategoria.ObtenerCategoriasMasVendidas(cantidad, dtpFechaDesde.Value, dtpFechaHasta.Value);

                dgvData.Rows.Clear();

                foreach (Categoria categoria in categoriasMasVendidas)
                {
                    dgvData.Rows.Add(categoria.Descripcion);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida en el campo de texto.");
            }

        }

        private void CargarCategoriasMasVendidas(int cantidad)
        {
            List<Categoria> categoriasMasVendidas = negocioCategoria.ObtenerCategoriasMasVendidas(cantidad, dtpFechaDesde.Value, dtpFechaHasta.Value);

            dgvData.Rows.Clear();

            foreach (Categoria categoria in categoriasMasVendidas)
            {
                dgvData.Rows.Add(categoria.Descripcion);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
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
                CargarCategoriasMasVendidas(cantidad);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida en el campo de texto.");
            }
        }
    }
}
