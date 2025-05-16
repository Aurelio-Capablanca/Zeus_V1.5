using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Zeus.Controlador
{
    class conexion
    {
        public static MySqlConnection obtenerconexion()
        {
            MySqlConnection connect;
            string server = "127.0.0.1";
            string database = "dbsistema_votacion";
            string user = "root";
            string pass = "";
            try
            {
                connect = new MySqlConnection("server = " + server +
                                              "; database = " + database +
                                              "; Uid = " + user +
                                              "; pwd = " + pass);
                connect.Open();
                //MessageBox.Show("Conectado");
                return connect;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexión: " + e, "Fallo de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return connect = new MySqlConnection();
            }
        }
    }
}
