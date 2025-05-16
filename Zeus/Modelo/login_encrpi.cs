using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeus.Controlador;
using MySql.Data.MySqlClient;

namespace Zeus.Modelo
{
    class login_encrpi
    {
        public static int IngresarEncriptado(constructor_clave añadir)
        {
            int regreso = 0;
            try
            {
                MySqlCommand cmdañadir = new MySqlCommand(string.Format("INSERT INTO tbusuarios (clave_usuarios) VALUES('{0}')", añadir.encriptado), conexion.obtenerconexion());
                regreso = Convert.ToInt32(cmdañadir.ExecuteNonQuery());
                return regreso;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de conexion" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return regreso;
            }
        }
    


       public static bool ActualizarEcriptado(constructor_clave udpd)
        {
            bool retorno = false;
            try
            {
                MySqlCommand cmdup = new MySqlCommand(string.Format("UPDATE tbusuarios SET clave_usuarios='{0}' ", udpd.encriptado), conexion.obtenerconexion());
                retorno = Convert.ToBoolean(cmdup.ExecuteNonQuery());
                return retorno;
            }

            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un problema revise su conexion a internet, y si el problema persiste contcte su administrador" + e, "Error critico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }

}

}
}
    
