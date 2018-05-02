using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace el_torto
{
    class Tablero
    {
        public int[,] cuadros;
        public Tablero()
        {
            int limiteRenglones = cuadros.GetLength(0);
            int limiteColumnas = cuadros.GetLength(1);
            cuadros = new int[20, 20];
            PrepararVector(limiteRenglones, limiteColumnas);
        }
        public void PrepararVector(int limiteRenglones, int limiteColumnas)
        {
            
            for (int renglones = 0; renglones < limiteRenglones; renglones++)
            {
                for (int columnas = 0; columnas < limiteColumnas; columnas++)
                {
                    cuadros[columnas, renglones] = 0;
                }
            }
        }
        public string MostrarTablero()
        {
            string respuesta = "";
            int limiteRenglones = cuadros.GetLength(0);
            int limiteColumnas = cuadros.GetLength(1);
            for (int renglones = 0; renglones < limiteRenglones; renglones++)
            {
                for (int columnas = 0; columnas < limiteColumnas; columnas++)
                {
                    respuesta += cuadros[columnas, renglones] + " ";
                    respuesta += Environment.NewLine;
                }
            }
            return respuesta;
        }
    }
}
