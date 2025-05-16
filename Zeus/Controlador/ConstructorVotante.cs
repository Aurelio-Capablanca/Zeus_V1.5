using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeus.Controlador
{
    class ConstructorVotante
    { 
        public static int dui { get; set; }
        public  int estado { get; set; }

        public ConstructorVotante()
        {
            dui = ConstructorVotante.dui;
           
        }


    }
}
