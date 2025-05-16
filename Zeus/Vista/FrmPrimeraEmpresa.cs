using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Zeus.Controlador;
using Zeus.Modelo;
using System.Windows.Forms;

namespace Zeus.Vista
{
    public partial class FrmPrimeraEmpresa : Form
    {
        public FrmPrimeraEmpresa()
        {
            InitializeComponent();
        }

        private void FrmPrimeraEmpresa_Load(object sender, EventArgs e)
        {
            if (Control_Empresa.ObtenerEstadoEmpresa() != null)
            {
                cmbEstadoE.DataSource = Control_Empresa.ObtenerEstadoEmpresa();
                cmbEstadoE.DisplayMember = "estado_empresa";
                cmbEstadoE.ValueMember = "id_estado_empresa";
            }
            if (Control_Empresa.ObtenerTipoEmpresa() != null)
            {
                cmbTipoE.DataSource = Control_Empresa.ObtenerTipoEmpresa();
                cmbTipoE.DisplayMember = "nombre_tipo_empresa";
                cmbTipoE.ValueMember = "id_tipo_empresa";
            }
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                openCargarImagen.Filter = "Archivo de Imagen (.jpg) |*.jpg | Archivos de Imagen (.png) |*.png | Archivo de Imagen (.jpeg) |*.jpeg | Todos los archivos |*.*";
                DialogResult resultado = openCargarImagen.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    pbLogo.Image = Image.FromFile(openCargarImagen.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Opps! Ha ocurrido un error al crgar la imagen", "Error Wey", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
    }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtEmpresa.Text.Trim() == "" || TxtNit.Text.Trim() == "" || TxtRepresentante.Text.Trim() == "" || pbLogo.Image == null)
            {
                MessageBox.Show("No todos los campos entan completos", "Porfavor rellene todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Constructor_Empresa empresa = new Constructor_Empresa();
                empresa.empresa = TxtEmpresa.Text;
                empresa.nit = TxtNit.Text;
                empresa.direccion = TxtDireccion.Text;
                empresa.representante = TxtRepresentante.Text;
                empresa.tipo_empresa = Convert.ToInt16(cmbTipoE.SelectedValue);
                empresa.estado_empresa = Convert.ToInt16(cmbEstadoE.SelectedValue);
                MemoryStream ms = new MemoryStream();
                pbLogo.Image.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();
                string encoded = Convert.ToBase64String(aByte);
                empresa.imagen = encoded;

                if (Control_Empresa.RegistarEmpresa(empresa) >= 1)
                {
                    MessageBox.Show("Muy Bien!! Has ingresado tu empresa. Ahora ingresa el primer usuario", "Proceso Completado 1/2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmPrimerUsuario primerusuario = new FrmPrimerUsuario();
                    primerusuario.Show();
                    this.Hide();
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void TxtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void TxtRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
    }
}
