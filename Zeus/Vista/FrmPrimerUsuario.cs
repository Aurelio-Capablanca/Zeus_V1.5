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
using System.IO;
using System.Security.Cryptography;
using System.Drawing.Imaging;

namespace Zeus.Vista
{
    public partial class FrmPrimerUsuario : Form
    {
        public FrmPrimerUsuario()
        {
            InitializeComponent();
        }
        Constructor_PrimerUsuario añadir = new Constructor_PrimerUsuario();
        public void AgregarUsuario()
        {

            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || pbFoto == null)
            {
                MessageBox.Show("Por favor complete todos los campos para poder proceder", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int tipo = 1;
                añadir.nombre = txtNombre.Text;
                añadir.apellidos = txtApellido.Text;
                añadir.clave = txtEncrip.Text;
                añadir.dui = Convert.ToString(mskDui.Text);
                añadir.municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                añadir.tipo_usuario = tipo;
                añadir.estado = Convert.ToInt16(cmbEstado.SelectedValue);
                añadir.telefono = mskTelefono.Text;
                añadir.correo = txtCorreo.Text;
                añadir.genero = Convert.ToInt32(cmbGenero.SelectedValue);
                añadir.usuario = txtUsuario.Text;
                MemoryStream ms = new MemoryStream();
                pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string encoded = Convert.ToBase64String(aByte);
                añadir.Foto = encoded;
            }
                if (Control_Empresa.IngresarUsuario(añadir) >= 1)
            {
                MessageBox.Show("Muy Bien!! Has ingresado Tu primer usuario,Ahora puedes ingresar en el sistema", "Proceso Completado 2/2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin primerusuario = new FrmLogin();
                primerusuario.Show();
                this.Hide();
            }
        }

        private string clave;

        public void encriptado()
        {

            txtclave.Text = "Zeus";
           
            clave = txtclave.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(clave);
            byte[] hash = md5.ComputeHash(inputBytes);
            clave = BitConverter.ToString(hash).Replace("-", "");
            txtEncrip.Text = clave.ToString();
        
         }


        private void btnContinuar_Click(object sender, EventArgs e)
        {
            encriptado();
            AgregarUsuario();
        }

        private void FrmPrimerUsuario_Load(object sender, EventArgs e)
        {
            if (Control_Empresa.ObtenerMunicipio() != null)
            {
                cmbMunicipio.DataSource = Control_Empresa.ObtenerMunicipio();
                cmbMunicipio.DisplayMember = "Nombre_mun";
                cmbMunicipio.ValueMember = "id_municipio";
            }
            //if (Control_Empresa.ObtenerTipoUsuario() != null)
            //{

            //    cmbTipoUsuario.DataSource = Control_Empresa.ObtenerTipoUsuario();
            //    cmbTipoUsuario.DisplayMember = "nombre_tipo_usuario";
            //    cmbTipoUsuario.Text = "Root";
            //    cmbTipoUsuario.ValueMember = "id_tipo_usuario";
            //}

            txtroot.Text = "Root";
            

            if (Control_Empresa.ObtenerEstados() != null)
            {
                cmbEstado.DataSource = Control_Empresa.ObtenerEstados();
                cmbEstado.DisplayMember = "nombre_est_usu";
                cmbEstado.ValueMember = "id_est_usu";
            }
            if (Control_Empresa.ObtenerGenero() != null)
            {
                cmbGenero.DataSource = Control_Empresa.ObtenerGenero();
                cmbGenero.DisplayMember = "genero";
                cmbGenero.ValueMember = "id_genero";
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                openCargarImagen.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivos de Imagen (.png) |*.png | Archivo de Imagen (.jpeg) |*.jpeg | Todos los archivos |*.*";
                DialogResult resultado = openCargarImagen.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(openCargarImagen.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Opps! Ha ocurrido un error al crgar la imagen", "Error Wey", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsSeparator(e.KeyChar) && char.IsDigit(e.KeyChar);
        }
    }
}
