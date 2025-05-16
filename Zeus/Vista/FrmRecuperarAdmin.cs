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
    public partial class FrmRecuperarAdmin : Form
    {
        public FrmRecuperarAdmin()
        {
            InitializeComponent();
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
                    grpcredenial.Enabled = true;
                    grpUser.Enabled = false;
                }


            }
        }
        private void limpiarusuario()
        {
            txtUsuario.Clear();
        }
      

            public void pruebas()
        {
            
        } 



        void ValidarRoot()
        {
            if (txtroot.Text.Trim() == "" || txtclave.Text.Trim() == "")
            {
                MessageBox.Show("Existen Campos vacíos, debe rellenarlos", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                ConstructorLogin log = new ConstructorLogin(txtroot.Text, txtEncrip.Text);
                ConstructorLogin.usuario = txtroot.Text;
                log.clave = txtEncrip.Text;
                bool datos = FuncionContraseña.RevisionRoot(log);
                if (datos == true)
                {
                    grpcredenial.Enabled = false;
                    limpiarroot();
                    grpnew.Enabled = true;
                }


            }
        }

        private void limpiarroot()
        {
            txtroot.Clear();
            txtclave.Clear();
        }

        private string claves;
      
        public void EncriptarRoot()
        {
            claves = txtclave.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(claves);
            byte[] hash = md5.ComputeHash(inputBytes);
            claves = BitConverter.ToString(hash).Replace("-", "");
            txtEncrip.Text = claves.ToString();
        }


        void ValidarRetorno()
        {
            if ( txtcontraenvio.Text.Trim() == "" || txtingresa.Text.Trim() == "")
            {
                MessageBox.Show("Existen Campos vacíos, debe rellenarlos", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                    FrmLogin principal = new FrmLogin();
                    principal.Show();
                    this.Hide();
                }


            }
        //ConstructorContraseña log = new ConstructorContraseña(txtUsuario.Text);
        //ConstructorContraseña.usuario = txtUsuario.Text;
        //        bool datos = FuncionContraseña.revisionRecuperar(log);
        //        if (datos == true)
        //        {



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRecuperarAdmin_Load(object sender, EventArgs e)
        {
            grpcredenial.Enabled = false;
            grpnew.Enabled = false;


           
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
           
            ValidarCampos();
        }

        private void btncredencial_Click(object sender, EventArgs e)
        {
            EncriptarRoot();
            ValidarRoot();  

         }



        private void label2_Click(object sender, EventArgs e)
        {

        }


        private string clave;

        public void EncriptarRecuperacion()
        {
            clave = txtcontraenvio.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(clave);
            byte[] hash = md5.ComputeHash(inputBytes);
            clave = BitConverter.ToString(hash).Replace("-", "");
            txtEncriptados.Text = clave.ToString();
        }

        constructo_admin actualizarContra = new constructo_admin();  

        public void Actualizarcontra()
        {
            ConstructorContraseña log = new ConstructorContraseña(txtUsuario.Text);
          
                actualizarContra.clave = txtEncriptados.Text;
                actualizarContra.usuario = txtUsuario.Text;
                FuncionContraseña.Revisar(log,actualizarContra);
        
            
        }




        private void btnnew_Click(object sender, EventArgs e)
        {
            if (txtingresa.Text.Trim() == txtcontraenvio.Text.Trim())
            {
                EncriptarRecuperacion();
                Actualizarcontra();
                ValidarRetorno();
            }
            else
            {
                MessageBox.Show("La Contraseña no concuerda con el campo antes esctrito, favor colocar correctamente", "Reingresar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           

        }
    }
}
