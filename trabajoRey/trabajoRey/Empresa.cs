using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoRey
{
    internal class Empresa
    {
        private int _intEmpleados;
        public int intEmpleados 
        {
            get { return _intEmpleados; }
            set { _intEmpleados = value; }
        }
        private string _strProducto;

        public string Producto
        {
            get { return _strProducto; }
            set { _strProducto = value; }
        }
        private int _intClientes;

        public int Clientes
        {
            get { return _intClientes; }
            set { _intClientes = value; }
        }


    }
}
