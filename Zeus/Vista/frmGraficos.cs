using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeus.Modelo;
using System.Windows.Forms.DataVisualization.Charting;

namespace Zeus.Vista
{
    public partial class frmGraficos : Form
    {
        public frmGraficos()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmGraficos_Load(object sender, EventArgs e)
        {
            int[] datos = { frmGraficas.contaVotos(1), frmGraficas.contaVotos(2), frmGraficas.contaVotos(3), frmGraficas.contaVotos(4), frmGraficas.contaVotos(5), frmGraficas.contaVotos(6), frmGraficas.contaVotos(7), frmGraficas.contaVotos(8) };
            string[] nombre = { "FMLN", "ARENA", "GANA", "Democracia Salvadoreña", "PCN", "PDC", "Vamos", "Nulo" };
            for (int i = 0; i < nombre.Length; i++)
            {
                Series hola = grGrafico.Series.Add(nombre[i]);
                hola.Label = datos[i].ToString();
                hola.Points.Add(datos[i]);
            }
        }

        private void grGrafico_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
