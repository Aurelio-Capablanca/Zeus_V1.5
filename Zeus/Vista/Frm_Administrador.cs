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
using Zeus.Reportes;
using System.Text.RegularExpressions;
using Zeus.Modelo;
using System.Security.Cryptography;
namespace Zeus.Vista
{
    public partial class Frm_Administrador : Form
    {
        public Frm_Administrador()
        {
            InitializeComponent();
        }
        Constructor agregar = new Constructor();
        Constructor actualizar = new Constructor();
        constructo_admin añadir = new constructo_admin();
        constructo_admin actualizarUsuario = new constructo_admin();
        private void Frm_Administrador_Load(object sender, EventArgs e)
        {
            if (Funciones_admin.ObtenerGeneros() != null)
            {


                cmbGenero_Admin.DataSource = Funciones_admin.ObtenerGeneros();
                cmbGenero_Admin.DisplayMember = "genero";
                cmbGenero_Admin.ValueMember = "id_genero";
            }

            if (Funciones_admin.ObtenerMunicipio() != null)
            {
                cmbMunicipio.DataSource = Funciones_admin.ObtenerMunicipio();
                cmbMunicipio.DisplayMember = "Nombre_mun";
                cmbMunicipio.ValueMember = "id_municipio";

            }


            txtTipo.Text = "Administrador";

            if (Funciones_admin.estadoUsuario() != null)
            {
                cmbEstado.DataSource = Funciones_admin.estadoUsuario();
                cmbEstado.DisplayMember = "nombre_est_usu";
                cmbEstado.ValueMember = "id_est_usu";
            }

            MostrarUsuario();
            btnRestaurar.Enabled = false;
            this.dgvadmin.Columns[0].Visible = false;
            this.dgvadmin.Columns[3].Visible = false;
            

            MostrarMiembro();
            this.dgvMiembros.Columns[0].Visible = false;
            if (Funciones_mie.ObtenerCargo() != null)
            {
                cmbcargo.DataSource = Funciones_mie.ObtenerCargo();
                cmbcargo.DisplayMember = "nombre_tipo_integrante";
                cmbcargo.ValueMember = "id_tipo_integrante";
            }

            if (Funciones_mie.ObtenerEstado() != null)
            {
                cmbestadomie.DataSource = Funciones_mie.ObtenerEstado();
                cmbestadomie.DisplayMember = "nombre_estado_integrante";
                cmbestadomie.ValueMember = "id_estado_integrante";
            }


                ShowJRV();
                this.dgvJRV.Columns[0].Visible = false;
                if (Funciones_jrv.ObtenerEstado() != null)
                {
                    cmbEstadoJunta.DataSource = Funciones_jrv.ObtenerEstado();
                    cmbEstadoJunta.DisplayMember = "nombre_estado_junta";
                    cmbEstadoJunta.ValueMember = "id_estado_junta";
                }

                if (Funciones_jrv.Obtenerintegrante() != null)
                {
                cmbIntegrantes.DataSource = Funciones_jrv.Obtenerintegrante();
                cmbIntegrantes.DisplayMember = "nombre_int";
                cmbIntegrantes.ValueMember = "id_integrante";
                }


                if (Funciones_jrv.ObtenerMesa() != null)
                {
                    cmbMesa.DataSource = Funciones_jrv.ObtenerMesa();
                    cmbMesa.DisplayMember = "Lugar";
                    cmbMesa.ValueMember = "id_mesa_votacion";
                }

            if (ConstructorLogin.nivel == 2)
            {
                //tbcVotante.Enabled = false;
                //btnactualizar.Enabled = false;
                //btnAgregar.Enabled = false;
                //btndel.Enabled = false;
                //btnMostrar.Enabled = false;


                tbcAdministador.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button2.Enabled = false;



            }
            else if (ConstructorLogin.nivel == 1)
            {

                //tbcVotante.Visible = true;
                //btnactualizar.Enabled = true;
                //btnAgregar.Enabled = true;
                //btndel.Enabled = true;
                //btnMostrar.Enabled = true;


                tbcAdministador.Visible = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button2.Enabled = true;



            }
               
        }


