using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeus.Controlador;
using Zeus.Config;

namespace Zeus.Modelo
{
    class Verificacion_PrimerUso
    {
        public static bool VerificarEmpresa()
        {
            bool retorno = false;
            string query = "SELECT * FROM tbempresas";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurido un error en el momento de validar la primera empresa" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }

        public static bool VerificarUsuario()
        {
            bool retorno = false;
            string query = "SELECT * FROM tbusuarios";
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdselect.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurido un error en el momento de validar la primera empresa" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }

    }
}
