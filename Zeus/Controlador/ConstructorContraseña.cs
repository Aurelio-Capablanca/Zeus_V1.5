using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeus.Controlador
{
    class ConstructorContraseña
    {

        public static string usuario { get; set; }
        public static string clave { get; set; }
        public static string usuarios { get; set; }
        public static string nombres { get; set; }
        public static int nivel { get; set; }
        public static int estado { get; set; }
        public static int intentos { get; set; }
        public ConstructorContraseña(string usuario)
        {
            usuario = ConstructorContraseña.usuario;
            
        }
    } }
