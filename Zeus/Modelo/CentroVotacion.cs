using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeus.Controlador;
using Zeus.Modelo;

namespace Zeus.Modelo
{
    class CentroVotacion
    {
        public static int IngresarCentroVotacion(Controlador.constructorcentrovotacion añadir)
        {
            int regreso = 0;
            try
            {
                MySqlCommand cmdañadir = new MySqlCommand(string.Format("insert into tbcentros_votacion(municipio_centro_votacion,numero_infraestructura,ubicacion_centro) VALUES('{0}','{1}','{2}')", añadir.municipiocentrovotacion, añadir.numeroinfra, añadir.ubicacion), conexion.obtenerconexion());
                regreso = Convert.ToInt32(cmdañadir.ExecuteNonQuery());
                if (regreso >= 1)
                {
                    MessageBox.Show("El Centro de votacion se ingreso de manera exitosa", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El Centro de votacion no se a podido ingresar", "Error en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return regreso;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return regreso;
            }
        }

        public static bool EliminarCentro(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbcentros_votacion WHERE id_centro_votacion='{0}'", id), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmddel.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("El centro de votacion ha sido eliminado correctamente", "proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El centro de votacion ha no sido eliminado correctamente", "proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;

            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error con su conexion de internet revise su equipo o pongase en contacto con su distribuidor de internet" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }
        public static DataTable MostrarCentros()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbcentros_votacion";
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




        public static bool ActualizarCentroVotacion(constructorcentrovotacion update)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdup = new MySqlCommand(string.Format("UPDATE tbcentros_votacion  SET  municipio_centro_votacion='{0}' WHERE id_centro_votacion='{1}'", update.municipiocentrovotacion, update.idCentroVotacion), conexion.obtenerconexion());
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

        public static DataTable ObtenerMunicipio()
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
                MessageBox.Show("Oops!,Ha ocurrido un error al obtener los tipos de empresa, Consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }


        public static DataTable Obtenerubicacion()
        {
            string query = "SELECT * FROM  tbubicaciones";
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
                MessageBox.Show("Oops!,Ha ocurrido un error al obtener los tipos de empresa, Consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
    }
}
