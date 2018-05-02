using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace el_torto
{
    class ElTorto
    {
        private bool arriba = false, abajo = false;
        private int horizontal = 0, vertical = 0, control = 1;
        private Tablero tablero;
        public ElTorto()
        {
            tablero = new Tablero();
        }
        public void Avanzar(int cuanto)
        {
            if (horizontal == 0 && vertical == 0)
            {
                for(int contador = 0; contador < cuanto; contador++)
                {
                    if (control == 1)
                        horizontal = contador;
                    else if (control == 2)
                        vertical = contador;
                    RayandoElSol();
                }
            }
            else
            {
                if (!LimitesDeTablero(cuanto))
                {
                    for (int contador = 0; contador < cuanto; contador++)
                    {
                        if (control == 1)
                        {
                            horizontal++;
                        }
                        else if (control == 2)
                        {
                            vertical++;
                        }
                        else if (control == 3)
                        {
                            horizontal--;
                        }
                        else if (control == 4)
                        {
                            vertical--;
                        }
                        RayandoElSol();
                    }
                }
            }
        }
        public void RayandoElSol()
        {
            if (abajo)
                tablero.cuadros[horizontal, vertical] = 1;
            else
                tablero.cuadros[horizontal, vertical] = 0;
        }
        public bool LimitesDeTablero(int cuanto)
        {
            bool monitor = false;
            if (control == 1)
            {
                if (horizontal + cuanto > 19)
                    monitor = true;
            }
            else if (control == 2)
            {
                if (vertical + cuanto > 19)
                    monitor = true;
            }
            else if (control == 3)
            {
                if (vertical - cuanto < 0)
                    monitor = true;
            }
            else if (control == 4)
            {
                if (vertical - cuanto < 0)
                    monitor = true;
            }
            return monitor;
        }
        public void GirarDerecha()
        {
            if (control == 1)
            {
                control = 4;
            }
            else if (control == 2)
            {
                control = 1;
            }
            else if (control == 3)
            {
                control = 2;
            }
            else if (control == 4)
            {
                control = 3;
            }
            RayandoElSol();
        }
        public void GirarIzquierda()
        {
            if (control == 1)
            {
                control = 2;
            }
            else if (control == 2)
            {
                control = 3;
            }
            else if (control == 3)
            {
                control = 4;
            }
            else if (control == 4)
            {
                control = 1;
            }
            RayandoElSol();
        }
        public void Arriba()
        {
            arriba = true;
            abajo = false;
        }
        public void Abajo()
        {
            arriba = false;
            abajo = true;
        } 
        public string MostrarTablero()
        {
            string respuesta = tablero.MostrarTablero();
            return respuesta;
        }
    }
}
