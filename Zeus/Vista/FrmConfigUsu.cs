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
    public partial class FrmConfigUsu : Form
    {
        public FrmConfigUsu()
        {
            InitializeComponent();
        }


        private void FrmConfigUsu_Load(object sender, EventArgs e)
        {
           
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (txtClave.Text != txtverificacion.Text)
            {
                lblCnc.Visible = true;
            }
            else
            {
                lblCnc.Visible = false;
            }
        }

        private void txtverificacion_TextChanged(object sender, EventArgs e)
        {
            if (txtverificacion.Text != txtClave.Text)
            {
                lblCnc.Visible = true;
            }
            else
            {
                lblCnc.Visible = false;
            }


        }

        private string clave;

        public void Encriptar()
        {

            clave = txtClave.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(clave);
            byte[] hash = md5.ComputeHash(inputBytes);
            clave = BitConverter.ToString(hash).Replace("-", "");
            txtEncriptcontra.Text = clave.ToString();
        }



        private string claves;

        public void Encriptar1preg()
        {

            claves = txtPregunta1.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(claves);
            byte[] hash = md5.ComputeHash(inputBytes);
            claves = BitConverter.ToString(hash).Replace("-", "");
            txtencript1.Text = claves.ToString();
        }


        private string clavess;

        public void Encriptar2preg()
        {

            clavess = txtPregunta2.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(clavess);
            byte[] hash = md5.ComputeHash(inputBytes);
            clavess = BitConverter.ToString(hash).Replace("-", "");
            txtEncript2.Text = clavess.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Encriptar();
            Encriptar1preg();
            Encriptar2preg();
            constructor_PrimerUsoUsuario us = new constructor_PrimerUsoUsuario();
            us.clave = txtEncriptcontra.Text;
            us.pregunta1 = Convert.ToInt32(cmbPregunta1.SelectedValue);
            us.pregunta2 = Convert.ToInt32(cmbPregunta2.SelectedValue);
            us.respuesta1 = txtencript1.Text;
            us.respuesta2 = txtEncript2.Text;
            if (Funciones_PrimerUsoUsuario.clavePrimerUso(us) == true)
            {
                MessageBox.Show("¡Gracias!,Pro completar el formulario ", "Gracias.......", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin regeresar = new FrmLogin();
                regeresar.Show();
                this.Hide();
            }
        }

        private void FrmConfigUsu_Load_1(object sender, EventArgs e)
        {
            if (Funciones_PrimerUsoUsuario.Obtener_preguntas() != null)
            {
                cmbPregunta1.DataSource = Funciones_PrimerUsoUsuario.Obtener_preguntas();
                cmbPregunta1.DisplayMember = "pregunta";
                cmbPregunta1.ValueMember = "id_pregunta";
            }
            if (Funciones_PrimerUsoUsuario.Obtener_preguntas() != null)
            {
                cmbPregunta2.DataSource = Funciones_PrimerUsoUsuario.Obtener_preguntas();
                cmbPregunta2.DisplayMember = "pregunta";
                cmbPregunta2.ValueMember = "id_pregunta";
            }
        }
    }
}
