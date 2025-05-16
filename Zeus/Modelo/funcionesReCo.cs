using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeus.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Zeus.Config;

namespace Zeus.Modelo
{
    class funcionesReCo
    {
        public static string obtenercorreo()
        {
            string retorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand(string.Format("SELECT correo_usuario FROM  tbusuarios WHERE usuario = binary ?param"), conexion.obtenerconexion());
                cmd.Parameters.Add(new MySqlParameter("param", constructorCorreoRe.usario));
                retorno = Convert.ToString(cmd.ExecuteScalar());
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al obtener el Correo" + e);
                return retorno = "";
            }
        }
        public static bool enviaRamdom()
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdUPDATE = new MySqlCommand(string.Format("UPDATE tbusuarios SET codigo_recuperacion = '{0}' WHERE usuario ='{1}'", constructorCorreoRe.codigoRe,constructorCorreoRe.usario), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdUPDATE.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al modificar codigo usuario" + e, "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static int verifiacrCodigo()
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(string.Format("SELECT id_usuario FROM tbusuarios WHERE codigo_recuperacion = binary ?param"), conexion.obtenerconexion());
                cmdselect.Parameters.Add(new MySqlParameter("param", constructorCorreoRe.codigoRe));
                retorno = Convert.ToInt32(cmdselect.ExecuteScalar());
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error en la obtención de datos" + e, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
            return retorno;
        }
        public static bool NuevaClave(string co)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdnuevaC = new MySqlCommand(string.Format("UPDATE tbusuarios SET clave_usuarios = '{0}' WHERE usuario = '{1}'", co,constructorCorreoRe.usario), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdnuevaC.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Opps...., Error no esperado, Verifique su conexion al internet o que sus servios del servidor" + e, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
