using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coladera_de_Eratostenes
{
    class LaColadera
    {
        private int _maximo;
        private int[] _vectorUno;
        public int maximo
        {
            get { return _maximo; }
        }
        public int [] vectorUno
        {
            get { return _vectorUno}
        }
        public LaColadera(int maximo)
        {
            _maximo = maximo;
            _vectorUno = new int[_maximo];
        }
        public void colar()
        {
            for (int i = 0; i < _maximo; i++)
                _vectorUno[i] = i + 1;
        }
        public void controlNoPrimos()
        {
            int control = 0;
            int segundoControl = 2;
            for (int i = 0; i < _maximo; i++)
            {
                if (Math.Pow(_vectorUno[i], 2) < _maximo)
                    control = _vectorUno[i];
            }
            _vectorUno[0] = 0;
            while (segundoControl <= control)
            {
                for (int i = segundoControl - 1; i > 1; i--)
                {
                    if (segundoControl % i == 0)
                        segundoControl++;
                }

                for (int i = 1; i < _maximo; i++)
                {
                    if (_vectorUno[i] != 0 && _vectorUno[i] % segundoControl == 0 && _vectorUno[i] > segundoControl)
                        _vectorUno[i] = 0;
                }

                segundoControl++;
            }
        }

        public int mostrar(int control)
        {
            return _vectorUno[control];
        }
    }
}
