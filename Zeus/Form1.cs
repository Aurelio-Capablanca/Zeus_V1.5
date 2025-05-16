using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeus.Vista;
using Zeus.Controlador;


namespace Zeus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int lx, ly;
        int sw, sh;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {

           
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnExpandir.Visible = false;
            btnMinimizar.Visible = true;
            btnNormal.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            btnExpandir.Visible = true;
            btnMinimizar.Visible = true;
            btnNormal.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        Form currentForm;
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                if (currentForm != null)
                {
                    currentForm.Close();
                    panelContenedor.Controls.Remove(currentForm);
                }
                currentForm = formulario;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Administrador>();
        }

        private void btnPadron_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Partido>();
        }

        private void btnVotacion_Click(object sender, EventArgs e)
        {
            FrmLogVotante votar = new FrmLogVotante();
            votar.Show();
            this.Hide();
        }

        private void btnPadron_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPadron_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPadron>();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmLogin regeresar = new FrmLogin();
            regeresar.Show();
            this.Hide();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEstadisticas>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGraficos gra = new frmGraficos();
            gra.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmGarafico2 gra = new frmGarafico2();
            gra.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmLogin regeresar = new FrmLogin();
            regeresar.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FrmReportes>();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        void ocultar()
        {
            btnUsuario.Visible = false;
            btnPartidos.Visible = false;
            btnEstadisticas.Visible = false;
           
            btnPadron.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripLabel3.Text = ConstructorLogin.nombres;
            if (ConstructorLogin.nivel == 1)
            {
                LblUsuarioConectado.Text = ("Root");
            }
            else if(ConstructorLogin.nivel == 2)
            {
                LblUsuarioConectado.Text = ("Administrador");
            }

            if (ConstructorLogin.prueba == "98DD15C330FB5ABB4508347265A7F76C")
            {
                FrmConfigUsu uso = new FrmConfigUsu();
                uso.Show();
                this.Close();
            }

            if (ConstructorLogin.nivel == 2)
            {
                btnPartidos.Visible = true;
                btnUsuario.Visible = true;
               
                btnPadron.Visible = true;
                btnEstadisticas.Visible = true;

            }
            else if (ConstructorLogin.nivel == 1)
            {
                btnPartidos.Visible = true;
                btnUsuario.Visible = true;
      
                btnPadron.Visible = true;
                btnEstadisticas.Visible = true;

            }
            else if (ConstructorLogin.nivel == 3)
            {

            }

        }
    }
}




 