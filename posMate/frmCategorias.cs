using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
            txtBusqueda.TextChanged += new EventHandler(txtBusqueda_TextChanged);
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            // Agregar opciones "Activo" y "No Activo" al ComboBox cboEstado
            cboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });

            // Configurar el ComboBox cboEstado para mostrar el texto y usar el valor al seleccionar
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";

            // Establecer la opción seleccionada inicialmente como "Activo"
            cboEstado.SelectedIndex = 0;

            // Obtener una lista de categorias y mostrarlos en el dgv
            List<Categoria> ObtenerCategorias = new CN_Categoria().ObtenerCategorias();

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                // Agregar a cboBusqueda
                if (columna.Visible == true && columna.Name != "Estado")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            // Configurar el ComboBox cboBusqueda para mostrar el texto y usar el valor al seleccionar
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";

            // Establecer la opción seleccionada inicialmente como la primera columna visible
            cboBusqueda.SelectedIndex = 0;

            foreach (Categoria categoria in ObtenerCategorias)
            {
                string estadoTexto = categoria.estado ? "Activo" : "Inactivo";
                dgvData.Rows.Add(
                    categoria.IdCategoria,
                    categoria.Descripcion,
                    estadoTexto
                );
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();
            string textoBusqueda = txtBusqueda.Text.Trim().ToUpper();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    string valorCelda = row.Cells[columnaFiltro].Value != null ? row.Cells[columnaFiltro].Value.ToString().ToUpper() : "";
                    bool filaVisible = valorCelda.Contains(textoBusqueda);
                    row.Visible = filaVisible;
                }
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int indice = e.RowIndex;
                btnGuardar.Text = "Actualizar datos";
                txtIndice.Text = indice.ToString();
                txtId.Text = dgvData.Rows[indice].Cells["IdCategoria"].Value.ToString();
                txtDescripcion.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();

                // Obtén el valor de la celda "Estado" en el DataGridView (que debería ser "Activo" o "Inactivo")
                string estadoEnDataGrid = dgvData.Rows[indice].Cells["Estado"].Value.ToString();

                // Establece el ComboBox según el valor de la celda "Estado"
                cboEstado.SelectedIndex = cboEstado.FindStringExact(estadoEnDataGrid);
            }
        }



        private void limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDescripcion.Clear();
            cboEstado.SelectedIndex = -1;
        }

        private void btnlimpiarCampos_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Guardar";
            limpiar();
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

       

        private void FiltrarUsuarios(bool estadoActivo)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que se hayan completado los campos 
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }

            // Crear un objeto de la clase Categoria con los datos del formulario
            Categoria categoria = new Categoria
            {
                Descripcion = txtDescripcion.Text,
                estado = cboEstado.SelectedIndex == 0, // 0 para Inactivo, 1 para Activo
            };

            CN_Categoria negocioCategoria = new CN_Categoria();

            if (txtId.Text == "0")
            {
               
                if (negocioCategoria.AgregarCategoria(categoria))
                {
                    MessageBox.Show("La categoría se ha agregado correctamente.");
                    
                    limpiar();
                    ActualizarDataGridView();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al agregar la categoría. Verifica la información e inténtalo de nuevo.");
                }
            }
            else
            {
                // Si txtId no es igual a 0, asumimos que deseas editar una categoría existente.
                int idCategoria = int.Parse(txtId.Text);
                categoria.IdCategoria = idCategoria;

                if (negocioCategoria.EditarCategoria(categoria))
                {
                    MessageBox.Show("La categoría se ha editado correctamente.");
                    
                    limpiar();
                    ActualizarDataGridView();
                }
               
            }
        }


        private void ActualizarDataGridView()
        {
            // Obtener una nueva lista de categorías y actualizar el DataGridView
            List<Categoria> categorias = new CN_Categoria().ObtenerCategorias();
            dgvData.Rows.Clear();

            foreach (Categoria categoria in categorias)
            {
                string estadoTexto = categoria.estado ? "Activo" : "Inactivo";
                dgvData.Rows.Add(
                    categoria.IdCategoria,
                    categoria.Descripcion,
                    estadoTexto
                );
            }
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            FiltrarUsuarios(true);

        }

        private void btnBaja_Click_1(object sender, EventArgs e)
        {
            FiltrarUsuarios(false);

        }
    }
}
