using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Zeus.Modelo;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeus.Reportes
{
    public partial class ReportePadron : Form
    {
        public ReportePadron()
        {
            InitializeComponent();
        }
       public void cargarDatos()
        {
            // TODO: esta línea de código carga datos en la tabla 'DataPadrones.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataPadrones.DataTable);

            this.reportViewer1.RefreshReport();
        }

        private void ReportePadron_Load(object sender, EventArgs e)
        {
            try
            {
                cmbpadron.DataSource = Funciones_admin.MostrarMesas();
                cmbpadron.DisplayMember = "Lugar";
                cmbpadron.ValueMember = "id_mesa_votacion";
                cargarDatos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataPadrones.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.MostrarMesa(this.DataPadrones.DataTable,Convert.ToInt16(cmbpadron.SelectedValue));

            this.reportViewer1.RefreshReport();
        }
    }
}
