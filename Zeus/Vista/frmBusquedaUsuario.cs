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
using Zeus.Controlador;

namespace Zeus.Vista
{
    public partial class frmBusquedaUsuario : Form
    {
        public frmBusquedaUsuario()
        {
            InitializeComponent();
        }

        public void Mostrarvotantes()
        {
            dataGridView1.DataSource = Funciones_votante.MostrarVotantes();
        }

        private void frmBusquedaUsuario_Load(object sender, EventArgs e)
        {
            Mostrarvotantes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fucionesBusquedas.buscar(Convert.ToInt32(cmbTipoBusqueda.SelectedIndex), txtBusqueda.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lugar;
            lugar = dataGridView1.CurrentRow.Index;

            lblNombre.Text = this.dataGridView1[1, lugar].Value.ToString();
            lblApellido.Text = this.dataGridView1[2, lugar].Value.ToString();
            lblDiscapacidad.Text = this.dataGridView1[4, lugar].Value.ToString();
            lblMunicipio.Text = this.dataGridView1[5, lugar].Value.ToString();
            lblEstado.Text = this.dataGridView1[6, lugar].Value.ToString();
            lblGenero.Text = this.dataGridView1[7, lugar].Value.ToString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmLogVotante principal = new FrmLogVotante();
            principal.Show();
            this.Hide();
        }



        Constructor actualizar = new Constructor(); 

        public void ActualizarEstados()
        {
            int estado = 1;
            actualizar.Estadovotante = estado;
            actualizar.nombrevotante = lblNombre.Text;
            fucionesBusquedas.ActualizarVotante(actualizar);
        }


        private void btnActivarUsuario_Click(object sender, EventArgs e)
        {
            ActualizarEstados();
            Mostrarvotantes();
        }
    }
}
