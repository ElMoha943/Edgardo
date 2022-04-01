namespace Edgardo
{
    partial class FormDashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelCountSales = new System.Windows.Forms.Panel();
            this.labelPercentageSales = new System.Windows.Forms.Label();
            this.labelCountSales = new System.Windows.Forms.Label();
            this.labelSales = new System.Windows.Forms.Label();
            this.ipbSales = new FontAwesome.Sharp.IconPictureBox();
            this.panelCounIncome = new System.Windows.Forms.Panel();
            this.labelPercentageIncome = new System.Windows.Forms.Label();
            this.labelCountIncome = new System.Windows.Forms.Label();
            this.ipbIncome = new FontAwesome.Sharp.IconPictureBox();
            this.labelIncome = new System.Windows.Forms.Label();
            this.panelCounProfit = new System.Windows.Forms.Panel();
            this.labelPercentageProfit = new System.Windows.Forms.Label();
            this.labelCountProfit = new System.Windows.Forms.Label();
            this.ipbProfit = new FontAwesome.Sharp.IconPictureBox();
            this.labelProfit = new System.Windows.Forms.Label();
            this.panelSales = new System.Windows.Forms.Panel();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTotals = new System.Windows.Forms.Panel();
            this.ipbProducts = new FontAwesome.Sharp.IconPictureBox();
            this.ipbProviders = new FontAwesome.Sharp.IconPictureBox();
            this.ipbClients = new FontAwesome.Sharp.IconPictureBox();
            this.labelTotalProducts = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelTotalProviders = new System.Windows.Forms.Label();
            this.labelProviders = new System.Windows.Forms.Label();
            this.labelTotalClients = new System.Windows.Forms.Label();
            this.labelClients = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelLowStock = new System.Windows.Forms.Panel();
            this.labelStock = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.panelTopProducts = new System.Windows.Forms.Panel();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnFilterYear = new System.Windows.Forms.Button();
            this.btnFilterMonth = new System.Windows.Forms.Button();
            this.btnFilterWeek = new System.Windows.Forms.Button();
            this.btnFilterDay = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelCountSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbSales)).BeginInit();
            this.panelCounIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbIncome)).BeginInit();
            this.panelCounProfit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbProfit)).BeginInit();
            this.panelSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.panelTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbProviders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbClients)).BeginInit();
            this.panelLowStock.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.panelTopProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCountSales
            // 
            this.panelCountSales.BackColor = System.Drawing.Color.GhostWhite;
            this.panelCountSales.Controls.Add(this.labelPercentageSales);
            this.panelCountSales.Controls.Add(this.labelCountSales);
            this.panelCountSales.Controls.Add(this.labelSales);
            this.panelCountSales.Controls.Add(this.ipbSales);
            this.panelCountSales.Location = new System.Drawing.Point(7, 31);
            this.panelCountSales.Name = "panelCountSales";
            this.panelCountSales.Size = new System.Drawing.Size(250, 50);
            this.panelCountSales.TabIndex = 1;
            // 
            // labelPercentageSales
            // 
            this.labelPercentageSales.AutoSize = true;
            this.labelPercentageSales.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentageSales.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelPercentageSales.Location = new System.Drawing.Point(212, 10);
            this.labelPercentageSales.Name = "labelPercentageSales";
            this.labelPercentageSales.Size = new System.Drawing.Size(34, 16);
            this.labelPercentageSales.TabIndex = 12;
            this.labelPercentageSales.Text = "+10%";
            // 
            // labelCountSales
            // 
            this.labelCountSales.AutoSize = true;
            this.labelCountSales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountSales.Location = new System.Drawing.Point(56, 23);
            this.labelCountSales.Name = "labelCountSales";
            this.labelCountSales.Size = new System.Drawing.Size(21, 16);
            this.labelCountSales.TabIndex = 11;
            this.labelCountSales.Text = "53";
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSales.Location = new System.Drawing.Point(56, 8);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(44, 16);
            this.labelSales.TabIndex = 10;
            this.labelSales.Text = "Ventas";
            // 
            // ipbSales
            // 
            this.ipbSales.BackColor = System.Drawing.Color.GhostWhite;
            this.ipbSales.Dock = System.Windows.Forms.DockStyle.Left;
            this.ipbSales.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ipbSales.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.ipbSales.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.ipbSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbSales.IconSize = 50;
            this.ipbSales.Location = new System.Drawing.Point(0, 0);
            this.ipbSales.Name = "ipbSales";
            this.ipbSales.Size = new System.Drawing.Size(50, 50);
            this.ipbSales.TabIndex = 0;
            this.ipbSales.TabStop = false;
            // 
            // panelCounIncome
            // 
            this.panelCounIncome.BackColor = System.Drawing.Color.GhostWhite;
            this.panelCounIncome.Controls.Add(this.labelPercentageIncome);
            this.panelCounIncome.Controls.Add(this.labelCountIncome);
            this.panelCounIncome.Controls.Add(this.ipbIncome);
            this.panelCounIncome.Controls.Add(this.labelIncome);
            this.panelCounIncome.Location = new System.Drawing.Point(263, 31);
            this.panelCounIncome.Name = "panelCounIncome";
            this.panelCounIncome.Size = new System.Drawing.Size(250, 50);
            this.panelCounIncome.TabIndex = 2;
            // 
            // labelPercentageIncome
            // 
            this.labelPercentageIncome.AutoSize = true;
            this.labelPercentageIncome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentageIncome.ForeColor = System.Drawing.Color.Crimson;
            this.labelPercentageIncome.Location = new System.Drawing.Point(214, 10);
            this.labelPercentageIncome.Name = "labelPercentageIncome";
            this.labelPercentageIncome.Size = new System.Drawing.Size(34, 16);
            this.labelPercentageIncome.TabIndex = 15;
            this.labelPercentageIncome.Text = "+10%";
            // 
            // labelCountIncome
            // 
            this.labelCountIncome.AutoSize = true;
            this.labelCountIncome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountIncome.Location = new System.Drawing.Point(58, 23);
            this.labelCountIncome.Name = "labelCountIncome";
            this.labelCountIncome.Size = new System.Drawing.Size(21, 16);
            this.labelCountIncome.TabIndex = 14;
            this.labelCountIncome.Text = "53";
            // 
            // ipbIncome
            // 
            this.ipbIncome.BackColor = System.Drawing.Color.GhostWhite;
            this.ipbIncome.Dock = System.Windows.Forms.DockStyle.Left;
            this.ipbIncome.ForeColor = System.Drawing.Color.Crimson;
            this.ipbIncome.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.ipbIncome.IconColor = System.Drawing.Color.Crimson;
            this.ipbIncome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbIncome.IconSize = 50;
            this.ipbIncome.Location = new System.Drawing.Point(0, 0);
            this.ipbIncome.Name = "ipbIncome";
            this.ipbIncome.Size = new System.Drawing.Size(50, 50);
            this.ipbIncome.TabIndex = 1;
            this.ipbIncome.TabStop = false;
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncome.Location = new System.Drawing.Point(58, 8);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(49, 16);
            this.labelIncome.TabIndex = 13;
            this.labelIncome.Text = "Ingresos";
            // 
            // panelCounProfit
            // 
            this.panelCounProfit.BackColor = System.Drawing.Color.GhostWhite;
            this.panelCounProfit.Controls.Add(this.labelPercentageProfit);
            this.panelCounProfit.Controls.Add(this.labelCountProfit);
            this.panelCounProfit.Controls.Add(this.ipbProfit);
            this.panelCounProfit.Controls.Add(this.labelProfit);
            this.panelCounProfit.Location = new System.Drawing.Point(519, 31);
            this.panelCounProfit.Name = "panelCounProfit";
            this.panelCounProfit.Size = new System.Drawing.Size(250, 50);
            this.panelCounProfit.TabIndex = 3;
            // 
            // labelPercentageProfit
            // 
            this.labelPercentageProfit.AutoSize = true;
            this.labelPercentageProfit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentageProfit.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelPercentageProfit.Location = new System.Drawing.Point(214, 10);
            this.labelPercentageProfit.Name = "labelPercentageProfit";
            this.labelPercentageProfit.Size = new System.Drawing.Size(34, 16);
            this.labelPercentageProfit.TabIndex = 18;
            this.labelPercentageProfit.Text = "+10%";
            // 
            // labelCountProfit
            // 
            this.labelCountProfit.AutoSize = true;
            this.labelCountProfit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountProfit.Location = new System.Drawing.Point(58, 23);
            this.labelCountProfit.Name = "labelCountProfit";
            this.labelCountProfit.Size = new System.Drawing.Size(21, 16);
            this.labelCountProfit.TabIndex = 17;
            this.labelCountProfit.Text = "53";
            // 
            // ipbProfit
            // 
            this.ipbProfit.BackColor = System.Drawing.Color.GhostWhite;
            this.ipbProfit.Dock = System.Windows.Forms.DockStyle.Left;
            this.ipbProfit.ForeColor = System.Drawing.Color.BlueViolet;
            this.ipbProfit.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWaveAlt;
            this.ipbProfit.IconColor = System.Drawing.Color.BlueViolet;
            this.ipbProfit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbProfit.IconSize = 50;
            this.ipbProfit.Location = new System.Drawing.Point(0, 0);
            this.ipbProfit.Name = "ipbProfit";
            this.ipbProfit.Size = new System.Drawing.Size(50, 50);
            this.ipbProfit.TabIndex = 2;
            this.ipbProfit.TabStop = false;
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfit.Location = new System.Drawing.Point(58, 8);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(68, 16);
            this.labelProfit.TabIndex = 16;
            this.labelProfit.Text = "Ganancias";
            // 
            // panelSales
            // 
            this.panelSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSales.BackColor = System.Drawing.Color.GhostWhite;
            this.panelSales.Controls.Add(this.chartSales);
            this.panelSales.Location = new System.Drawing.Point(8, 87);
            this.panelSales.Name = "panelSales";
            this.panelSales.Size = new System.Drawing.Size(561, 180);
            this.panelSales.TabIndex = 2;
            // 
            // chartSales
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            this.chartSales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(0, 0);
            this.chartSales.Name = "chartSales";
            this.chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.BlueViolet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.MediumSpringGreen;
            series1.Legend = "Legend1";
            series1.LegendText = "Ventas";
            series1.Name = "Series1";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(561, 180);
            this.chartSales.TabIndex = 1;
            this.chartSales.Text = "chart2";
            // 
            // panelTotals
            // 
            this.panelTotals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTotals.BackColor = System.Drawing.Color.GhostWhite;
            this.panelTotals.Controls.Add(this.ipbProducts);
            this.panelTotals.Controls.Add(this.ipbProviders);
            this.panelTotals.Controls.Add(this.ipbClients);
            this.panelTotals.Controls.Add(this.labelTotalProducts);
            this.panelTotals.Controls.Add(this.labelProducts);
            this.panelTotals.Controls.Add(this.labelTotalProviders);
            this.panelTotals.Controls.Add(this.labelProviders);
            this.panelTotals.Controls.Add(this.labelTotalClients);
            this.panelTotals.Controls.Add(this.labelClients);
            this.panelTotals.Controls.Add(this.label11);
            this.panelTotals.Location = new System.Drawing.Point(7, 273);
            this.panelTotals.Name = "panelTotals";
            this.panelTotals.Size = new System.Drawing.Size(175, 180);
            this.panelTotals.TabIndex = 3;
            // 
            // ipbProducts
            // 
            this.ipbProducts.BackColor = System.Drawing.Color.GhostWhite;
            this.ipbProducts.ForeColor = System.Drawing.Color.DarkViolet;
            this.ipbProducts.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.ipbProducts.IconColor = System.Drawing.Color.DarkViolet;
            this.ipbProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbProducts.IconSize = 50;
            this.ipbProducts.Location = new System.Drawing.Point(3, 127);
            this.ipbProducts.Name = "ipbProducts";
            this.ipbProducts.Size = new System.Drawing.Size(50, 50);
            this.ipbProducts.TabIndex = 18;
            this.ipbProducts.TabStop = false;
            // 
            // ipbProviders
            // 
            this.ipbProviders.BackColor = System.Drawing.Color.GhostWhite;
            this.ipbProviders.ForeColor = System.Drawing.Color.Crimson;
            this.ipbProviders.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.ipbProviders.IconColor = System.Drawing.Color.Crimson;
            this.ipbProviders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbProviders.IconSize = 50;
            this.ipbProviders.Location = new System.Drawing.Point(3, 78);
            this.ipbProviders.Name = "ipbProviders";
            this.ipbProviders.Size = new System.Drawing.Size(50, 50);
            this.ipbProviders.TabIndex = 17;
            this.ipbProviders.TabStop = false;
            // 
            // ipbClients
            // 
            this.ipbClients.BackColor = System.Drawing.Color.GhostWhite;
            this.ipbClients.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ipbClients.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ipbClients.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.ipbClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbClients.IconSize = 50;
            this.ipbClients.Location = new System.Drawing.Point(3, 28);
            this.ipbClients.Name = "ipbClients";
            this.ipbClients.Size = new System.Drawing.Size(50, 50);
            this.ipbClients.TabIndex = 13;
            this.ipbClients.TabStop = false;
            // 
            // labelTotalProducts
            // 
            this.labelTotalProducts.AutoSize = true;
            this.labelTotalProducts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProducts.Location = new System.Drawing.Point(56, 142);
            this.labelTotalProducts.Name = "labelTotalProducts";
            this.labelTotalProducts.Size = new System.Drawing.Size(49, 16);
            this.labelTotalProducts.TabIndex = 16;
            this.labelTotalProducts.Text = "100000";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(56, 129);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(61, 16);
            this.labelProducts.TabIndex = 15;
            this.labelProducts.Text = "Productos";
            // 
            // labelTotalProviders
            // 
            this.labelTotalProviders.AutoSize = true;
            this.labelTotalProviders.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProviders.Location = new System.Drawing.Point(56, 91);
            this.labelTotalProviders.Name = "labelTotalProviders";
            this.labelTotalProviders.Size = new System.Drawing.Size(49, 16);
            this.labelTotalProviders.TabIndex = 14;
            this.labelTotalProviders.Text = "100000";
            // 
            // labelProviders
            // 
            this.labelProviders.AutoSize = true;
            this.labelProviders.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProviders.Location = new System.Drawing.Point(56, 78);
            this.labelProviders.Name = "labelProviders";
            this.labelProviders.Size = new System.Drawing.Size(75, 16);
            this.labelProviders.TabIndex = 13;
            this.labelProviders.Text = "Proveedores";
            // 
            // labelTotalClients
            // 
            this.labelTotalClients.AutoSize = true;
            this.labelTotalClients.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalClients.Location = new System.Drawing.Point(56, 42);
            this.labelTotalClients.Name = "labelTotalClients";
            this.labelTotalClients.Size = new System.Drawing.Size(49, 16);
            this.labelTotalClients.TabIndex = 12;
            this.labelTotalClients.Text = "100000";
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.Location = new System.Drawing.Point(56, 29);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(49, 16);
            this.labelClients.TabIndex = 11;
            this.labelClients.Text = "Clientes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Contadores";
            // 
            // panelLowStock
            // 
            this.panelLowStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLowStock.BackColor = System.Drawing.Color.GhostWhite;
            this.panelLowStock.Controls.Add(this.labelStock);
            this.panelLowStock.Controls.Add(this.panel10);
            this.panelLowStock.Location = new System.Drawing.Point(188, 273);
            this.panelLowStock.Name = "panelLowStock";
            this.panelLowStock.Size = new System.Drawing.Size(380, 180);
            this.panelLowStock.TabIndex = 4;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(3, 9);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(162, 16);
            this.labelStock.TabIndex = 17;
            this.labelStock.Text = "Productos en Bajo Stock";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dgvLowStock);
            this.panel10.Location = new System.Drawing.Point(8, 28);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(359, 148);
            this.panel10.TabIndex = 5;
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.AllowUserToAddRows = false;
            this.dgvLowStock.AllowUserToDeleteRows = false;
            this.dgvLowStock.AllowUserToResizeColumns = false;
            this.dgvLowStock.AllowUserToResizeRows = false;
            this.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLowStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLowStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLowStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLowStock.GridColor = System.Drawing.Color.BlueViolet;
            this.dgvLowStock.Location = new System.Drawing.Point(0, 0);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLowStock.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvLowStock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLowStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.ShowCellErrors = false;
            this.dgvLowStock.ShowCellToolTips = false;
            this.dgvLowStock.ShowEditingIcon = false;
            this.dgvLowStock.ShowRowErrors = false;
            this.dgvLowStock.Size = new System.Drawing.Size(359, 148);
            this.dgvLowStock.TabIndex = 0;
            // 
            // panelTopProducts
            // 
            this.panelTopProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopProducts.Controls.Add(this.chartTopProducts);
            this.panelTopProducts.Location = new System.Drawing.Point(574, 87);
            this.panelTopProducts.Name = "panelTopProducts";
            this.panelTopProducts.Size = new System.Drawing.Size(195, 366);
            this.panelTopProducts.TabIndex = 3;
            // 
            // chartTopProducts
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea2);
            this.chartTopProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend2);
            this.chartTopProducts.Location = new System.Drawing.Point(0, 0);
            this.chartTopProducts.Name = "chartTopProducts";
            this.chartTopProducts.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BorderColor = System.Drawing.Color.GhostWhite;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.Transparent;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopProducts.Series.Add(series2);
            this.chartTopProducts.Size = new System.Drawing.Size(195, 366);
            this.chartTopProducts.TabIndex = 0;
            this.chartTopProducts.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Prodcutos Mas Vendidos";
            this.chartTopProducts.Titles.Add(title1);
            // 
            // btnFilterYear
            // 
            this.btnFilterYear.BackColor = System.Drawing.Color.Transparent;
            this.btnFilterYear.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnFilterYear.FlatAppearance.BorderSize = 2;
            this.btnFilterYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterYear.Location = new System.Drawing.Point(689, 4);
            this.btnFilterYear.Name = "btnFilterYear";
            this.btnFilterYear.Size = new System.Drawing.Size(80, 23);
            this.btnFilterYear.TabIndex = 6;
            this.btnFilterYear.Text = "Anual";
            this.btnFilterYear.UseVisualStyleBackColor = false;
            // 
            // btnFilterMonth
            // 
            this.btnFilterMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnFilterMonth.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnFilterMonth.FlatAppearance.BorderSize = 2;
            this.btnFilterMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterMonth.Location = new System.Drawing.Point(611, 4);
            this.btnFilterMonth.Name = "btnFilterMonth";
            this.btnFilterMonth.Size = new System.Drawing.Size(80, 23);
            this.btnFilterMonth.TabIndex = 7;
            this.btnFilterMonth.Text = "Mensual";
            this.btnFilterMonth.UseVisualStyleBackColor = false;
            // 
            // btnFilterWeek
            // 
            this.btnFilterWeek.BackColor = System.Drawing.Color.Transparent;
            this.btnFilterWeek.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnFilterWeek.FlatAppearance.BorderSize = 2;
            this.btnFilterWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterWeek.Location = new System.Drawing.Point(535, 4);
            this.btnFilterWeek.Name = "btnFilterWeek";
            this.btnFilterWeek.Size = new System.Drawing.Size(80, 23);
            this.btnFilterWeek.TabIndex = 8;
            this.btnFilterWeek.Text = "Semanal";
            this.btnFilterWeek.UseVisualStyleBackColor = false;
            // 
            // btnFilterDay
            // 
            this.btnFilterDay.BackColor = System.Drawing.Color.Transparent;
            this.btnFilterDay.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnFilterDay.FlatAppearance.BorderSize = 2;
            this.btnFilterDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterDay.Location = new System.Drawing.Point(460, 4);
            this.btnFilterDay.Name = "btnFilterDay";
            this.btnFilterDay.Size = new System.Drawing.Size(80, 23);
            this.btnFilterDay.TabIndex = 9;
            this.btnFilterDay.Text = "Diario";
            this.btnFilterDay.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(7, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(115, 16);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Panel de Control";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnFilterDay);
            this.Controls.Add(this.btnFilterWeek);
            this.Controls.Add(this.btnFilterMonth);
            this.Controls.Add(this.btnFilterYear);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelTopProducts);
            this.Controls.Add(this.panelLowStock);
            this.Controls.Add(this.panelTotals);
            this.Controls.Add(this.panelSales);
            this.Controls.Add(this.panelCounProfit);
            this.Controls.Add(this.panelCounIncome);
            this.Controls.Add(this.panelCountSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelCountSales.ResumeLayout(false);
            this.panelCountSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbSales)).EndInit();
            this.panelCounIncome.ResumeLayout(false);
            this.panelCounIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbIncome)).EndInit();
            this.panelCounProfit.ResumeLayout(false);
            this.panelCounProfit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbProfit)).EndInit();
            this.panelSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.panelTotals.ResumeLayout(false);
            this.panelTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbProviders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbClients)).EndInit();
            this.panelLowStock.ResumeLayout(false);
            this.panelLowStock.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.panelTopProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelCountSales;
        private System.Windows.Forms.Panel panelCounIncome;
        private System.Windows.Forms.Panel panelCounProfit;
        private System.Windows.Forms.Panel panelSales;
        private System.Windows.Forms.Panel panelTotals;
        private System.Windows.Forms.Panel panelLowStock;
        private System.Windows.Forms.Panel panelTopProducts;
        private System.Windows.Forms.Button btnFilterYear;
        private System.Windows.Forms.Label labelPercentageSales;
        private System.Windows.Forms.Label labelCountSales;
        private System.Windows.Forms.Label labelSales;
        private FontAwesome.Sharp.IconPictureBox ipbSales;
        private System.Windows.Forms.Label labelPercentageIncome;
        private System.Windows.Forms.Label labelCountIncome;
        private FontAwesome.Sharp.IconPictureBox ipbIncome;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.Label labelPercentageProfit;
        private System.Windows.Forms.Label labelCountProfit;
        private FontAwesome.Sharp.IconPictureBox ipbProfit;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Button btnFilterMonth;
        private System.Windows.Forms.Button btnFilterWeek;
        private System.Windows.Forms.Button btnFilterDay;
        private System.Windows.Forms.Label labelTotalProducts;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelTotalProviders;
        private System.Windows.Forms.Label labelProviders;
        private System.Windows.Forms.Label labelTotalClients;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelStock;
        private FontAwesome.Sharp.IconPictureBox ipbProducts;
        private FontAwesome.Sharp.IconPictureBox ipbProviders;
        private FontAwesome.Sharp.IconPictureBox ipbClients;
        private System.Windows.Forms.Label labelTitle;
    }
}

