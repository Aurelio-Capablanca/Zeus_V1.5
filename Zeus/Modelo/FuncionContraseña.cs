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
    class FuncionContraseña
    {

        public static bool revisionRecuperar(ConstructorContraseña prev)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tbusuarios WHERE usuario= binary ?param1";
                MySqlCommand cmdSELECT = new MySqlCommand(query, conexion.obtenerconexion());
                cmdSELECT.Parameters.Add(new MySqlParameter("param1", ConstructorContraseña.usuario));
                retorno = Convert.ToBoolean(cmdSELECT.ExecuteScalar());
                if (retorno == true)
                {
                    MessageBox.Show("Su Usuario es correcto, proceda a solicitar el usuario root para restaurar su contraseña", "Usuario Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Su Usuario no es correcto", "Usuario Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Compruebe su conexion de internet o consulte con el administrador", "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }


        }




        public static bool RevisionRoot(ConstructorLogin rev)
        {
            bool regresar = false;
            try
            {
                string query = "SELECT * FROM tbusuarios WHERE usuario= binary ?param1";
                MySqlCommand cmdSELECT = new MySqlCommand(query, conexion.obtenerconexion());
                cmdSELECT.Parameters.Add(new MySqlParameter("param1", ConstructorLogin.usuario));
                regresar = Convert.ToBoolean(cmdSELECT.ExecuteScalar());
                if (regresar == true)
                {
                    string query2 = "SELECT * FROM tbusuarios WHERE usuario = binary ?param2 AND clave_usuarios = binary ?param3 AND tipo_usuario = binary ?param4";
                    MySqlCommand cmdSELECT2 = new MySqlCommand(query2, conexion.obtenerconexion());
                    cmdSELECT2.Parameters.Add(new MySqlParameter("param2", ConstructorLogin.usuario));
                    cmdSELECT2.Parameters.Add(new MySqlParameter("param3", rev.clave));
                    int niveles = 1;
                    cmdSELECT2.Parameters.Add(new MySqlParameter("param4", niveles));
                    regresar = Convert.ToBoolean(cmdSELECT2.ExecuteScalar());

                    if (regresar == true)
                    {
                        int nivel = 1;
                        MySqlCommand cmdRESET = new MySqlCommand(string.Format("SELECT * FROM tbusuarios SET  tipo_usuario = '{0}' WHERE usuario = '{1}'", nivel, ConstructorLogin.usuario), conexion.obtenerconexion());
                        MySqlDataReader reader = cmdSELECT2.ExecuteReader();
                        while (reader.Read())
                        {
                            MessageBox.Show("Proceda a realizar el cambio de contraseñas", "Usuario Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no posee permisos para proceder a realizar el cambio de contraseñas", "Usuario sin acceso al proceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
                else
                {
                    MessageBox.Show("Su Usuario no es correcto, por favor reingresar sus datos ", "Usuario Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return regresar;
            }
            catch (Exception)
            {
                MessageBox.Show("Compruebe su conexion de internet o consulte con el administrador", "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return regresar;
            }

        }



        public static bool Revisar(ConstructorContraseña prev, constructo_admin inn)
        {
            bool retorno = false;
            try
            {
                //string query = "SELECT * FROM tbusuarios WHERE usuario= binary ?param1";
                //MySqlCommand cmdSELECT = new MySqlCommand(query, conexion.obtenerconexion());
                //cmdSELECT.Parameters.Add(new MySqlParameter("param1", ConstructorContraseña.usuario));
                //retorno = Convert.ToBoolean(cmdSELECT.ExecuteScalar());
                MySqlCommand cmdup = new MySqlCommand(string.Format("UPDATE tbusuarios SET clave_usuarios='{0}'WHERE usuario='{1}'", inn.clave, inn.usuario), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdup.ExecuteNonQuery());
                if (retorno == true)
                {
                    ///MessageBox.Show("Su Usuario es correcto, proceda a solicitar el usuario root para restaurar su contraseña", "Usuario Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                       
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
                else
                {
                    MessageBox.Show("Su Usuario no es correcto", "Usuario Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Compruebe su conexion de internet o consulte con el administrador", "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }



        }


        public static bool revisionRespuestas(ConstructorPregunta log)
        {
            bool retorno = false;
            try
            {
                string query = "SELECT * FROM tbusuarios WHERE usuario=binary ?param1 AND respuesta1 = binary ?param2 AND respuesta2 = binary ?param3";
                MySqlCommand cmdSELECT = new MySqlCommand(query, conexion.obtenerconexion());
                cmdSELECT.Parameters.Add(new MySqlParameter("param1", ConstructorContraseña.usuario));
                cmdSELECT.Parameters.Add(new MySqlParameter("param2", ConstructorPregunta.respuesta1));
                cmdSELECT.Parameters.Add(new MySqlParameter("param3",ConstructorPregunta.respuesta2));
                retorno = Convert.ToBoolean(cmdSELECT.ExecuteScalar());
                if (retorno == true)
                {
                    MessageBox.Show("Respuestas Correctas", "Cambio de Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Respuestas Inorrectas", " No se puede proceder al cambio de Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception)
            {
                MessageBox.Show("Compruebe su conexion de internet o consulte con el administrador", "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }

        }





        public static string verpregunta()
        {
            string pregunta;
            MessageBox.Show(Convert.ToString(constructo_admin.pregunta1));
            MySqlCommand cmdSELECT = new MySqlCommand(string.Format("SELECT  FROM tbpreguntas WHERE pregunta = ´{0}´", constructo_admin.pregunta1),conexion.obtenerconexion());
            pregunta = Convert.ToString(cmdSELECT.ExecuteScalar());
            if (pregunta != "")
            {
                MessageBox.Show("Paso");
            }
            else
            {
                MessageBox.Show("No paso");
            }
            return pregunta;
        }





        ////   public static bool ActualizarContraseña(constructo_admin udpd )
        //   {
        //       bool retorno = false;
        //       try
        //       {
        //           string query = "SELECT * FROM tbusuarios WHERE usuario= binary ?param1";
        //           MySqlCommand cmdSELECT = new MySqlCommand(query, conexion.obtenerconexion());
        //           cmdSELECT.Parameters.Add(new MySqlParameter("param1", ConstructorContraseña.usuario));
        //           retorno = Convert.ToBoolean(cmdSELECT.ExecuteScalar());
        //           bool actualizar ;
        //           actualizar = Convert.ToBoolean(cmdSELECT.ExecuteScalar());

        //           MySqlCommand cmdup = new MySqlCommand(string.Format("UPDATE tbusuarios SET usuario='{0}'WHERE  clave_usuarios='{1}'", udpd.clave, udpd.usuario), conexion.obtenerconexion());
        //           retorno = Convert.ToBoolean(cmdup.ExecuteNonQuery());
        //           if (retorno == true)
        //           {

        //           MessageBox.Show("Datos actualizados correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //           }
        //           else
        //           {
        //               MessageBox.Show("Datos actualizados incorrectamente", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //           }
        //           return retorno;
        //       }

        //       catch (Exception e)
        //       {
        //           MessageBox.Show("Ha ocurrido un problema revise su conexion a internet, y si el problema persiste contcte su administrador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //           return retorno;
        //       }


        //   }


    }



    }

