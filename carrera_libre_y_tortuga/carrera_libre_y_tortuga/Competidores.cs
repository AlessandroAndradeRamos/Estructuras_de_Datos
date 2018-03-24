using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrera_libre_y_tortuga
{
    abstract class Competidores
    {
        static protected Random aleatorio;
        public Competidores()
        {
            aleatorio = new Random();
        }
        public int darleCandela()
        {
            return aleatorio.Next(1, 11);   
        }
    }
}
