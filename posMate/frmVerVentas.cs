using CapaEntidad;
using CapaNegocio;
using CapaNegocios;
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
    public partial class frmVerVentas : Form
    {
        private static Usuario usuarioActual;
        public frmVerVentas(Usuario objUsuario = null)
        {
            usuarioActual = objUsuario;
            InitializeComponent();
        }

        private void frmVerVentas_Load(object sender, EventArgs e)
        {
            CN_Usuario negocioUsuario = new CN_Usuario();

            // Obtener la lista de usuarios desde la capa de negocio
            List<Usuario> usuarios = negocioUsuario.Listar();

            // Llena el control desplegable con los nombres de los usuarios
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.oRol.IdRol == 2)
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

        private void dgvDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalVentas_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalDetalleVentas_Click(object sender, EventArgs e)
        {

        }

        private void ddlUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia el DataGridView y los labels
            dgvDataVenta.Rows.Clear();
            dgvDetalleVenta.Rows.Clear();
            //lblTotalVentas2.Text = "0";
            lblSubtotalVenta.Text = "0";
            lblTotalDetalleVentas.Text = "0";

            string usuarioSeleccionado = ddlUsuarios.SelectedItem.ToString();

            if (usuarioSeleccionado == "Todos los usuarios")
            {
                CN_Venta negocioVenta = new CN_Venta();

                // Obtener la lista de compras desde la capa de negocio
                List<Venta> ventas = negocioVenta.ObtenerVentas();

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
                    string Vendedor = venta.oUsuario.Nombre;

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
            else
            {
                // Obtén el IdUsuario del usuario seleccionado
                CN_Usuario negocioUsuario = new CN_Usuario();
                Usuario usuario = negocioUsuario.ObtenerUsuarioPorNombre(usuarioSeleccionado);
                int idUsuario = usuario.IdUsuario;



                // Filtra las ventas por el usuario seleccionado
                CN_Venta negocioVenta = new CN_Venta();
                List<Venta> ventas = negocioVenta.ObtenerVentas(idUsuario);

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
                    string Vendedor = venta.oUsuario.Nombre;

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

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }
    }
}
