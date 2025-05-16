using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeus.Modelo;
using System.Windows.Forms;

namespace Zeus.Reportes
{
    public partial class ReportesVotantes : Form
    {
        public ReportesVotantes()
        {
            InitializeComponent();
        }
        private void cargarReporte()
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataSet1.DataTable);

            this.reportViewer1.RefreshReport();

        }

        private void ReportesVotantes_Load(object sender, EventArgs e)
        {
            
            try
            {
                cmbVotantes.DataSource = Funciones_admin.MostrarVotantes();
                cmbVotantes.DisplayMember = "nombre_estado_votante";
                cmbVotantes.ValueMember = "id_estado_votante";
                cargarReporte();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnfiltro_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Filtro(this.DataSet1.DataTable,Convert.ToInt16(cmbVotantes.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void btnmostaratodos_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
