using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeus.Controlador;

namespace Zeus.Modelo
{
    class Control_Empresa
    {
        public static int RegistarEmpresa(Constructor_Empresa emp)
        {
            /*
             Verificar la empresa de la empresa (Nombre de la Empresa, nit)
             TRUE
                mensaje de duplicidad de informacion
            FALSE
                se agrega la empresa
             */
            int retorno = 0;
            try
            {
                string query = "SELECT * FROM tbempresas WHERE empresa = ?empresa OR nit = ?nit";
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                cmdselect.Parameters.Add(new MySqlParameter("empresa", emp.empresa));
                cmdselect.Parameters.Add(new MySqlParameter("nit", emp.nit));
                bool verificacion;
                verificacion = Convert.ToBoolean(cmdselect.ExecuteScalar());
                if (verificacion == true)
                {
                    MessageBox.Show("La empresa que desea registar ya existe en la base de datos", "Duplicidad de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = 0;
                }
                else
                {
                    MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbempresas (empresa,nit,representante_legal,tipo_empresa,estado_empresa,direccion,logoempresa) VALUES ('" + emp.empresa + "','" + emp.nit + "','" + emp.representante + "','" + emp.tipo_empresa + "','" + emp.estado_empresa + "','" + emp.direccion + "','" + emp.imagen + "')"), conexion.obtenerconexion());
                    retorno = Convert.ToInt16(cmdinsert.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        MessageBox.Show("Empresa Registrada con exito", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La empresa no pudo ser registrada, verifique lo datos proporcinados", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                return retorno;
            }
            catch (Exception e)
            {
                MessageBox.Show("Compruebe su conexion de internet o consulte con el administrador" + e, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable ObtenerTipoEmpresa()
        {
            string query = "SELECT * FROM tbtipos_empresas";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!,Ha ocurrido un error al obtener los tipos de empresa, Consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }

        public static DataTable ObtenerEstadoEmpresa()
        {
            string query = "SELECT * FROM tbestado_empresas";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!,Ha ocurrido un error al obtener el estado de la empresa, Consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
        public static int IngresarUsuario(Constructor_PrimerUsuario add)
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmdadd = new MySqlCommand(string.Format("INSERT INTO tbusuarios (nombres_usuario,apellidos_usuario,clave_usuarios,dui_usuario,municipio_usuario,tipo_usuario,est_usu,telefono_usuario,correo_usuario,genero_usuario,usuario,logo) VALUES ('" + add.nombre + "','" + add.apellidos + "','" +add.clave+"','"+ add.dui + "','" + add.municipio + "','" + add.tipo_usuario + "','" + add.estado + "','" + add.telefono + "','" + add.correo + "','" + add.genero + "','" + add.usuario + "','" + add.Foto + "')"), conexion.obtenerconexion());
                retorno = Convert.ToInt16(cmdadd.ExecuteNonQuery());
                if (retorno >= 1)
                {
                    MessageBox.Show("El usuario se ingrso de manera exitosa Su contraseña por ahora es Zeus", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El usuario no se a podido ingresar", "Error en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion"+ex,"Error critico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return retorno;
            }


        }
        public static DataTable ObtenerMunicipio()
        {
            string query = "SELECT * FROM tbmunicipios";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!,Ha ocurrido un error al obtener el estado de la empresa, Consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
        public static DataTable ObtenerTipoUsuario()
        {
            string query = "SELECT * FROM tbtipo_usuarios";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!,Ha ocurrido un error al obtener el estado de la empresa, Consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
        public static DataTable ObtenerEstados()
        {
            string query = "SELECT * FROM tbestado_usuarios";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!,Ha ocurrido un error al obtener el estado de la empresa, Consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
        public static DataTable ObtenerGenero()
        {
            string query = "SELECT * FROM tbgenero";
            DataTable data = new DataTable();
            try
            {
                MySqlCommand cmdselect = new MySqlCommand(query, conexion.obtenerconexion());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdselect);
                adapter.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!,Ha ocurrido un error al obtener el estado de la empresa, Consulte con el administrador" + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return data;
            }
            finally
            {
                conexion.obtenerconexion().Close();
            }
        }
    }
}
