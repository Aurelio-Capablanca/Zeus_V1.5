using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeus.Controlador;

namespace Zeus.Modelo
{
    class frmGraficas
    {
        public static int contaVotos(int vo)
        {
            int retornoo;
            try
            {
                MySqlCommand cmdSELECT = new MySqlCommand(string.Format("SELECT COUNT(partido_voto) FROM tbvotos WHERE partido_voto = '{0}'", vo),conexion.obtenerconexion());
                retornoo = Convert.ToInt32(cmdSELECT.ExecuteScalar());
                return retornoo;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ya me rindo"+e);
                return retornoo = 0;
            }
        }
        public static int estadoVo(int vo)
        {
            int retornoo;
            try
            {
                MySqlCommand cmdSELECT = new MySqlCommand(string.Format("SELECT COUNT(estado_votante) FROM tbvotantes WHERE estado_votante = '{0}'", vo), conexion.obtenerconexion());
                retornoo = Convert.ToInt32(cmdSELECT.ExecuteScalar());
                return retornoo;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ya me rindo" + e);
                return retornoo = 0;
            }
        }
    }
}
