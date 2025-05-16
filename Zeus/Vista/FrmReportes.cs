using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeus.Reportes;
using System.Windows.Forms;

namespace Zeus.Vista
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportePadron pa = new ReportePadron();
            pa.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReporteJRV regeresar = new ReporteJRV();
            regeresar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportesVotantes regeresar = new ReportesVotantes();
            regeresar.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReporteMesa regeresar = new ReporteMesa();
            regeresar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actas_JRV regeresar = new Actas_JRV();
            regeresar.Show();
            this.Hide();
        }
    }
}
