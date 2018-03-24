using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrera_libre_y_tortuga
{
    class LaLibre : Competidores
    {
        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
        }
        public LaLibre(string nombre)
        {
            _nombre = nombre;
        }
        public int simularCarrera()
        {
            if (darleCandela() == 1 || darleCandela() == 2)
                return 0;
            else if (darleCandela() == 3 || darleCandela() == 4)
                return 9;
            else if (darleCandela() == 5)
                return -12;
            else if (darleCandela() == 6 || darleCandela() == 7 || darleCandela() == 8)
                return 1;
            else
                return -2;
        }
    }
}
