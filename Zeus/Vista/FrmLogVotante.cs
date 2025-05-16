using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeus.Controlador;
using Zeus.Modelo;
using System.Security.Cryptography;

namespace Zeus.Vista
{
    public partial class FrmLogVotante : Form
    {
        public FrmLogVotante()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBusquedaUsuario principal = new frmBusquedaUsuario();
            principal.Show();
            this.Hide();
        }

        void ValidarCampos()
        {
            if (txtdui.Text.Trim() == "")
            {
                MessageBox.Show("Existen Campos vacíos, debe rellenarlos", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ConstructorVotanteLog aa = new ConstructorVotanteLog(txtdui.Text);
                ConstructorVotanteLog.dui = txtdui.Text;
               
                bool datos = FuncionVotantes.IngresoaVoto(aa);
                if (datos == true)
                {
                   
                    Papeleta principal = new Papeleta();
                    principal.Show();
                    this.Hide();
                }

            }
        }
        
      
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
           
            ValidarCampos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
