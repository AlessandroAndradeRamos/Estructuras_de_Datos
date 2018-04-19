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
            for (int contador = 0; contador < vectorProductos.Length; contador++)
            {
                if(vectorProductos[contador] == null)
                {
                    vectorProductos[contador] = producto;
                    break;
                }
            }
        }
        public string Buscar (int codigo, Producto[] vectorBusqueda)
        {
            string resultado = "";
            for (int contador = 0; contador < vectorBusqueda.Length; contador++)
            {
                if(vectorBusqueda[contador] != null) //Aquí esta condición está comparando para encontrar los que no estén vacios
                {
                    if (vectorBusqueda[contador].codigo == codigo) //Y aquí se compara el código para encontrar el que se buscaba 
                    {
                        resultado += "----PRODUCTO ENCONTRADO----" + Environment.NewLine + "Nombre: " + vectorBusqueda[contador].nombre
                            + Environment.NewLine + "Código: " + vectorBusqueda[contador].codigo + Environment.NewLine + "Cantidad: "
                            + vectorBusqueda[contador].cantidad + Environment.NewLine + "Costo: " + vectorBusqueda[contador].costo + Environment.NewLine;
                        break;
                    }
                    else
                        resultado += "----PRODUCTO NO ECONTRADO---" + Environment.NewLine;
                }
            }
            return resultado;
        }
        public void Eliminar(int codigo, Producto[] vectorEliminar)
        {
            for(int contador = 0; contador < vectorEliminar.Length; contador++)
            {
                if (vectorEliminar[contador] != null)
                {
                    if (vectorEliminar[contador].codigo == codigo)
                        vectorEliminar[contador] = null;
                }
            }
        }
        public void Insertar (Producto producto, int posicion, Producto[] vectorInsertar)
        {
            for (int contador = vectorInsertar.Length - 1; contador > posicion; contador--)
            {
                if (vectorInsertar[contador] != null)
                {
                    Producto control = vectorInsertar[contador];
                    vectorInsertar[contador] = vectorInsertar[contador - 1];
                    if (contador < vectorInsertar.Length - 1)
                        vectorInsertar[contador + 1] = control;
                }
            }
            vectorInsertar[posicion] = producto;
        }
        public string Listar (Producto[] vectorListar)
        {
            string resultado = "";
            for (int contador = 0; contador < vectorListar.Length; contador++)
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
    }
}
