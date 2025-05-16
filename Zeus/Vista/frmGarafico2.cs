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
    public partial class frmGarafico2 : Form
    {
        public frmGarafico2()
        {
            InitializeComponent();
        }

        private void frmGarafico2_Load(object sender, EventArgs e)
        {
            int[] datos = { frmGraficas.estadoVo(1), frmGraficas.estadoVo(2), frmGraficas.estadoVo(3)};
            string[] nombre = { "En Proceso", "No han votado", "Voto emitido" };
            for (int i = 0; i < nombre.Length; i++)
            {
                Series hola = grGrafico.Series.Add(nombre[i]);
                hola.Label = nombre[i].ToString();
                hola.Points.Add(datos[i]);
            }
        }

        private void grGrafico_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 regeresar = new Form1();
            regeresar.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
