using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW
{

    public partial class Grafic : Form
    {
        private List<Imprumut> imprumuturi;
        public Grafic(List<Imprumut> imprumuturi)
        {
            InitializeComponent();
            this.imprumuturi = imprumuturi;
        }

        private void Grafic_Load(object sender, EventArgs e)
        {
            chart1.Legends.Clear();
            var serie = chart1.Series.Add("Imprumuturi pe cititor");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            var grupare = imprumuturi.GroupBy(i => i.Cititor.Id).Select(g => new
            {
                Id = g.Key,
                Nume = g.First().Cititor.Nume + " " + g.First().Cititor.Prenume,
                Nr = g.Count()
            });
            foreach (var item in grupare)
            {
                serie.Points.AddXY(item.Nume, item.Nr);
            }
        }
    }
}
