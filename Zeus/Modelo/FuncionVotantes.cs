using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeus.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace Zeus.Modelo
{
    class FuncionVotantes
    {

      public static bool IngresoaVoto(ConstructorVotanteLog log)
        {
            bool retorno = false;

            try
            {
                string query = "SELECT * FROM tbvotantes WHERE dui_votante = binary ?param1";
                MySqlCommand cmdSELECT = new MySqlCommand(query, conexion.obtenerconexion());
                cmdSELECT.Parameters.Add(new MySqlParameter("param1", ConstructorVotanteLog.dui));
                retorno = Convert.ToBoolean(cmdSELECT.ExecuteScalar());

                if (retorno == true)
                {
                    string query2 = "SELECT * FROM tbvotantes WHERE dui_votante = binary ?param2 AND estado_votante = binary ?param3";
                    MySqlCommand cmdSELECT2 = new MySqlCommand(query2, conexion.obtenerconexion());
                    cmdSELECT2.Parameters.Add(new MySqlParameter("param2", ConstructorVotanteLog.dui));
                    int estado = 1;
                    cmdSELECT2.Parameters.Add(new MySqlParameter("param3", estado));
                    retorno = Convert.ToBoolean(cmdSELECT2.ExecuteScalar());

                    if (retorno == true)
                    {
                        int estadobloc = 1;
                        MySqlCommand cmdRESET = new MySqlCommand(string.Format("UPDATE tbvotantes SET estado_votante = '{0}' WHERE dui_votante = '{1}'", estadobloc, ConstructorVotanteLog.dui), conexion.obtenerconexion());
                        int verifiacion = Convert.ToInt16(cmdRESET.ExecuteNonQuery());
                        MySqlDataReader reader = cmdSELECT2.ExecuteReader();
                        while (reader.Read())
                        {
                            ConstructorVotanteLog.nombres = reader.GetString(1);
                            MessageBox.Show("El Votante puede emitir su voto" + ConstructorVotanteLog.nombres, "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }              
                    else
                    {
                      
                       MessageBox.Show("El dui que a ingresado no se le permite el acceso, favor comunicarse con la JRV de la mesa asignada a su padrón", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      
                    }

                }
                else
                {
                    MessageBox.Show("El dui que a ingresado no existe, asegurese de escribirlo bien", "Votante no existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido  un error en la conexion de internet, si el problema persiste comuniquese con su administrador", "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }



        public static int Enviardui(Constructor add)
        {
            int retorno = 0;
            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO tbvotos(dui_votante,estado_voto,partido_voto) VALUES ('{0}','{1}','{2}')", add.documento,add.Estadovotante,add.genero), conexion.obtenerconexion());
                retorno = Convert.ToInt32(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("Usuario Ingresado existosamente", "proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El docente no pudo ser registrado, intente nuevamente y verifique que los datos sean correctos", "proceso no completado"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error critico de conexión: " + e, "Fallo de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }

    }
}
