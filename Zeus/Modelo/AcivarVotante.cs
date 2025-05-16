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
    class AcivarVotante
    {
        //public static bool Ingreso(ConstructorLogin log)
        //{
        //    bool retorno = false;
        //    try
        //    {
        //        string query = "SELECT * FROM tbvotantes WHERE dui_votante = ?param1";
        //        MySqlCommand cmdSELECT = new MySqlCommand(query, conexion.obtenerconexion());
        //        cmdSELECT.Parameters.Add(new MySqlParameter("param1", ConstructorVotante.dui));
        //        retorno = Convert.ToBoolean(cmdSELECT.ExecuteScalar());

        //        if (retorno == true)
        //        {
        //            string query2 = "SELECT * FROM tbvotantes WHERE dui_votante = ?param2 AND estado_votante = ?param3";
        //            MySqlCommand cmdSELECT2 = new MySqlCommand(query2, conexion.obtenerconexion());
        //            cmdSELECT2.Parameters.Add(new MySqlParameter("param2", ConstructorVotante.dui));
        //            int estado = 1;
        //            cmdSELECT2.Parameters.Add(new MySqlParameter("param4", estado));
        //            retorno = Convert.ToBoolean(cmdSELECT2.ExecuteScalar());

        //            int estados = 0;
        //            MySqlCommand cmdRESET = new MySqlCommand(string.Format("UPDATE tbvotantes SET estado_votante = '{0}' WHERE dui_votante = '{1}'", estados, ConstructorVotante.dui), conexion.obtenerconexion());
        //            int verifiacion = Convert.ToInt16(cmdRESET.ExecuteNonQuery());
        //            MySqlDataReader reader = cmdSELECT2.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                ConstructorLogin.nombres = reader.GetString(1);
        //                ConstructorLogin.nivel = reader.GetInt16(6);
        //                MessageBox.Show("Bienvenido:" + ConstructorLogin.nombres, "Votante listo para efectuar el sufragio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //        else
        //        {
        //            MySqlDataReader reader = cmdSELECT.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                int intentos = 0;
        //                intentos = reader.GetInt16(4) + 1;
        //                if (intentos > 5)
        //                {
        //                    int bloqueo = 0;
        //                    MessageBox.Show("Este usuario ha sido BLOQUEADO , porfavor verificar las credenciales del  votante en caso que este ya haya votado , sino reporte el caso con un Admininistrador ", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //                    MySqlCommand cmdUPDATE1 = new MySqlCommand(string.Format("UPDATE tbusuarios SET est_usu = '{0}' WHERE usuario = '{1}'", bloqueo, ConstructorLogin.usuario), conexion.obtenerconexion());

        //                }
        //                else
        //                {
        //                    MySqlCommand cmdUPDATE2 = new MySqlCommand(string.Format("UPDATE tbusuarios SET intentos = '{0}' WHERE usuario = '{1}'", intentos, ConstructorLogin.usuario), conexion.obtenerconexion());
        //                    int verificacion = Convert.ToInt32(cmdUPDATE2.ExecuteNonQuery());
        //                    if (verificacion >= 1)
        //                    {
        //                        MessageBox.Show("La contraseña es incorrecta o un usuario inactivo", "contraseña incorrecta o usuario inactivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                }
        //            }
              

        //        else
        //        {
        //                MessageBox.Show("El usuario que a ingresado no esta registrado en la base de datos", "Usuario no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //            }
        //            return retorno;
        //        } }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(" Error no esperado, Verifique su conexion al internet o que sus servios del servidor" + e.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return retorno;
        //    }
        } }  

