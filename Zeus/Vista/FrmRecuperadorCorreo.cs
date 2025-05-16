using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeus.Modelo;
using Zeus.Controlador;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Zeus.Vista
{
    public partial class FrmRecuperadorCorreo : Form
    {
        public FrmRecuperadorCorreo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtUs.Text.Trim() != "")
            {
                constructorCorreoRe.usario = txtUs.Text;
                string correo = funcionesReCo.obtenercorreo();
                if (correo != "")
                {
                    Random random = new Random();
                    int a = random.Next(0, 10);
                    int b = random.Next(0, 10);
                    int c = random.Next(0, 10);
                    int d = random.Next(0, 10);
                    int f = random.Next(0, 10);

                    string rmd = a.ToString() + b.ToString() + c.ToString() + d.ToString() + f.ToString();
                    if (rmd != "")
                    {
                        constructorCorreoRe.codigoRe = rmd;
                        if (funcionesReCo.enviaRamdom() == true)
                        {
                            MessageBox.Show(correo);
                            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                            msg.To.Add(correo);
                            msg.Subject = "Recuperación de Contraseña";
                            msg.SubjectEncoding = System.Text.Encoding.UTF8;
                            msg.Body = "El codigo de recuperación de contraseñan es: " + rmd + " por favor, ingrese este codigo para verificar que pertenese a usted este usuario";
                            msg.BodyEncoding = System.Text.Encoding.UTF8;
                            msg.IsBodyHtml = true;
                            msg.From = new System.Net.Mail.MailAddress("zeussystem7@gmail.com");

                            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                            cliente.Credentials = new System.Net.NetworkCredential("zeussystem7@gmail.com", "sistemazeus10");
                            cliente.Port = 587;
                            cliente.EnableSsl = true;
                            cliente.Host = "smtp.gmail.com";
                            try
                            {
                                cliente.Send(msg);
                                gbCorreo.Enabled = false;
                                gbVerificacion.Enabled = true;
                                gbUsuario.Enabled = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al Enviar el Mensage" + ex.Message, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }   
            }
            else
            {

            }
        }

        private void btnVerCodigo_Click(object sender, EventArgs e)
        {

            if (txtCodigoUs.Text.Trim() != "")
            {
                constructorCorreoRe.codigoRe = txtCodigoUs.Text;
                if (funcionesReCo.verifiacrCodigo() >= 1)
                {
                    MessageBox.Show("El codigo es correcto, a continuación introduce la nueva contaseña.", "Proceso completado 2/3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbUsuario.Enabled = false;
                    gbCorreo.Enabled = true;
                    gbVerificacion.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El codigo que ha ingresado no es el correcto, por favor introducir datos correctos.", "Codigo Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigoUs.Clear();
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios, por favor verifique que los todos los campos esten completos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoUs.Clear();
            }

        }
        private string clave;

        public void Encriptar()
        {
            
            clave = txtConClave.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(clave);
            byte[] hash = md5.ComputeHash(inputBytes);
            clave = BitConverter.ToString(hash).Replace("-", "");
            txtencriptado.Text = clave.ToString();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Encriptar();
            string act =txtencriptado.Text ;
            bool datos = funcionesReCo.NuevaClave(act);
            if (datos == true)
            {
                MessageBox.Show("Contraseña actualizada correctamente", "Proceso Finalizado 3/3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin log = new FrmLogin();
                log.Show();
                this.Close();
            }
            else if (txtConClave.Text.Trim() == "" || txtNuClave.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos vacios, por favor verifique que los todos los campos esten completos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La contraseña no pudo ser modificada, intente de nuevo", "Proceso fallido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNuClave.Clear();
                txtConClave.Clear();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmRecuperadores principal = new FrmRecuperadores();
            principal.Show();
            this.Hide();
        }
    }
}
