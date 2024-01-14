using CapaEntidad;
using posMate;
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
    public partial class frmReportes : Form
    {
        private Usuario usuarioActual;
        public frmReportes(Usuario oUsuario = null)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            frmVerCompras formularioCompras = new frmVerCompras();
            formularioCompras.Show();

            // Obtener el formulario padre (Form1)
            //Form1 formPadre = this.ParentForm as Form1;

            //formPadre.MostrarFormularioEnContenedor(formularioCompras);
        }

        private void categoriaGanancias_Click(object sender, EventArgs e)
        {
            FormGananciasPorCategoria formGananciasPorCategoria = new FormGananciasPorCategoria();
            formGananciasPorCategoria.Show();
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            frmVerVentas formularioVentas = new frmVerVentas(usuarioActual);
            formularioVentas.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmVerStock formularioStock = new frmVerStock();
            formularioStock.Show();
        }

        private void gananciasVendedor_Click(object sender, EventArgs e)
        {
            {
                frmVerGananciasVendedor formularioGananciasVendedor = new frmVerGananciasVendedor();
                formularioGananciasVendedor.Show();
            }
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            bunifuButton21.Visible = false;
            btnProductoMasVendido.Visible = false;
            bunifuButton22.Visible = false;
            btnStock.Visible = false;


            if (usuarioActual.oRol.IdRol == 2)
            {
                bunifuButton21.Visible = true;
                Compras.Visible = false;          
                gananciasVendedor.Visible = false;
                Ventas.Visible = false;
                categoriaGanancias.Visible = false;
                ResumenFinanciero.Visible = false;


                bunifuButton22.Visible = false;
            }

            if(usuarioActual.oRol.IdRol == 3)
            {
                btnProductoMasVendido.Visible = true;
                btnStock.Visible = true;
                Compras.Visible = false;
                ResumenFinanciero.Visible=false;
                gananciasVendedor.Visible = false;
                Ventas.Visible = false;
                categoriaGanancias.Visible = false;
                bunifuButton22.Visible = true;

            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            frmVerVentasVendedor formularioVentas = new frmVerVentasVendedor(usuarioActual);
            formularioVentas.Show();
        }

        private void btnProductoMasVendido_Click(object sender, EventArgs e)
        {
            frmProductosMasVendidos formulario = new frmProductosMasVendidos(usuarioActual);
            formulario.Show();
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            verCategoriaMasVendidas formulario = new verCategoriaMasVendidas();
            formulario.Show();

        }

        private void ResumenFinanciero_Click(object sender, EventArgs e)
        {
            frmResumenFinanciero formulario = new frmResumenFinanciero();
            formulario.Show();
        }
    }
}