        // Votantes
        #region
        //public void AgregarVotante()
        //{
        //    if (txtNombres.Text.Trim() == "" || txtApellidos.Text.Trim() == "" ||
        //        txtDUI.Text.Trim() == "" ||
        //        cmbMunicipio.Text.Trim() == "" || cmbGenero.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Complete todos los campos", "Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        int estado = 1;
        //        agregar.nombrevotante = txtNombres.Text;
        //        agregar.apellidovotante = txtApellidos.Text;
        //        agregar.documento = txtDUI.Text;
        //        agregar.municipiovotante = Convert.ToInt16(cmbMunicipio.SelectedValue);
        //        agregar.Estadovotante = estado;
        //        agregar.genero = Convert.ToInt32(cmbGenero.SelectedValue);
        //        agregar.discapacidad = Convert.ToInt16(cmbdis.SelectedValue);
        //        int datos = Funciones_votante.IngresarVotante(agregar);
        //    }

        //}

        //public void Mostrarvotantes()
        //{
        //    dgvVotantes.DataSource = Funciones_votante.MostrarVotantes();
        //}
        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    AgregarVotante();
        //    Mostrarvotantes();
        //}
        //public void ModificarRegistro()
        //{

        //    int estado = 1;
        //    actualizar.Estadovotante = estado;
        //    actualizar.idvotante = Convert.ToInt32(txtId_Votante.Text);
        //    actualizar.nombrevotante = txtNombres.Text;
        //    actualizar.apellidovotante = txtApellidos.Text;
        //    actualizar.documento = txtDUI.Text;
        //    actualizar.genero = Convert.ToInt32(cmbGenero.SelectedValue);
        //    actualizar.municipiovotante = Convert.ToInt32(cmbMunicipio.SelectedValue);
        //    actualizar.discapacidad = Convert.ToInt16(cmbdis.SelectedValue);
        //    Funciones_votante.ActualizarVotante(actualizar);
        //}




        //private void btnMostrar_Click(object sender, EventArgs e)
        //{
        //    Mostrarvotantes();
        //}

        //private void dgvVotantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int pocision;
        //    pocision = this.dgvVotantes.CurrentRow.Index;
        //    txtNombres.Text = this.dgvVotantes[1, pocision].Value.ToString();
        //    txtApellidos.Text = this.dgvVotantes[2, pocision].Value.ToString();
        //    txtDUI.Text = this.dgvVotantes[3, pocision].Value.ToString();
        //    cmbdis.SelectedValue = this.dgvVotantes[4, pocision].Value.ToString();
        //    cmbMunicipio.SelectedValue = this.dgvVotantes[5, pocision].Value.ToString();
        //    cmbGenero.SelectedValue = this.dgvVotantes[6, pocision].Value.ToString();
        //    txtId_Votante.Text = this.dgvVotantes[0, pocision].Value.ToString();
        //    btnactualizar.Enabled = true;
        //    btnEliminar.Enabled = true;
        //    btnAgregar.Enabled = false;
        //}

        //private void btnactualizar_Click(object sender, EventArgs e)
        //{
        //    ModificarRegistro();
        //    btnactualizar.Enabled = false;
        //    btnEliminar.Enabled = false;
        //    btnAgregar.Enabled = true;
        //    Mostrarvotantes();
        //}




        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    EliminarRegistro();
        //    Mostrarvotantes();
        //    btnactualizar.Enabled = false;
        //    btnEliminar.Enabled = false;
        //    btnAgregar.Enabled = true;
        //}
        //public void EliminarRegistro()
        //{
        //    if (MessageBox.Show("¿Estas seguro que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        Funciones_votante.EliminarVotante(Convert.ToInt32(txtId_Votante.Text));
        //    }

        //}

        #endregion

