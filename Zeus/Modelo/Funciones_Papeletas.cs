using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeus.Controlador;

namespace Zeus.Modelo
{
    class Funciones_Papeletas
    {
        public static int IngresarPapeleta(Constructor_Papeleta añadir)
        {
            int regreso = 0;
            try
            {
                MySqlCommand cmdañadir = new MySqlCommand(string.Format("INSERT INTO tbvotos (estado_voto,partido_voto,dui_votante) VALUES('{0}','{1}','{2}')", añadir.estado_voto, añadir.partido_voto, añadir.dui), conexion.obtenerconexion());
                regreso = Convert.ToInt32(cmdañadir.ExecuteNonQuery());
                if (regreso >= 1)
                {
                    MessageBox.Show("El Voto fue emitido de manera exitosa", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ah ocurrido un error porfavor comunicarse con La mesa encargada", "Error en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return regreso;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return regreso;
            }

        }
             public static bool ActualizarVotante(Constructor upd)
        {
            bool retorno;
            try
            {
                
                MySqlCommand cmdupd = new MySqlCommand(string.Format("UPDATE tbvotantes SET estado_votante = '{0}' WHERE dui_votante = '{1}'", upd.Estadovotante, upd.documento), conexion.obtenerconexion());
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
                return retorno = false;
            }
        }

    }
  }   
