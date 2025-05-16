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
using Zeus.Reportes;

namespace Zeus.Vista
{
    public partial class FrmPadron : Form
    {
        public FrmPadron()
        {
            InitializeComponent();
        }
        Constructor agregar = new Constructor();
        Constructor actualizar = new Constructor();
        #region
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //ReportePadron regeresar = new ReportePadron();
            //regeresar.Show();
            //this.Hide();
        }



        #endregion
        ConstructorPadron añadir = new ConstructorPadron();
        private void FrmPadron_Load(object sender, EventArgs e)
        {
            MostrarUbicacion();
            this.dgvUbicaciones.Columns[0].Visible = false;
            if (Funciones_Padron.ObtenerVotante() != null)
            {
                cmbVotante.DataSource = Funciones_Padron.ObtenerVotante();
                cmbVotante.DisplayMember = "nombre_votante";
                cmbVotante.ValueMember = "id_votante";

            }
            if (Funciones_Padron.ObtenerMesa() != null)
            {
                cmbMesa.DataSource = Funciones_Padron.ObtenerMesa();
                cmbMesa.DisplayMember = "Lugar";
                cmbMesa.ValueMember = "id_mesa_votacion";

            }
            mostrarpadron();
            dgvpadron.Columns[0].Visible = false;


            if (ConstructorLogin.nivel == 2)
            {
                //tbcVotante.Visible = true;
                //btnactualizar.Enabled = false;
                //btnAgregar.Enabled = false;
                //btndel.Enabled = false;
                //btnMostrar.Enabled = false;


                //tbcAdministador.Visible = true;
                //button7.Enabled = false;
                //button8.Enabled = false;
                //button9.Enabled = false;
                //button2.Enabled = false; 


                tabPage3.Visible = true;
                btnAgrgar.Enabled = true;
                button11.Enabled = true;
                button10.Enabled = true;
                btnEliminar.Enabled = true;



            }
            else if (ConstructorLogin.nivel == 1)
            {

                //tbcVotante.Visible = true;
                //btnactualizar.Enabled = true;
                //btnAgregar.Enabled = true;
                //btndel.Enabled = true;
                //btnMostrar.Enabled = true;


                //tbcAdministador.Visible = true;
                //button7.Enabled = true;
                //button8.Enabled = true;
                //button9.Enabled = true;
                //button2.Enabled = true;



                tabPage3.Enabled = true;
                btnAgrgar.Enabled = true;
                button11.Enabled = true;
                button10.Enabled = true;
                btnEliminar.Enabled = true;


            }

            Mostrarvotantes();
            this.dgvVotantes.Columns[0].Visible = false;
            if (Funciones_votante.obtenermunicipio() != null )
            {
                cmbMunicipio.DataSource = Funciones_votante.obtenermunicipio();
                cmbMunicipio.DisplayMember = "Nombre_mun";
                cmbMunicipio.ValueMember = "id_municipio";
            }

            if ( Funciones_votante.Genero() != null)
            {
                cmbGenero.DataSource = Funciones_votante.Genero();
                cmbGenero.DisplayMember = "genero";
                cmbGenero.ValueMember = "id_genero";
            }


            if (Funciones_votante.discapacidad() != null)
            {
                cmbDiss.DataSource = Funciones_votante.discapacidad();
                cmbDiss.DisplayMember = "nombre";
                cmbDiss.ValueMember = "id_discapacidad";
            }


            MostrarMesa();
            dgvMesa.DataSource = funciones_mesas.MostrarMesa();
            this.dgvMesa.Columns[0].Visible = false;


            if (funciones_mesas.ObtenerCentroVota() != null)
            {
                cmbCentro.DataSource = funciones_mesas.ObtenerCentroVota();
                cmbCentro.DisplayMember = "numero_infraestructura";
                cmbCentro.ValueMember = "id_centro_votacion";
            }

            if (funciones_mesas.Obtenerubicacion() != null)
            {
                cmbUbicación.DataSource = funciones_mesas.Obtenerubicacion();
                cmbUbicación.DisplayMember = "ubicacion";
                cmbUbicación.ValueMember = "id_ubicacion";
            }


            Mostrarcentro();
            this.dgvCentro.Columns[0].Visible = false;
            if (CentroVotacion.ObtenerMunicipio() != null )
            {
                cmbMunicipioC.DataSource = CentroVotacion.ObtenerMunicipio();
                cmbMunicipioC.DisplayMember = "Nombre_mun";
                cmbMunicipioC.ValueMember = "id_municipio";
               

            }


            if (CentroVotacion.Obtenerubicacion() != null)
            {
                cmbUbicacionC.DataSource = CentroVotacion.Obtenerubicacion();
                cmbUbicacionC.DisplayMember = "ubicacion";
                cmbUbicacionC.ValueMember = "id_ubicacion";
            }


        }

