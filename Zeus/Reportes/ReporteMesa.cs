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
    public partial class ReporteMesa : Form
    {
        public ReporteMesa()
        {
            InitializeComponent();
        }
        public void CargarInfo()
        {
            // TODO: esta línea de código carga datos en la tabla 'DataMesa.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DataMesa.DataTable);
            this.reportViewer1.RefreshReport();
        }
        private void ReporteMesa_Load(object sender, EventArgs e)
        {
            try
            {
                cmbMesa.DataSource = Funciones_admin.MostrarUbicacionn();
                cmbMesa.DisplayMember = "ubicacion";
                cmbMesa.ValueMember = "id_ubicacion";
                CargarInfo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarInfo();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataMesa.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.MostrarUbicacion(this.DataMesa.DataTable,Convert.ToInt16(cmbMesa.SelectedValue));
            this.reportViewer1.RefreshReport();
        }
    }
}
