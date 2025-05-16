using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using Zeus.Controlador;

namespace Zeus.Controlador
{
    class Funciones_PrimerUsoUsuario
    {

        public static DataTable Obtener_preguntas()
        {
            DataTable dato;

            try
            {
                string query = "SELECT * FROM tbpreguntas";
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




        public static bool clavePrimerUso(constructor_PrimerUsoUsuario Upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdUPDATE = new MySqlCommand(string.Format("UPDATE tbusuarios SET clave_usuarios = '{0}',pregunta1 = '{1}',respuesta1 = '{2}',pregunta2 = '{3}',respuesta2 = '{4}' WHERE usuario ='{5}'", Upd.clave, Upd.pregunta1, Upd.respuesta1, Upd.pregunta2, Upd.respuesta2, ConstructorLogin.usuario), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdUPDATE.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("¡Felicidades!, El usuario a sido modificado correctamente", "Usuario modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro No Modificado");
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al modificar Usuario" + e, "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
