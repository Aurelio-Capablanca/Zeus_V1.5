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


namespace Zeus.Vista
{
    public partial class Frm_Partido : Form
    {
        public Frm_Partido()
        {
            InitializeComponent();
        }
        #region
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPartido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvFormula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }








        #endregion
        //candidatos  

        Constructorformula_pres Agregar = new Constructorformula_pres();
        Constructorformula_pres Actualizar = new Constructorformula_pres();
        public void AgregarFormula()
        {
            if (txtPresidente.Text.Trim() == "")
            {
                MessageBox.Show("Por favor complete todos los campos para poder proceder", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                Agregar.nombreCandidato = txtPresidente.Text;
                Agregar.estadoCandiadato = Convert.ToInt16(cmbEstado.SelectedValue);
                Agregar.tipoCandidato = Convert.ToInt16(cmbTipo.SelectedValue);
                Agregar.partidoCandidato = Convert.ToInt16(cmbPresi.SelectedValue);
                int formula = formulaPresidencial.IngresarFormula(Agregar);

            }
        }




        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            AgregarFormula();
            Mostrarformula();
            Limpiar();

        }

        public void Limpiar()
        {
            txtPresidente.Clear();


        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            Mostrarformula();
            this.dgvFormula.Columns[0].Visible = false;
            btnActualizar.Enabled = false;
            bntEliminar.Enabled = false;
            btnAgregar.Enabled = true;
            Limpiar();


        }


        public void ActualizarRegistro()
        {
            Actualizar.idcandidato = Convert.ToInt32(txtId.Text);
            Actualizar.nombreCandidato = txtPresidente.Text;
            Actualizar.estadoCandiadato = Convert.ToInt16(cmbEstado.SelectedValue);
            Actualizar.tipoCandidato = Convert.ToInt16(cmbTipo.SelectedValue);
            Actualizar.partidoCandidato = Convert.ToInt16(cmbPresi.SelectedValue);
            formulaPresidencial.ActualizarFormula(Actualizar);
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarRegistro();
            Mostrarformula();
            Limpiar();
            btnActualizar.Enabled = false;
            bntEliminar.Enabled = false;
            btnAgregar.Enabled = true;

        }
        public void EliminarRegistro()
        {
            if (MessageBox.Show("¿Esta seguro de que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                formulaPresidencial.EliminarFormula(Convert.ToInt32(txtId.Text));
            }


        }

        public void Mostrarformula()
        {
            dgvFormula.DataSource = formulaPresidencial.MostrarFormula();
        }
        private void bntEliminar_Click_1(object sender, EventArgs e)
        {
            EliminarRegistro();
            Limpiar();
            Mostrarformula();
            btnActualizar.Enabled = false;
            bntEliminar.Enabled = false;
            btnAgregar.Enabled = true;

        } 





        private void FrmCandidatos_Click(object sender, EventArgs e)
        {

        }

        private void dgvPartido_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int lugar;
            lugar = dgvPartido.CurrentRow.Index;

            txtId.Text = this.dgvPartido[0, lugar].Value.ToString();
            txtNombre.Text = this.dgvPartido[1, lugar].Value.ToString();
          
           btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btningresar.Enabled = false;
        }

        private void grpIngresar_Enter(object sender, EventArgs e)
        {

        }






