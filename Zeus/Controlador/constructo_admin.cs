using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeus.Controlador
{
    class constructo_admin
    {
        public static int id { get; set; }
        public  int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dui { get; set; }

        public string clave { get; set; }
        public int municipio { get; set; }
        public int tipo_usuario { get; set; }
        public int estado { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public int genero { get; set; } 

        public string usuario { get; set; } 

        public static int pregunta1 { get; set; }
        public  static  int pregunta2 { get; set; }

        public constructo_admin()
        {

        }
    }
}
