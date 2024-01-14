namespace CapaPresentacion
{
    partial class frmVerVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.laberlVenta5 = new Bunifu.UI.WinForms.BunifuLabel();
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
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalVentas = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalDetalleVentas = new Bunifu.UI.WinForms.BunifuLabel();
            this.ddlUsuarios = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSubtotalVenta = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel11 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotalVentas2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // laberlVenta5
            // 
            this.laberlVenta5.AllowParentOverrides = false;
            this.laberlVenta5.AutoEllipsis = false;
            this.laberlVenta5.Cursor = System.Windows.Forms.Cursors.Default;
            this.laberlVenta5.CursorType = System.Windows.Forms.Cursors.Default;
            this.laberlVenta5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlVenta5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.laberlVenta5.Location = new System.Drawing.Point(10, 13);
            this.laberlVenta5.Name = "laberlVenta5";
            this.laberlVenta5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laberlVenta5.Size = new System.Drawing.Size(125, 39);
            this.laberlVenta5.TabIndex = 63;
            this.laberlVenta5.Text = "Reporte";
            this.laberlVenta5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.laberlVenta5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // laberlVenta3
            // 
            this.laberlVenta3.AllowParentOverrides = false;
            this.laberlVenta3.AutoEllipsis = false;
            this.laberlVenta3.Cursor = System.Windows.Forms.Cursors.Default;
            this.laberlVenta3.CursorType = System.Windows.Forms.Cursors.Default;
            this.laberlVenta3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlVenta3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.laberlVenta3.Location = new System.Drawing.Point(636, 83);
            this.laberlVenta3.Name = "laberlVenta3";
            this.laberlVenta3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laberlVenta3.Size = new System.Drawing.Size(204, 39);
            this.laberlVenta3.TabIndex = 61;
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
            this.laberlVenta4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlVenta4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.laberlVenta4.Location = new System.Drawing.Point(846, 83);
            this.laberlVenta4.Name = "laberlVenta4";
            this.laberlVenta4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laberlVenta4.Size = new System.Drawing.Size(96, 39);
            this.laberlVenta4.TabIndex = 62;
            this.laberlVenta4.Text = "Venta";
            this.laberlVenta4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.laberlVenta4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowCustomTheming = false;
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dgvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalleVenta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvDetalleVenta.HeaderBackColor = System.Drawing.Color.Maroon;
            this.dgvDetalleVenta.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDetalleVenta.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(616, 130);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.RowTemplate.Height = 40;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(466, 445);
            this.dgvDetalleVenta.TabIndex = 60;
            this.dgvDetalleVenta.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            this.dgvDetalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVenta_CellContentClick);
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
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.dgvDataVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDataVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataVenta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDataVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDataVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataVenta.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDataVenta.EnableHeadersVisualStyles = false;
            this.dgvDataVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvDataVenta.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvDataVenta.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDataVenta.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDataVenta.Location = new System.Drawing.Point(11, 130);
            this.dgvDataVenta.Name = "dgvDataVenta";
            this.dgvDataVenta.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDataVenta.RowHeadersVisible = false;
            this.dgvDataVenta.RowTemplate.Height = 40;
            this.dgvDataVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataVenta.Size = new System.Drawing.Size(599, 445);
            this.dgvDataVenta.TabIndex = 59;
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
            this.laberlVenta.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.laberlVenta.Location = new System.Drawing.Point(183, 83);
            this.laberlVenta.Name = "laberlVenta";
            this.laberlVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laberlVenta.Size = new System.Drawing.Size(96, 39);
            this.laberlVenta.TabIndex = 57;
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
            this.laberlVenta2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlVenta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.laberlVenta2.Location = new System.Drawing.Point(285, 83);
            this.laberlVenta2.Name = "laberlVenta2";
            this.laberlVenta2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laberlVenta2.Size = new System.Drawing.Size(166, 39);
            this.laberlVenta2.TabIndex = 58;
            this.laberlVenta2.Text = "realizadas";
            this.laberlVenta2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.laberlVenta2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 579);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(241, 28);
            this.bunifuLabel1.TabIndex = 64;
            this.bunifuLabel1.Text = "Cantidad de ventas:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
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
            this.bunifuLabel2.Location = new System.Drawing.Point(616, 579);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(269, 28);
            this.bunifuLabel2.TabIndex = 65;
            this.bunifuLabel2.Text = "Cantidad de Registros:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AllowParentOverrides = false;
            this.lblTotalVentas.AutoEllipsis = false;
            this.lblTotalVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalVentas.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotalVentas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblTotalVentas.Location = new System.Drawing.Point(259, 579);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalVentas.Size = new System.Drawing.Size(13, 28);
            this.lblTotalVentas.TabIndex = 66;
            this.lblTotalVentas.Text = "0";
            this.lblTotalVentas.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotalVentas.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblTotalVentas.Click += new System.EventHandler(this.lblTotalVentas_Click);
            // 
            // lblTotalDetalleVentas
            // 
            this.lblTotalDetalleVentas.AllowParentOverrides = false;
            this.lblTotalDetalleVentas.AutoEllipsis = false;
            this.lblTotalDetalleVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalDetalleVentas.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotalDetalleVentas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalDetalleVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblTotalDetalleVentas.Location = new System.Drawing.Point(895, 579);
            this.lblTotalDetalleVentas.Name = "lblTotalDetalleVentas";
            this.lblTotalDetalleVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalDetalleVentas.Size = new System.Drawing.Size(13, 28);
            this.lblTotalDetalleVentas.TabIndex = 67;
            this.lblTotalDetalleVentas.Text = "0";
            this.lblTotalDetalleVentas.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotalDetalleVentas.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblTotalDetalleVentas.Click += new System.EventHandler(this.lblTotalDetalleVentas_Click);
            // 
            // ddlUsuarios
            // 
            this.ddlUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.ddlUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.ddlUsuarios.BorderColor = System.Drawing.Color.Silver;
            this.ddlUsuarios.BorderRadius = 1;
            this.ddlUsuarios.Color = System.Drawing.Color.Silver;
            this.ddlUsuarios.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddlUsuarios.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlUsuarios.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddlUsuarios.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlUsuarios.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddlUsuarios.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlUsuarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddlUsuarios.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddlUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUsuarios.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlUsuarios.FillDropDown = true;
            this.ddlUsuarios.FillIndicator = false;
            this.ddlUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddlUsuarios.ForeColor = System.Drawing.Color.Black;
            this.ddlUsuarios.FormattingEnabled = true;
            this.ddlUsuarios.Icon = null;
            this.ddlUsuarios.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlUsuarios.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlUsuarios.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlUsuarios.IndicatorThickness = 2;
            this.ddlUsuarios.IsDropdownOpened = false;
            this.ddlUsuarios.ItemBackColor = System.Drawing.Color.White;
            this.ddlUsuarios.ItemBorderColor = System.Drawing.Color.White;
            this.ddlUsuarios.ItemForeColor = System.Drawing.Color.Black;
            this.ddlUsuarios.ItemHeight = 26;
            this.ddlUsuarios.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddlUsuarios.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddlUsuarios.ItemTopMargin = 3;
            this.ddlUsuarios.Location = new System.Drawing.Point(891, 24);
            this.ddlUsuarios.Name = "ddlUsuarios";
            this.ddlUsuarios.Size = new System.Drawing.Size(187, 32);
            this.ddlUsuarios.TabIndex = 68;
            this.ddlUsuarios.Text = null;
            this.ddlUsuarios.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlUsuarios.TextLeftMargin = 5;
            this.ddlUsuarios.SelectedIndexChanged += new System.EventHandler(this.ddlUsuarios_SelectedIndexChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Century Gothic", 14.21F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(581, 22);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(303, 34);
            this.bunifuLabel3.TabIndex = 69;
            this.bunifuLabel3.Text = "Seleccionar vendedor";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Click += new System.EventHandler(this.bunifuLabel3_Click);
            // 
            // lblSubtotalVenta
            // 
            this.lblSubtotalVenta.AllowParentOverrides = false;
            this.lblSubtotalVenta.AutoEllipsis = false;
            this.lblSubtotalVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSubtotalVenta.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSubtotalVenta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblSubtotalVenta.Location = new System.Drawing.Point(862, 613);
            this.lblSubtotalVenta.Name = "lblSubtotalVenta";
            this.lblSubtotalVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubtotalVenta.Size = new System.Drawing.Size(13, 28);
            this.lblSubtotalVenta.TabIndex = 81;
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
            this.bunifuLabel11.Location = new System.Drawing.Point(616, 613);
            this.bunifuLabel11.Name = "bunifuLabel11";
            this.bunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel11.Size = new System.Drawing.Size(224, 28);
            this.bunifuLabel11.TabIndex = 80;
            this.bunifuLabel11.Text = "Total de la Venta:";
            this.bunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel11.Click += new System.EventHandler(this.bunifuLabel11_Click);
            // 
            // lblTotalVentas2
            // 
            this.lblTotalVentas2.AllowParentOverrides = false;
            this.lblTotalVentas2.AutoEllipsis = false;
            this.lblTotalVentas2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalVentas2.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotalVentas2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalVentas2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblTotalVentas2.Location = new System.Drawing.Point(259, 613);
            this.lblTotalVentas2.Name = "lblTotalVentas2";
            this.lblTotalVentas2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalVentas2.Size = new System.Drawing.Size(13, 28);
            this.lblTotalVentas2.TabIndex = 79;
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
            this.bunifuLabel10.Location = new System.Drawing.Point(12, 613);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(208, 28);
            this.bunifuLabel10.TabIndex = 78;
            this.bunifuLabel10.Text = "Total en Ventas:";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmVerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 640);
            this.Controls.Add(this.lblSubtotalVenta);
            this.Controls.Add(this.bunifuLabel11);
            this.Controls.Add(this.lblTotalVentas2);
            this.Controls.Add(this.bunifuLabel10);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.ddlUsuarios);
            this.Controls.Add(this.lblTotalDetalleVentas);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.laberlVenta5);
            this.Controls.Add(this.laberlVenta3);
            this.Controls.Add(this.laberlVenta4);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.dgvDataVenta);
            this.Controls.Add(this.laberlVenta);
            this.Controls.Add(this.laberlVenta2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVerVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerVentas";
            this.Load += new System.EventHandler(this.frmVerVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel laberlVenta5;
        private Bunifu.UI.WinForms.BunifuLabel laberlVenta3;
        private Bunifu.UI.WinForms.BunifuLabel laberlVenta4;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDetalleVenta;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDataVenta;
        private Bunifu.UI.WinForms.BunifuLabel laberlVenta;
        private Bunifu.UI.WinForms.BunifuLabel laberlVenta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalVentas;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalDetalleVentas;
        private Bunifu.UI.WinForms.BunifuDropdown ddlUsuarios;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel lblSubtotalVenta;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel11;
        private Bunifu.UI.WinForms.BunifuLabel lblTotalVentas2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
    }
}