        private void Frm_Partido_Load(object sender, EventArgs e)
        {

            Mostrarformula();
            this.dgvFormula.Columns[0].Visible = false;
            btnActualizar.Enabled = false;
            bntEliminar.Enabled = false;
            btnAgregar.Enabled = true;

            if (formulaPresidencial.ObtenerEstado() != null)
            {
                cmbEstado.DataSource = formulaPresidencial.ObtenerEstado();
                cmbEstado.DisplayMember = "nombre_estado_formula_pres";
                cmbEstado.ValueMember = "id_estado_formula_pres";
            }


            if (formulaPresidencial.ObtenerTipo() != null)
            {
                cmbTipo.DataSource = formulaPresidencial.ObtenerTipo();
                cmbTipo.DisplayMember = "cargo";
                cmbTipo.ValueMember = "id_tipo_candidato";
            }

            if (formulaPresidencial.ObtenerPartido() != null)
            {
                cmbPresi.DataSource = formulaPresidencial.ObtenerPartido();
                cmbPresi.DisplayMember = "nombre_par";
                cmbPresi.ValueMember = "id_partido";
            }

         

            btndelete.Enabled = false;
            bntshow.Enabled = false;
            btningresar.Enabled = true;
            MostrarPartido();
            this.dgvPartido.Columns[0].Visible = false;



            if (ConstructorLogin.nivel == 2)
            {

                FrmCandidatos.Enabled = true;
              

                FrmFormula.Enabled = true;



            }
            else if (ConstructorLogin.nivel == 1)
            {

                FrmCandidatos.Visible = true;
               
                FrmFormula.Enabled = true;



            }


        }




        private void dgvFormula_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int lugar;
            lugar = dgvFormula.CurrentRow.Index;
            txtId.Text = this.dgvFormula[0, lugar].Value.ToString();
            txtPresidente.Text = this.dgvFormula[1, lugar].Value.ToString();
            cmbEstado.SelectedValue = this.dgvFormula[2, lugar].Value.ToString();
            cmbTipo.SelectedValue = this.dgvFormula[3, lugar].Value.ToString();
            btnActualizar.Enabled = true;
            bntEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }





        //partido politico 
        ConstructorPartido agregar = new ConstructorPartido();
        ConstructorPartido actualizar = new ConstructorPartido();

        public void AgregarPartido()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Por favor complete todos los campos para poder proceder", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                agregar.nombrePartido = txtNombre.Text;
                int partido = partidoPolitico.IngresarPartido(agregar);
            }
        }
        public void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarPartido();
            limpiar();
            MostrarPartido();
        }

        public void MostrarPartido()
        {
            dgvPartido.DataSource = partidoPolitico.MostrarPartido();
        } 

        private void bntshow_Click(object sender, EventArgs e)
        {
            Limpiar();
            MostrarPartido();
            btningresar.Enabled = true;

        }
        public void ActualizarPartido()
        {
            if (MessageBox.Show("¿Estas seguro que desea actualizar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(Convert.ToString(txtId.Text));
                actualizar.idPartido = Convert.ToInt32(txtId.Text);
                actualizar.nombrePartido = txtNombre.Text;
                partidoPolitico.ActualizarPartido(actualizar);

            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ActualizarPartido();
            MostrarPartido();
            limpiar();
            btndelete.Enabled = false;
            bntshow.Enabled = false;
            btningresar.Enabled = true;

        }
        public void eliminarRegistro()
        {
            if (MessageBox.Show("¿Esta seguro de que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(Convert.ToString(txtId.Text));
                partidoPolitico.EliminarPartido(Convert.ToInt32(txtId.Text));
            }


        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            eliminarRegistro();
            MostrarPartido();
            Limpiar();
            btndelete.Enabled = false;
            bntshow.Enabled = false;
            btningresar.Enabled = true;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            AgregarFormula();
            Mostrarformula();
            Limpiar();
        }

        private void btnMostrar_Click_2(object sender, EventArgs e)
        {
            Mostrarformula();
            this.dgvFormula.Columns[0].Visible = false;
            btnActualizar.Enabled = false;
            bntEliminar.Enabled = false;
            btnAgregar.Enabled = true;
            Limpiar();
        }

        private void btnActualizar_Click_2(object sender, EventArgs e)
        {
            ActualizarRegistro();
            Mostrarformula();
            Limpiar();
            btnActualizar.Enabled = false;
            bntEliminar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void bntEliminar_Click_2(object sender, EventArgs e)
        {
            EliminarRegistro();
            Mostrarformula();
            btnActualizar.Enabled = false;
            bntEliminar.Enabled = false;
            btnAgregar.Enabled = true;
            Limpiar();

        }
    }
}
