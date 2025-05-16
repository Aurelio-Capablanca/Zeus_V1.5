using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeus.Controlador;

namespace Zeus.Modelo
{
    class Funciones_votante
    {
        public static DataTable obtenerdepartamentos()
        {
            string query = "SELECT * FROM tbdepartamentos";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!, Ha ocurrido un error consulte con el administrador." + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }

        public static DataTable discapacidad()
        {
            string query = "SELECT * FROM tbdiscapacidades";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!, Ha ocurrido un error consulte con el administrador." + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
        public static DataTable obtenermunicipio()
        {
            string query = "SELECT * FROM tbmunicipios";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!, Ha ocurrido un error consulte con el administrador." + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
        public static int IngresarVotante(Constructor add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO tbvotantes(nombre_votante, apellido_votante,dui_votante,municipio_votante,estado_votante,genero_votante,discapacidad_votante) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                    , add.nombrevotante, add.apellidovotante, add.documento, add.municipiovotante, add.Estadovotante, add.genero,add.discapacidad), conexion.obtenerconexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Usuario Ingresado existosamente", "proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El docente no pudo ser registrado, intente nuevamente y verifique que los datos sean correctos", "proceso no completado"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexión: " + e, "Fallo de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static DataTable MostrarVotantes()
        {
            DataTable data;
            try
            {

                string query = "SELECT * FROM tbvotantes";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, ha ocurrido un error en la obtencion de datos, consulte con su administrador.", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
        public static DataTable Genero()
        {
            DataTable data;
            try
            {

                string query = "SELECT * FROM tbgenero";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, ha ocurrido un error en la obtencion de datos, consulte con su administrador.", "Error critico de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data = new DataTable();
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
        public static bool ActualizarVotante(Constructor upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE tbvotantes SET nombre_votante = '{0}',apellido_votante = '{1}',dui_votante = '{2}',municipio_votante = '{3}',estado_votante = '{4}',genero_votante = '{5}',discapacidad_votante='{6}' WHERE id_votante = '{7}'"
                     , upd.nombrevotante, upd.apellidovotante, upd.documento, upd.municipiovotante, upd.Estadovotante, upd.genero,upd.discapacidad,upd.idvotante), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Datos actualizados correctamente.", "proceso completado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados.", "proceso no completado.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Oops!, ha ocurrido un problema, revise su conexion a internet o los servicios del servidor, consulte al administrador." + e, "Error Critico.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static bool EliminarVotante(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(String.Format("DELETE FROM tbvotantes WHERE id_votante = '{0}'", id), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro ha sido eliminado correctamente.", "proceso completado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no pudo ser eliminado.", "proceso no completado.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Oops!, ha ocurrido un problema, revise su conexion a internet o los servicios del servidor, consulte al administrador.", "Error Critico." + e, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
