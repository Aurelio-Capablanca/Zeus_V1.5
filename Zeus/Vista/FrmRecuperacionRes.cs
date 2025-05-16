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
using System.Threading;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Zeus.Vista
{
    public partial class FrmRecuperacionRes : Form
    {
        public FrmRecuperacionRes()
        {
            InitializeComponent();
        }

        void ValidarCampos()
        {
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Existen Campos vacíos, debe rellenarlos", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ConstructorContraseña log = new ConstructorContraseña(txtUsuario.Text);
                ConstructorContraseña.usuario = txtUsuario.Text;
                bool datos = FuncionContraseña.revisionRecuperar(log);
                if (datos == true)
                {
                    
                    grpUser.Enabled = false;
                    grppregntas.Enabled = true;
                }


            }
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmRecuperadores principal = new FrmRecuperadores();
            principal.Show();
            this.Hide();
        }

        private string claves;

        public void EncriptarRes1()
        {
            claves = txtres1.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(claves);
            byte[] hash = md5.ComputeHash(inputBytes);
            claves = BitConverter.ToString(hash).Replace("-", "");
            txtencript1.Text = claves.ToString();
        }

        private string clave;

        public void EncriptarRes2()
        {
            clave = txtres2.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(clave);
            byte[] hash = md5.ComputeHash(inputBytes);
            clave = BitConverter.ToString(hash).Replace("-", "");
            txtencript2.Text = clave.ToString();
        }


        private string envio;

        public void EnviarContraseña()
        {
            txtclave.Text = "Zeus";
            envio = txtclave.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(envio);
            byte[] hash = md5.ComputeHash(inputBytes);
            envio = BitConverter.ToString(hash).Replace("-", "");
            txtEncriptados.Text = envio.ToString();
        }

        void ValidarPreguntaas()
        {
            if (txtres1.Text.Trim() == "" || txtres2.Text.Trim()=="")
            {
                MessageBox.Show("Existen Campos vacíos, debe rellenarlos", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ConstructorPregunta pass = new ConstructorPregunta(txtres1.Text,txtres2.Text);
                ConstructorPregunta.respuesta1 = txtencript1.Text;
                ConstructorPregunta.respuesta2 = txtencript2.Text;
                ConstructorContraseña.usuario = txtUsuario.Text;
                bool datos = FuncionContraseña.revisionRespuestas(pass);
                if (datos == true)
                {
                    EnviarContraseña();
                    Actualizarcontra();
                    FrmLogin abrir = new FrmLogin();
                    abrir.Show();
                    this.Hide();
                }


            }
        }

        constructo_admin actualizar = new constructo_admin();
        public void Actualizarcontra()
        {
            ConstructorContraseña log = new ConstructorContraseña(txtUsuario.Text);

            actualizar.clave = txtEncriptados.Text;
            actualizar.usuario = txtUsuario.Text;
            FuncionContraseña.Revisar(log, actualizar);


        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            EncriptarRes1();
            EncriptarRes2();
            ValidarPreguntaas();


        }

        private void grpnew_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRecuperacionRes_Load(object sender, EventArgs e)
        {


                grppregntas.Enabled = false;
        }

       
    }
}
