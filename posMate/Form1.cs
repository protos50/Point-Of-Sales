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
using CapaPresentacion;
using FontAwesome.Sharp;
using CapaNegocio;

namespace posMate
{
    public partial class Form1 : Form
    {
        private static Usuario usuarioActual;
       
        public Form1(Usuario objUsuario = null)
        {
            usuarioActual = objUsuario;
            InitializeComponent(); 
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            //Recorre los permisos para habilitar menus
            foreach (Control control in panel1.Controls)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == control.Name);
                if (!encontrado && control is Button)
                {
                    Button boton = (Button)control;
                    boton.Enabled = false; // Deshabilitar el botón
                }
            }
            lblUsuario.Text = usuarioActual.Nombre;

            Inicio Inicio = new Inicio();
            MostrarFormularioEnContenedor(Inicio);
        }
        

        //venta
        private void iconButton3_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnVentas.Top;

            frmVentas formularioVentas = new frmVentas(usuarioActual);
            MostrarFormularioEnContenedor(formularioVentas);



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnUsuario.Top;
            // Crea una instancia del formulario 
            frmUsuarios frmUsuario = new frmUsuarios();

            // Llama al método para mostrar el formulario en el contenedor
            MostrarFormularioEnContenedor(frmUsuario);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmBackUp formularioBU = new frmBackUp();
            MostrarFormularioEnContenedor(formularioBU);
            SidePanel.Top = btnBackup.Top;

        }

        private void btnReportes_Click_2(object sender, EventArgs e)
        {
            SidePanel.Top = btnReportes.Top;
            frmReportes formularioRP = new frmReportes(usuarioActual);
            MostrarFormularioEnContenedor(formularioRP);
        }


        private void btnProveedores_Click_2(object sender, EventArgs e)
        {
            SidePanel.Top = btnProveedores.Top;
            frmProveedores formularioPV = new frmProveedores();
            MostrarFormularioEnContenedor(formularioPV);
        }

        private void btnProductos_Click_2(object sender, EventArgs e)
        {
            SidePanel.Top = btnProductos.Top;
            frmProductos formularioPD = new frmProductos(usuarioActual);
            MostrarFormularioEnContenedor(formularioPD);
        }

        //Compra
        private void btnCompras_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnCompras.Top;
            // Crear una instancia del formulario de compras (frmCompras)
            frmCompras formularioCompras = new frmCompras(usuarioActual);

            // Mostrar el formulario de compras en el contenedor de Form1
            MostrarFormularioEnContenedor(formularioCompras);

        }

        private void btnCategorias_Click_1(object sender, EventArgs e)
        {
            SidePanel.Top = btnCategorias.Top;
            frmCategorias formularioCG = new frmCategorias();
            MostrarFormularioEnContenedor(formularioCG);
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            SidePanel.Top = btnCerrarSesion.Top;
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar la sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Cerrar el formulario actual
                this.Close();
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

            // Crea una instancia del formulario
            Inicio frmInicio = new Inicio();

            // Llama al método para mostrar el formulario en el "contenedor"
            MostrarFormularioEnContenedor(frmInicio);
        }

        public void MostrarFormularioEnContenedor(Form formulario)
        {
            // Borra cualquier control existente en el panel "contenedor"
            contenedor.Controls.Clear();
            // Establece las propiedades del formulario secundario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            // Agrega el formulario secundario al panel "contenedor"
            contenedor.Controls.Add(formulario);
            // Muestra el formulario secundario
            formulario.Show();
        }

    }
}


