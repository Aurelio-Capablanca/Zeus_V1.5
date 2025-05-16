using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeus.Vista
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGraficos est = new frmGraficos();
            est.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmGarafico2 gra = new frmGarafico2();
            gra.Show();
            this.Hide();
        }
    }
}
