using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Es26_GraficoMSChart
{
    public partial class frmMSChart : Form
    {
        public frmMSChart()
        {
            InitializeComponent();
        }

        private void frmMSChart_Load(object sender, EventArgs e)
        {
            cmbTipoBarre.Items.Add("Barre Orizzontali");
            cmbTipoBarre.Items.Add("Barre Verticali");
            cmbTipoBarre.Items.Add("Linee");
            cmbTipoBarre.Items.Add("Punti");
            cmbTipoBarre.SelectedIndex = 0;
            cmbTipoTIP.Items.Add("Torta");
            cmbTipoTIP.Items.Add("Piramide");
            cmbTipoTIP.Items.Add("Imbuto");
            cmbTipoTIP.SelectedIndex = 0;
            pulisciCollections();
        }

        private void pulisciCollections()
        {
            myChart.Series.Clear();
            myChart.Legends.Clear();
            myChart.ChartAreas.Clear();
            myChart.Titles.Clear();
        }

        private void btnBarre_Click(object sender, EventArgs e)
        {
            pulisciCollections();
            //aggiungo chartarea
            myChart.ChartAreas.Add("AreaGraficoBarre");
            //apetto 3d
            myChart.ChartAreas["AreaGraficoBarre"].Area3DStyle.Enable3D = false;
            //aggiungo legenda
            myChart.Legends.Add("Legenda");
            myChart.Legends["Legenda"].Title = "Risultati a.s. 2024/25";
            myChart.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            //aggiungo titolo
            myChart.Titles.Add("Promossi a.s. 2024/25");
            myChart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            //creo serie dei dati
            Series p2024 = new Series("Promossi 2024");
            Series p2025 = new Series("Promossi 2025");
            //aggiungo i dati
            p2024.Points.Add(20);
            p2024.Points.Add(25);
            p2024.Points.Add(17);
            p2024.Points.Add(22);
            p2024.Points.Add(19);
            p2025.Points.Add(18);
            p2025.Points.Add(21);
            p2025.Points.Add(14);
            p2025.Points.Add(20);
            p2025.Points.Add(17);
            //inserisco le label delle serie
            p2024.Points[0].AxisLabel = "Vallauri";
            p2024.Points[1].AxisLabel = "Tesauro";
            p2024.Points[2].AxisLabel = "Ancina";
            p2024.Points[3].AxisLabel = "Del Pozzo";
            p2024.Points[4].AxisLabel = "Avogadro";
            //aggiungo le serie al grafico
            myChart.Series.Add(p2024);
            myChart.Series.Add(p2025);
            //colore
            p2024.Color = Color.Red;
            myChart.Series[1].Color = Color.Blue;
            //mostro etichette
            p2024.IsValueShownAsLabel = true;
            p2025.IsValueShownAsLabel = true;
            //label degli assi
            myChart.ChartAreas[0].AxisX.Title = "SCUOLE";
            myChart.ChartAreas[0].AxisY.Title = "RAGAZZI";
            //Posizione del grafico
            myChart.Location = new System.Drawing.Point(1, 1);
            //Dimensioni
            myChart.Size = new System.Drawing.Size(this.Width - 1, this.Height - 100);
            //vedo il tipo di grafico
            switch (cmbTipoBarre.SelectedIndex)
            {
                case 0: //barre orizzontali
                    myChart.Series[0].ChartType = SeriesChartType.Bar;
                    myChart.Series[1].ChartType = SeriesChartType.Bar;
                    break;
                case 1: //barre verticali
                    myChart.Series[0].ChartType = SeriesChartType.Column;
                    myChart.Series[1].ChartType = SeriesChartType.Column;
                    break;
                case 2: //linee
                    myChart.Series[0].ChartType = SeriesChartType.Line;
                    myChart.Series[1].ChartType = SeriesChartType.Line;
                    break;
                case 3: //punti
                    myChart.Series[0].ChartType = SeriesChartType.Point;
                    myChart.Series[1].ChartType = SeriesChartType.Point;
                    break;
            }
        }

        private void btnTortaImbutoPiramide_Click(object sender, EventArgs e)
        {
            pulisciCollections();
            //aggiungo chartarea
            myChart.ChartAreas.Add("AreaGraficoTorta");
            //apetto 3d
            myChart.ChartAreas["AreaGraficoTorta"].Area3DStyle.Enable3D = true;
            //aggiungo legenda
            myChart.Legends.Add("Legenda");
            myChart.Legends["Legenda"].Title = "Risultati 2023";
            myChart.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            //aggiungo titolo
            myChart.Titles.Add("Promossi - Bocciati - Con Debito");
            myChart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            //creo la serie dei dati
            Series PBD = new Series();
            //aggiungo i dati
            PBD.Points.Add(20);
            PBD.Points.Add(25);
            PBD.Points.Add(17);
            //inserisco le label delle serie
            PBD.Points[0].AxisLabel = "Promossi";
            PBD.Points[1].AxisLabel = "Bocciati";
            PBD.Points[2].AxisLabel = "Debito";
            //aggiungo al grafico
            myChart.Series.Add(PBD);
            //tipo grafico
            switch (cmbTipoTIP.SelectedIndex)
            {
                case 0: //torta
                    myChart.Series[0].ChartType = SeriesChartType.Pie;
                    break;
                case 1: //piramide
                    myChart.Series[0].ChartType = SeriesChartType.Pyramid;
                    break;
                case 2: //imbuto
                    myChart.Series[0].ChartType = SeriesChartType.Funnel;
                    break;
            }
        }

        

        private void btnEsporta_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|" +
                "PNG (*.png)|*.png";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FilterIndex = 2;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                myChart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
            }


        }

        private void btnDoppio_Click(object sender, EventArgs e)
        {
            // Clear existing series and chart areas
            myChart.Series.Clear();
            myChart.ChartAreas.Clear();
            myChart.Legends.Clear();

            // === Chart Area 1: Bar Chart ===
            myChart.ChartAreas.Add("BarArea");
            myChart.ChartAreas["BarArea"].Position.X = 0;
            myChart.ChartAreas["BarArea"].Position.Width = 50;
            myChart.ChartAreas["BarArea"].Position.Height = 100;

            var barSeries = new System.Windows.Forms.DataVisualization.Charting.Series("BarSeries");
            barSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            barSeries.Points.AddXY("A", 10);
            barSeries.Points.AddXY("B", 20);
            barSeries.Points.AddXY("C", 15);
            barSeries.ChartArea = "BarArea";

            // === Chart Area 2: Pyramid Chart ===
            myChart.ChartAreas.Add("PyramidArea");
            myChart.ChartAreas["PyramidArea"].Position.X = 50;
            myChart.ChartAreas["PyramidArea"].Position.Width = 50;
            myChart.ChartAreas["PyramidArea"].Position.Height = 100;

            var pyramidSeries = new System.Windows.Forms.DataVisualization.Charting.Series("PyramidSeries");
            pyramidSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            pyramidSeries.Points.AddXY("A", 5);
            pyramidSeries.Points.AddXY("B", 12);
            pyramidSeries.Points.AddXY("C", 8);
            pyramidSeries.ChartArea = "PyramidArea";

            // Add both series
            myChart.Series.Add(barSeries);
            myChart.Series.Add(pyramidSeries);

            // Add legends
            myChart.Legends.Add("Legend");
            barSeries.Legend = "Legend";
            pyramidSeries.Legend = "Legend";
        }

    }
}