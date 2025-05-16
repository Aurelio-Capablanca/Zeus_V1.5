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
    public partial class Papeleta : Form
    {
        public Papeleta()
        {
            InitializeComponent();
        }



        private void ckbVamos_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbVamos.Checked)
            {
                ckbGana.Enabled = false;
                ckbFMLN.Enabled = false;
                ckbPCN.Enabled = false;
                ckbDemocracia_salvadoreña.Enabled = false;
                ckbPDC.Enabled = false;
                ckbArena.Enabled = false;
                ckbvotonulo.Enabled = false;

                picArena.Enabled = false;
                picDemo.Enabled = false;
                picGana.Enabled = false;
                picFmln.Enabled = false;
                picPcn.Enabled = false;
                picPdc.Enabled = false;
                picvotonulo.Enabled = false;
            }
            else
            {
                ckbGana.Enabled = true;
                ckbFMLN.Enabled = true;
                ckbPCN.Enabled = true;
                ckbDemocracia_salvadoreña.Enabled = true;
                ckbPDC.Enabled = true;
                ckbArena.Enabled = true;
                ckbvotonulo.Enabled = true;

                picArena.Enabled = true;
                picDemo.Enabled = true;
                picGana.Enabled = true;
                picFmln.Enabled = true;
                picPcn.Enabled = true;
                picPdc.Enabled = true;
                picvotonulo.Enabled = true;
            }
        }

        private void ckbGana_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbGana.Checked)
            {
                ckbVamos.Enabled = false;
                ckbFMLN.Enabled = false;
                ckbPCN.Enabled = false;
                ckbDemocracia_salvadoreña.Enabled = false;
                ckbPDC.Enabled = false;
                ckbArena.Enabled = false;
                ckbvotonulo.Enabled = false;

                picArena.Enabled = false;
                picDemo.Enabled = false;
                picVamos.Enabled = false;
                picFmln.Enabled = false;
                picPcn.Enabled = false;
                picPdc.Enabled = false;
                picvotonulo.Enabled = false;
            }
            else
            {
                ckbVamos.Enabled = true;
                ckbFMLN.Enabled = true;
                ckbPCN.Enabled = true;
                ckbDemocracia_salvadoreña.Enabled = true;
                ckbPDC.Enabled = true;
                ckbArena.Enabled = true;
                ckbvotonulo.Enabled = true;

                picArena.Enabled = true;
                picDemo.Enabled = true;
                picVamos.Enabled = true;
                picFmln.Enabled = true;
                picPcn.Enabled = true;
                picPdc.Enabled = true;
                picvotonulo.Enabled = true;
            }
        }

        private void ckbFMLN_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbFMLN.Checked)
            {
                ckbVamos.Enabled = false;
                ckbGana.Enabled = false;
                ckbPCN.Enabled = false;
                ckbDemocracia_salvadoreña.Enabled = false;
                ckbPDC.Enabled = false;
                ckbArena.Enabled = false;
                ckbvotonulo.Enabled = false;

                picArena.Enabled = false;
                picDemo.Enabled = false;
                picVamos.Enabled = false;
                picGana.Enabled = false;
                picPcn.Enabled = false;
                picPdc.Enabled = false;
                picvotonulo.Enabled = false;
            }
            else
            {
                ckbGana.Enabled = true;
                ckbVamos.Enabled = true;
                ckbPCN.Enabled = true;
                ckbDemocracia_salvadoreña.Enabled = true;
                ckbPDC.Enabled = true;
                ckbArena.Enabled = true;
                ckbvotonulo.Enabled = true;

                picArena.Enabled = true;
                picDemo.Enabled = true;
                picVamos.Enabled = true;
                picGana.Enabled = true;
                picPcn.Enabled = true;
                picPdc.Enabled = true;
                picvotonulo.Enabled = true;
            }
        }

        private void ckbPDC_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbPDC.Checked)
            {
                ckbVamos.Enabled = false;
                ckbGana.Enabled = false;
                ckbPCN.Enabled = false;
                ckbDemocracia_salvadoreña.Enabled = false;
                ckbFMLN.Enabled = false;
                ckbArena.Enabled = false;
                ckbvotonulo.Enabled = false;

                picArena.Enabled = false;
                picPcn.Enabled = false;
                picVamos.Enabled = false;
                picGana.Enabled = false;
                picFmln.Enabled = false;
                picDemo.Enabled = false;
                picvotonulo.Enabled = false;
            }
            else
            {
                ckbGana.Enabled = true;
                ckbVamos.Enabled = true;
                ckbPCN.Enabled = true;
                ckbDemocracia_salvadoreña.Enabled = true;
                ckbFMLN.Enabled = true;
                ckbArena.Enabled = true;
                ckbvotonulo.Enabled = true;

                picArena.Enabled = true;
                picPcn.Enabled = true;
                picVamos.Enabled = true;
                picGana.Enabled = true;
                picFmln.Enabled = true;
                picDemo.Enabled = true;
                picvotonulo.Enabled = true;
            }
        }

        private void ckbPCN_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbPCN.Checked)
            {
                ckbVamos.Enabled = false;
                ckbGana.Enabled = false;
                ckbFMLN.Enabled = false;
                ckbDemocracia_salvadoreña.Enabled = false;
                ckbPDC.Enabled = false;
                ckbArena.Enabled = false;
                ckbvotonulo.Enabled = false;

                picArena.Enabled = false;
                picDemo.Enabled = false;
                picVamos.Enabled = false;
                picGana.Enabled = false;
                picFmln.Enabled = false;
                picPdc.Enabled = false;
                picvotonulo.Enabled = false;
            }
            else
            {
                ckbGana.Enabled = true;
                ckbVamos.Enabled = true;
                ckbFMLN.Enabled = true;
                ckbDemocracia_salvadoreña.Enabled = true;
                ckbPDC.Enabled = true;
                ckbArena.Enabled = true;
                ckbvotonulo.Enabled = true;

                picArena.Enabled = true;
                picDemo.Enabled = true;
                picVamos.Enabled = true;
                picGana.Enabled = true;
                picFmln.Enabled = true;
                picPdc.Enabled = true;
                picvotonulo.Enabled = true;
            }
        }

        private void ckbDemocracia_salvadoreña_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDemocracia_salvadoreña.Checked)
            {
                ckbVamos.Enabled = false;
                ckbGana.Enabled = false;
                ckbPCN.Enabled = false;
                ckbFMLN.Enabled = false;
                ckbPDC.Enabled = false;
                ckbArena.Enabled = false;
                ckbvotonulo.Enabled = false;

                picArena.Enabled = false;
                picPcn.Enabled = false;
                picVamos.Enabled = false;
                picGana.Enabled = false;
                picFmln.Enabled = false;
                picPdc.Enabled = false;
                picvotonulo.Enabled = false;
            }
            else
            {
                ckbGana.Enabled = true;
                ckbVamos.Enabled = true;
                ckbPCN.Enabled = true;
                ckbFMLN.Enabled = true;
                ckbPDC.Enabled = true;
                ckbArena.Enabled = true;
                ckbvotonulo.Enabled = true;

                picArena.Enabled = true;
                picPcn.Enabled = true;
                picVamos.Enabled = true;
                picGana.Enabled = true;
                picFmln.Enabled = true;
                picPdc.Enabled = true;
                picvotonulo.Enabled = true;
            }
        }

        private void ckbArena_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbArena.Checked)
            {
                ckbVamos.Enabled = false;
                ckbGana.Enabled = false;
                ckbPCN.Enabled = false;
                ckbDemocracia_salvadoreña.Enabled = false;
                ckbPDC.Enabled = false;
                ckbFMLN.Enabled = false;
                ckbvotonulo.Enabled = false;

                picPdc.Enabled = false;
                picPcn.Enabled = false;
                picVamos.Enabled = false;
                picGana.Enabled = false;
                picFmln.Enabled = false;
                picDemo.Enabled = false;
                picvotonulo.Enabled = false;
            }
            else
            {
                ckbGana.Enabled = true;
                ckbVamos.Enabled = true;
                ckbPCN.Enabled = true;
                ckbDemocracia_salvadoreña.Enabled = true;
                ckbPDC.Enabled = true;
                ckbFMLN.Enabled = true;
                ckbvotonulo.Enabled = true;

                picPdc.Enabled = true;
                picPcn.Enabled = true;
                picVamos.Enabled = true;
                picGana.Enabled = true;
                picFmln.Enabled = true;
                picDemo.Enabled = true;
                picvotonulo.Enabled = true;
            }
        }

        private void ckbvotonulo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbvotonulo.Checked)
            {
                ckbVamos.Enabled = false;
                ckbGana.Enabled = false;
                ckbPCN.Enabled = false;
                ckbDemocracia_salvadoreña.Enabled = false;
                ckbPDC.Enabled = false;
                ckbFMLN.Enabled = false;
                ckbArena.Enabled = false;

                picPdc.Enabled = false;
                picPcn.Enabled = false;
                picVamos.Enabled = false;
                picGana.Enabled = false;
                picFmln.Enabled = false;
                picDemo.Enabled = false;
                picArena.Enabled = false;
            }
            else
            {
                ckbGana.Enabled = true;
                ckbVamos.Enabled = true;
                ckbPCN.Enabled = true;
                ckbDemocracia_salvadoreña.Enabled = true;
                ckbPDC.Enabled = true;
                ckbFMLN.Enabled = true;
                ckbArena.Enabled = false;

                picPdc.Enabled = true;
                picPcn.Enabled = true;
                picVamos.Enabled = true;
                picGana.Enabled = true;
                picFmln.Enabled = true;
                picDemo.Enabled = true;
                ckbArena.Enabled = false;
            }
        }


        Constructor_Papeleta agregar = new Constructor_Papeleta();
        Constructor actualizar = new Constructor();

        public void actualizarEstado()
        {
            int estado = 3;
            actualizar.documento = txtdui.Text;
            actualizar.Estadovotante = estado;
            Funciones_Papeletas.ActualizarVotante(actualizar);

        }

        private void Papeleta_Load(object sender, EventArgs e)
        {
            txtdui.Text = ConstructorVotanteLog.dui;

        }
        private string clave;
        public void Encriptar()
        {
            
            clave = txtdui.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(clave);
            byte[] hash = md5.ComputeHash(inputBytes);
            clave = BitConverter.ToString(hash).Replace("-", "");
            txtencriptar.Text = clave.ToString();
        }
        private void BtnVotar_Click(object sender, EventArgs e)
        {

            if (ckbFMLN.Checked)
            {
                
                Encriptar();
                actualizarEstado();
                int partido = 1;
                int estado = 1;      
                agregar.dui = txtencriptar.Text;
                agregar.estado_voto = estado;
                agregar.partido_voto = partido;
                int datos = Funciones_Papeletas.IngresarPapeleta(agregar);
            }
            if (ckbArena.Checked)
            {
                Encriptar();
                actualizarEstado();
                int partido = 2;
                int estado = 1;
                agregar.dui = txtencriptar.Text;
                agregar.estado_voto = estado;
                agregar.partido_voto = partido;
                int datos = Funciones_Papeletas.IngresarPapeleta(agregar);
            }
            if (ckbPDC.Checked)
            {
                Encriptar();
                actualizarEstado();
                agregar.dui = txtencriptar.Text;
                agregar.estado_voto = 1;
                agregar.partido_voto = 6;
                int datos = Funciones_Papeletas.IngresarPapeleta(agregar);
            }
            if (ckbGana.Checked)
            {
                Encriptar();
                actualizarEstado();
                agregar.dui = txtencriptar.Text;
                agregar.estado_voto = 1;
                agregar.partido_voto = 3;
                int datos = Funciones_Papeletas.IngresarPapeleta(agregar);
            }
            if (ckbPCN.Checked)
            {
                Encriptar();
                actualizarEstado();
                agregar.dui = txtencriptar.Text;
                agregar.estado_voto = 1;
                agregar.partido_voto = 5;
                int datos = Funciones_Papeletas.IngresarPapeleta(agregar);
            }
            if (ckbVamos.Checked)
            {
                Encriptar();
                actualizarEstado();
                agregar.dui = txtencriptar.Text;
                agregar.estado_voto = 1;
                agregar.partido_voto = 7;
                int datos = Funciones_Papeletas.IngresarPapeleta(agregar);
            }
            if (ckbDemocracia_salvadoreña.Checked)
            {
                Encriptar();
                actualizarEstado();
                agregar.dui = txtencriptar.Text;
                agregar.estado_voto = 1;
                agregar.partido_voto = 4;
                int datos = Funciones_Papeletas.IngresarPapeleta(agregar);
            }
            if (ckbvotonulo.Checked)
            {
                Encriptar();
                actualizarEstado();
                agregar.dui = txtencriptar.Text;
                agregar.estado_voto = 2;
                agregar.partido_voto = 8;
                int datos = Funciones_Papeletas.IngresarPapeleta(agregar);
            }
            FrmLogVotante log = new FrmLogVotante();
            log.Show();
            this.Close();
        }

        private void picVamos_Click(object sender, EventArgs e)
        {
            switch (ckbVamos.Checked)
            {
                case true:
                    ckbVamos.Checked = false;
                    break;
                default:
                    ckbVamos.Checked = true;
                    break;
            }

        }

        private void picGana_Click(object sender, EventArgs e)
        {
            switch (ckbGana.Checked)
            {
                case true:
                    ckbGana.Checked = false;
                    break;
                default:
                    ckbGana.Checked = true;
                    break;
            }

        }

        private void picFmln_Click(object sender, EventArgs e)
        {
            switch (ckbFMLN.Checked)
            {
                case true:
                    ckbFMLN.Checked = false;
                    break;
                default:
                    ckbFMLN.Checked = true;
                    break;
            }
        }

        private void picPdc_Click(object sender, EventArgs e)
        {
            switch (ckbPDC.Checked)
            {
                case true:
                    ckbPDC.Checked = false;
                    break;
                default:
                    ckbPDC.Checked = true;
                    break;
            }
        }

        private void picPcn_Click(object sender, EventArgs e)
        {
            switch (ckbPCN.Checked)
            {
                case true:
                    ckbPCN.Checked = false;
                    break;
                default:
                    ckbPCN.Checked = true;
                    break;
            }
        }

        private void picDemo_Click(object sender, EventArgs e)
        {
            switch (ckbDemocracia_salvadoreña.Checked)
            {
                case true:
                    ckbDemocracia_salvadoreña.Checked = false;
                    break;
                default:
                    ckbDemocracia_salvadoreña.Checked = true;
                    break;
            }
        }

        private void picArena_Click(object sender, EventArgs e)
        {
            switch (ckbArena.Checked)
            {
                case true:
                    ckbArena.Checked = false;
                    break;
                default:
                    ckbArena.Checked = true;
                    break;
            }
        }

        private void picvotonulo_Click(object sender, EventArgs e)
        {
            switch (ckbvotonulo.Checked)
            {
                case true:
                    ckbvotonulo.Checked = false;
                    break;
                default:
                    ckbvotonulo.Checked = true;
                    break;
            }
        }    




    }
}