        //Ubicaciones
        #region
        public void AgregarUbicacion()
        {
            if (txtUbicacion.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agregar.ubicacion = txtUbicacion.Text;
                int datos = Funciones_Padron.AgregarUbicacion(agregar);
            }
        }
        private void btnAgrgar_Click(object sender, EventArgs e)
        {
            AgregarUbicacion();
            MostrarUbicacion();
            vacio();
        }
        public void MostrarUbicacion()
        {
            dgvUbicaciones.DataSource = Funciones_Padron.MostrarUbicacion();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            MostrarUbicacion();
            vacio();
        }

        private void vacio()
        {
            txtUbicacion.Clear();
            TxtCodigo.Clear();
        }


        private void ActualizarUbicacion()
        {
            actualizar.idUbicacion = Convert.ToInt32(txtIdUbicacion.Text);
            actualizar.ubicacion = txtUbicacion.Text;
            Funciones_Padron.ActualizarUbicacion(actualizar);
        }

        private void dgvUbicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocision;
            pocision = this.dgvUbicaciones.CurrentRow.Index;
            txtIdUbicacion.Text = this.dgvUbicaciones[0, pocision].Value.ToString();
            txtUbicacion.Text = this.dgvUbicaciones[1, pocision].Value.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ActualizarUbicacion();
            MostrarUbicacion();
            vacio();
        }
        public void EliminarUbicacion()
        {
            if (MessageBox.Show("¿Estas seguro que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Padron.EliminarUbicacion(Convert.ToInt32(txtIdUbicacion.Text));
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUbicacion();
            MostrarUbicacion();
            vacio();
        }
        #endregion

        //Padron
        #region

        ConstructorPadron agregarP = new ConstructorPadron();
        ConstructorPadron actualizarP = new ConstructorPadron();
        public void AgregarPadron()
        {
            if (TxtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                agregarP.votantePadron = Convert.ToInt32(cmbVotante.SelectedValue);
                agregarP.mesaPadron = Convert.ToInt32(cmbMesa.SelectedValue);
                agregarP.codigo = Convert.ToInt32(TxtCodigo.Text);
                int datos = Funciones_Padron.AgregarPadron(agregarP);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // agregar
            AgregarPadron();
            mostrarpadron();
            vacio();


        }
        public void mostrarpadron()
        {
            dgvpadron.DataSource = Funciones_Padron.MostrarPadron();

        }


        public void actualizarPadron()
        {
            actualizarP.idPadron = Convert.ToInt32(TxtId.Text);
            actualizarP.votantePadron = Convert.ToInt32(cmbVotante.SelectedValue);
            actualizarP.mesaPadron = Convert.ToInt32(cmbMesa.SelectedValue);
            actualizarP.codigo = Convert.ToInt32(TxtCodigo.Text);


            Funciones_Padron.ActualizarPadron(actualizarP);
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarpadron();
            vacio();

        }

        public void actualizarPadrones()
        {
            actualizarP.idPadron = Convert.ToInt32(TxtId.Text);
            actualizarP.votantePadron = Convert.ToInt32(cmbVotante.SelectedValue);
            actualizarP.mesaPadron = Convert.ToInt32(cmbMesa.SelectedValue);
            actualizarP.codigo = Convert.ToInt32(TxtCodigo.Text);


            Funciones_Padron.ActualizarPadron(actualizarP);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            actualizarPadrones();
            mostrarpadron();
            vacio();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_Padron.EliminarPadron(Convert.ToInt32(TxtId.Text));
                mostrarpadron();
                vacio();
            }
        }

        private void dgvpadron_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lugares;
            lugares = dgvpadron.CurrentRow.Index;

            TxtId.Text = this.dgvpadron[0, lugares].Value.ToString();
            TxtCodigo.Text = this.dgvpadron[3, lugares].Value.ToString();
            cmbMesa.SelectedValue = this.dgvpadron[2, lugares].Value.ToString();
            cmbVotante.SelectedValue = this.dgvpadron[1, lugares].Value.ToString();

        }

        #endregion

        //Votantes
        #region
        public void AgregarVotante()
        {
            if (txtNombres.Text.Trim() == "" || txtApellidos.Text.Trim() == "" ||
                txtDUI.Text.Trim() == "" ||
                cmbMunicipio.Text.Trim() == "" || cmbGenero.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int estado = 1;
                agregar.nombrevotante = txtNombres.Text;
                agregar.apellidovotante = txtApellidos.Text;
                agregar.documento = txtDUI.Text;
                agregar.municipiovotante = Convert.ToInt16(cmbMunicipio.SelectedValue);
                agregar.Estadovotante = estado;
                agregar.genero = Convert.ToInt32(cmbGenero.SelectedValue);
                agregar.discapacidad = Convert.ToInt16(cmbDiss.SelectedValue);
                int datos = Funciones_votante.IngresarVotante(agregar);
            }

        }

        public void Mostrarvotantes()
        {
            dgvVotantes.DataSource = Funciones_votante.MostrarVotantes();
        }

        public void limpiarcaposvot()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDUI.Clear();
        }

        public void ModificarRegistro()
        {

            int estado = 2;
            actualizar.Estadovotante = estado;
            actualizar.idvotante = Convert.ToInt32(txtId_Votante.Text);
            actualizar.nombrevotante = txtNombres.Text;
            actualizar.apellidovotante = txtApellidos.Text;
            actualizar.documento = txtDUI.Text;          
            actualizar.genero = Convert.ToInt32(cmbGenero.SelectedValue);
            actualizar.municipiovotante = Convert.ToInt32(cmbMunicipio.SelectedValue);
            actualizar.discapacidad = Convert.ToInt16(cmbDiss.SelectedValue);
            Funciones_votante.ActualizarVotante(actualizar);
        }


        private void btnAgregarVotante_Click(object sender, EventArgs e)
        {
            AgregarVotante();
            Mostrarvotantes();
            limpiarcaposvot();
        }

        private void btnMostrarVotantes_Click(object sender, EventArgs e)
        {
            Mostrarvotantes();
            limpiarcaposvot();
            btnAgregarVotante.Enabled = true;
        }

        private void btnActualizarVo_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
            btnActualizarVo.Enabled = false;
            button1.Enabled = false;
            btnAgregarVotante.Enabled = true;
            Mostrarvotantes();
            limpiarcaposvot();
        }

        public void EliminarRegistro()
        {
            if (MessageBox.Show("¿Estas seguro que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_votante.EliminarVotante(Convert.ToInt32(txtId_Votante.Text));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            EliminarRegistro();
            Mostrarvotantes();
            btnActualizarVo.Enabled = false;
            button1.Enabled = false;
            btnAgregarVotante.Enabled = true;
            limpiarcaposvot();
        }

        private void dgvVotantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocision;
            pocision = this.dgvVotantes.CurrentRow.Index;
            txtId_Votante.Text = this.dgvVotantes[0, pocision].Value.ToString();
            txtNombres.Text = this.dgvVotantes[1, pocision].Value.ToString();
            txtApellidos.Text = this.dgvVotantes[2, pocision].Value.ToString();
            txtDUI.Text = this.dgvVotantes[3, pocision].Value.ToString();
            cmbMunicipio.SelectedValue = this.dgvVotantes[4, pocision].Value.ToString();
            cmbGenero.SelectedValue = this.dgvVotantes[6, pocision].Value.ToString();
            cmbDiss.SelectedValue = this.dgvVotantes[7, pocision].Value.ToString();
        
            btnActualizarVo.Enabled = true;
            button1.Enabled = true;
            btnAgregarVotante.Enabled = false;
        }


        #endregion

        //Mesas de Votación    
        #region       
        ControladorMesa agregarMesas = new ControladorMesa();
        ControladorMesa actualizarMesas = new ControladorMesa();

        public void limpiarmesa()
        {
            txtlugar.Clear();
        }

        public void añadirMesa()
        {
            agregarMesas.centroMesa = Convert.ToInt16(cmbCentro.SelectedValue);
            agregarMesas.lugar = txtlugar.Text;
            agregarMesas.ubicacionMesa = Convert.ToInt16(cmbUbicación.SelectedValue);
            funciones_mesas.IngresarMesas(agregarMesas);

        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            añadirMesa();
            MostrarMesa();
            limpiarmesa();
        }

        public void MostrarMesa()
        {
            dgvMesa.DataSource = funciones_mesas.MostrarMesa();
        } 

        private void btnMostrarMesa_Click(object sender, EventArgs e)
        {
            MostrarMesa();
            btnAgregarMesa.Enabled=true;
            limpiarmesa();
        }
        public void ActualizarMesa()
        {
            actualizarMesas.idMesa = Convert.ToInt32(txtID_Mesa.Text);
            actualizarMesas.centroMesa = Convert.ToInt16(cmbCentro.SelectedValue);
            actualizarMesas.lugar = txtlugar.Text;
            actualizarMesas.ubicacionMesa = Convert.ToInt16(cmbUbicación.SelectedValue);
            funciones_mesas.ActualizarMesas(actualizarMesas);
            btnActualizarMesa.Enabled = false;
            btnEliminarMesa.Enabled = false;
            btnAgregarMesa.Enabled = true;
            MostrarMesa();
            limpiarmesa();
        }
        private void btnActualizarMesa_Click(object sender, EventArgs e)
        {
            ActualizarMesa();
        }
        public void EliminarMesa()
        {
            if (MessageBox.Show("¿Estas seguro que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funciones_mesas.EliminarMesa(Convert.ToInt32(txtID_Mesa.Text));
            }
        }

        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {
            EliminarMesa();
            btnActualizarMesa.Enabled = false;
            btnEliminarMesa.Enabled = false;
            btnAgregarMesa.Enabled = true;
            MostrarMesa();
            limpiarmesa();
        }

        private void dgvMesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lugar;
            lugar = this.dgvMesa.CurrentRow.Index;
            txtID_Mesa.Text = this.dgvMesa[0, lugar].Value.ToString();
            cmbCentro.SelectedValue = this.dgvMesa[1, lugar].Value.ToString();
            txtlugar.Text = this.dgvMesa[2, lugar].Value.ToString();
            cmbUbicación.SelectedValue = this.dgvMesa[3, lugar].Value.ToString();
            btnActualizarMesa.Enabled = true;
            btnEliminarMesa.Enabled = true;
            btnAgregarMesa.Enabled = false;
        }


        #endregion

        //Centros de votación       
        #region
        constructorcentrovotacion agregarcentro = new constructorcentrovotacion();
        constructorcentrovotacion actualizarcentro = new constructorcentrovotacion();

        public void AgregarCentro()
        {
            if (txtNumero.Text.Trim()=="")
            {
                MessageBox.Show("Complete todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agregarcentro.municipiocentrovotacion = Convert.ToInt16(cmbMunicipioC.SelectedValue);
                agregarcentro.numeroinfra = txtNumero.Text;
                agregarcentro.ubicacion = Convert.ToInt16(cmbUbicacionC.SelectedValue);
                int data = CentroVotacion.IngresarCentroVotacion(agregarcentro);
            }
        }
       public void limpiarCentros()
        {
            txtNumero.Clear();
        }
        public void Mostrarcentro()
        {
            dgvCentro.DataSource = CentroVotacion.MostrarCentros();
        }

        private void btnAgregarCentro_Click(object sender, EventArgs e)
        {
            AgregarCentro();
            limpiarCentros();
        }

        private void btnMostrarCentro_Click(object sender, EventArgs e)
        {
            Mostrarcentro();
            limpiarCentros();
            btnAgregarCentro.Enabled = true;
        }
        public void ActualizarCentro()
        {
            actualizarcentro.idCentroVotacion = Convert.ToInt32(txtID_Centro.Text);
            actualizarcentro.municipiocentrovotacion = Convert.ToInt16(cmbMunicipioC.SelectedValue);
            actualizarcentro.numeroinfra = txtNumero.Text;
            actualizarcentro.ubicacion = Convert.ToInt16(cmbUbicacionC.SelectedValue);
            CentroVotacion.ActualizarCentroVotacion(actualizarcentro);
        }
        private void btnActualizarCentro_Click(object sender, EventArgs e)
        {
            ActualizarCentro();
            Mostrarcentro();
            btnActualizarCentro.Enabled = false;
            btnEliminarCentro.Enabled = false;
            btnAgregarCentro.Enabled = true;
            limpiarCentros();
        }
         
        public void EliminarCentro()
        {
            if (MessageBox.Show("¿Estas seguro que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CentroVotacion.EliminarCentro(Convert.ToInt32(txtID_Centro.Text));
            }
        }
        private void btnEliminarCentro_Click(object sender, EventArgs e)
        {
            EliminarCentro();
            Mostrarcentro();
            btnActualizarCentro.Enabled = false;
            btnEliminarCentro.Enabled = false;
            btnAgregarCentro.Enabled = true;
            limpiarCentros();
        }

        private void dgvCentro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lugares;
            lugares = this.dgvCentro.CurrentRow.Index;
            txtID_Centro.Text= this.dgvCentro[0, lugares].Value.ToString();
            cmbMunicipioC.SelectedValue= this.dgvCentro[1, lugares].Value.ToString();
            txtNumero.Text= this.dgvCentro[2, lugares].Value.ToString();
            cmbUbicacionC.SelectedValue= this.dgvCentro[3, lugares].Value.ToString();
            btnActualizarCentro.Enabled = true;
            btnEliminarCentro.Enabled = true;
            btnAgregarCentro.Enabled = false;


        }
        #endregion
    }
}
