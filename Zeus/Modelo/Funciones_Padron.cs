using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeus.Controlador;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Zeus.Modelo
{
    class Funciones_Padron
    {
       public static int AgregarUbicacion(Constructor add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO tbubicaciones(ubicacion) VALUES ('{0}')", add.ubicacion), conexion.obtenerconexion());
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
        public static DataTable MostrarUbicacion()
        {
            DataTable data;
            try
            {

                string query = "SELECT * FROM tbubicaciones";
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
        public static bool ActualizarUbicacion(Constructor upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE tbubicaciones SET ubicacion = '{0}' WHERE id_ubicacion = '{1}'"
                     , upd.ubicacion,upd.idUbicacion), conexion.obtenerconexion());
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
        public static bool EliminarUbicacion(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbubicaciones WHERE id_ubicacion = '{0}'", id), conexion.obtenerconexion());
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
                MessageBox.Show("Oops!, ha ocurrido un problema, revise su conexion a internet o los servicios del servidor, consulte al administrador." + e, "Error Critico." , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }   























        public static DataTable ObtenerVotante()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbvotantes";
                MySqlCommand cmdelegir = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adaptar = new MySqlDataAdapter(cmdelegir);
                dato = new DataTable();
                adaptar.Fill(dato);
                return dato;

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la obtencion de datos, consulte con su administrador", "Error Critico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dato = new DataTable();
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }

        public static DataTable ObtenerMesa()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbmesas_votacion";
                MySqlCommand cmdelegir = new MySqlCommand(string.Format(query), conexion.obtenerconexion());
                MySqlDataAdapter adaptar = new MySqlDataAdapter(cmdelegir);
                dato = new DataTable();
                adaptar.Fill(dato);
                return dato;

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la obtencion de datos, consulte con su administrador", "Error Critico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dato = new DataTable();
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        } 









        // Fin de Apertado para Mostrar los valores del ConboBox //

        public static int AgregarPadron(ConstructorPadron add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO tbpadrones(votante_padron,mesa_padron,codigo_padron) VALUES ('{0}','{1}','{2}')", add.votantePadron, add.mesaPadron, add.codigo), conexion.obtenerconexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Padron Ingresado existosamente", "proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El Padron no pudo ser registrado, intente nuevamente y verifique que los datos sean correctos", "proceso no completado"
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

        public static DataTable MostrarPadron()
        {
            DataTable data;
            try
            {

                string query = "SELECT * FROM tbpadrones";
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

        public static bool ActualizarPadron(ConstructorPadron upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE tbpadrones SET votante_padron = '{0}',mesa_padron = '{1}',codigo_padron = '{2}' WHERE id_padron = '{3}'", upd.votantePadron, upd.mesaPadron, upd.codigo, upd.idPadron), conexion.obtenerconexion());
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

        public static bool EliminarPadron(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbpadrones WHERE id_padron='{0}'", id), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El registro ha sido eliminado correctamente", "proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro ha no sido eliminado correctamente", "proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error con su conexion de internet revise su equipo o pongase en contacto con su distribuidor de internet", "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }



    }
}
