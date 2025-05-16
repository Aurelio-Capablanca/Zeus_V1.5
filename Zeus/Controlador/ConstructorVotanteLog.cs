using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeus.Controlador
{
    class ConstructorVotanteLog
    { 
        public static int id { get; set; }

        public static string nombres { get; set; }

        public static string dui { get; set; } 

        public  static string estado { get; set; }

        public ConstructorVotanteLog(string dui)
        {
            dui = ConstructorVotanteLog.dui;
        }

    }
}
