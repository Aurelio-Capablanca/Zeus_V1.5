using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Zeus.Modelo;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeus.Reportes
{
    public partial class ReporteJRV : Form
    {
        public ReporteJRV()
        {
            InitializeComponent();
        }
        public void cargaresp()
        {
            // TODO: esta línea de código carga datos en la tabla 'DataJRV.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataJRV.DataTable);
            this.reportViewer1.RefreshReport();
        }


        private void ReporteJRV_Load(object sender, EventArgs e)
        {
            try
            {
                cmbJRV.DataSource = Funciones_admin.MostrarMesas();
                cmbJRV.DisplayMember = "Lugar";
                cmbJRV.ValueMember = "id_mesa_votacion";
                cargaresp();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataJRV.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.ShowMesa(this.DataJRV.DataTable,Convert.ToInt16(cmbJRV.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cargaresp();
        }
    }
}
