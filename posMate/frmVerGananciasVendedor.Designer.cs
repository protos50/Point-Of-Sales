namespace CapaPresentacion
{
    partial class frmVerGananciasVendedor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerGananciasVendedor));
            this.chartGananciasMeses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridGananciasMeses = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dropdownMeses = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dropdownAños = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.laberlVenta5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartGananciasMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGananciasMeses)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGananciasMeses
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGananciasMeses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGananciasMeses.Legends.Add(legend1);
            this.chartGananciasMeses.Location = new System.Drawing.Point(12, 134);
            this.chartGananciasMeses.Name = "chartGananciasMeses";
            this.chartGananciasMeses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGananciasMeses.Series.Add(series1);
            this.chartGananciasMeses.Size = new System.Drawing.Size(515, 400);
            this.chartGananciasMeses.TabIndex = 0;
            this.chartGananciasMeses.Text = "chart1";
            // 
            // dataGridGananciasMeses
            // 
            this.dataGridGananciasMeses.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridGananciasMeses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridGananciasMeses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGananciasMeses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridGananciasMeses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridGananciasMeses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGananciasMeses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridGananciasMeses.ColumnHeadersHeight = 40;
            this.dataGridGananciasMeses.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.dataGridGananciasMeses.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridGananciasMeses.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridGananciasMeses.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.dataGridGananciasMeses.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridGananciasMeses.CurrentTheme.BackColor = System.Drawing.Color.Crimson;
            this.dataGridGananciasMeses.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dataGridGananciasMeses.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.dataGridGananciasMeses.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridGananciasMeses.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridGananciasMeses.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.dataGridGananciasMeses.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridGananciasMeses.CurrentTheme.Name = null;
            this.dataGridGananciasMeses.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.dataGridGananciasMeses.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridGananciasMeses.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridGananciasMeses.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.dataGridGananciasMeses.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridGananciasMeses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridGananciasMeses.EnableHeadersVisualStyles = false;
            this.dataGridGananciasMeses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dataGridGananciasMeses.HeaderBackColor = System.Drawing.Color.Crimson;
            this.dataGridGananciasMeses.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridGananciasMeses.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridGananciasMeses.Location = new System.Drawing.Point(533, 134);
            this.dataGridGananciasMeses.Name = "dataGridGananciasMeses";
            this.dataGridGananciasMeses.RowHeadersVisible = false;
            this.dataGridGananciasMeses.RowTemplate.Height = 40;
            this.dataGridGananciasMeses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGananciasMeses.Size = new System.Drawing.Size(383, 400);
            this.dataGridGananciasMeses.TabIndex = 1;
            this.dataGridGananciasMeses.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            this.dataGridGananciasMeses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGananciasMeses_CellContentClick);
            // 
            // dropdownMeses
            // 
            this.dropdownMeses.BackColor = System.Drawing.Color.Transparent;
            this.dropdownMeses.BackgroundColor = System.Drawing.Color.White;
            this.dropdownMeses.BorderColor = System.Drawing.Color.Silver;
            this.dropdownMeses.BorderRadius = 1;
            this.dropdownMeses.Color = System.Drawing.Color.Silver;
            this.dropdownMeses.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropdownMeses.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropdownMeses.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropdownMeses.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropdownMeses.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropdownMeses.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropdownMeses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropdownMeses.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropdownMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownMeses.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownMeses.FillDropDown = true;
            this.dropdownMeses.FillIndicator = false;
            this.dropdownMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownMeses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropdownMeses.ForeColor = System.Drawing.Color.Black;
            this.dropdownMeses.FormattingEnabled = true;
            this.dropdownMeses.Icon = null;
            this.dropdownMeses.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownMeses.IndicatorColor = System.Drawing.Color.DarkGray;
            this.dropdownMeses.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownMeses.IndicatorThickness = 2;
            this.dropdownMeses.IsDropdownOpened = false;
            this.dropdownMeses.ItemBackColor = System.Drawing.Color.White;
            this.dropdownMeses.ItemBorderColor = System.Drawing.Color.White;
            this.dropdownMeses.ItemForeColor = System.Drawing.Color.Black;
            this.dropdownMeses.ItemHeight = 26;
            this.dropdownMeses.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropdownMeses.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropdownMeses.ItemTopMargin = 3;
            this.dropdownMeses.Location = new System.Drawing.Point(739, 51);
            this.dropdownMeses.Name = "dropdownMeses";
            this.dropdownMeses.Size = new System.Drawing.Size(177, 32);
            this.dropdownMeses.TabIndex = 2;
            this.dropdownMeses.Text = null;
            this.dropdownMeses.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownMeses.TextLeftMargin = 5;
            this.dropdownMeses.SelectedIndexChanged += new System.EventHandler(this.dropdownMeses_SelectedIndexChanged);
            // 
            // dropdownAños
            // 
            this.dropdownAños.BackColor = System.Drawing.Color.Transparent;
            this.dropdownAños.BackgroundColor = System.Drawing.Color.White;
            this.dropdownAños.BorderColor = System.Drawing.Color.Silver;
            this.dropdownAños.BorderRadius = 1;
            this.dropdownAños.Color = System.Drawing.Color.Silver;
            this.dropdownAños.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropdownAños.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropdownAños.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropdownAños.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropdownAños.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropdownAños.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropdownAños.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropdownAños.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropdownAños.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownAños.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownAños.FillDropDown = true;
            this.dropdownAños.FillIndicator = false;
            this.dropdownAños.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownAños.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropdownAños.ForeColor = System.Drawing.Color.Black;
            this.dropdownAños.FormattingEnabled = true;
            this.dropdownAños.Icon = null;
            this.dropdownAños.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownAños.IndicatorColor = System.Drawing.Color.DarkGray;
            this.dropdownAños.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropdownAños.IndicatorThickness = 2;
            this.dropdownAños.IsDropdownOpened = false;
            this.dropdownAños.ItemBackColor = System.Drawing.Color.White;
            this.dropdownAños.ItemBorderColor = System.Drawing.Color.White;
            this.dropdownAños.ItemForeColor = System.Drawing.Color.Black;
            this.dropdownAños.ItemHeight = 26;
            this.dropdownAños.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropdownAños.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropdownAños.ItemTopMargin = 3;
            this.dropdownAños.Location = new System.Drawing.Point(739, 89);
            this.dropdownAños.Name = "dropdownAños";
            this.dropdownAños.Size = new System.Drawing.Size(177, 32);
            this.dropdownAños.TabIndex = 3;
            this.dropdownAños.Text = null;
            this.dropdownAños.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropdownAños.TextLeftMargin = 5;
            this.dropdownAños.SelectedIndexChanged += new System.EventHandler(this.dropdownAños_SelectedIndexChanged);
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.Font = new System.Drawing.Font("Century Gothic", 14.21F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuLabel8.Location = new System.Drawing.Point(644, 51);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(84, 34);
            this.bunifuLabel8.TabIndex = 74;
            this.bunifuLabel8.Text = "Fecha";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 14.21F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(672, 89);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(56, 34);
            this.bunifuLabel1.TabIndex = 75;
            this.bunifuLabel1.Text = "Año";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Century Gothic", 16.21F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Indigo;
            this.bunifuLabel3.Location = new System.Drawing.Point(143, 17);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(363, 34);
            this.bunifuLabel3.TabIndex = 77;
            this.bunifuLabel3.Text = "Ganancias por empleados";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // laberlVenta5
            // 
            this.laberlVenta5.AllowParentOverrides = false;
            this.laberlVenta5.AutoEllipsis = false;
            this.laberlVenta5.Cursor = System.Windows.Forms.Cursors.Default;
            this.laberlVenta5.CursorType = System.Windows.Forms.Cursors.Default;
            this.laberlVenta5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberlVenta5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.laberlVenta5.Location = new System.Drawing.Point(12, 12);
            this.laberlVenta5.Name = "laberlVenta5";
            this.laberlVenta5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laberlVenta5.Size = new System.Drawing.Size(125, 39);
            this.laberlVenta5.TabIndex = 76;
            this.laberlVenta5.Text = "Reporte";
            this.laberlVenta5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.laberlVenta5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Indigo;
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 100);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(128, 28);
            this.bunifuLabel2.TabIndex = 78;
            this.bunifuLabel2.Text = "Ganancias";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Century Gothic", 14.21F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuLabel5.Location = new System.Drawing.Point(603, 11);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(132, 34);
            this.bunifuLabel5.TabIndex = 81;
            this.bunifuLabel5.Text = "Filtrar por:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmVerGananciasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 546);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.laberlVenta5);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuLabel8);
            this.Controls.Add(this.dropdownAños);
            this.Controls.Add(this.dropdownMeses);
            this.Controls.Add(this.dataGridGananciasMeses);
            this.Controls.Add(this.chartGananciasMeses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVerGananciasVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerGananciasVendedor";
            this.Load += new System.EventHandler(this.frmVerGananciasVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGananciasMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGananciasMeses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGananciasMeses;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridGananciasMeses;
        private Bunifu.UI.WinForms.BunifuDropdown dropdownMeses;
        private Bunifu.UI.WinForms.BunifuDropdown dropdownAños;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel laberlVenta5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
    }
}