using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoRey
{
    internal class Empresa
    {
      
        private int _intClientes;
        public int Clientes
        {
            get { return _intClientes; }
            set { _intClientes = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private int _intVenta;

        public int Venta
        {
            get { return _intVenta; }
            set { _intVenta = value; }
        }



    }
}
