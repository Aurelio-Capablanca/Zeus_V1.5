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
    class Funciones_mie
    {
        public static int IngresarMiembro(ConstructorMiembro añadir)
        {
            int regreso = 0;
            try
            {
                MySqlCommand cmdañadir = new MySqlCommand(string.Format("INSERT INTO  tbmiembros (nombre_int,apelllido_int,cargo_integrante,estado_integrante,correo_miembro,telefono_miembro) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", añadir.nombreMiembro,añadir.apellidoMiembro,añadir.cargoMiembro,añadir.estadoMiembro,añadir.correoMiembro,añadir.telefonoMiembro), conexion.obtenerconexion());
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



        public static DataTable MostrarMiembro()
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

        
        public static bool ActualizarMiembro(ConstructorMiembro udpd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdup = new MySqlCommand(string.Format("UPDATE tbmiembros SET nombre_int='{0}',apelllido_int='{1}',cargo_integrante='{2}',estado_integrante='{3}',correo_miembro='{4}',telefono_miembro='{5}' WHERE id_integrante='{6}'", udpd.nombreMiembro,udpd.apellidoMiembro,udpd.cargoMiembro,udpd.estadoMiembro,udpd.correoMiembro,udpd.telefonoMiembro,udpd.id), conexion.obtenerconexion());
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




        public static bool EliminarMiembro(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbmiembros WHERE id_integrante='{0}'", id), conexion.obtenerconexion());
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


      

        public static DataTable ObtenerCargo()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbtipo_integrantes";
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

        public static DataTable ObtenerEstado()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbestado_miembros";
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