       // usuarios
        #region
        public void AgregarAdmin()
        {
            int tipo = 2;
            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || cmbEstado.Text.Trim() == "" || txtDocumento.Text.Trim() == "" || txtTelefono.Text.Trim() == ""
                || cmbGenero_Admin.Text.Trim() == "" || cmbMunicipio.Text.Trim() == "" || cmbEstado.Text.Trim() == "" || txtTelefono.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Por favor complete todos los campos para poder proceder", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            añadir.nombre = txtNombre.Text;
            añadir.apellidos = txtApellido.Text;
            añadir.clave = txtEncripenv.Text;
            añadir.dui = Convert.ToString(txtDocumento.Text);
            añadir.municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
            añadir.tipo_usuario = tipo;
            añadir.estado = Convert.ToInt16(cmbEstado.SelectedValue);
            añadir.telefono = txtTelefono.Text;
            añadir.correo = txtCorreo.Text;
            añadir.genero = Convert.ToInt32(cmbGenero_Admin.SelectedValue);
            añadir.usuario = txtUsuario.Text;
            int datos = Funciones_admin.IngresarAdmin(añadir);
  
        }

        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Por favor coloque un dominio a su cuenta de correo", "Informacion incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Encriptar();
            email_bien_escrito(txtCorreo.Text);
            AgregarAdmin();
            MostrarUsuario();
            LimpiarCampos();
        }
        public void LimpiarCampos()
        {
            txtCorreo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtContra.Clear();
            txtUsuario.Clear();

        }
        public void MostrarUsuario()
        {
            dgvadmin.DataSource = Funciones_admin.MostrarUsuario();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MostrarUsuario();
            LimpiarCampos();
            button8.Enabled = true;
        }
        private string clave;

        public void Encriptar()
        {
            txtContra.Text = "Zeus";
            clave = txtContra.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(clave);
            byte[] hash = md5.ComputeHash(inputBytes);
            clave = BitConverter.ToString(hash).Replace("-", "");
            txtEncripenv.Text = clave.ToString();
        }

        public void ActualizarUsuario()
        {

         
                int tipo = 2;
                actualizarUsuario.id_usuario = Convert.ToInt32(txtID.Text);
                actualizarUsuario.nombre = txtNombre.Text;
                actualizarUsuario.apellidos = txtApellido.Text;
                actualizarUsuario.dui = txtDocumento.Text;
                actualizarUsuario.municipio = Convert.ToInt16(cmbMunicipio.SelectedValue);
                actualizarUsuario.tipo_usuario = tipo;
                actualizarUsuario.estado = Convert.ToInt16(cmbEstado.SelectedValue);
                actualizarUsuario.telefono = txtTelefono.Text;
                actualizarUsuario.correo = txtCorreo.Text;
                actualizarUsuario.genero = Convert.ToInt16(cmbGenero_Admin.SelectedValue);
                actualizarUsuario.usuario = txtUsuario.Text;
                Funciones_admin.ActualizarUsuario(actualizarUsuario);
          
        }

        public void recuperarcontra()
        {
            actualizarUsuario.id_usuario = Convert.ToInt32(txtID.Text);
            actualizarUsuario.clave = txtEncripenv.Text;
            Funciones_admin.Restaurarcontraseña(actualizarUsuario);
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Encriptar();
            recuperarcontra();
            LimpiarCampos();
            btnRestaurar.Enabled = false;
        }

        private void dgvadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lugar;
            lugar = dgvadmin.CurrentRow.Index;

          
            txtID.Text = this.dgvadmin[0, lugar].Value.ToString();
            txtNombre.Text = this.dgvadmin[1, lugar].Value.ToString();
            txtApellido.Text = this.dgvadmin[2, lugar].Value.ToString();
            txtEncripenv.Text = this.dgvadmin[3, lugar].Value.ToString();
            txtDocumento.Text = this.dgvadmin[4, lugar].Value.ToString();
            cmbMunicipio.SelectedValue = this.dgvadmin[5, lugar].Value.ToString();
          
