namespace CapaPresentacion
{
    partial class frmVerVentasVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerVentasVendedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.laberlVenta3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.laberlVenta4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvDetalleVenta = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDataVenta = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laberlVenta = new Bunifu.UI.WinForms.BunifuLabel();
            this.laberlVenta2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalVentas2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalVentas = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSubtotalVenta = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel11 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalDetalleVentas = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // laberlVenta3
            // 
            this.laberlVenta3.AllowParentOverrides = false;
            this.laberlVenta3.AutoEllipsis = false;
            this.laberlVenta3.Cursor = System.Windows.Forms.Cursors.Default;
            this.laberlVenta3.CursorType = System.Windows.Forms.Cursors.Default;
            this.laberlVenta3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlVenta3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.laberlVenta3.Location = new System.Drawing.Point(735, 74);
            this.laberlVenta3.Name = "laberlVenta3";
            this.laberlVenta3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laberlVenta3.Size = new System.Drawing.Size(149, 28);
            this.laberlVenta3.TabIndex = 67;
            this.laberlVenta3.Text = "Detalle de la";
            this.laberlVenta3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.laberlVenta3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // laberlVenta4
            // 
            this.laberlVenta4.AllowParentOverrides = false;
            this.laberlVenta4.AutoEllipsis = false;
            this.laberlVenta4.Cursor = System.Windows.Forms.Cursors.Default;
            this.laberlVenta4.CursorType = System.Windows.Forms.Cursors.Default;
            this.laberlVenta4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlVenta4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.laberlVenta4.Location = new System.Drawing.Point(890, 74);
            this.laberlVenta4.Name = "laberlVenta4";
            this.laberlVenta4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laberlVenta4.Size = new System.Drawing.Size(69, 28);
            this.laberlVenta4.TabIndex = 68;
            this.laberlVenta4.Text = "Venta";
            this.laberlVenta4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.laberlVenta4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowCustomTheming = false;
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVenta.ColumnHeadersHeight = 40;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.PrecioVenta,
            this.Cantidad,
            this.Subtotal});
            this.dgvDetalleVenta.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.dgvDetalleVenta.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetalleVenta.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetalleVenta.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvDetalleVenta.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.CurrentTheme.BackColor = System.Drawing.Color.Maroon;
            this.dgvDetalleVenta.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvDetalleVenta.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvDetalleVenta.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetalleVenta.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvDetalleVenta.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.CurrentTheme.Name = null;
            this.dgvDetalleVenta.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvDetalleVenta.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDetalleVenta.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetalleVenta.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvDetalleVenta.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleVenta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvDetalleVenta.HeaderBackColor = System.Drawing.Color.Maroon;
            this.dgvDetalleVenta.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDetalleVenta.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(614, 108);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.RowTemplate.Height = 40;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(466, 445);
            this.dgvDetalleVenta.TabIndex = 66;
            this.dgvDetalleVenta.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.FillWeight = 35.31608F;
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.FillWeight = 60F;
            this.NombreProducto.HeaderText = "NombreProducto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "PrecioVenta";
            this.PrecioVenta.FillWeight = 51.49196F;
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.FillWeight = 62.08146F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.DataPropertyName = "Subtotal";
            this.Subtotal.FillWeight = 46.56324F;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // dgvDataVenta
            // 
            this.dgvDataVenta.AllowCustomTheming = false;
            this.dgvDataVenta.AllowUserToAddRows = false;
            this.dgvDataVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgvDataVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDataVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataVenta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDataVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDataVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDataVenta.ColumnHeadersHeight = 40;
            this.dgvDataVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenta,
            this.Vendedor,
            this.MontoPago,
            this.MontoCambio,
            this.MontoTotal,
            this.FechaRegistro});
            this.dgvDataVenta.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvDataVenta.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDataVenta.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDataVenta.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvDataVenta.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDataVenta.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvDataVenta.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvDataVenta.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvDataVenta.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDataVenta.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDataVenta.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvDataVenta.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDataVenta.CurrentTheme.Name = null;
            this.dgvDataVenta.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvDataVenta.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDataVenta.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDataVenta.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvDataVenta.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataVenta.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDataVenta.EnableHeadersVisualStyles = false;
            this.dgvDataVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvDataVenta.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvDataVenta.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDataVenta.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDataVenta.Location = new System.Drawing.Point(9, 108);
            this.dgvDataVenta.Name = "dgvDataVenta";
            this.dgvDataVenta.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDataVenta.RowHeadersVisible = false;
            this.dgvDataVenta.RowTemplate.Height = 40;
            this.dgvDataVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataVenta.Size = new System.Drawing.Size(599, 445);
            this.dgvDataVenta.TabIndex = 65;
            this.dgvDataVenta.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dgvDataVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataVenta_CellContentClick);
            // 
            // IdVenta
            // 
            this.IdVenta.DataPropertyName = "IdVenta";
            this.IdVenta.FillWeight = 24.02624F;
            this.IdVenta.HeaderText = "IdVenta";
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            // 
            // Vendedor
            // 
            this.Vendedor.DataPropertyName = "Vendedor";
            this.Vendedor.FillWeight = 30F;
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            // 
            // MontoPago
            // 
            this.MontoPago.DataPropertyName = "MontoPago";
            this.MontoPago.FillWeight = 36.27516F;
            this.MontoPago.HeaderText = "MontoPago";
            this.MontoPago.Name = "MontoPago";
            this.MontoPago.ReadOnly = true;
            // 
            // MontoCambio
            // 
            this.MontoCambio.DataPropertyName = "MontoCambio";
            this.MontoCambio.FillWeight = 39.92798F;
            this.MontoCambio.HeaderText = "MontoCambio";
            this.MontoCambio.Name = "MontoCambio";
            this.MontoCambio.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.FillWeight = 23.86558F;
            this.MontoTotal.HeaderText = "MontoTotal";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            this.FechaRegistro.FillWeight = 36.27516F;
            this.FechaRegistro.HeaderText = "FechaRegistro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // laberlVenta
            // 
            this.laberlVenta.AllowParentOverrides = false;
            this.laberlVenta.AutoEllipsis = false;
            this.laberlVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.laberlVenta.CursorType = System.Windows.Forms.Cursors.Default;
            this.laberlVenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.laberlVenta.Location = new System.Drawing.Point(125, 74);
            this.laberlVenta.Name = "laberlVenta";
            this.laberlVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laberlVenta.Size = new System.Drawing.Size(69, 28);
            this.laberlVenta.TabIndex = 63;
            this.laberlVenta.Text = "Venta";
            this.laberlVenta.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.laberlVenta.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // laberlVenta2
            // 
            this.laberlVenta2.AllowParentOverrides = false;
            this.laberlVenta2.AutoEllipsis = false;
            this.laberlVenta2.Cursor = System.Windows.Forms.Cursors.Default;
            this.laberlVenta2.CursorType = System.Windows.Forms.Cursors.Default;
            this.laberlVenta2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlVenta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.laberlVenta2.Location = new System.Drawing.Point(199, 74);
            this.laberlVenta2.Name = "laberlVenta2";
            this.laberlVenta2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laberlVenta2.Size = new System.Drawing.Size(121, 28);
            this.laberlVenta2.TabIndex = 64;
            this.laberlVenta2.Text = "realizadas";
            this.laberlVenta2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.laberlVenta2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotalVentas2
            // 
            this.lblTotalVentas2.AllowParentOverrides = false;
            this.lblTotalVentas2.AutoEllipsis = false;
            this.lblTotalVentas2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalVentas2.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotalVentas2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalVentas2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblTotalVentas2.Location = new System.Drawing.Point(256, 600);
            this.lblTotalVentas2.Name = "lblTotalVentas2";
            this.lblTotalVentas2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalVentas2.Size = new System.Drawing.Size(13, 28);
            this.lblTotalVentas2.TabIndex = 83;
            this.lblTotalVentas2.Text = "0";
            this.lblTotalVentas2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotalVentas2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.AutoSize = false;
            this.bunifuLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuLabel10.Location = new System.Drawing.Point(9, 600);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(208, 28);
            this.bunifuLabel10.TabIndex = 82;
            this.bunifuLabel10.Text = "Total en Ventas:";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AllowParentOverrides = false;
            this.lblTotalVentas.AutoEllipsis = false;
            this.lblTotalVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalVentas.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotalVentas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblTotalVentas.Location = new System.Drawing.Point(256, 566);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalVentas.Size = new System.Drawing.Size(13, 28);
            this.lblTotalVentas.TabIndex = 81;
            this.lblTotalVentas.Text = "0";
            this.lblTotalVentas.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotalVentas.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(9, 566);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(241, 28);
            this.bunifuLabel1.TabIndex = 80;
            this.bunifuLabel1.Text = "Cantidad de ventas:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblSubtotalVenta
            // 
            this.lblSubtotalVenta.AllowParentOverrides = false;
            this.lblSubtotalVenta.AutoEllipsis = false;
            this.lblSubtotalVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSubtotalVenta.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSubtotalVenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblSubtotalVenta.Location = new System.Drawing.Point(977, 600);
            this.lblSubtotalVenta.Name = "lblSubtotalVenta";
            this.lblSubtotalVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubtotalVenta.Size = new System.Drawing.Size(13, 28);
            this.lblSubtotalVenta.TabIndex = 87;
            this.lblSubtotalVenta.Text = "0";
            this.lblSubtotalVenta.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblSubtotalVenta.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel11
            // 
            this.bunifuLabel11.AllowParentOverrides = false;
            this.bunifuLabel11.AutoEllipsis = false;
            this.bunifuLabel11.AutoSize = false;
            this.bunifuLabel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel11.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuLabel11.Location = new System.Drawing.Point(735, 600);
            this.bunifuLabel11.Name = "bunifuLabel11";
            this.bunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel11.Size = new System.Drawing.Size(224, 28);
            this.bunifuLabel11.TabIndex = 86;
            this.bunifuLabel11.Text = "Total de la Venta:";
            this.bunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotalDetalleVentas
            // 
            this.lblTotalDetalleVentas.AllowParentOverrides = false;
            this.lblTotalDetalleVentas.AutoEllipsis = false;
            this.lblTotalDetalleVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalDetalleVentas.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotalDetalleVentas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalDetalleVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblTotalDetalleVentas.Location = new System.Drawing.Point(1006, 566);
            this.lblTotalDetalleVentas.Name = "lblTotalDetalleVentas";
            this.lblTotalDetalleVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalDetalleVentas.Size = new System.Drawing.Size(13, 28);
            this.lblTotalDetalleVentas.TabIndex = 85;
            this.lblTotalDetalleVentas.Text = "0";
            this.lblTotalDetalleVentas.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotalDetalleVentas.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(735, 566);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(269, 28);
            this.bunifuLabel2.TabIndex = 84;
            this.bunifuLabel2.Text = "Cantidad de Registros:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Ver ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(50, 25);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaDesde.TabIndex = 91;
            this.dtpFechaDesde.Value = new System.DateTime(2023, 11, 12, 19, 18, 13, 0);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(211, 25);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaHasta.TabIndex = 92;
            this.dtpFechaHasta.Value = new System.DateTime(2023, 11, 12, 19, 18, 13, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpFechaDesde);
            this.panel1.Location = new System.Drawing.Point(387, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 78);
            this.panel1.TabIndex = 93;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 93;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVerVentasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 640);
            this.Controls.Add(this.lblSubtotalVenta);
            this.Controls.Add(this.bunifuLabel11);
            this.Controls.Add(this.lblTotalDetalleVentas);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.lblTotalVentas2);
            this.Controls.Add(this.bunifuLabel10);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.laberlVenta3);
            this.Controls.Add(this.laberlVenta4);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.dgvDataVenta);
            this.Controls.Add(this.laberlVenta);
            this.Controls.Add(this.laberlVenta2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVerVentasVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerVentasVendedor";
            this.Load += new System.EventHandler(this.frmVerVentasVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel laberlVenta3;
        private Bunifu.UI.WinForms.BunifuLabel laberlVenta4;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDataVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private Bunifu.UI.WinForms.BunifuLabel laberlVenta;
        private Bunifu.UI.WinForms.BunifuLabel laberlVenta2;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalVentas2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalVentas;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lblSubtotalVenta;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel11;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalDetalleVentas;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}