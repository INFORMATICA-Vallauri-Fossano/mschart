namespace mschart
{
    partial class frmChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea2.Name = "ChartArea1";
            this.myChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.myChart.Legends.Add(legend2);
            this.myChart.Location = new System.Drawing.Point(12, 12);
            this.myChart.Name = "myChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.myChart.Series.Add(series2);
            this.myChart.Size = new System.Drawing.Size(649, 300);
            this.myChart.TabIndex = 0;
            this.myChart.Text = "chart1";
            // 
            // btnGraficoBarre
            // 
            this.btnGraficoBarre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGraficoBarre.Location = new System.Drawing.Point(12, 318);
            this.btnGraficoBarre.Name = "btnGraficoBarre";
            this.btnGraficoBarre.Size = new System.Drawing.Size(139, 23);
            this.btnGraficoBarre.TabIndex = 1;
            this.btnGraficoBarre.Text = "Grafico a barre";
            this.btnGraficoBarre.UseVisualStyleBackColor = true;
            this.btnGraficoBarre.Click += new System.EventHandler(this.btnGraficoBarre_Click);
            // 
            // btnTortaInbutoPiramide
            // 
            this.btnTortaInbutoPiramide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTortaInbutoPiramide.Location = new System.Drawing.Point(12, 347);
            this.btnTortaInbutoPiramide.Name = "btnTortaInbutoPiramide";
            this.btnTortaInbutoPiramide.Size = new System.Drawing.Size(284, 23);
            this.btnTortaInbutoPiramide.TabIndex = 2;
            this.btnTortaInbutoPiramide.Text = "Grafico a Torta, Inbuto, Piramide";
            this.btnTortaInbutoPiramide.UseVisualStyleBackColor = true;
            // 
            // btnDoppio
            // 
            this.btnDoppio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDoppio.Location = new System.Drawing.Point(522, 318);
            this.btnDoppio.Name = "btnDoppio";
            this.btnDoppio.Size = new System.Drawing.Size(139, 23);
            this.btnDoppio.TabIndex = 3;
            this.btnDoppio.Text = "Grafico doppio";
            this.btnDoppio.UseVisualStyleBackColor = true;
            // 
            // btnEsporta
            // 
            this.btnEsporta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEsporta.Location = new System.Drawing.Point(522, 347);
            this.btnEsporta.Name = "btnEsporta";
            this.btnEsporta.Size = new System.Drawing.Size(139, 23);
            this.btnEsporta.TabIndex = 4;
            this.btnEsporta.Text = "ESPORTA";
            this.btnEsporta.UseVisualStyleBackColor = true;
            // 
            // cmbTipoBarre
            // 
            this.cmbTipoBarre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbTipoBarre.FormattingEnabled = true;
            this.cmbTipoBarre.Location = new System.Drawing.Point(157, 318);
            this.cmbTipoBarre.Name = "cmbTipoBarre";
            this.cmbTipoBarre.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoBarre.TabIndex = 5;
            // 
            // cmbTipoTIP
            // 
            this.cmbTipoTIP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbTipoTIP.FormattingEnabled = true;
            this.cmbTipoTIP.Location = new System.Drawing.Point(302, 345);
            this.cmbTipoTIP.Name = "cmbTipoTIP";
            this.cmbTipoTIP.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTIP.TabIndex = 6;
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.cmbTipoTIP);
            this.Controls.Add(this.cmbTipoBarre);
            this.Controls.Add(this.btnEsporta);
            this.Controls.Add(this.btnDoppio);
            this.Controls.Add(this.btnTortaInbutoPiramide);
            this.Controls.Add(this.btnGraficoBarre);
            this.Controls.Add(this.myChart);
            this.Name = "frmChart";
            this.Text = "MS CHART";
            this.Load += new System.EventHandler(this.frmChart_Load);
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

