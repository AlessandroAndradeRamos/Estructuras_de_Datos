using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_con_arreglos
{
    class Producto
    {
        private string _nombre = "";
        private int _codigo = 0;
        private double _cantidad = 0, _costo = 0;
        private int contadorGlobal = 0;
        public string nombre
        {
            get { return _nombre; }
        }
        public int codigo
        {
            get { return _codigo; }
        }
        public double cantidad
        {
            get { return _cantidad; }
        }
        public double costo
        {
            get { return _costo; }
        }
        public Producto(string nombre, int codigo, double cantidad, double costo)
        {
            this._nombre = nombre;
            this._codigo = codigo;
            this._cantidad = cantidad;
            this._costo = costo;
        }
        public void AgregarProducto(Producto producto, Producto[] vectorProductos)
        {
            if (contadorGlobal == 0)
            {
                vectorProductos[0] = producto;
            }
            else if (contadorGlobal < 15 && !ValidarCodigo(codigo, vectorProductos))
            {
                if(producto.codigo > vectorProductos[contadorGlobal - 1].codigo)
                {
                    vectorProductos[contadorGlobal] = producto;
                    contadorGlobal++;
                }
                else
                {
                    for(int contador = 0; contador < contadorGlobal; contador++)
                    {
                        if (producto.codigo < vectorProductos[contador].codigo)
                        {
                            for (int contador2 = contadorGlobal - 1; contador2 >= contador; contador2++)
                                vectorProductos[contador2 + 1] = vectorProductos[contador2];
                            vectorProductos[contador] = producto;
                            contadorGlobal++;
                            break;
                        }
                    }
                }
            }
        }
        public int Buscar (int codigo, Producto[] vectorBuscar)
        {
            int posicion = 0, maximus = contadorGlobal - 1, controlDeBusqueda = 0, minimus, mitad = 0;
            controlDeBusqueda = codigo;
            for (minimus = 0; minimus <= maximus;)
            {
                if (vectorBuscar[minimus].codigo == vectorBuscar[maximus].codigo)
                {
                    if (vectorBuscar[minimus].codigo == controlDeBusqueda)
                    {
                        posicion = minimus;
                    }
                    else
                    {
                        posicion = -1;
                    }
                    break;
                }
                mitad = (minimus + maximus) / 2;
                if (vectorBuscar[mitad].codigo == controlDeBusqueda)
                {
                    posicion = mitad;
                    break;
                }
                else
                {
                    if (controlDeBusqueda < vectorBuscar[mitad].codigo)
                        maximus = mitad - 1;
                    else
                        minimus = mitad + 1;
                }
            }
            return posicion;
        }
        public void Eliminar(int codigo, Producto[] vectorEliminar)
        {
            if (contadorGlobal > 0)
            {
                int posicion = Buscar(codigo, vectorEliminar);
                if (posicion != 0)
                {
                    for (int contador = posicion; contador < contadorGlobal - 1; contador++)
                    {
                        vectorEliminar[contador] = vectorEliminar[contador + 1];
                    }
                    contadorGlobal--;
                }
            }
        }
        public string Listar (Producto[] vectorListar)
        {
            string resultado = "";
            for (int contador = 0; contador < contadorGlobal; contador++)
            {
                if (vectorListar[contador] != null)
                {
                    resultado += "Nombre: " + vectorListar[contador].nombre + Environment.NewLine + "Código: " 
                        + vectorListar[contador].codigo + Environment.NewLine + "Cantidad: " + vectorListar[contador].cantidad 
                        + Environment.NewLine + "Costo: " + vectorListar[contador].costo + Environment.NewLine;
                }
            }
            return resultado;
        }
        public string MostrarProducto(int codigo, Producto[] vectorMostrar)
        {
            string resultado = "";
            if (contadorGlobal > 0)
            {
                int posicion = Buscar(codigo, vectorMostrar);
                if (posicion != -1)
                {
                    resultado += "Nombre: " + vectorMostrar[posicion].nombre + Environment.NewLine + "Código: "
                        + vectorMostrar[posicion].codigo + Environment.NewLine + "Cantidad: " + vectorMostrar[posicion].cantidad
                        + Environment.NewLine + "Costo: " + vectorMostrar[posicion].costo + Environment.NewLine;
                }
            }
            return resultado;
        }

        //VALIDACIONES VALIDADERAS QUE VALIDAN LO QUE HAY QUE VALIDAR

        public bool ValidarVectorUsuario(Producto[] vectorValidar)
        {
            bool control = true;
            for (int contador = 0; contador < vectorValidar.Length; contador++)
            {
                if (vectorValidar[contador] == null)
                    control = false;
            }
            return control;
        }
        public bool ValidarCodigoUsuario(int codigo, Producto[] vectorValidar)
        {
            bool control = false;
            for (int contador = 0; contador < vectorValidar.Length; contador++)
            {
                if(vectorValidar[contador] != null)
                {
                    if (vectorValidar[contador].codigo == codigo)
                        control = true;
                }
            }
            return control;
        }
        public bool ValidarCodigo(int zackYCodigo, Producto[] vectorValidarCodigo)
        {
            bool control = true;
            int posicion = Buscar(zackYCodigo, vectorValidarCodigo);
            if (posicion == -1)
                control = false;
            return control;
        }
    }
}
