using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmVerCompras : Form
    {
        public frmVerCompras()
        {
            InitializeComponent();
        }

        private void frmVerCompras_Load(object sender, EventArgs e)
        {
            CN_Usuario negocioUsuario = new CN_Usuario();

            // Obtener la lista de usuarios desde la capa de negocio
            List<Usuario> usuarios = negocioUsuario.Listar();

            // Llena el control desplegable con los nombres de los usuarios
            foreach (Usuario usuario in usuarios)
            {
                if(usuario.oRol.IdRol == 3)
                {
                    ddlUsuarios.Items.Add(usuario.Nombre);
                }
               
            }

            // Agrega una opción para seleccionar todas las ventas
            ddlUsuarios.Items.Add("Todos los usuarios");



            // Selecciona por defecto la opción "Todos los usuarios"
            ddlUsuarios.SelectedIndex = ddlUsuarios.Items.Count - 1; // Si "Todos los usuarios" es el último elemento
                                                                     // O
            ddlUsuarios.SelectedItem = "Todos los usuarios"; // Si quieres seleccionar por el nombre del elemento
       
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtén el índice de la fila seleccionada
            int index = e.RowIndex;

            // Si el índice es válido (es decir, el usuario hizo clic en una fila, no en el encabezado de la columna)
            if (index != -1)
            {
                // Obtén el IdCompra de la fila seleccionada
                int idCompra = Convert.ToInt32(dgvData.Rows[index].Cells[0].Value);

                // Crea una instancia de CN_DetalleCompra
                CN_DetalleCompra negocioDetalleCompra = new CN_DetalleCompra();

                // Obtén los detalles de la compra desde la capa de negocio
                List<DetalleCompra> detallesCompra = negocioDetalleCompra.ObtenerDetallesCompra(idCompra);

                // Calcula la suma total de los detalles de la compra
                decimal subtotal = detallesCompra.Sum(dc => dc.MontoTotal);

                // Asigna la suma total al label
                lblSubtotal.Text = subtotal.ToString("C");

                // Limpia las filas existentes en dgvDetalleCompra
                dgvDetalleCompra.Rows.Clear();

                // Agrega los detalles de la compra a dgvDetalleCompra
                foreach (DetalleCompra detalleCompra in detallesCompra)
                {
                    dgvDetalleCompra.Rows.Add(
                        detalleCompra.oProducto.IdProducto,
                        detalleCompra.oProducto.Nombre,
                        detalleCompra.PrecioCompra,
                        detalleCompra.Cantidad,
                        detalleCompra.MontoTotal
                    );
                }

                // Establecer el texto de lblTotalDetalleCompras para mostrar el total de registros en detalle de compra
                lblTotalDetalleCompras.Text = detallesCompra.Count.ToString();
            }
        }

        private void dgvDetalleCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCompras_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalDetalleCompras_Click(object sender, EventArgs e)
        {

        }

        private void ddlUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia el DataGridView y los labels
            dgvData.Rows.Clear();
            dgvDetalleCompra.Rows.Clear();
            lblTotalCompras.Text = "0";
            lblSubtotal.Text = "0";
            lblTotalDetalleCompras.Text = "0";

            string usuarioSeleccionado = ddlUsuarios.SelectedItem.ToString();

            if (usuarioSeleccionado == "Todos los usuarios")
            {
                CN_Compra negocioCompra = new CN_Compra();

                // Obtener la lista de compras desde la capa de negocio
                List<Compra> compras = negocioCompra.ObtenerCompras();

                // Calcula la suma total de las ventas
                decimal totalCompras = compras.Sum(v => v.MontoTotal);

                // Asigna la suma total al label
                lblTotalVentas.Text = totalCompras.ToString("C");

                // Establecer el texto de lblTotalVentas para mostrar el total de compras
                lblTotalCompras.Text = compras.Count.ToString();
                dgvData.Rows.Clear();

                foreach (Compra compra in compras)
                {
                    // Accede a las propiedades Nombre de Usuario y Proveedor
                    string nombreUsuario = compra.oUsuario.Nombre;
                    string nombreProveedor = compra.oProveedor.Nombre;

                    dgvData.Rows.Add(
                        compra.IdCompra,
                        nombreUsuario,
                        nombreProveedor,
                        compra.MontoTotal,
                        compra.FechaRegistro
                    );
                }

            }
            else
            {
                // Obtén el IdUsuario del usuario seleccionado
                CN_Usuario negocioUsuario = new CN_Usuario();
                Usuario usuario = negocioUsuario.ObtenerUsuarioPorNombre(usuarioSeleccionado);
                int idUsuario = usuario.IdUsuario;



                // Filtra las compras por el usuario seleccionado
                CN_Compra negocioCompra = new CN_Compra();
                List<Compra> compras = negocioCompra.ObtenerCompras(idUsuario);


                // Calcula la suma total de las compras
                decimal totalCompras = compras.Sum(v => v.MontoTotal);

                // Asigna la suma total al label
                lblTotalVentas.Text = totalCompras.ToString("C");

                // Establecer el texto de lblTotalCompras para mostrar el total de compras
                lblTotalCompras.Text = compras.Count.ToString();
                dgvData.Rows.Clear();

                foreach (Compra compra in compras)
                {
                    // Accede a las propiedades Nombre de Usuario y Proveedor
                    string nombreUsuario = compra.oUsuario.Nombre;
                    string nombreProveedor = compra.oProveedor.Nombre;

                    dgvData.Rows.Add(
                        compra.IdCompra,
                        nombreUsuario,
                        nombreProveedor,
                        compra.MontoTotal,
                        compra.FechaRegistro
                    );
                }
            }
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }
    }
}