            cmbEstado.SelectedValue = this.dgvadmin[7, lugar].Value.ToString();
            txtTelefono.Text = this.dgvadmin[8, lugar].Value.ToString();
            txtCorreo.Text = this.dgvadmin[9, lugar].Value.ToString();
            cmbGenero_Admin.SelectedValue = this.dgvadmin[10, lugar].Value.ToString();
            txtUsuario.Text = this.dgvadmin[14, lugar].Value.ToString();
            btnRestaurar.Enabled = true;
            button2.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            email_bien_escrito(txtCorreo.Text);
            ActualizarUsuario();
            MostrarUsuario();
            LimpiarCampos();
            button2.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
            MostrarUsuario();
            LimpiarCampos();
            button8.Enabled = false;
        }
        public void EliminarUsuario()
        {
            if (MessageBox.Show("¿Esta seguro de que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_admin.EliminarUsuario(Convert.ToInt32(txtID.Text));
            }
        }
        #endregion

        //trash 
        #region
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbcAdministador_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //miembros
        #region
        ConstructorMiembro Añadir = new ConstructorMiembro();
       ConstructorMiembro Actualizar = new ConstructorMiembro();
        public void AgregarMiembro()
        {

            if (txtnombremie.Text.Trim() == "" || txttelefonomie.Text.Trim() == "" || txtapellidomie.Text.Trim() == "" || txtcorreomie.Text.Trim() == "")
            {
                MessageBox.Show("Por favor complete todos los campos para poder proceder", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else

            Añadir.nombreMiembro = txtnombremie.Text;
            Añadir.apellidoMiembro = txtapellidomie.Text;
            Añadir.cargoMiembro = Convert.ToInt16(cmbcargo.SelectedValue);
            Añadir.estadoMiembro = Convert.ToInt16(cmbestadomie.SelectedValue);
            Añadir.correoMiembro = txtcorreomie.Text;
            Añadir.telefonoMiembro = txttelefonomie.Text;    
            int datos = Funciones_mie.IngresarMiembro(Añadir);
        }


        private void btninsert_Click(object sender, EventArgs e)
        {
            AgregarMiembro();
            MostrarMiembro();
            limpiar();
        }

        public void limpiar()
        {
            txtnombremie.Clear();
            txtapellidomie.Clear();
            txtcorreomie.Clear();
            txttelefonomie.Clear();
        }

        public void MostrarMiembro()
        {
            dgvMiembros.DataSource = Funciones_mie.MostrarMiembro();
        }


        private void btnshow_Click(object sender, EventArgs e)
        {
            MostrarMiembro();
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btninsert.Enabled = true;
            limpiar();   
        }


        public void ActualizarMiembro()
        {
            Actualizar.id = Convert.ToInt32(txtidmi.Text);
            Actualizar.nombreMiembro = txtnombremie.Text;
            Actualizar.apellidoMiembro = txtapellidomie.Text;
            Actualizar.cargoMiembro = Convert.ToInt16(cmbcargo.SelectedValue);
            Actualizar.estadoMiembro = Convert.ToInt16(cmbestadomie.SelectedValue);
            Actualizar.correoMiembro = txtcorreomie.Text;
            Actualizar.telefonoMiembro = txttelefonomie.Text;
            Funciones_mie.ActualizarMiembro(Actualizar);
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            ActualizarMiembro();
            MostrarMiembro();
            limpiar();
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btninsert.Enabled = true;
        }
        public void EliminarMiembro()
        {
            if (MessageBox.Show("¿Esta seguro de que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_mie.EliminarMiembro(Convert.ToInt32(txtidmi.Text));
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            EliminarMiembro();
            MostrarMiembro();
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btninsert.Enabled = true;
            limpiar();
        }

        private void dgvMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dgvMiembros.CurrentRow.Index;
            txtidmi.Text = this.dgvMiembros[0, posicion].Value.ToString();
            txtnombremie.Text = this.dgvMiembros[1, posicion].Value.ToString();
            txtapellidomie.Text = this.dgvMiembros[2, posicion].Value.ToString();
            cmbcargo.SelectedValue = this.dgvMiembros[3, posicion].Value.ToString();
            cmbestadomie.SelectedValue= this.dgvMiembros[4, posicion].Value.ToString();
            txtcorreomie.Text= this.dgvMiembros[5, posicion].Value.ToString();
            txttelefonomie.Text= this.dgvMiembros[6, posicion].Value.ToString();

            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btninsert.Enabled = false;


        }


        #endregion

        //JRV
        #region 
        ControladorJRV Añadirle = new ControladorJRV();
        ControladorJRV Actualizarle = new ControladorJRV();

        public void AñadirJRV()
        {
            Añadirle.estadoJRV = Convert.ToInt16(cmbEstadoJunta.SelectedValue);
            Añadirle.integrantesJRV = Convert.ToInt16(cmbIntegrantes.SelectedValue);
            Añadirle.mesaJRV = Convert.ToInt16(cmbMesa.SelectedValue);
            int data = Funciones_jrv.IngresarJRV(Añadirle);
        } 

        private void btnañadir_Click(object sender, EventArgs e)
        {
            AñadirJRV();
            ShowJRV();
        } 
        public void ShowJRV()
        {
            dgvJRV.DataSource = Funciones_jrv.MostrarJRV();
        }

        private void btnmostrarjrv_Click(object sender, EventArgs e)
        {
            ShowJRV();
            this.dgvJRV.Columns[0].Visible = false;
            btnudp.Enabled = false;
            btnañadir.Enabled = true;
        }

        public void UpdateJRV()
        {
            Actualizarle.idJRV = Convert.ToInt32(txtIdentificador.Text);
            Actualizarle.estadoJRV = Convert.ToInt16(cmbEstadoJunta.SelectedValue);
            Actualizarle.integrantesJRV = Convert.ToInt16(cmbIntegrantes.SelectedValue);
            Actualizarle.mesaJRV = Convert.ToInt16(cmbMesa.SelectedValue);
            Funciones_jrv.ActualizarJRV(Actualizarle);

        }

        private void btnudp_Click(object sender, EventArgs e)
        {
            UpdateJRV();
            ShowJRV();
            btnupdate.Enabled = false;
            btndel.Enabled = false;
            btninsert.Enabled = true;
        }
        public void DeleteJRV()
        {
            if (MessageBox.Show("¿Esta seguro de que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Funciones_jrv.EliminarJRV(Convert.ToInt32(txtIdentificador.Text));
            }
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            DeleteJRV();
            ShowJRV();
            btnudp.Enabled = false;
            btndel.Enabled = false;
            btnañadir.Enabled = true;
        }

        private void dgvJRV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dgvJRV.CurrentRow.Index;
            txtIdentificador.Text = this.dgvJRV[0, posicion].Value.ToString();
            cmbIntegrantes.SelectedValue = this.dgvJRV[1, posicion].Value.ToString();
            cmbEstadoJunta.SelectedValue = this.dgvJRV[2, posicion].Value.ToString();
            cmbMesa.SelectedValue = this.dgvJRV[3, posicion].Value.ToString();
            btnañadir.Enabled = false;
            btndel.Enabled = true;
            btnudp.Enabled = true;
           
        }
        #endregion

        private void cmbGenero_Admin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsSeparator(e.KeyChar) && char.IsDigit(e.KeyChar);
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cmbGenero_Admin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cmbMunicipio_admin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cmbTipUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void cmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReportev_Click(object sender, EventArgs e)
        {
            ReportesVotantes regeresar = new ReportesVotantes();
            regeresar.Show();
            this.Hide();
        }

        private void btnReportejrv_Click(object sender, EventArgs e)
        {
            //ReporteJRV regeresar = new ReporteJRV();
            //regeresar.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Actas regeresar = new Actas();
            //regeresar.Show();
            //this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBusquedaUsuario form = new frmBusquedaUsuario();
            form.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmBusquedaUsuario form = new frmBusquedaUsuario();
            form.Show();
        }
    }
}



