using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeus.Reportes
{
    public partial class Actas_JRV : Form
    {
        public Actas_JRV()
        {
            InitializeComponent();
        }

        private void Actas_JRV_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataJRV.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataJRV.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
