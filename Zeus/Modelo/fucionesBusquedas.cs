using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeus.Controlador;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Zeus.Modelo
{
    class fucionesBusquedas
    {
        public static DataTable buscar(int preguntas, string parametro)
        {
            DataTable retono;
            try
            {
                switch (preguntas)
                {
                    case 0:
                        MySqlCommand cmbSELECT1 = new MySqlCommand(string.Format("SELECT * FROM tbvotantes WHERE nombre_votante = ?param"), conexion.obtenerconexion());
                        cmbSELECT1.Parameters.Add(new MySqlParameter("param", parametro));
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmbSELECT1);
                        retono = new DataTable();
                        adapter.Fill(retono);
                        break;
                    default:
                        MySqlCommand cmbSELECT2 = new MySqlCommand(string.Format("SELECT * FROM tbvotantes WHERE dui_votante  = ?param"), conexion.obtenerconexion());
                        cmbSELECT2.Parameters.Add(new MySqlParameter("param", parametro));
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmbSELECT2);
                        retono = new DataTable();
                        adapter2.Fill(retono);
                        break;
                }
                return retono;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Buscar" + e);
                return retono = new DataTable();
            }
        }


        public static bool ActualizarVotante(Constructor upd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE tbvotantes SET estado_votante = '{0}' WHERE nombre_votante = '{1}'"
                     , upd.Estadovotante, upd.nombrevotante), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdupd.ExecuteNonQuery());
                if (retorno == true)
                {
                    MessageBox.Show("Datos actualizados correctamente.", "proceso completado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser actualizados.", "proceso no completado.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Oops!, ha ocurrido un problema, revise su conexion a internet o los servicios del servidor, consulte al administrador." + e, "Error Critico.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }



    }
}
