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
    class Funciones_admin
    {
        public static int IngresarAdmin(constructo_admin añadir)
        {
            int regreso = 0;
            try
            {
                MySqlCommand cmdañadir = new MySqlCommand(string.Format("INSERT INTO tbusuarios (nombres_usuario,apellidos_usuario,clave_usuarios,"+
                "dui_usuario,municipio_usuario,tipo_usuario,est_usu,telefono_usuario,correo_usuario,genero_usuario,usuario)"+
                " VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", 
                añadir.nombre, añadir.apellidos, 
                añadir.clave, añadir.dui, 
                añadir.municipio, añadir.tipo_usuario, 
                añadir.estado, añadir.telefono, añadir.correo, 
                añadir.genero,añadir.usuario), conexion.obtenerconexion());

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


        public static DataTable ObtenerGeneros()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbgenero";
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

        public static DataTable ObtenerMunicipio()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbmunicipios";
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
        public static DataTable ObtenerTipoUsuario()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbtipo_usuarios";
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
        public static DataTable estadoUsuario()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbestado_usuarios";
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

        public static DataTable MostrarUsuario()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbusuarios";
                MySqlCommand cmdelegir = new MySqlCommand(
                    string.Format(query), 
                    conexion.obtenerconexion()
                );
                MySqlDataAdapter adaptar = new MySqlDataAdapter(cmdelegir);
                dato = new DataTable();
                adaptar.Fill(dato);
                return dato;

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la obtencion de datos, consulte con su administrador", 
                "Error Critico de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dato = new DataTable();
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }


        }

        public static bool ActualizarUsuario(constructo_admin udpd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdup = new MySqlCommand(string.Format("UPDATE tbusuarios SET nombres_usuario='{0}',apellidos_usuario='{1}',dui_usuario='{2}',municipio_usuario='{3}',tipo_usuario='{4}',est_usu='{5}',telefono_usuario='{6}',correo_usuario='{7}',genero_usuario='{8}',usuario='{9}' WHERE id_usuario='{10}'", udpd.nombre, udpd.apellidos,  udpd.dui, udpd.municipio, udpd.tipo_usuario, udpd.estado, udpd.telefono, udpd.correo, udpd.genero,udpd.usuario, udpd.id_usuario), conexion.obtenerconexion());
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

        public static bool EliminarUsuario(int id)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbusuarios WHERE id_usuario='{0}'", id), conexion.obtenerconexion());
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

        public static bool Restaurarcontraseña(constructo_admin udpd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdup = new MySqlCommand(string.Format("UPDATE tbusuarios SET clave_usuarios='{0}' WHERE id_usuario='{1}'",udpd.clave, udpd.id_usuario), conexion.obtenerconexion());
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

        public static DataTable MostrarVotantes()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM  tbestado_votante";
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

        public static DataTable MostrarMesas()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM   tbmesas_votacion";
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


        public static DataTable MostrarUbicacionn()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM   tbubicaciones";
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
