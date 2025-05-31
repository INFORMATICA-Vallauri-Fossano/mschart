namespace Es26_GraficoMSChart
{
    partial class frmMSChart
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraficoBarre = new System.Windows.Forms.Button();
            this.btnTortaInbutoPiramide = new System.Windows.Forms.Button();
            this.btnDoppio = new System.Windows.Forms.Button();
            this.btnEsporta = new System.Windows.Forms.Button();
            this.cmbTipoBarre = new System.Windows.Forms.ComboBox();
            this.cmbTipoTIP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            this.SuspendLayout();
            // 
            // myChart
            // 
            this.myChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.myChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.myChart.Legends.Add(legend1);
            this.myChart.Location = new System.Drawing.Point(16, 15);
            this.myChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myChart.Name = "myChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.myChart.Series.Add(series1);
            this.myChart.Size = new System.Drawing.Size(865, 434);
            this.myChart.TabIndex = 0;
            this.myChart.Text = "chart1";
            // 
            // btnGraficoBarre
            // 
            this.btnGraficoBarre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGraficoBarre.Location = new System.Drawing.Point(13, 480);
            this.btnGraficoBarre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGraficoBarre.Name = "btnGraficoBarre";
            this.btnGraficoBarre.Size = new System.Drawing.Size(185, 28);
            this.btnGraficoBarre.TabIndex = 1;
            this.btnGraficoBarre.Text = "Grafico a barre";
            this.btnGraficoBarre.UseVisualStyleBackColor = true;
            this.btnGraficoBarre.Click += new System.EventHandler(this.btnBarre_Click);
            // 
            // btnTortaInbutoPiramide
            // 
            this.btnTortaInbutoPiramide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTortaInbutoPiramide.Location = new System.Drawing.Point(13, 516);
            this.btnTortaInbutoPiramide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTortaInbutoPiramide.Name = "btnTortaInbutoPiramide";
            this.btnTortaInbutoPiramide.Size = new System.Drawing.Size(379, 28);
            this.btnTortaInbutoPiramide.TabIndex = 2;
            this.btnTortaInbutoPiramide.Text = "Grafico a Torta, Inbuto, Piramide";
            this.btnTortaInbutoPiramide.UseVisualStyleBackColor = true;
            this.btnTortaInbutoPiramide.Click += new System.EventHandler(this.btnTortaImbutoPiramide_Click);
            // 
            // btnDoppio
            // 
            this.btnDoppio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDoppio.Location = new System.Drawing.Point(693, 480);
            this.btnDoppio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoppio.Name = "btnDoppio";
            this.btnDoppio.Size = new System.Drawing.Size(185, 28);
            this.btnDoppio.TabIndex = 3;
            this.btnDoppio.Text = "Grafico doppio";
            this.btnDoppio.UseVisualStyleBackColor = true;
            this.btnDoppio.Click += new System.EventHandler(this.btnDoppio_Click);
            // 
            // btnEsporta
            // 
            this.btnEsporta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEsporta.Location = new System.Drawing.Point(693, 516);
            this.btnEsporta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEsporta.Name = "btnEsporta";
            this.btnEsporta.Size = new System.Drawing.Size(185, 28);
            this.btnEsporta.TabIndex = 4;
            this.btnEsporta.Text = "ESPORTA";
            this.btnEsporta.UseVisualStyleBackColor = true;
            this.btnEsporta.Click += new System.EventHandler(this.btnEsporta_Click);
            // 
            // cmbTipoBarre
            // 
            this.cmbTipoBarre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbTipoBarre.FormattingEnabled = true;
            this.cmbTipoBarre.Location = new System.Drawing.Point(206, 480);
            this.cmbTipoBarre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoBarre.Name = "cmbTipoBarre";
            this.cmbTipoBarre.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoBarre.TabIndex = 5;
            // 
            // cmbTipoTIP
            // 
            this.cmbTipoTIP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbTipoTIP.FormattingEnabled = true;
            this.cmbTipoTIP.Location = new System.Drawing.Point(400, 514);
            this.cmbTipoTIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoTIP.Name = "cmbTipoTIP";
            this.cmbTipoTIP.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoTIP.TabIndex = 6;
            // 
            // frmMSChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 554);
            this.Controls.Add(this.cmbTipoTIP);
            this.Controls.Add(this.cmbTipoBarre);
            this.Controls.Add(this.btnEsporta);
            this.Controls.Add(this.btnDoppio);
            this.Controls.Add(this.btnTortaInbutoPiramide);
            this.Controls.Add(this.btnGraficoBarre);
            this.Controls.Add(this.myChart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMSChart";
            this.Text = "MS CHART";
            this.Load += new System.EventHandler(this.frmMSChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.Button btnGraficoBarre;
        private System.Windows.Forms.Button btnTortaInbutoPiramide;
        private System.Windows.Forms.Button btnDoppio;
        private System.Windows.Forms.Button btnEsporta;
        private System.Windows.Forms.ComboBox cmbTipoBarre;
        private System.Windows.Forms.ComboBox cmbTipoTIP;
    }
}

