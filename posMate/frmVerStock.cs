using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
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
    public partial class frmVerStock : Form
    {
        public frmVerStock()
        {
            InitializeComponent();
        }

        private void frmVerStock_Load(object sender, EventArgs e)
        {
            CN_Producto negocioProducto = new CN_Producto();
            List<Producto> productos = negocioProducto.ObtenerProductos();
            foreach (Producto producto in productos)
            {
                dgvStock.Rows.Add(
                        producto.IdProducto,
                        producto.codigoProducto,
                        producto.Nombre,
                        producto.Stock
                );
            }

            txtStockMin_TextChanged(txtStockMin, EventArgs.Empty);
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtStockMin_TextChanged(object sender, EventArgs e)
        {
            // Obtiene el valor mínimo de stock del cuadro de texto
            int stockMin;
            if (!int.TryParse(txtStockMin.Text, out stockMin))
            {
                // Si el valor ingresado no es un número entero válido, no hace nada
                dgvStockMin.Rows.Clear();
                return;
            }

            // Crea una instancia de CN_Producto
            CN_Producto negocioProducto = new CN_Producto();

            // Obtiene la lista de productos desde la capa de negocio
            List<Producto> productos = negocioProducto.ObtenerProductos();

            // Limpia las filas existentes en dgvStockMin
            dgvStockMin.Rows.Clear();

            // Agrega a dgvStockMin los productos que tienen una cantidad menor o igual al valor mínimo de stock
            foreach (Producto producto in productos)
            {
                if (producto.Stock <= stockMin)
                {
                    dgvStockMin.Rows.Add(
                        producto.IdProducto,
                        producto.codigoProducto,
                        producto.Nombre,                      
                        producto.Stock
                    );
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            // Obtiene el texto de búsqueda del cuadro de texto y lo convierte a mayúsculas
            string textoBusqueda = txtBusqueda.Text.Trim().ToUpper();

            if (dgvStock.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvStock.Rows)
                {
                    // Obtiene el valor de la celda en la columna de filtro, si no es nulo
                    string valorCelda = row.Cells["NombreProducto"].Value != null ? row.Cells["NombreProducto"].Value.ToString().ToUpper() : "";

                    // Comprueba si el valor de la celda contiene el texto de búsqueda
                    bool filaVisible = valorCelda.Contains(textoBusqueda);

                    // Configura la visibilidad de la fila en función del resultado de la búsqueda
                    row.Visible = filaVisible;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            if (dgvStock.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvStock.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
}
