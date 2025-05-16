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
    class Funciones_jrv
    {
        public static int IngresarJRV(ControladorJRV añadir)
        {
            int regreso = 0;
            try
            {
                MySqlCommand cmdañadir = new MySqlCommand(string.Format("INSERT INTO  tbjrv (estado_junta,integrantes_junta,jrv_mesa) VALUES('{0}','{1}','{2}')",añadir.estadoJRV,añadir.integrantesJRV,añadir.mesaJRV ), conexion.obtenerconexion());
                regreso = Convert.ToInt32(cmdañadir.ExecuteNonQuery());
                if (regreso >= 1)
                {
                    MessageBox.Show("El usuario se ingreso de manera exitosa", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El usuario no se a podido ingresar", "Error en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return regreso;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return regreso;
            }
        }



        public static DataTable MostrarJRV()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbjrv";
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


        public static bool ActualizarJRV(ControladorJRV udpd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdup = new MySqlCommand(string.Format("UPDATE tbjrv SET estado_junta='{0}',integrantes_junta='{1}',jrv_mesa='{2}', WHERE id_junta='{3}'",udpd.estadoJRV,udpd.integrantesJRV,udpd.mesaJRV, udpd.idJRV), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdup.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Datos actualizados correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Datos actualizados incorrectamente", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }

            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema revise su conexion a internet, y si el problema persiste contcte su administrador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }




        }




        public static bool EliminarJRV(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbjrv WHERE id_junta='{0}'", id), conexion.obtenerconexion());
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




        public static DataTable ObtenerEstado()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbestado_juntas";
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

        public static DataTable Obtenerintegrante()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbmiembros";
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


    }
}
