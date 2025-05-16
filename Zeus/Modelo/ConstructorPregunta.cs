using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeus.Modelo
{
    class ConstructorPregunta
    {
        public string contra { get; set; }
        public static string respuesta1 { get; set; }
        public static string respuesta2 { get; set; }

        public ConstructorPregunta(string respuesta1, string respuesta2)
        {
            respuesta1 = ConstructorPregunta.respuesta1;
            respuesta2 = ConstructorPregunta.respuesta2;

        }
    }
}
