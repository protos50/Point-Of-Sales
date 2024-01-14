using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaNegocios;
using CapaPresentacion.Utilidades;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class frmCompras : Form
    {


        // para saber que usuario compra
        private Usuario usuarioActual;
        // Declara una lista para el carrito
        private List<Producto> carrito = new List<Producto>();


        public frmCompras(Usuario oUsuario = null)
        {

            usuarioActual = oUsuario;
            InitializeComponent();
            txtCodigoBarra.Focus();
            verificarCheck();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void verificarCheck()
        {
            //si el carrito tiene elementos podemos comprar
            if (carrito.Count > 0)
            {
                btnConfirmarCompra.Enabled = true;
                btnConfirmarCompra.BackColor = Color.Green;
            }

            else
            {
                btnConfirmarCompra.Enabled = false;
                btnConfirmarCompra.BackColor = SystemColors.Control;
            }

            //hace que btn verificar solo este habilitado
            iconButton2.Enabled = true;
            iconButton2.BackColor = Color.ForestGreen;
            btnCarrito.BackColor = SystemColors.Control;
            btnCarrito.Enabled = false;
            txtNombree.Enabled = false;
            txtDesc.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecioCompra.Enabled = false;
            txtPrecioVenta.Enabled = false;
            cboCategoria.Enabled = false;
            cboProveedor.Enabled = false;
            cboEstadoo.Enabled = false;
        }

        private void verificado()
        {
            //se desactiva el verificar una vez verificado.
            iconButton2.Enabled = false;
            iconButton2.BackColor = SystemColors.Control;
            btnCarrito.BackColor = Color.MediumTurquoise;

            btnCarrito.Enabled = true;
            aviso.Visible = false;
            txtNombree.Enabled = true;
            txtDesc.Enabled = true;
            txtCantidad.Enabled = true;
            txtPrecioCompra.Enabled = true;
            txtPrecioVenta.Enabled = true;
            cboCategoria.Enabled = true;
            cboProveedor.Enabled = true;
            cboEstadoo.Enabled = true;
        }


        //al cargar el form
        private void frmCompras_Load(object sender, EventArgs e)
        {
            //la fecha se carga a la acutal
            dtpFecha.Value = DateTime.Now; 


            
            cboEstadoo.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstadoo.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });      
            cboEstadoo.DisplayMember = "Texto";
            cboEstadoo.ValueMember = "Valor";    
            cboEstadoo.SelectedIndex = 0;


            //obtenemos los proveedores y agregamos al cboProveedor, guardamos id y nombre
            List<Proveedor> listaProveedor = new CN_Proveedor().ObtenerProveedores();
            foreach (var item in listaProveedor)
            {
                if (item.Estado != false)
                {
                    cboProveedor.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.Nombre });
                }
                    
            }
            cboProveedor.DisplayMember = "Texto";
            cboProveedor.ValueMember = "Valor"; 
            cboProveedor.SelectedIndex = 0;

           
            //obtenemos las categorias y guardamos id y nombre
            List<Categoria> listaCategoria = new CN_Categoria().ObtenerCategorias();
            foreach (var item in listaCategoria)
            {
                if (item.estado != false)
                {
                    cboCategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
                }                                      
            }   
            
            cboCategoria.DisplayMember = "Texto";
            cboCategoria.ValueMember = "Valor";           
            cboCategoria.SelectedIndex = 0;
        }




        //boton agregar carrito
        private void btnCarrito_Click(object sender, EventArgs e)
        {
            //Verificamos que se ingresen los datos
            if (string.IsNullOrWhiteSpace(txtCodigoBarra.Text) ||
                string.IsNullOrWhiteSpace(txtNombree.Text) ||
                string.IsNullOrWhiteSpace(txtDesc.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sale del método si algún campo de texto está vacío
            }

            //Una vez agregado volvemos a desabilitar los botones y habilitamos solo verificar
            verificarCheck();

            //Creamos un producto con los datos de los textBox
            Producto nuevoProducto = new Producto
            {
                codigoProducto = txtCodigoBarra.Text,
                Nombre = txtNombree.Text,
                Descripcion = txtDesc.Text,
                Stock = Convert.ToInt32(txtCantidad.Text),
                PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text),
                PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                FechaRegistro = dtpFecha.Value,
                Estado = cboEstadoo.SelectedIndex == 0,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cboCategoria.SelectedItem).Valor) }
            };

            // Agrega el producto al carrito
            carrito.Add(nuevoProducto);
            MessageBox.Show("Producto agregado al carrito. Total de productos en el carrito: " + carrito.Count);


            //Si hay mas de un producto en el carrito podemos comprar
            if (carrito.Count > 0)
            {
                btnConfirmarCompra.BackColor = Color.ForestGreen;
                btnConfirmarCompra.Enabled = true;
            }

            CN_Producto negocioProducto = new CN_Producto();

            //Si el producto no existe hacemos la insercion
            if (txtCodigoBarra.Enabled)
            {
                if (negocioProducto.AgregarProducto(nuevoProducto))
                {
                    MessageBox.Show("Producto insertado en la base de datos correctamente.");
                    ActualizarDataGridView(carrito);
                }
            }

            //Si existe, actualizamos su stock y su precio de compra
            else
            {
                int idProducto = int.Parse(txtId.Text);
                Producto productoExistente = negocioProducto.ObtenerProductoPorCodigoProducto(txtCodigoBarra.Text);

                if (productoExistente != null)
                {
                    productoExistente.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
                    int cantidadNueva = int.Parse(txtCantidad.Text);

                    if (negocioProducto.EditarProducto(productoExistente) && negocioProducto.ActualizarStockProducto(idProducto, cantidadNueva))
                    {
                        MessageBox.Show("El producto se ha editado correctamente.");
                        ActualizarDataGridView(carrito);
                    }
                }
            }

            limpar();
        }

        //Carga los productos al carrito
        private void ActualizarDataGridView(List<Producto> productos)
        {
            dgvData.Rows.Clear();

            foreach (Producto producto in productos)
            {
                string estadoTexto = producto.Estado ? "Activo" : "Inactivo";
                dgvData.Rows.Add(
                    producto.Nombre,
                    producto.Stock,
                    producto.PrecioCompra,
                    producto.PrecioVenta,
                    producto.FechaRegistro
                );
            }
        }


        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            // Obtenemos el id del proveedor a través del item valor del combobox
            int idProveedor = Convert.ToInt32(((OpcionCombo)cboProveedor.SelectedItem).Valor);

            // Calculamos el monto total del carrito de compras
            decimal montoTotal = CalcularMontoTotalDelCarrito();

            // Creamos un objeto compra con los datos del usuario actual, proveedor, el monto y la fecha
            Compra nuevoCompra = new Compra
            {
                oUsuario = new Usuario() { IdUsuario = usuarioActual.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = idProveedor },
                MontoTotal = montoTotal,
                FechaRegistro = dtpFecha.Value
            };

            // Instanciamos objetos de las clases de negocios
            CN_Compra negocioCompra = new CN_Compra();
            CN_DetalleCompra negocioDetalle = new CN_DetalleCompra();
            CN_Producto negocioProducto = new CN_Producto();

            // Intentamos agregar la compra
            if (negocioCompra.AgregarCompra(nuevoCompra))
            {
                // Obtenemos el último id de compra registrado
                int idCompra = negocioCompra.obtenerUltimoIdCompra();

                // Si se obtiene un id válido
                if (idCompra > 0)
                {
                    // Inicializamos listas y obtenemos productos disponibles
                    List<DetalleCompra> detallesCompra = new List<DetalleCompra>();
                    List<Producto> productosDisponibles = negocioProducto.ObtenerProductos();

                    // Iteramos sobre los productos en el carrito
                    foreach (Producto productoEnCarrito in carrito)
                    {
                        // Buscamos el producto en la base de datos por nombre y descripción
                        Producto productoEnBaseDeDatos = productosDisponibles.FirstOrDefault(p =>
                            p.Nombre == productoEnCarrito.Nombre && p.Descripcion == productoEnCarrito.Descripcion);

                        // Si encontramos el producto en la base de datos
                        if (productoEnBaseDeDatos != null)
                        {
                            // Creamos un objeto DetalleCompra
                            DetalleCompra detalle = new DetalleCompra
                            {
                                IdCompra = idCompra,
                                oProducto = new Producto() { IdProducto = productoEnBaseDeDatos.IdProducto },
                                PrecioCompra = productoEnCarrito.PrecioCompra,
                                PrecioVenta = productoEnCarrito.PrecioVenta,
                                Cantidad = productoEnCarrito.Stock,
                                MontoTotal = productoEnCarrito.PrecioCompra * productoEnCarrito.Stock,
                                FechaRegistro = productoEnCarrito.FechaRegistro
                            };

                            // Intentamos agregar el detalle de compra
                            if (negocioDetalle.AgregarDetalleCompra(detalle))
                            {
                                detallesCompra.Add(detalle);
                            }
                        }
                    }

                    // Asignamos la lista de detalles de compra al objeto Compra
                    nuevoCompra.DetallesCompra = detallesCompra;

                    // Limpiamos el carrito y actualizamos el DataGridView
                    carrito.Clear();
                    ActualizarDataGridView(carrito);

                    // Mostramos un mensaje de éxito
                    MessageBox.Show("Compra confirmada con éxito.");

                    // Verificamos el estado del checkbox
                    verificarCheck();
                }
            }
        }





        private decimal CalcularMontoTotalDelCarrito()
        {
            decimal montoTotal = 0;

            // Recorre los productos en el carrito y suma el valor total de cada uno
            foreach (Producto producto in carrito)
            {
                decimal valorTotalProducto = producto.Stock * producto.PrecioCompra;
                montoTotal += valorTotalProducto;
            }

            return montoTotal;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //BOTON VERIFICAR
        private void iconButton2_Click(object sender, EventArgs e)
        {
          if(string.IsNullOrWhiteSpace(txtCodigoBarra.Text))
            {

                MessageBox.Show("Por favor, ingrese un código de barras ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            verificado();

            CN_Producto negocioProducto = new CN_Producto();

            string codigoProducto = txtCodigoBarra.Text;

            //obtenemos un producto por el codigo de barras
            Producto productoCargado = negocioProducto.ObtenerProductoPorCodigoProducto(codigoProducto);

            //Si este existe se rellenan los textBox correspondientes y solo nos permite usar cantidad y precio compra
            if (productoCargado != null)
            {
                MessageBox.Show("Producto existente");
                txtCantidad.Focus();
                int id = productoCargado.IdProducto;
                txtId.Text = id.ToString();

                txtCodigoBarra.Text = productoCargado.codigoProducto;
                txtCodigoBarra.Enabled = false;
                txtNombree.Text = productoCargado.Nombre;
                txtNombree.Enabled = false;
                txtDesc.Text = productoCargado.Descripcion;
                txtDesc.Enabled = false;
                txtPrecioVenta.Text = productoCargado.PrecioVenta.ToString();
                txtPrecioVenta.Enabled = false;
               
                cboCategoria.Enabled = false;
                cboEstadoo.Enabled = false;

            }
            //Si el producto no existe cargamos uno nuevo
            else
            {
                MessageBox.Show("Producto inexistente, cargue sus datos");
                limparVerificado();
            }




        }

        private void limpar()
        {
            txtCodigoBarra.Focus();
            txtCodigoBarra.Enabled = true;
            txtCodigoBarra.Clear();
            txtNombree.Clear();
            txtDesc.Clear();
            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();


        }

        private void limparVerificado()
        {
            txtNombree.Focus();
            txtCodigoBarra.ReadOnly = true;
          
            txtNombree.Clear();
            txtDesc.Clear();
            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtCodigoBarra.Clear();
            txtCodigoBarra.Enabled = true;
            txtNombree.Clear();
            txtDesc.Clear();
            txtCantidad.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();

            verificarCheck();
        }
    }
}