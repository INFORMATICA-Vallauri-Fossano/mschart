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

namespace mschart
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();

        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            cmbTipoBarre.Items.Clear();
            cmbTipoBarre.Items.Add("Barre Orizzontali");
            cmbTipoBarre.Items.Add("Barre Verticali");
            cmbTipoBarre.Items.Add("Punti");
            cmbTipoBarre.Items.Add("Linee");
            cmbTipoBarre.SelectedIndex = 0;
            cmbTipoTIP.Items.Clear();
            cmbTipoTIP.Items.Add("Torta");
            cmbTipoTIP.Items.Add("Inbuto");
            cmbTipoTIP.Items.Add("Piramide");
            cmbTipoTIP.SelectedIndex = 0;
            pulisciCollection();
        }

        private void pulisciCollection()
        {
            myChart.Series.Clear();
            myChart.Legends.Clear();
            myChart.ChartAreas.Clear();
            myChart.Titles.Clear();
        }

        private void btnGraficoBarre_Click(object sender, EventArgs e)
        {
            pulisciCollection();
            //aggiungo una zona dove piazzare il grafico
            myChart.ChartAreas.Add("AreaGraficoBarre");
            //aspetto 3d
            myChart.ChartAreas["AreaGraficoBarre"].Area3DStyle.Enable3D = true;
            //aggiungo legenda
            myChart.Legends.Add("Legenda");
            myChart.Legends["Legenda"].Title = "Risultati a.s. 2024/25";
            myChart.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            //aggiungi titolo
            myChart.Titles.Add("Promossi a.s. 2024/25");
            myChart.Titles[0].Font=new Font("Arial",16,FontStyle.Bold);
            //aggiungo le serie di dati
            //creazione
            Series p2024 = new Series("Promossi 2024");
            Series p2025 = new Series("Promossi 2025");
            //dati
            Random rnd=new Random();
            string[] scuole = {"Vallauri","Tesauro","Ancina","Del Pozzo","Avogadro" };
            for (int i = 0; i < 10; i++)
            {
                p2024.Points.Add(rnd.Next(20) + 1);
                p2024.Points[i].AxisLabel = scuole[i];
            }
            //aggiungo la serie al grafico
            myChart.Series.Add(p2024);
            myChart.Series.Add(p2025);
            //colore
            p2024.Color = Color.Red;
            myChart.Series[1].Color = Color.Blue;
            //mostro etichette
            p2024.IsValueShownAsLabel = true;
            p2025.IsValueShownAsLabel = true;


            //inserisco label delle serie
        }
    }
}
