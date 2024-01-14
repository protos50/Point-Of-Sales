using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaNegocios;
using CapaPresentacion;
using CapaPresentacion.Utilidades;
using FontAwesome.Sharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private Usuario usuarioActual;
        private decimal montoTotal = 0;

        private List<Producto> carrito = new List<Producto>();
        public frmVentas(Usuario oUsuario = null)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
        }







        private void frmVentas_Load(object sender, EventArgs e)
        {

            //La fecha siempre la actual
            dtpFecha.Value = DateTime.Now;
            verificarCheck();

            //obtener los productos
            List <Producto> listaProducto = new CN_Producto().ObtenerProductos();
            foreach (var producto in listaProducto)
            {
                if(producto.Estado != false)
                {
                    cboProducto.Items.Add(new OpcionCombo() { Valor = producto.IdProducto, Texto = producto.Nombre });
                }
               
            }
            cboProducto.DisplayMember = "Texto";
            cboProducto.ValueMember = "Valor";
            cboProducto.SelectedIndex = 0;
           
        }

        private void verificarCheck()
        {
            //Metodo para tengamos que primero cargar dni del cliente
            //si hay mas de un producto en el carrito podemos comprar
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
            txtDNII.Enabled = true;
            txtDNII.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCantidad.Clear(); 
            txtPago.Clear();    

            iconButton1.Enabled = true;
            iconButton1.BackColor = Color.ForestGreen;

            btnCarrito.BackColor = SystemColors.Control;
            btnCarrito.Enabled = false;

            txtDNII.Focus();
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCantidad.Enabled = false;
            txtPago.Enabled = false;
            cboProducto.Enabled = false;
            montoTotal = 0;
            resultadoTotal.Text = montoTotal.ToString("C");
        }

        private void verifiado()
        {
            iconButton1.Enabled = false;
            iconButton1.BackColor = SystemColors.Control;

            btnCarrito.BackColor = Color.MediumTurquoise;
            btnCarrito.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCantidad.Enabled = true;
            txtPago.Enabled = true;
            cboProducto.Enabled = true;
        }


        //verificar
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNII.Text))
            {
                MessageBox.Show("Por favor, completa el campo DNI.");
                return;
            }

            //Se verifica
            verifiado();

            CN_Cliente negocioCliente = new CN_Cliente();

            int dni = int.Parse(txtDNII.Text);

            //Buscamos el cliente por su dni, si existe se rellenan los txt con sus datos, evitamos que hayan registros repetidos en la bd
            Cliente clienteCargado = negocioCliente.BuscarClientePorDNI(dni);
            if(clienteCargado != null)
            {
                MessageBox.Show("Bienvenido "  + clienteCargado.Nombre + " " + clienteCargado.Apellido);
                int id = clienteCargado.IdCliente;
                txtId.Text = id.ToString();

                txtDNII.Text = clienteCargado.DNI.ToString();
                txtDNII.Enabled = false;

                txtNombre.Text = clienteCargado.Nombre;
                txtNombre.Enabled = false;

                txtApellido.Text = clienteCargado.Apellido;
                txtApellido.Enabled = false;


            }
            else
            {
                //Si no existe en la bd creamos
                MessageBox.Show("Cliente inexistente, cargue sus datos");
                limpiarVerdificado();
                
            }
        }

        private void limpiarVerdificado()
        {
            txtNombre.Focus();
            txtDNII.ReadOnly = true;

            

        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDNII.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
                return;
            }

            CN_Cliente negocioCliente = new CN_Cliente();

            

            Cliente nuevoCliente = new Cliente()
            {
                DNI = Convert.ToInt32(txtDNII.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text
            };

            negocioCliente.AgregarCliente(nuevoCliente);


            if (txtId.Text == "0")
            {
                int idClienteCreado = negocioCliente.ObtenerIdClientePorDNI(Convert.ToInt32(txtDNII.Text));
                txtId.Text = idClienteCreado.ToString();
            }

            CN_Producto negocioProducto = new CN_Producto();

            OpcionCombo productoSeleccionado = (OpcionCombo)cboProducto.SelectedItem;

            int idProducto = (int)productoSeleccionado.Valor; // ID del producto
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            Producto producto = negocioProducto.ObtenerProductoPorId(idProducto);
            // Verificar si el producto existe y la cantidad es válida
            if (producto != null && cantidad > 0 && cantidad <= producto.Stock)
            {

                negocioProducto.ActualizarStockProductoVenta(idProducto, cantidad);
                carrito.Add(producto);


                montoTotal += producto.PrecioVenta * cantidad;

                resultadoTotal.Text =   montoTotal.ToString("C");

                if (carrito.Count > 0)
                {
                    btnConfirmarCompra.BackColor = Color.ForestGreen;
                    btnConfirmarCompra.Enabled = true;
                }

                // Agregar los datos del producto al DataGridView
                dgvData.Rows.Add(new object[]
                {
                    producto.IdProducto,
                     txtDNII.Text, // DNI del cliente
                     producto.Nombre,
                     producto.PrecioVenta,
                     cantidad,
                     producto.PrecioVenta * cantidad
                }); ;

                // Limpiar los campos después de agregar el producto al carrito
                txtCantidad.Clear();
                cboProducto.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("La cantidad ingresada excede el stock del producto.");
            }
        }


        private decimal CalcularMontoTotalDelCarrito()
        {
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.Cells["Cantidad"].Value != null)
                {
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioVenta = Convert.ToDecimal(row.Cells["Precio"].Value);
                    decimal valorTotalProducto = cantidad * precioVenta;
                    montoTotal += valorTotalProducto;
                }
            }

            return montoTotal;
        }


        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPago.Text))
            {
                MessageBox.Show("Por favor, ingrese un monto de pago válido.");
                return;
            }

            decimal montoTotal = CalcularMontoTotalDelCarrito();
            decimal montoPago = decimal.Parse(txtPago.Text);

            if (montoPago < montoTotal)
            {
                MessageBox.Show("El monto de pago debe ser mayor o igual al monto total.");
                return;
            }

            Venta nuevaVenta = new Venta
            {
                oUsuario = new Usuario() { IdUsuario = usuarioActual.IdUsuario },
                oCliente = new Cliente() { IdCliente = int.Parse(txtId.Text) },
                MontoPago = decimal.Parse(txtPago.Text),
                MontoCambio = decimal.Parse(txtPago.Text) - montoTotal,
                MontoTotal = montoTotal,
                FechaRegistro = dtpFecha.Value,
            };

            CN_Venta negocioVenta = new CN_Venta();
            CN_DetalleVenta negocioDetalle = new CN_DetalleVenta();
            CN_Producto negocioProducto = new CN_Producto();

            if (negocioVenta.AgregarVenta(nuevaVenta))
            {
                int idVenta = negocioVenta.ObtenerUltimoIDVenta();
                if (idVenta > 0)
                {
                    List<DetalleVenta> detallesVenta = new List<DetalleVenta>();
                    List<Producto> productosDisponibles = negocioProducto.ObtenerProductos();

                    foreach (Producto productoEnCarrito in carrito)
                    {
                        Producto productoEnBaseDeDatos = productosDisponibles.FirstOrDefault(p =>
                            p.Nombre == productoEnCarrito.Nombre && p.Descripcion == productoEnCarrito.Descripcion);

                        if (productoEnBaseDeDatos != null)
                        {
                            // Obtener la fila correspondiente a este producto en el DataGridView
                            DataGridViewRow row = dgvData.Rows
                                .Cast<DataGridViewRow>()
                                .First(r => r.Cells["Producto"].Value.ToString() == productoEnBaseDeDatos.Nombre);

                            int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                            decimal subtotal = cantidad * productoEnCarrito.PrecioVenta;

                            DetalleVenta detalle = new DetalleVenta
                            {
                                IdVenta = idVenta,
                                oProducto = new Producto() { IdProducto = productoEnBaseDeDatos.IdProducto },
                                PrecioVenta = productoEnCarrito.PrecioVenta,
                                Cantidad = cantidad,    // Usar la cantidad del DataGridView
                                Subtotal = subtotal,    // Calcular el subtotal
                                FechaRegistro = dtpFecha.Value
                            };

                            if (negocioDetalle.AgregarDetalleVenta(detalle))
                            {
                                detallesVenta.Add(detalle);
                            }
                        }
                    }

                    nuevaVenta.DetalleVenta = detallesVenta;



                    //******FACTURA**********
                    int idVentaFactura = negocioVenta.ObtenerUltimoIDVenta();

                    DialogResult result = MessageBox.Show("¿Desea imprimir la factura?", "Imprimir Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SaveFileDialog savefile = new SaveFileDialog();

                        savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmm"));

                        string PaginaHTML_Texto = Properties.Resources.plantilla.ToString();

                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITULO", "Factura" + " " + txtApellido.Text + " " + txtNombre.Text + " " + "Compra N" + idVentaFactura.ToString());
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txtApellido.Text + " " + txtNombre.Text);
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txtDNII.Text);
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@idventa", idVentaFactura.ToString());

                        string filas = string.Empty;

                        foreach (DataGridViewRow row in dgvData.Rows)
                        {
                            filas += "<tr>";
                            filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                            filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                            filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                            filas += "<td>" + row.Cells["Total"].Value.ToString() + "</td>";
                            filas += "</tr>";
                        }

                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);

                        // Reemplazar la etiqueta @TOTAL con el monto total de la venta
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", resultadoTotal.Text);

                        if (savefile.ShowDialog() == DialogResult.OK)
                        {
                            using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Phrase(""));

                                using (StringReader sr = new StringReader(PaginaHTML_Texto))
                                {
                                    
                                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                                }

                                pdfDoc.Close();
                                stream.Close();
                            }
                        }
                    }

                    

                    MessageBox.Show("Venta confirmada con éxito.");
                    dgvData.Rows.Clear();
                    carrito.Clear();

                    

                    verificarCheck();
                }
            }
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }


        //Eliminar
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CN_Producto cnProducto = new CN_Producto();
            if (e.ColumnIndex == dgvData.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Obtén el ID del producto que se está eliminando
                int idProducto = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["productoid"].Value);

                // Busca el producto en la lista carrito y elimínalo
                Producto productoEliminado = carrito.FirstOrDefault(p => p.IdProducto == idProducto);
                if (productoEliminado != null)
                {
                    carrito.Remove(productoEliminado);
                }

                // Llama a la función de la capa de negocio para actualizar el stock del producto
                int cantidadEliminada = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["Cantidad"].Value);
                if (cnProducto.ActualizarStockProducto(idProducto, cantidadEliminada))
                {
                    // Actualiza el monto total restando el total del producto eliminado
                    montoTotal -= Convert.ToDecimal(dgvData.Rows[e.RowIndex].Cells["Total"].Value);
                    resultadoTotal.Text = montoTotal.ToString("C");

                    // Elimina la fila del DataGridView
                    dgvData.Rows.RemoveAt(e.RowIndex);

                    // Verifica si el carrito está vacío
                    if (dgvData.Rows.Count == 0)
                    {
                        btnConfirmarCompra.Enabled = false;
                        btnConfirmarCompra.BackColor = SystemColors.Control;
                    }
                }
                else
                {
                    MessageBox.Show("Error al actualizar el stock del producto.");
                }
            }
        }



    }

}



