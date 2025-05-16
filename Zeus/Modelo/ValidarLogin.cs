using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeus.Controlador;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Zeus.Modelo
{
    class ValidarLogin
    {
        public static bool Ingreso(ConstructorLogin log)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tbusuarios WHERE usuario = binary ?param1";
                MySqlCommand cmdSELECT = new MySqlCommand(query, conexion.obtenerconexion());
                cmdSELECT.Parameters.Add(new MySqlParameter("param1", ConstructorLogin.usuario));
                retorno = Convert.ToBoolean(cmdSELECT.ExecuteScalar());

                if (retorno == true)
                {
                    string query2 = "SELECT * FROM tbusuarios WHERE usuario = binary ?param2 AND clave_usuarios = binary ?param3 AND est_usu = binary ?param4";
                    MySqlCommand cmdSELECT2 = new MySqlCommand(query2, conexion.obtenerconexion());
                    cmdSELECT2.Parameters.Add(new MySqlParameter("param2", ConstructorLogin.usuario));
                    cmdSELECT2.Parameters.Add(new MySqlParameter("param3", log.clave));
                    int estado = 1;
                    cmdSELECT2.Parameters.Add(new MySqlParameter("param4", estado));
                    retorno = Convert.ToBoolean(cmdSELECT2.ExecuteScalar());

                    if (retorno == true)
                    {
                        int intentos = 0;
                        MySqlCommand cmdRESET = new MySqlCommand(string.Format("UPDATE tbusuarios SET Intentos = '{0}' WHERE usuario = '{1}'", intentos, ConstructorLogin.usuario), conexion.obtenerconexion());
                        int verifiacion = Convert.ToInt16(cmdRESET.ExecuteNonQuery());
                        MySqlDataReader reader = cmdSELECT2.ExecuteReader();
                        while (reader.Read())
                        {
                            ConstructorLogin.nombres = reader.GetString(1);
                            ConstructorLogin.nivel = reader.GetInt16(6);
                            MessageBox.Show("Bienvenido:" + ConstructorLogin.nombres, "Usuario Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MySqlDataReader reader = cmdSELECT.ExecuteReader();
                        while (reader.Read())
                        {
                            int intentos = 0;
                            intentos = reader.GetInt16(13) + 1;
                            if (intentos > 5)
                            {
                                int bloqueo = 0;
                                MessageBox.Show("Este usuario ha sido BLOQUEADO , porfavor comunicarce con el admunistrador para desbloquear este usuario", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                MySqlCommand cmdUPDATE1 = new MySqlCommand(string.Format("UPDATE tbusuarios SET est_usu = '{0}' WHERE usuario = '{1}'", bloqueo, ConstructorLogin.usuario), conexion.obtenerconexion());

                            }
                            else
                            {
                                MySqlCommand cmdUPDATE2 = new MySqlCommand(string.Format("UPDATE tbusuarios SET intentos = '{0}' WHERE usuario = '{1}'", intentos, ConstructorLogin.usuario), conexion.obtenerconexion());
                                int verificacion = Convert.ToInt32(cmdUPDATE2.ExecuteNonQuery());
                                if (verificacion >= 1)
                                {
                                    MessageBox.Show("La contraseña es incorrecta o un usuario inactivo", "contraseña incorrecta o usuario inactivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("El usuario que a ingresado no esta registrado en la base de datos,Asegurese e escribirlo bien", "Usuario no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show(" Error no esperado, Verifique su conexion al internet o que sus servios del servidor" +e.Message , "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }


    }
}
