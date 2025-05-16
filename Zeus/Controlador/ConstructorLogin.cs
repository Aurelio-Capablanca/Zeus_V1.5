using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeus.Controlador
{
    class ConstructorLogin
    {
        public static string usuario { get; set; }
        public string clave { get; set; }
        public static string prueba { get; set; } 

        public static string nombres { get; set; }
        public static int nivel { get; set; }
        public static int estado { get; set; }
        public static int intentos { get; set; }
        public ConstructorLogin(string usuario, string clave)
        {
            usuario = ConstructorLogin.usuario;
            clave = this.clave;
        }
    }
}
