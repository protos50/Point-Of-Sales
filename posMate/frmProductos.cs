using CapaDatos;
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

    public partial class frmProductos : Form
    {
        private static Usuario usuarioActual;
        public frmProductos(Usuario objUsuario = null)
        {
            usuarioActual = objUsuario;
            InitializeComponent();
            dgvData.CellFormatting += dgvData_CellFormatting;
            txtBusqueda.TextChanged += new EventHandler(txtBusqueda_TextChanged);

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            if(usuarioActual.oRol.IdRol == 2)
            {
                bunifuGradientPanel1.Visible = false;
            }


            // Agregar opciones "Activo" y "No Activo" al ComboBox cboEstado
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            // Configurar el ComboBox cboEstado para mostrar el texto y usar el valor al seleccionar
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";

            // Establecer la opción seleccionada inicialmente como "Activo"
            cboEstado.SelectedIndex = 0;

            List<Categoria> listaCat = new CN_Categoria().ObtenerCategorias();
            foreach (var item in listaCat)
            {
                cboCateg.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }


            cboCateg.DisplayMember = "Texto";
            cboCateg.ValueMember = "Valor";


            cboCateg.SelectedIndex = 0;



            // Iterar a través de las columnas del DataGridView dgvData
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                //  agrega a cboBusqueda
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";

            // Establecer la opción seleccionada inicialmente como la primera columna visible
            cboBusqueda.SelectedIndex = 0;




            CN_Producto negocioProducto = new CN_Producto();
            List<Producto> productos = negocioProducto.ObtenerProductos();
            foreach (Producto producto in productos)
            {
                dgvData.Rows.Add(
                    producto.IdProducto,
                    producto.Nombre,
                    producto.Descripcion,
                    producto.PrecioVenta,
                    producto.Stock,
                    producto.FechaRegistro,
                    producto.oCategoria.Descripcion,
                    producto.Estado ? "Activo" : "Inactivo",
                    producto.codigoProducto
                );



            }
        }


        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            // Obtiene la columna de filtro seleccionada desde el ComboBox
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();
            // Obtiene el texto de búsqueda del cuadro de texto y lo convierte a mayúsculas
            string textoBusqueda = txtBusqueda.Text.Trim().ToUpper();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    // Obtiene el valor de la celda en la columna de filtro, si no es nulo
                    string valorCelda = row.Cells[columnaFiltro].Value != null ? row.Cells[columnaFiltro].Value.ToString().ToUpper() : "";

                    // Comprueba si el valor de la celda contiene el texto de búsqueda
                    bool filaVisible = valorCelda.Contains(textoBusqueda);

                    // Configura la visibilidad de la fila en función del resultado de la búsqueda
                    row.Visible = filaVisible;
                }
            }
        }


      

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvData.Columns[e.ColumnIndex].Name == "FechaRegistro" && e.Value != null)
            {
                if (e.Value is DateTime fecha)
                {
                    // Formatea la fecha para mostrar solo la parte de la fecha (sin la hora)
                    e.Value = fecha.ToShortDateString();
                }
            }
        }

        private void dgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int indice = e.RowIndex;
                btnGuardar.Text = "Actualizar datos";

                // Muestra los datos del producto en los controles
                txtIndice.Text = indice.ToString();
                txtId.Text = dgvData.Rows[indice].Cells["IdProducto"].Value.ToString();
                txtPrecioVenta.Text = dgvData.Rows[indice].Cells["PrecioVenta"].Value.ToString();
                txtDescripcion.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();
                txtCantidad.Text = dgvData.Rows[indice].Cells["Cantidad"].Value.ToString();

                string categoriaEnDataGrid = dgvData.Rows[indice].Cells["Categoria"].Value.ToString();
                cboCateg.SelectedIndex = cboCateg.FindStringExact(categoriaEnDataGrid);

                string estadoEnDataGrid = dgvData.Rows[indice].Cells["Estado"].Value.ToString();
                cboEstado.SelectedIndex = cboEstado.FindStringExact(estadoEnDataGrid);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que se hayan completado los campos necesarios
            if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || cboEstado.SelectedIndex == -1 || cboCateg.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }



            CN_Producto negocioProducto = new CN_Producto();

            // Si txtId es mayor a 0 se desea editar un producto existente.
            if (int.TryParse(txtId.Text, out int id) && id > 0)
            {
                int idProducto = int.Parse(txtId.Text);

                // Obtener el producto completo desde la base de datos
                Producto producto = negocioProducto.ObtenerProductos().FirstOrDefault(p => p.IdProducto == idProducto);

                // Actualizar los campos del producto con los datos del formulario
                producto.oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cboCateg.SelectedItem).Valor) };
                producto.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
                producto.Descripcion = txtDescripcion.Text;
                producto.Stock = int.Parse(txtCantidad.Text);
                producto.Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false;


                if (negocioProducto.EditarProducto(producto))
                {
                    MessageBox.Show("El producto se ha editado correctamente.");
                    
                    limpiar();
                    ActualizarDataGridView();
                }

            }
        }

        private void ActualizarDataGridView()
        {
            // Obtener una nueva lista de proveedores y actualizar el DataGridView
            List<Producto> productos = new CN_Producto().ObtenerProductos();
            dgvData.Rows.Clear();

            foreach (Producto producto in productos)
            {
                dgvData.Rows.Add(
                   producto.IdProducto,
                   producto.Nombre,
                   producto.Descripcion,
                   producto.PrecioVenta,
                   producto.Stock,
                   producto.FechaRegistro,
                   producto.oCategoria.Descripcion,
                   producto.Estado ? "Activo" : "Inactivo",
                   producto.codigoProducto
               );
            }

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Clear();
            txtPrecioVenta.Clear();
            txtCantidad.Clear();
            cboEstado.SelectedIndex = -1;
            cboCateg.SelectedIndex = -1;
        }

        private void btnlimpiarCampos_Click(object sender, EventArgs e)
        {
            
            limpiar();
        }

        private void cboCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Filtrar(true);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Filtrar(false);
        }

        private void Filtrar(bool estadoActivo)
        {
            txtBusqueda.Clear();

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                int estadoFila = row.Cells["Estado"].Value.ToString() == "Activo" ? 1 : 0;

                if ((estadoActivo && estadoFila == 1) || (!estadoActivo && estadoFila == 0))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
}
