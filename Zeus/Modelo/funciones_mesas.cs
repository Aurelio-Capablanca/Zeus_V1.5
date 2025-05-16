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
    class funciones_mesas
    {
        public static int IngresarMesas(ControladorMesa añadir)
        {
            int regreso = 0;
            try
            {
                MySqlCommand cmdañadir = new MySqlCommand(string.Format("INSERT INTO tbmesas_votacion (centro_votacion_mesa,Lugar,ubicacion_mesa) VALUES('{0}','{1}','{2}')", añadir.centroMesa, añadir.lugar, añadir.ubicacionMesa), conexion.obtenerconexion());
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


        public static DataTable MostrarMesa()
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

        public static bool ActualizarMesas(ControladorMesa update)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdup = new MySqlCommand(string.Format("UPDATE tbmesas_votacion  SET  centro_votacion_mesa='{0}',Lugar='{1}',ubicacion_mesa='{2}' WHERE id_mesa_votacion='{3}'", update.centroMesa, update.lugar, update.ubicacionMesa, update.idMesa), conexion.obtenerconexion());
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
                MessageBox.Show("Ha ocurrido un problema revise su conexion a internet, y si el problema persiste contcte su administrador" + e, "Error criitico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }

        public static bool EliminarMesa(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbmesas_votacion WHERE id_mesa_votacion='{0}'", id), conexion.obtenerconexion());
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
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error con su conexion de internet revise su equipo o pongase en contacto con su distribuidor de internet" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }




        }

        public static DataTable ObtenerCentroVota()
        {
            string query = "SELECT * FROM tbcentros_votacion";
            DataTable dato = new DataTable();
            try
            {
                MySqlCommand cmdselec = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adaptar = new MySqlDataAdapter(cmdselec);
                adaptar.Fill(dato);
                return dato;

            }
            catch (Exception a)
            {
                MessageBox.Show("Se ha producido un error al obtener la información de la tabla de los candidatos, consulte con el administrador" + a.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dato;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }


        public static DataTable Obtenerubicacion()
        {
            string query = "SELECT * FROM tbubicaciones";
            DataTable dato = new DataTable();
            try
            {
                MySqlCommand cmdselec = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adaptar = new MySqlDataAdapter(cmdselec);
                adaptar.Fill(dato);
                return dato;

            }
            catch (Exception a)
            {
                MessageBox.Show("Se ha producido un error al obtener la información de la tabla de los candidatos, consulte con el administrador" + a.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dato;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
    }
}
