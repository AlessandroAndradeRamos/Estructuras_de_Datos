using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrera_libre_y_tortuga
{
    class ElTorto : Competidores
    {
        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
        }
        public ElTorto(string nombre)
        {
            _nombre = nombre;
        }
        public int simularCarrera()
        {
            if (darleCandela() == 1 || darleCandela() == 2 || darleCandela() == 3 || darleCandela() == 4
                || darleCandela() == 5)
                return 3;
            else if (darleCandela() == 6 || darleCandela() == 7)
                return -6;
            else
                return -1;
        }
    }
}
