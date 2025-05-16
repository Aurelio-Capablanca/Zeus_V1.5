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
using System.Security.Cryptography;

namespace Zeus.Vista
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
            ////txtUsuario.ContextMenu = new ContextMenu();
            ////txtClave.ContextMenu = new ContextMenu();


            //Thread a = new Thread(new ThreadStart(StartForm));
            //a.Start();
            //Thread.Sleep(3000);
            //InitializeComponent();
            //a.Abort();
        }



        public void StartForm()
        {
            //Application.Run(new FrmSplashScreen());

        }




        void ValidarCampos()
        {
            if (txtUsuario.Text.Trim() == "" || txtClave.Text.Trim() == "")
            {
                MessageBox.Show("Existen Campos vacíos, debe rellenarlos", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ConstructorLogin log = new ConstructorLogin(txtUsuario.Text, txtEncrip.Text);
                ConstructorLogin.usuario = txtUsuario.Text;
                log.clave = txtEncrip.Text;
                ConstructorLogin.prueba = txtEncrip.Text;
                bool datos = ValidarLogin.Ingreso(log);
                if (datos == true)
                {
                    Form1 principal = new Form1();
                    principal.Show();
                    this.Hide();
                }  


            }
        }


        private string clave;
        constructor_clave actualizar = new constructor_clave();
       
      

        public void Encriptar()
        {
            clave = txtClave.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(clave);
            byte[] hash = md5.ComputeHash(inputBytes);
            clave = BitConverter.ToString(hash).Replace("-", "");
            txtEncrip.Text = clave.ToString();
        }


    

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
           Encriptar();
           ValidarCampos();
         }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (Verificacion_PrimerUso.VerificarEmpresa() == true)
            {
                if (Verificacion_PrimerUso.VerificarUsuario() == true)
                {
                    btnPrimerUso.Visible = false;
                    lblMensaje.Visible = false;          
                }
                else
                {

                    lblUsuario.Visible = false;
                    lineacontra.Visible = false;
                    lineausuario.Visible = false;
                    lblClave.Visible = false;
                    txtUsuario.Visible = false;
                    txtClave.Visible = false;
                    BtnIniciar.Visible = false;
                    pictureBox1.Visible = false;
                    LinkRecuperarClave.Visible = false;
                    btnPrimerUso.LabelText = "Primer Usuario";
                }

            }
            else
            {
                lineausuario.Visible = false;
                lineacontra.Visible = false;
                pictureBox1.Visible = false;
                lblUsuario.Visible = false;
                lblClave.Visible = false;
                txtUsuario.Visible = false;
                txtClave.Visible = false;
                BtnIniciar.Visible = false;
                LinkRecuperarClave.Visible = false;
            }

        }

      



        private void btnEnncript_Click(object sender, EventArgs e)
        {
          
        }

        private void txtEncrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

      
        private void btnPrimerUso_Click_1(object sender, EventArgs e)
        {
            if (btnPrimerUso.LabelText == "Primer Usuario")
            {
                FrmPrimerUsuario pu = new FrmPrimerUsuario();
                pu.Show();
                this.Hide();
            }
            else
            {
                FrmPrimeraEmpresa pus = new FrmPrimeraEmpresa();
                pus.Show();
                this.Hide();
            }
        }

        private void LinkRecuperarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperadores pu = new FrmRecuperadores();
            pu.Show();
            this.Hide();
        }
    }
}
