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
    class formulaPresidencial
    {
        public static int IngresarFormula(Constructorformula_pres añadir)
        {
            int regreso = 0;
            try
            {
                MySqlCommand cmdañadir = new MySqlCommand(string.Format("INSERT INTO tbcandidatos (nombre_candidato,estado_candidato,tipo_candidato,partido_candidato) VALUES('{0}','{1}','{2}','{3}')", añadir.nombreCandidato, añadir.estadoCandiadato, añadir.tipoCandidato,añadir.partidoCandidato), conexion.obtenerconexion());
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


        public static DataTable MostrarFormula()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbcandidatos";
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

        public static bool ActualizarFormula(Constructorformula_pres update)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbcandidatos SET  nombre_candidato='{0}',estado_candidato='{1}',tipo_candidato='{2}', partido_candidato='{3}' WHERE  id_candidato='{4}' ", update.nombreCandidato, update.estadoCandiadato, update.tipoCandidato,update.partidoCandidato, update.idcandidato), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
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
                MessageBox.Show("Ha ocurrido un problema revise su conexion a internet, y si el problema persiste contcte su administrador" + e.Message, "Error criitico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

        }

        public static bool EliminarFormula(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbcandidatos WHERE id_candidato='{0}'", id), conexion.obtenerconexion());
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

        public static DataTable ObtenerEstado()
        {
            string query = "SELECT * FROM tbestado_candidato";
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
                MessageBox.Show("Se ha producido un error al obtener la información de la tabla de los tipos de usuario, consulte con el administrador" + a.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dato;


            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }


        public static DataTable ObtenerPartido()
        {
            string query = "SELECT * FROM tbpartidos_politicos";
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



        public static DataTable ObtenerTipo()
        {
            string query = "SELECT * FROM tbtipos_candidatos";
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
                MessageBox.Show("Se ha producido un error al obtener la información de la tabla de los tipos de usuario, consulte con el administrador" + a.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dato;


            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
    }
}
