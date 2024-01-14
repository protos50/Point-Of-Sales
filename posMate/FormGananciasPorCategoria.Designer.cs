namespace CapaPresentacion
{
    partial class FormGananciasPorCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGananciasPorCategoria));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganancias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMañana = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnTarde = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnNoche = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnTotal = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(478, 67);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(617, 488);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoría,
            this.Ganancias});
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.dataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.Name = null;
            this.dataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dataGridView1.HeaderBackColor = System.Drawing.Color.Teal;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(460, 358);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            // 
            // Categoría
            // 
            this.Categoría.DataPropertyName = "Categoría";
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.Name = "Categoría";
            // 
            // Ganancias
            // 
            this.Ganancias.DataPropertyName = "Ganancias";
            this.Ganancias.HeaderText = "Ganancias";
            this.Ganancias.Name = "Ganancias";
            // 
            // btnMañana
            // 
            this.btnMañana.AllowAnimations = true;
            this.btnMañana.AllowMouseEffects = true;
            this.btnMañana.AllowToggling = false;
            this.btnMañana.AnimationSpeed = 200;
            this.btnMañana.AutoGenerateColors = false;
            this.btnMañana.AutoRoundBorders = false;
            this.btnMañana.AutoSizeLeftIcon = true;
            this.btnMañana.AutoSizeRightIcon = true;
            this.btnMañana.BackColor = System.Drawing.Color.Transparent;
            this.btnMañana.BackColor1 = System.Drawing.Color.LimeGreen;
            this.btnMañana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMañana.BackgroundImage")));
            this.btnMañana.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnMañana.ButtonText = "Mañana";
            this.btnMañana.ButtonTextMarginLeft = 0;
            this.btnMañana.ColorContrastOnClick = 45;
            this.btnMañana.ColorContrastOnHover = 45;
            this.btnMañana.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnMañana.CustomizableEdges = borderEdges1;
            this.btnMañana.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMañana.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMañana.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMañana.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMañana.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnMañana.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMañana.ForeColor = System.Drawing.Color.White;
            this.btnMañana.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMañana.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMañana.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMañana.IconMarginLeft = 11;
            this.btnMañana.IconPadding = 10;
            this.btnMañana.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMañana.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMañana.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMañana.IconSize = 25;
            this.btnMañana.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMañana.IdleBorderRadius = 1;
            this.btnMañana.IdleBorderThickness = 1;
            this.btnMañana.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btnMañana.IdleIconLeftImage = null;
            this.btnMañana.IdleIconRightImage = null;
            this.btnMañana.IndicateFocus = false;
            this.btnMañana.Location = new System.Drawing.Point(217, 495);
            this.btnMañana.Name = "btnMañana";
            this.btnMañana.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMañana.OnDisabledState.BorderRadius = 1;
            this.btnMañana.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnMañana.OnDisabledState.BorderThickness = 1;
            this.btnMañana.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMañana.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMañana.OnDisabledState.IconLeftImage = null;
            this.btnMañana.OnDisabledState.IconRightImage = null;
            this.btnMañana.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnMañana.onHoverState.BorderRadius = 1;
            this.btnMañana.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnMañana.onHoverState.BorderThickness = 1;
            this.btnMañana.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnMañana.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMañana.onHoverState.IconLeftImage = null;
            this.btnMañana.onHoverState.IconRightImage = null;
            this.btnMañana.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMañana.OnIdleState.BorderRadius = 1;
            this.btnMañana.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnMañana.OnIdleState.BorderThickness = 1;
            this.btnMañana.OnIdleState.FillColor = System.Drawing.Color.LimeGreen;
            this.btnMañana.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMañana.OnIdleState.IconLeftImage = null;
            this.btnMañana.OnIdleState.IconRightImage = null;
            this.btnMañana.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnMañana.OnPressedState.BorderRadius = 1;
            this.btnMañana.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnMañana.OnPressedState.BorderThickness = 1;
            this.btnMañana.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnMañana.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMañana.OnPressedState.IconLeftImage = null;
            this.btnMañana.OnPressedState.IconRightImage = null;
            this.btnMañana.Size = new System.Drawing.Size(112, 60);
            this.btnMañana.TabIndex = 2;
            this.btnMañana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMañana.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMañana.TextMarginLeft = 0;
            this.btnMañana.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMañana.UseDefaultRadiusAndThickness = true;
            this.btnMañana.Click += new System.EventHandler(this.btnMañana_Click);
            // 
            // btnTarde
            // 
            this.btnTarde.AllowAnimations = true;
            this.btnTarde.AllowMouseEffects = true;
            this.btnTarde.AllowToggling = false;
            this.btnTarde.AnimationSpeed = 200;
            this.btnTarde.AutoGenerateColors = false;
            this.btnTarde.AutoRoundBorders = false;
            this.btnTarde.AutoSizeLeftIcon = true;
            this.btnTarde.AutoSizeRightIcon = true;
            this.btnTarde.BackColor = System.Drawing.Color.Transparent;
            this.btnTarde.BackColor1 = System.Drawing.Color.Chocolate;
            this.btnTarde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTarde.BackgroundImage")));
            this.btnTarde.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTarde.ButtonText = "Tarde";
            this.btnTarde.ButtonTextMarginLeft = 0;
            this.btnTarde.ColorContrastOnClick = 45;
            this.btnTarde.ColorContrastOnHover = 45;
            this.btnTarde.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnTarde.CustomizableEdges = borderEdges2;
            this.btnTarde.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTarde.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTarde.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTarde.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTarde.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnTarde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTarde.ForeColor = System.Drawing.Color.White;
            this.btnTarde.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarde.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTarde.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTarde.IconMarginLeft = 11;
            this.btnTarde.IconPadding = 10;
            this.btnTarde.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTarde.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTarde.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTarde.IconSize = 25;
            this.btnTarde.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTarde.IdleBorderRadius = 1;
            this.btnTarde.IdleBorderThickness = 1;
            this.btnTarde.IdleFillColor = System.Drawing.Color.Chocolate;
            this.btnTarde.IdleIconLeftImage = null;
            this.btnTarde.IdleIconRightImage = null;
            this.btnTarde.IndicateFocus = false;
            this.btnTarde.Location = new System.Drawing.Point(217, 431);
            this.btnTarde.Name = "btnTarde";
            this.btnTarde.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTarde.OnDisabledState.BorderRadius = 1;
            this.btnTarde.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTarde.OnDisabledState.BorderThickness = 1;
            this.btnTarde.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTarde.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTarde.OnDisabledState.IconLeftImage = null;
            this.btnTarde.OnDisabledState.IconRightImage = null;
            this.btnTarde.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTarde.onHoverState.BorderRadius = 1;
            this.btnTarde.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTarde.onHoverState.BorderThickness = 1;
            this.btnTarde.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTarde.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTarde.onHoverState.IconLeftImage = null;
            this.btnTarde.onHoverState.IconRightImage = null;
            this.btnTarde.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTarde.OnIdleState.BorderRadius = 1;
            this.btnTarde.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTarde.OnIdleState.BorderThickness = 1;
            this.btnTarde.OnIdleState.FillColor = System.Drawing.Color.Chocolate;
            this.btnTarde.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTarde.OnIdleState.IconLeftImage = null;
            this.btnTarde.OnIdleState.IconRightImage = null;
            this.btnTarde.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTarde.OnPressedState.BorderRadius = 1;
            this.btnTarde.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTarde.OnPressedState.BorderThickness = 1;
            this.btnTarde.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTarde.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTarde.OnPressedState.IconLeftImage = null;
            this.btnTarde.OnPressedState.IconRightImage = null;
            this.btnTarde.Size = new System.Drawing.Size(112, 60);
            this.btnTarde.TabIndex = 3;
            this.btnTarde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTarde.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTarde.TextMarginLeft = 0;
            this.btnTarde.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTarde.UseDefaultRadiusAndThickness = true;
            this.btnTarde.Click += new System.EventHandler(this.btnTarde_Click);
            // 
            // btnNoche
            // 
            this.btnNoche.AllowAnimations = true;
            this.btnNoche.AllowMouseEffects = true;
            this.btnNoche.AllowToggling = false;
            this.btnNoche.AnimationSpeed = 200;
            this.btnNoche.AutoGenerateColors = false;
            this.btnNoche.AutoRoundBorders = false;
            this.btnNoche.AutoSizeLeftIcon = true;
            this.btnNoche.AutoSizeRightIcon = true;
            this.btnNoche.BackColor = System.Drawing.Color.Transparent;
            this.btnNoche.BackColor1 = System.Drawing.Color.DarkBlue;
            this.btnNoche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNoche.BackgroundImage")));
            this.btnNoche.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNoche.ButtonText = "Noche";
            this.btnNoche.ButtonTextMarginLeft = 0;
            this.btnNoche.ColorContrastOnClick = 45;
            this.btnNoche.ColorContrastOnHover = 45;
            this.btnNoche.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnNoche.CustomizableEdges = borderEdges3;
            this.btnNoche.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNoche.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNoche.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNoche.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNoche.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnNoche.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNoche.ForeColor = System.Drawing.Color.White;
            this.btnNoche.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoche.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNoche.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNoche.IconMarginLeft = 11;
            this.btnNoche.IconPadding = 10;
            this.btnNoche.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNoche.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNoche.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNoche.IconSize = 25;
            this.btnNoche.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNoche.IdleBorderRadius = 1;
            this.btnNoche.IdleBorderThickness = 1;
            this.btnNoche.IdleFillColor = System.Drawing.Color.DarkBlue;
            this.btnNoche.IdleIconLeftImage = null;
            this.btnNoche.IdleIconRightImage = null;
            this.btnNoche.IndicateFocus = false;
            this.btnNoche.Location = new System.Drawing.Point(350, 431);
            this.btnNoche.Name = "btnNoche";
            this.btnNoche.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNoche.OnDisabledState.BorderRadius = 1;
            this.btnNoche.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNoche.OnDisabledState.BorderThickness = 1;
            this.btnNoche.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNoche.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNoche.OnDisabledState.IconLeftImage = null;
            this.btnNoche.OnDisabledState.IconRightImage = null;
            this.btnNoche.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNoche.onHoverState.BorderRadius = 1;
            this.btnNoche.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNoche.onHoverState.BorderThickness = 1;
            this.btnNoche.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNoche.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNoche.onHoverState.IconLeftImage = null;
            this.btnNoche.onHoverState.IconRightImage = null;
            this.btnNoche.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNoche.OnIdleState.BorderRadius = 1;
            this.btnNoche.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNoche.OnIdleState.BorderThickness = 1;
            this.btnNoche.OnIdleState.FillColor = System.Drawing.Color.DarkBlue;
            this.btnNoche.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNoche.OnIdleState.IconLeftImage = null;
            this.btnNoche.OnIdleState.IconRightImage = null;
            this.btnNoche.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNoche.OnPressedState.BorderRadius = 1;
            this.btnNoche.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNoche.OnPressedState.BorderThickness = 1;
            this.btnNoche.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNoche.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNoche.OnPressedState.IconLeftImage = null;
            this.btnNoche.OnPressedState.IconRightImage = null;
            this.btnNoche.Size = new System.Drawing.Size(112, 60);
            this.btnNoche.TabIndex = 4;
            this.btnNoche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNoche.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNoche.TextMarginLeft = 0;
            this.btnNoche.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNoche.UseDefaultRadiusAndThickness = true;
            this.btnNoche.Click += new System.EventHandler(this.btnNoche_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.AllowAnimations = true;
            this.btnTotal.AllowMouseEffects = true;
            this.btnTotal.AllowToggling = false;
            this.btnTotal.AnimationSpeed = 200;
            this.btnTotal.AutoGenerateColors = false;
            this.btnTotal.AutoRoundBorders = false;
            this.btnTotal.AutoSizeLeftIcon = true;
            this.btnTotal.AutoSizeRightIcon = true;
            this.btnTotal.BackColor = System.Drawing.Color.Transparent;
            this.btnTotal.BackColor1 = System.Drawing.Color.Gray;
            this.btnTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotal.BackgroundImage")));
            this.btnTotal.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTotal.ButtonText = "Total";
            this.btnTotal.ButtonTextMarginLeft = 0;
            this.btnTotal.ColorContrastOnClick = 45;
            this.btnTotal.ColorContrastOnHover = 45;
            this.btnTotal.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnTotal.CustomizableEdges = borderEdges4;
            this.btnTotal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTotal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTotal.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTotal.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTotal.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotal.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTotal.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTotal.IconMarginLeft = 11;
            this.btnTotal.IconPadding = 10;
            this.btnTotal.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTotal.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTotal.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTotal.IconSize = 25;
            this.btnTotal.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTotal.IdleBorderRadius = 1;
            this.btnTotal.IdleBorderThickness = 1;
            this.btnTotal.IdleFillColor = System.Drawing.Color.Gray;
            this.btnTotal.IdleIconLeftImage = null;
            this.btnTotal.IdleIconRightImage = null;
            this.btnTotal.IndicateFocus = false;
            this.btnTotal.Location = new System.Drawing.Point(350, 497);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTotal.OnDisabledState.BorderRadius = 1;
            this.btnTotal.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTotal.OnDisabledState.BorderThickness = 1;
            this.btnTotal.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTotal.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTotal.OnDisabledState.IconLeftImage = null;
            this.btnTotal.OnDisabledState.IconRightImage = null;
            this.btnTotal.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTotal.onHoverState.BorderRadius = 1;
            this.btnTotal.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTotal.onHoverState.BorderThickness = 1;
            this.btnTotal.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnTotal.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTotal.onHoverState.IconLeftImage = null;
            this.btnTotal.onHoverState.IconRightImage = null;
            this.btnTotal.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTotal.OnIdleState.BorderRadius = 1;
            this.btnTotal.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTotal.OnIdleState.BorderThickness = 1;
            this.btnTotal.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btnTotal.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTotal.OnIdleState.IconLeftImage = null;
            this.btnTotal.OnIdleState.IconRightImage = null;
            this.btnTotal.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTotal.OnPressedState.BorderRadius = 1;
            this.btnTotal.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTotal.OnPressedState.BorderThickness = 1;
            this.btnTotal.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnTotal.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTotal.OnPressedState.IconLeftImage = null;
            this.btnTotal.OnPressedState.IconRightImage = null;
            this.btnTotal.Size = new System.Drawing.Size(112, 60);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTotal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTotal.TextMarginLeft = 0;
            this.btnTotal.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTotal.UseDefaultRadiusAndThickness = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 440);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(178, 39);
            this.bunifuLabel2.TabIndex = 37;
            this.bunifuLabel2.Text = "Ganancias";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(28, 497);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(149, 39);
            this.bunifuLabel1.TabIndex = 38;
            this.bunifuLabel1.Text = "por Turno";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(247, 12);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(632, 39);
            this.bunifuLabel3.TabIndex = 39;
            this.bunifuLabel3.Text = "Ganancias por categoria de productos";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FormGananciasPorCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 567);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnNoche);
            this.Controls.Add(this.btnTarde);
            this.Controls.Add(this.btnMañana);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGananciasPorCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormGananciasPorCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganancias;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnMañana;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnTarde;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnNoche;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnTotal;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}